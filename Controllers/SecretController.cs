
using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using Mon_Secret.Models;

namespace Mon_Secret.Controllers
{
    internal class SecretController
    {
        private readonly SecretModel secretModel;

        public SecretController()
        {
            secretModel = new SecretModel();
        }

        // =========================================
        // CHIFFRER UNE VALEUR
        // =========================================

        private string Chiffrer(string? valeur)
        {
            string texte = valeur ?? string.Empty;

            byte[] donnees = Encoding.UTF8.GetBytes(texte);

            byte[] donneesChiffrees = ProtectedData.Protect(
                donnees,
                Array.Empty<byte>(),
                DataProtectionScope.CurrentUser
            );

            return Convert.ToBase64String(donneesChiffrees);
        }

        // =========================================
        // DECHIFFRER UNE VALEUR
        // =========================================

        private string Dechiffrer(string? valeur)
        {
            if (string.IsNullOrWhiteSpace(valeur))
                throw new ArgumentException("Valeur chiffrée invalide.");

            byte[] donneesChiffrees = Convert.FromBase64String(valeur);

            byte[] donnees = ProtectedData.Unprotect(
                donneesChiffrees,
                Array.Empty<byte>(),
                DataProtectionScope.CurrentUser
            );

            return Encoding.UTF8.GetString(donnees);
        }

        // =========================================
        // VALIDATION DES DONNEES
        // =========================================

        private bool ValiderSecret(
            string? title,
            string? category,
            string? secretValue,
            out string message)
        {
            message = "";

            if (string.IsNullOrWhiteSpace(title) ||
                string.IsNullOrWhiteSpace(category) ||
                string.IsNullOrWhiteSpace(secretValue))
            {
                message = "Veuillez remplir tous les champs obligatoires.";
                return false;
            }

            if (title.Trim().Length > 100)
            {
                message = "Le titre ne doit pas dépasser 100 caractères.";
                return false;
            }

            if (category.Trim().Length > 50)
            {
                message = "La catégorie ne doit pas dépasser 50 caractères.";
                return false;
            }

            if (secretValue.Length > 10000)
            {
                message = "La valeur du secret est trop longue.";
                return false;
            }

            return true;
        }

        // =========================================
        // 1. AJOUTER UN SECRET
        // =========================================

        public bool AjouterSecret(
            int userId,
            string? title,
            string? category,
            string? description,
            string? secretValue,
            out string message)
        {
            message = "";

            try
            {
                if (userId <= 0)
                {
                    message = "Utilisateur non valide.";
                    return false;
                }

                if (!ValiderSecret(
                    title,
                    category,
                    secretValue,
                    out message))
                {
                    return false;
                }

                Secret secret = new Secret
                {
                    UserId = userId,
                    Title = title!.Trim(),
                    Category = category!.Trim(),
                    Description = description?.Trim() ?? "",
                    SecretValue = Chiffrer(secretValue),
                    CreatedAt = DateTime.Now
                };

                bool resultat = secretModel.Save(secret);

                message = resultat
                    ? "Secret ajouté avec succès."
                    : "Impossible d'ajouter le secret.";

                return resultat;
            }
            catch (Exception ex)
            {
                message = "Erreur lors de l'ajout : " + ex.Message;
                return false;
            }
        }

        // =========================================
        // 2. AFFICHER LES SECRETS
        // =========================================

        public DataTable AfficherSecrets(int userId)
        {
            if (userId <= 0)
                return new DataTable();

            try
            {
                return secretModel.FindAllByUserId(userId);
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "Erreur lors du chargement des secrets : " + ex.Message
                );
            }
        }

        // =========================================
        // 3. VOIR LES DETAILS D'UN SECRET
        // =========================================

        public bool VoirSecret(
            int secretId,
            int userId,
            out Secret secret,
            out string message)
        {
            // Initialisation avec un objet non null
            secret = new Secret();
            message = "";

            try
            {
                if (secretId <= 0 || userId <= 0)
                {
                    message = "Identifiants invalides.";
                    return false;
                }

                DataTable dt = secretModel.FindSecretById(
                    secretId,
                    userId
                );

                if (dt.Rows.Count == 0)
                {
                    message = "Secret introuvable.";
                    return false;
                }

                DataRow row = dt.Rows[0]!;

                string valeurChiffree =
                    Convert.ToString(row["secret_value"]) ?? "";

                if (string.IsNullOrWhiteSpace(valeurChiffree))
                {
                    message = "La valeur secrète est introuvable.";
                    return false;
                }

                secret = new Secret
                {
                    Id = Convert.ToInt32(row["id"]),
                    UserId = Convert.ToInt32(row["user_id"]),
                    Title = Convert.ToString(row["title"]) ?? "",
                    Category = Convert.ToString(row["category"]) ?? "",

                    Description = row["description"] == DBNull.Value
                        ? ""
                        : Convert.ToString(row["description"]) ?? "",

                    SecretValue = Dechiffrer(valeurChiffree),
                    CreatedAt = Convert.ToDateTime(row["created_at"])
                };

                message = "Secret récupéré avec succès.";
                return true;
            }
            catch (Exception)
            {
                secret = new Secret();
                message = "Impossible de consulter ce secret.";
                return false;
            }
        }

        // =========================================
        // 4. MODIFIER UN SECRET
        // =========================================

        public bool ModifierSecret(
            int secretId,
            int userId,
            string? title,
            string? category,
            string? description,
            string? secretValue,
            out string message)
        {
            message = "";

            try
            {
                if (secretId <= 0 || userId <= 0)
                {
                    message = "Identifiants invalides.";
                    return false;
                }

                if (!ValiderSecret(
                    title,
                    category,
                    secretValue,
                    out message))
                {
                    return false;
                }

                DataTable dt = secretModel.FindSecretById(
                    secretId,
                    userId
                );

                if (dt.Rows.Count == 0)
                {
                    message = "Secret introuvable ou accès refusé.";
                    return false;
                }

                DataRow row = dt.Rows[0]!;

                Secret secret = new Secret
                {
                    Id = secretId,
                    UserId = userId,
                    Title = title!.Trim(),
                    Category = category!.Trim(),
                    Description = description?.Trim() ?? "",
                    SecretValue = Chiffrer(secretValue),
                    CreatedAt = Convert.ToDateTime(row["created_at"])
                };

                bool resultat = secretModel.Update(secret);

                message = resultat
                    ? "Secret modifié avec succès."
                    : "Aucune modification effectuée.";

                return resultat;
            }
            catch (Exception ex)
            {
                message = "Erreur lors de la modification : " + ex.Message;
                return false;
            }
        }

        // =========================================
        // 5. SUPPRIMER UN SECRET
        // =========================================

        public bool SupprimerSecret(
            int secretId,
            int userId,
            out string message)
        {
            message = "";

            try
            {
                if (secretId <= 0 || userId <= 0)
                {
                    message = "Identifiants invalides.";
                    return false;
                }

                DataTable dt = secretModel.FindSecretById(
                    secretId,
                    userId
                );

                if (dt.Rows.Count == 0)
                {
                    message = "Secret introuvable ou accès refusé.";
                    return false;
                }

                bool resultat = secretModel.DeleteById(secretId);

                message = resultat
                    ? "Secret supprimé avec succès."
                    : "Impossible de supprimer le secret.";

                return resultat;
            }
            catch (Exception ex)
            {
                message = "Erreur lors de la suppression : " + ex.Message;
                return false;
            }
        }
    }
}
