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

namespace ATAPP_XML
{
    class Password
    {
        public Password()
        {

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
        /// Méthode qui permet de copier-coller le mot de passe dans le press-papier
        /// </summary>
        /// <param name="tbx"> Le mot de passe entrée par l'utilisateur </param>
        public void CopyToClipboard(TextBox tbx)
        {
            Clipboard.SetDataObject(tbx.Text);
            MessageBox.Show("Votre mot de passe à été copier dans le press-papier.");
        }
    }
}
