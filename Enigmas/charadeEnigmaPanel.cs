using System.Drawing;
using System.Windows.Forms;

namespace Cpln.Enigmos.Enigmas
{
    /// <summary>
    /// Exemple d'�nigme tr�s simple. Seul un texte est affich�.
    /// </summary>
    public class CharadeEnigmaPanel : EnigmaPanel
    {
        /// <summary>
        /// Constructeur par d�faut, g�n�re un texte et l'affiche dans le Panel.
        /// </summary>
        public CharadeEnigmaPanel()
        {
            Label lblEnigme = new Label();

            lblEnigme.Text = "Mon premier est un mat�riau pr�cieux. \n" +
            "Mon second est la maison des oiseaux. \n" + 
            "Mon troisi�me est un Avenger. \n" +
            "Mon quatri�me est la fin de la fin. \n" +
            "Mon cinqui�me est la 11�me lettre de l'alphabet. \n\n" +
            "Mon tout est un mammif�re.";
            lblEnigme.Font = new Font(FontFamily.GenericSansSerif, 24, FontStyle.Bold);
            lblEnigme.Dock = DockStyle.Fill;
            lblEnigme.TextAlign = ContentAlignment.MiddleCenter;

            Controls.Add(lblEnigme);
        }
    }
}
