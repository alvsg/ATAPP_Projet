﻿/*
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
    class Password
    {
        //Permet de supprimer la clé de la mémoire après utilisation
        [DllImport("KERNEL32.DLL", EntryPoint = "RtlZeroMemory")]
        public static extern bool ZeroMemory(IntPtr Destination, int Length);

        static byte[] salt;

        FileXML file;

        public Password()
        {
            file = new FileXML();
            salt = GenerateRandomSalt();
        }

        /// <summary>
        /// Méthode qui permet de générer un mot de passe aléatoire avec une taille aléatoire
        /// </summary>
        /// <returns></returns>
        public string GeneratorRandom()
        {
            // https://wmich.edu/arts-sciences/technology-password-tips
            string characters = "aAbBcCdDeEfFgGhHiIjJkKlLmMnNoOpPqQrRsStTuUvVwWxXyYzZ0123456789 ~`!@#$%^&*()_-+={[}]|\\:;\"'<,>.?/";
            Random rnd = new Random();
            int length = rnd.Next(8, 32);
            string GeneratePwd = "";
            for (int i = 0; i <= length; i++)
            {
                GeneratePwd += characters[rnd.Next(0, characters.Length)];
            }
            return GeneratePwd;
        }
        /// <summary>
        /// Méthode qui permet de récupérer le mot de passe puis de lancer le chiffrage selon ce mot de passe
        /// </summary>
        /// <param name="password"> Le mot de passe de l'utilisateur </param>
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
                if (file.Error == null)
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
                file.Error = "Error: " + ex.Message;
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
                file.Error = "CryptographicException error: " + ex_CryptographicException.Message;
            }
            catch (Exception ex)
            {
                file.Error = "Error: " + ex.Message;
            }

            try
            {
                cs.Close();
            }
            catch (Exception ex)
            {
                file.Error = "Error by closing CryptoStream: " + ex.Message;
            }
            finally
            {
                fsOut.Close();
                fsCrypt.Close();
            }
        }
    }
}
