using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; //Add

namespace ATAPP_XML
{
    class Password
    {

        private string _pwd;

        public string Pwd { get => _pwd; set => _pwd = value; }

        public Password()
        {

        }

        /// <summary>
        /// Méthode qui permet de générer un mot de passe aléatoire avec une taille aléatoire
        /// </summary>
        /// <returns></returns>
        public string GeneratorRandom()
        {
            string characters = "aAbBcCdDeEfFgGhHiIjJkKlLmMnNoOpPqQrRsStTuUvVwWxXyYzZ0123456789^~_-!:;?@#%&$£+=§èüéöàä";
            Random rnd = new Random();
            int length = rnd.Next(8, 32);
            string GeneratePwd = "";
            for (int i = 0; i <= length; i++)
            {
                GeneratePwd += characters[rnd.Next(0, characters.Length)];
            }
            return GeneratePwd;
        }

        public void CopyToClipboard(TextBox tbx)
        {
            Clipboard.SetDataObject(tbx.Text);
            MessageBox.Show("Votre mot de passe à été copier dans le press-papier.");
        }
    }
}
