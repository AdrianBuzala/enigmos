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

            lblEnigme.Text = "La solution est simple.";
            lblEnigme.Font = new Font(FontFamily.GenericSansSerif, 24, FontStyle.Bold);
            lblEnigme.Dock = DockStyle.Fill;
            lblEnigme.TextAlign = ContentAlignment.MiddleCenter;

            Controls.Add(lblEnigme);
        }
    }
}
