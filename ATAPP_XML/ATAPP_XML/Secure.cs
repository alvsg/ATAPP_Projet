/*
 * PROJET : Bilbio-tech
 * AUTEUR : ALVES GUASTTI Letitia (I.FA-P3A)
 * DESC. : Un gestionnaire de mot de passe
 * VERSION : 26.01.2021 v.1
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; //Added
using System.Security.Cryptography; //Added
using System.Runtime.InteropServices; //Added
using System.IO; //Added

namespace ATAPP_XML
{
    class Secure
    {
        //Permet de supprimer la clé de la mémoire après utilisation
        [DllImport("KERNEL32.DLL", EntryPoint = "RtlZeroMemory")]
        public static extern bool ZeroMemory(IntPtr Destination, int Length);

        static byte[] salt;
        private string _error;
        FileXML file;

        public string Error { get => _error; set => _error = value; }


        /// <summary>
        /// Constructeur principal
        /// </summary>
        public Secure()
        {
            file = new FileXML();
            salt = GenerateRandomSalt();
        }

        /// <summary>
        /// Méthode qui permet de générer un mot de passe aléatoire avec une taille aléatoire
        /// </summary>
        /// <returns> Le mot de passe générer aléatoirement </returns>
        public string GeneratorRandom()
        {
            // https://wmich.edu/arts-sciences/technology-password-tips
            string characters = "aAbBcCdDeEfFgGhHiIjJkKlLmMnNoOpPqQrRsStTuUvVwWxXyYzZ";
            string numbers = "0123456789";
            string specialChar = "~`!@#$%^&*()_-+={[}]|\\:;\"'<,>.?/";
            Random rnd = new Random();
            int length = rnd.Next(8, 32);
            string GeneratePwd = "";
            for (int i = 0; i < length; i++)
            {
                if (i % 2 == 0)
                {
                    GeneratePwd += characters[rnd.Next(0, characters.Length)];
                }
                else if (i % 3 == 0)
                {
                    GeneratePwd += specialChar[rnd.Next(0, specialChar.Length)];
                }
                else if (i % i == 0)
                {
                    GeneratePwd += numbers[rnd.Next(0, numbers.Length)];
                }
            }
            return GeneratePwd;
        }

        /// <summary>
        /// Méthode qui permet de récupérer le mot de passe puis de lancer le chiffrage selon ce mot de passe
        /// </summary>
        /// <param name="action"> L'action effectué le fichier </param>
        /// <param name="password"> Le mot de passe de l'utilisateur </param>
        /// <param name="state"> Le statut de l'action </param>
        public void ActionOnFile(bool action, string password, string state)
        {
            // Epingle le mot de passe
            GCHandle gch = GCHandle.Alloc(password, GCHandleType.Pinned);

            if (action)
            {
                // Chiffre le fichier
                FileEncrypt(file.FilePath, password);
                file.IFExist(file.FilePath);
            }
            else
            {
                // Déchiffre le fichier
                string filePathAES = file.FilePath + ".aes";
                FileDecrypt(filePathAES, file.FilePath, password);
                if (_error == null)
                {
                    file.IFExist(file.FilePath + ".aes");
                }
                else
                {
                    file.IFExist(file.FilePath);
                }
            }

            // Supprime le mot de passe épingler si pas en ecriture dans le fichier
            if (state != "writing")
            {
                ZeroMemory(gch.AddrOfPinnedObject(), password.Length * 2);
                gch.Free();
            }
        }

        /// <summary>
        /// Methode qui permet de créer un sel aléatoire qui va être utiliser pour chiffrer le fichier.
        /// </summary>
        /// <returns> Le sel </returns>
        public static byte[] GenerateRandomSalt()
        {
            byte[] data = new byte[32];

            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                for (int i = 0; i < 10; i++)
                {
                    rng.GetBytes(data);
                }
            }

            return data;
        }

        // Potentiel possibilité de combiner les méthodes de chiffrage et de déchiffrage car beaucoup de similarité
        /// <summary>
        /// Méthode qu permet de chiffrer un fichier
        /// https://ourcodeworld.com/articles/read/471/how-to-encrypt-and-decrypt-files-using-the-aes-encryption-algorithm-in-c-sharp
        /// </summary>
        /// <param name="inputFile"> Le chemin du fichier à chiffrer </param>
        /// <param name="password"> Le mot de passe de l'utilisateur </param>
        private void FileEncrypt(string inputFile, string password)
        {
            // http://stackoverflow.com/questions/27645527/aes-encryption-on-large-files

            FileStream fsCrypt = new FileStream(inputFile + ".aes", FileMode.Create);

            // Générer un sel aléatoire
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

            // Définir l'algorithme de chiffrement symétrique Rijndael
            RijndaelManaged AES = new RijndaelManaged();
            AES.KeySize = 256;
            AES.BlockSize = 128;
            AES.Padding = PaddingMode.PKCS7;

            // http://stackoverflow.com/questions/2659214/why-do-i-need-to-use-the-rfc2898derivebytes-class-in-net-instead-of-directly
            // Hash à plusieurs reprises le mot de passe de l'utilisateur avec le sel. Nombre d'itérations élevé.
            var key = new Rfc2898DeriveBytes(passwordBytes, salt, 50000);
            AES.Key = key.GetBytes(AES.KeySize / 8);
            AES.IV = key.GetBytes(AES.BlockSize / 8);

            // Cipher modes: http://security.stackexchange.com/questions/52665/which-is-the-best-cipher-mode-and-padding-mode-for-aes-encryption
            AES.Mode = CipherMode.CFB;

            // Ecrit le sel au début du fichier
            fsCrypt.Write(salt, 0, salt.Length);

            CryptoStream cs = new CryptoStream(fsCrypt, AES.CreateEncryptor(), CryptoStreamMode.Write);

            FileStream fsIn = new FileStream(inputFile, FileMode.Open);

            // Créationd'un tampon (1mb) pour que seule cette quantité soit allouée dans la mémoire et non le fichier entier
            byte[] buffer = new byte[1048576];
            int read;

            try
            {
                while ((read = fsIn.Read(buffer, 0, buffer.Length)) > 0)
                {
                    Application.DoEvents();
                    cs.Write(buffer, 0, read);
                }

                fsIn.Close();
            }
            catch (Exception ex)
            {
                _error = "Error: " + ex.Message;
            }
            finally
            {
                cs.Close();
                fsCrypt.Close();
            }
        }

        /// <summary>
        /// Méthode qui permet de déchiffrer un fichier
        /// </summary>
        /// <param name="inputFile"> Le fichier chiffré </param>
        /// <param name="outputFile"> Le fichier déchiffré </param>
        /// <param name="password"> Le mot de passe de l'utilisateur </param>
        private void FileDecrypt(string inputFile, string outputFile, string password)
        {
            // Générer un sel aléatoire
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

            FileStream fsCrypt = new FileStream(inputFile, FileMode.Open);
            fsCrypt.Read(salt, 0, salt.Length);

            // Définir l'algorithme de chiffrement symétrique Rijndael
            RijndaelManaged AES = new RijndaelManaged();
            AES.KeySize = 256;
            AES.BlockSize = 128;
            AES.Padding = PaddingMode.PKCS7;

            // http://stackoverflow.com/questions/2659214/why-do-i-need-to-use-the-rfc2898derivebytes-class-in-net-instead-of-directly
            // Hash à plusieurs reprises le mot de passe de l'utilisateur avec le sel. Nombre d'itérations élevé.
            var key = new Rfc2898DeriveBytes(passwordBytes, salt, 50000);
            AES.Key = key.GetBytes(AES.KeySize / 8);
            AES.IV = key.GetBytes(AES.BlockSize / 8);

            // Cipher modes: http://security.stackexchange.com/questions/52665/which-is-the-best-cipher-mode-and-padding-mode-for-aes-encryption
            AES.Mode = CipherMode.CFB;

            CryptoStream cs = new CryptoStream(fsCrypt, AES.CreateDecryptor(), CryptoStreamMode.Read);

            FileStream fsOut = new FileStream(outputFile, FileMode.Create);

            // Créationd'un tampon (1mb) pour que seule cette quantité soit allouée dans la mémoire et non le fichier entier
            byte[] buffer = new byte[1048576];
            int read;

            try
            {
                while ((read = cs.Read(buffer, 0, buffer.Length)) > 0)
                {
                    Application.DoEvents();
                    fsOut.Write(buffer, 0, read);
                }
            }
            catch (CryptographicException ex_CryptographicException)
            {
                _error = "CryptographicException error: " + ex_CryptographicException.Message;
            }
            catch (Exception ex)
            {
                _error = "Error: " + ex.Message;
            }

            try
            {
                cs.Close();
            }
            catch (Exception ex)
            {
                _error = "Error by closing CryptoStream: " + ex.Message;
            }
            finally
            {
                fsOut.Close();
                fsCrypt.Close();
            }
        }

        /// <summary>
        /// Méthode qui permet d'ajouter ou de modifier les données dans le fichier XML
        /// </summary>
        /// <param name="key"> Le mot de passe de l'utilisateur </param>
        /// <param name="safe"> Le coffre fort </param>
        public void addInFile(string key, Safe safe)
        {
            Secure pwd = new Secure();
            pwd.ActionOnFile(false, key, "writing");
            // Boucle qui vérifie qu'il n'y est pas d'erreur
            if (pwd.Error == null)
            {
                // Boucle qui parcourt la liste de donnée dans le coffre fort
                foreach (Record record in safe.Coffre)
                {
                    int noIndex = safe.Coffre.FindIndex(a => a.Name == record.Name);
                    // Boucle qui vérifie si l'index de la donnée est dans la liste des éléments a ajouté
                    if (safe.AddedInXmlFile.Contains(noIndex) == true)
                    {
                        file.InsertDataInFile(record.Username, record.Name, record.Password, noIndex);
                        break;
                    }
                    // Boucle qui vérifie si l'index de la donnée est dans la liste des éléments modifié
                    else if (safe.ModifiedInXmlFile.Contains(noIndex) == true)
                    {
                        file.UpdateDataInXml(record.Username, record.Name, record.Password, noIndex);
                        // Boucle qui vérifie que le mot de passe de l'application a été modifié
                        if (key != safe.Coffre[0].Password)
                        {
                            key = safe.Coffre[0].Password;
                        }
                        break;
                    }
                    else if (safe.DeletedInXmlFile.Contains(noIndex) == true)
                    {
                        file.DeleteDataInXmlFile(noIndex);
                        safe.Coffre.RemoveAt(noIndex);
                        break;
                    }
                }
                pwd.ActionOnFile(true, key, "writing");
            }
            safe.AddedInXmlFile.Clear();
            safe.ModifiedInXmlFile.Clear();
            safe.DeletedInXmlFile.Clear();
        }
    }
}
