/*
 * PROJET : Bilbio-tech
 * AUTEUR : ALVES GUASTTI Letitia (I.FA-P3A)
 * DESC. : Un gestionnaire de mot de passe
 * VERSION : 26.01.2021 v.1
 */

using System;
using System.Collections.Generic;
using System.IO; //Add
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq; //Added

namespace ATAPP_XML
{
    class FileXML
    {
        private string _username, _dirPath, _filePath, _file;

        public string Username { get => _username; }
        public string DirPath { get => _dirPath; }
        public string FilePath { get => _filePath; }
        public string xmlFile { get => _file; }

        /// <summary>
        /// Constructeur principal de la classe FileXML
        /// </summary>
        public FileXML()
        {
            _username = Environment.UserName;
            _dirPath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "/db/";
            _file = "database.xml";
            _filePath = _dirPath + _file;
        }

        /// <summary>
        /// Méthode qui permet de vérifier si le dossier et le fichier XML existent
        /// </summary>
        /// <returns> L'action qui a été effectué </returns>
        public bool VerifyIfExist()
        {
            // Boucle qui vérifie si le dossier n'existe pas
            if (!Directory.Exists(_dirPath))
            {
                Directory.CreateDirectory(_dirPath);
                return false;
            }
            // Boucle qui vérifie si le fichier XML n'existe pas
            else if (!File.Exists(_filePath + ".aes"))
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Méthode qui permet de créer le fichier xml 
        /// </summary>
        public void CreateFile()
        {
            string createText = "<?xml version=\"1.0\" encoding=\"utf-8\" ?>" + Environment.NewLine + "<data>" + Environment.NewLine + "</data>";
            File.WriteAllText(_filePath, createText);
        }

        /// <summary>
        /// Méthode qui permet d'insérer des données dans le fichier xml
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="nameOf"></param>
        /// <param name="password"></param>
        /// <param name="noIndex"></param>
        public void InsertDataInFile(string userName, string nameOf, string password, int noIndex)
        {
            XDocument xmlFile = XDocument.Load(_filePath);

            // Déclaration des balises
            XElement name = new XElement("name", nameOf);
            XElement username = new XElement("username", userName);
            XElement pwd = new XElement("pwd", password);
            XElement id = new XElement("id");

            // Ajout de l'attribut à la balise index
            id.SetAttributeValue("num", noIndex);
            // Ajout de la balise index au fichier XML
            xmlFile.Root.Add(id);
            // Ajout des balises enfants dans la balise index (parent)
            id.Add(name, username, pwd);
            xmlFile.Save(_filePath);
        }

        /// <summary>
        /// Méthode qui permet de vérifier si un fichier existe et le supprimer dans le cas ou la boucle est vrai
        /// </summary>
        /// <param name="file"> Le nom du fichier chercher </param>
        public void IFExist(string file)
        {
            // Boucle qui vérifie si le fichier chercher existe
            if (File.Exists(file))
            {
                File.Delete(file);
            }
        }

        /// <summary>
        /// Méthode qui permet de récupérer les données du fichier xml et de les mettre dans une liste
        /// </summary>
        /// <returns> La liste de donnée </returns>
        public List<Record> GetDataInArray()
        {
            List<Record> data = new List<Record>();
            XDocument xmlFile = XDocument.Load(_filePath);

            // Boucle qui parcour les données dans le fichiers XML
            foreach (XElement element in xmlFile.Descendants("data").Nodes().ToList())
            {
                data.Add(new Record(element.Element("username").Value, element.Element("pwd").Value, element.Element("name").Value));
            }

            return data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="nameOf"></param>
        /// <param name="password"></param>
        /// <param name="noIndex"></param>
        public void UpdateDataInXml(string userName, string nameOf, string password, int noIndex)
        {
            XDocument xmlFile = XDocument.Load(_filePath);
            foreach (XElement parent in xmlFile.Root.Elements("id"))
            {
                if ((int)parent.Attribute("num") == noIndex)
                {
                    if ((string)parent.Element("name") != nameOf)
                    {
                        parent.Element("name").Value = nameOf;
                    }
                    else if ((string)parent.Element("username") != userName)
                    {
                        parent.Element("username").Value = userName;
                    }
                    else if ((string)parent.Element("pwd") != password)
                    {
                        parent.Element("pwd").Value = password;
                    }
                }
            }
            xmlFile.Save(_filePath);
        }
    }
}
