
using Mon_Secret.Models;
using System;
using System.Linq;

namespace Mon_Secret.Controllers
{
    internal class AuthController
    {
        private UserModel userModel;

        public AuthController()
        {
            userModel = new UserModel();
        }

        // Vérifier si un compte existe
        public bool HasUser()
        {
            return userModel.HasUser();
        }

        // Inscription du premier utilisateur
        public bool Register(
            string fullname,
            string username,
            string password,
            string confirmPassword,
            string pin,
            string confirmPin,
            out string message)
        {
            message = "";

            if (string.IsNullOrWhiteSpace(fullname) ||
                string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirmPassword) ||
                string.IsNullOrWhiteSpace(pin) ||
                string.IsNullOrWhiteSpace(confirmPin))
            {
                message = "Tous les champs sont obligatoires.";
                return false;
            }

            if (fullname.Trim().Length < 3)
            {
                message = "Le nom complet doit contenir au moins 3 caractères.";
                return false;
            }

            if (username.Trim().Length < 3)
            {
                message = "Le nom d'utilisateur doit contenir au moins 3 caractères.";
                return false;
            }

            if (password.Length < 8)
            {
                message = "Le mot de passe doit contenir au moins 8 caractères.";
                return false;
            }

            if (password != confirmPassword)
            {
                message = "Les mots de passe ne correspondent pas.";
                return false;
            }

            if (pin.Length < 4 || pin.Length > 6 ||
                !pin.All(char.IsDigit))
            {
                message = "Le PIN doit contenir entre 4 et 6 chiffres.";
                return false;
            }

            if (pin != confirmPin)
            {
                message = "Les codes PIN ne correspondent pas.";
                return false;
            }

            // Empêcher une deuxième inscription
            if (userModel.HasUser())
            {
                message = "Un compte existe déjà. Veuillez vous connecter.";
                return false;
            }

            User user = new User
            {
                Fullname = fullname.Trim(),
                Username = username.Trim(),
                Password = BCrypt.Net.BCrypt.HashPassword(password),
                Pin = BCrypt.Net.BCrypt.HashPassword(pin)
            };

            try
            {
                bool result = userModel.Save(user);

                message = result
                    ? "Compte créé avec succès !"
                    : "Échec de la création du compte.";

                return result;
            }
            catch (Exception ex)
            {
                message = "Erreur lors de l'inscription : " + ex.Message;
                return false;
            }
        }

        // Connexion
        public bool Login(
            string username,
            string password,
            out User user,
            out string message)
        {
            user = null;
            message = "";

            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
            {
                message = "Veuillez remplir tous les champs.";
                return false;
            }

            try
            {
                user = userModel.FindByUsername(username.Trim());

                if (user == null)
                {
                    message = "Nom d'utilisateur ou mot de passe incorrect.";
                    return false;
                }

                bool validPassword =
                    BCrypt.Net.BCrypt.Verify(password, user.Password);

                if (!validPassword)
                {
                    user = null;
                    message = "Nom d'utilisateur ou mot de passe incorrect.";
                    return false;
                }

                message = "Connexion réussie !";
                return true;
            }
            catch (Exception ex)
            {
                user = null;
                message = "Erreur de connexion : " + ex.Message;
                return false;
            }
        }

        // Vérification du PIN
        public bool VerifyPin(int userId, string pin, out string message)
        {
            message = "";

            if (string.IsNullOrWhiteSpace(pin) ||
                pin.Length < 4 ||
                pin.Length > 6 ||
                !pin.All(char.IsDigit))
            {
                message = "Veuillez saisir un PIN valide de 4 à 6 chiffres.";
                return false;
            }

            try
            {
                User user = userModel.FindById(userId);

                if (user == null)
                {
                    message = "Utilisateur introuvable.";
                    return false;
                }

                bool validPin = BCrypt.Net.BCrypt.Verify(pin, user.Pin);

                if (!validPin)
                {
                    message = "Code PIN incorrect.";
                    return false;
                }

                message = "Code PIN correct.";
                return true;
            }
            catch (Exception ex)
            {
                message = "Erreur lors de la vérification : " + ex.Message;
                return false;
            }
        }

        public bool ResetPassword(
    string username,
    string pin,
    string newPassword,
    string confirmPassword,
    out string message)
        {
            // Vérifier les champs obligatoires
            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(pin) ||
                string.IsNullOrWhiteSpace(newPassword) ||
                string.IsNullOrWhiteSpace(confirmPassword))
            {
                message = "Tous les champs sont obligatoires.";
                return false;
            }

            // Vérifier le format du PIN
            if (pin.Length < 4 || pin.Length > 6 ||
                !System.Text.RegularExpressions.Regex.IsMatch(pin, @"^\d+$"))
            {
                message = "Le PIN doit contenir entre 4 et 6 chiffres.";
                return false;
            }

            // Vérifier la longueur du mot de passe
            if (newPassword.Length < 8)
            {
                message = "Le nouveau mot de passe doit contenir au moins 8 caractères.";
                return false;
            }

            // Vérifier la confirmation
            if (newPassword != confirmPassword)
            {
                message = "Les mots de passe ne correspondent pas.";
                return false;
            }

            // Rechercher l'utilisateur
            User user = userModel.FindByUsername(username);

            if (user == null)
            {
                message = "Nom d'utilisateur incorrect.";
                return false;
            }

            // Vérifier le PIN
            if (!BCrypt.Net.BCrypt.Verify(pin, user.Pin))
            {
                message = "Code PIN incorrect.";
                return false;
            }

            // Crypter le nouveau mot de passe
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(newPassword);

            // Modifier le mot de passe
            bool resultat = userModel.UpdatePassword(user.Id, passwordHash);

            if (resultat)
            {
                message = "Votre mot de passe a été réinitialisé avec succès.";
                return true;
            }

            message = "Impossible de réinitialiser le mot de passe.";
            return false;
        }

        public User GetUserById(int userId)
        {
            return userModel.FindById(userId);
        }
    }
}
