using System;
using System.Collections.Generic;
using System.Data; //Add
using System.IO; //Add
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; //Add
using System.Security.Cryptography; //Add
using System.Runtime.InteropServices; //Add
using System.Xml.Linq; //Add
using System.Xml; //Add

namespace ATAPP_XML
{
    class fileXML
    {
        //  Permet de supprimer la clé de la mémoire après utilisation
        [DllImport("KERNEL32.DLL", EntryPoint = "RtlZeroMemory")]
        public static extern bool ZeroMemory(IntPtr Destination, int Length);

        static byte[] salt;

        private string _username, _dirPath, _filePath, _file, _error;

        public string Username { get => _username; set => _username = value; }
        public string DirPath { get => _dirPath; set => _dirPath = value; }
        public string FilePath { get => _filePath; set => _filePath = value; }
        public string xmlFile { get => _file; set => _file = value; }
        public string Error { get => _error; set => _error = value; }

        public fileXML(string user, string folder, string file)
        {
            salt = GenerateRandomSalt();

            _username = user;
            _dirPath = folder;
            _file = file;
            _filePath = folder + _file;
        }

        /// <summary>
        /// Méthode qui permet de vérifier si le dossier et le fichier XML existent
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public string VerifyIfExist()
        {
            string res = string.Empty;

            //Si le dossier n'existe pas
            if (!Directory.Exists(_dirPath))
            {
                Directory.CreateDirectory(_dirPath);
                CreateFile();
                return "Both created";
            }
            //Sinon si le fichier XML n'existe pas
            else if (!File.Exists(_filePath + ".aes"))
            {
                CreateFile();
                return "File created";
            }
            return "OK";
        }

        /// <summary>
        /// Méthode qui permet de créer et de définir les en-tête du fichier
        /// </summary>
        /// <param name="delimiter"> Le caractère d'espacement </param>
        public void CreateFile()
        {
            string createText = "<?xml version=\"1.0\" encoding=\"utf-8\" ?>" + Environment.NewLine + "<data>" + Environment.NewLine + "</data>";
            File.WriteAllText(_filePath, createText);
        }

        /// <summary>
        /// Méthode qui permet de récupérer le mot de passe puis de lancer le chiffrage selon ce mot de passe
        /// </summary>
        /// <param name="password"></param>
        public void ActionOnFile(bool action, string password)
        {
            // Epingle le mot de passe
            GCHandle gch = GCHandle.Alloc(password, GCHandleType.Pinned);

            if (action)
            {
                // Chiffre le fichier
                FileEncrypt(_filePath, password);

                IFExist(_filePath);
            }
            else
            {
                // Déchiffre le fichier
                string filePathAES = _filePath + ".aes";
                FileDecrypt(filePathAES, _filePath, password);

                IFExist(_filePath + ".aes");
            }

            // Supprime le mot de passe épingler
            ZeroMemory(gch.AddrOfPinnedObject(), password.Length * 2);
            gch.Free();

        }

        /// <summary>
        /// Methode qui permet de créer un sel aléatoire qui va être utiliser pour chiffrer le fichier.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Méthode qu permet de chiffrer un fichier.
        /// Encrypts a file from its path and a plain password.
        /// </summary>
        /// <param name="inputFile"> Le chemin du fichier </param>
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
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                cs.Close();
                fsCrypt.Close();
            }
        }

        /// <summary>
        /// Decrypts an encrypted file with the FileEncrypt method through its path and the plain password.
        /// </summary>
        /// <param name="inputFile"></param>
        /// <param name="outputFile"></param>
        /// <param name="password"></param>
        private void FileDecrypt(string inputFile, string outputFile, string password)
        {
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

            FileStream fsCrypt = new FileStream(inputFile, FileMode.Open);
            fsCrypt.Read(salt, 0, salt.Length);

            RijndaelManaged AES = new RijndaelManaged();
            AES.KeySize = 256;
            AES.BlockSize = 128;
            var key = new Rfc2898DeriveBytes(passwordBytes, salt, 50000);
            AES.Key = key.GetBytes(AES.KeySize / 8);
            AES.IV = key.GetBytes(AES.BlockSize / 8);
            AES.Padding = PaddingMode.PKCS7;
            AES.Mode = CipherMode.CFB;

            CryptoStream cs = new CryptoStream(fsCrypt, AES.CreateDecryptor(), CryptoStreamMode.Read);

            FileStream fsOut = new FileStream(outputFile, FileMode.Create);

            int read;
            byte[] buffer = new byte[1048576];

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
                _error =  "Error: " + ex.Message;
            }

            try
            {
                cs.Close();
            }
            catch (Exception ex)
            {
                _error =  "Error by closing CryptoStream: " + ex.Message;
            }
            finally
            {
                fsOut.Close();
                fsCrypt.Close();
            }
        }

        /// <summary>
        /// Méthode qui permet d'insérer des données dans le fichier xml
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public void InsertDataInFile(string user, string value)
        {
            XDocument xml = XDocument.Load(_filePath);

            XElement id = new XElement("id", "0");
            XElement username = new XElement("username", user);
            XElement pwd = new XElement("pwd", value);

            xml.Root.Add(id, username, pwd);
            xml.Save(_filePath);
        }

        public void IFExist(string file)
        {
            if (File.Exists(file))
            {
                File.Delete(file);
            }
        }
    }
}
