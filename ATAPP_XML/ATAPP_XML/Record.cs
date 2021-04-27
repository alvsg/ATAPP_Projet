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

namespace ATAPP_XML
{
    public class Record
    {
        private string _username;
        private string _password;
        private string _name;

        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
        public string Name { get => _name; set => _name = value; }

        public Record()
        {

        }

        /// <summary>
        /// Constructeur principal de la classe Record
        /// </summary>
        /// <param name="username"> Le nom d'utilisateur </param>
        /// <param name="password"> Le mot de passe </param>
        /// <param name="name"> Le nom du site/du logiciel </param>
        public Record(string username, string password, string name)
        {
            _username = username;
            _password = password;
            _name = name;
        }
    }
}
