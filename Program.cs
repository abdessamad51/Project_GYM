using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salle_De_Sport
{
    static class Program
    {

        public static List<Client> Cl = new List<Client>();
        public static List<Entraineur> En = new List<Entraineur>();
        private static Responsable r = new Responsable();
        public static Salle S = new Salle(r, "GYM", "CasaBlanca");

        public static NouveauClient N = null;
        public static ModifierClient M = null;
        public static Paiement P = null;
        public static RechercherClient R = null;
        public static NouveauEntraîneur NE = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
      
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Connection());
        }
    }
}
