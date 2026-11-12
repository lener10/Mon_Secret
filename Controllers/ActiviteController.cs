using System;
using System.Data;
using Mon_Secret.Models;

namespace Mon_Secret.Controllers
{
    internal class ActiviteController
    {
        private readonly ActiviteModel activiteModel;

        public ActiviteController()
        {
            activiteModel = new ActiviteModel();
        }

        private bool ValiderActivite(
            string? title,
            string? category,
            string? status,
            DateTime dateHeure,
            out string message)
        {
            message = "";

            if (string.IsNullOrWhiteSpace(title) ||
                string.IsNullOrWhiteSpace(category) ||
                string.IsNullOrWhiteSpace(status))
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

            if (status.Trim().Length > 30)
            {
                message = "Le statut ne doit pas dépasser 30 caractères.";
                return false;
            }

            if (dateHeure == DateTime.MinValue)
            {
                message = "La date et l'heure sont invalides.";
                return false;
            }

            return true;
        }

        public bool AjouterActivite(
            int userId,
            string? title,
            string? description,
            DateTime dateHeure,
            string? category,
            string? status,
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

                if (!ValiderActivite(
                    title,
                    category,
                    status,
                    dateHeure,
                    out message))
                {
                    return false;
                }

                Activite activite = new Activite
                {
                    UserId = userId,
                    Title = title!.Trim(),
                    Description = description?.Trim() ?? "",
                    DateHeure = dateHeure,
                    Category = category!.Trim(),
                    Status = status!.Trim()
                };

                bool resultat = activiteModel.Save(activite);
                message = resultat
                    ? "Activité ajoutée avec succès."
                    : "Impossible d'ajouter l'activité.";

                return resultat;
            }
            catch (Exception ex)
            {
                message = "Erreur lors de l'ajout : " + ex.Message;
                return false;
            }
        }

        public DataTable AfficherActivites(int userId)
        {
            if (userId <= 0)
                return new DataTable();

            try
            {
                return activiteModel.FindAllByUserId(userId);
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "Erreur lors du chargement des activités : " + ex.Message
                );
            }
        }

        public bool VoirActivite(
            int activiteId,
            int userId,
            out Activite activite,
            out string message)
        {
            activite = new Activite();
            message = "";

            try
            {
                if (activiteId <= 0 || userId <= 0)
                {
                    message = "Identifiants invalides.";
                    return false;
                }

                DataTable dt = activiteModel.FindActiviteById(activiteId, userId);

                if (dt.Rows.Count == 0)
                {
                    message = "Activité introuvable.";
                    return false;
                }

                DataRow row = dt.Rows[0];
                activite = ConvertirActivite(row);
                message = "Activité récupérée avec succès.";
                return true;
            }
            catch (Exception ex)
            {
                activite = new Activite();
                message = "Erreur lors de la consultation : " + ex.Message;
                return false;
            }
        }

        public bool ModifierActivite(
            int activiteId,
            int userId,
            string? title,
            string? description,
            DateTime dateHeure,
            string? category,
            string? status,
            out string message)
        {
            message = "";

            try
            {
                if (activiteId <= 0 || userId <= 0)
                {
                    message = "Identifiants invalides.";
                    return false;
                }

                if (!ValiderActivite(
                    title,
                    category,
                    status,
                    dateHeure,
                    out message))
                {
                    return false;
                }

                DataTable dt = activiteModel.FindActiviteById(activiteId, userId);

                if (dt.Rows.Count == 0)
                {
                    message = "Activité introuvable ou accès refusé.";
                    return false;
                }

                Activite activite = new Activite
                {
                    Id = activiteId,
                    UserId = userId,
                    Title = title!.Trim(),
                    Description = description?.Trim() ?? "",
                    DateHeure = dateHeure,
                    Category = category!.Trim(),
                    Status = status!.Trim()
                };

                bool resultat = activiteModel.Update(activite);
                message = resultat
                    ? "Activité modifiée avec succès."
                    : "Aucune modification effectuée.";

                return resultat;
            }
            catch (Exception ex)
            {
                message = "Erreur lors de la modification : " + ex.Message;
                return false;
            }
        }

        public bool SupprimerActivite(
            int activiteId,
            int userId,
            out string message)
        {
            message = "";

            try
            {
                if (activiteId <= 0 || userId <= 0)
                {
                    message = "Identifiants invalides.";
                    return false;
                }

                DataTable dt = activiteModel.FindActiviteById(activiteId, userId);

                if (dt.Rows.Count == 0)
                {
                    message = "Activité introuvable ou accès refusé.";
                    return false;
                }

                bool resultat = activiteModel.DeleteById(activiteId);
                message = resultat
                    ? "Activité supprimée avec succès."
                    : "Impossible de supprimer l'activité.";

                return resultat;
            }
            catch (Exception ex)
            {
                message = "Erreur lors de la suppression : " + ex.Message;
                return false;
            }
        }

        private Activite ConvertirActivite(DataRow row)
        {
            return new Activite
            {
                Id = Convert.ToInt32(row["id"]),
                UserId = Convert.ToInt32(row["user_id"]),
                Title = Convert.ToString(row["title"]) ?? "",
                Description = row["description"] == DBNull.Value
                    ? ""
                    : Convert.ToString(row["description"]) ?? "",
                DateHeure = Convert.ToDateTime(row["date_heure"]),
                Category = Convert.ToString(row["category"]) ?? "",
                Status = Convert.ToString(row["status"]) ?? ""
            };
        }
    }
}