using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AppReseauSocial
{
    /// ===============================================================================================
    /// <summary>
    /// Modélise un membre dans un réseau social. Le membre contient une collection de ses amis.
    /// </summary>
    public class Membre:IComparable
    {
        #region Constantes (NE PAS MODIFIER)
        
       // public const string PHOTO_PAR_DEFAUT = "Images\\" + Nom + ".jpg"
        #endregion

        #region Propriétés (NE PAS MODIFIER)
        /// ===============================================================================================
        private char m_genre;
        /// <summary>
        /// Obtient le genre du  membre (H ou F).
        /// </summary>
        public char Genre
        {
            get { return m_genre; }
        }
        /// ===============================================================================================
        private bool m_estCélibataire;
        /// <summary>)
        /// Obtient la propriété EstCélibataire du  membre
        /// </summary>
        public bool EstCélibataire
        {
            get { return m_estCélibataire; }
        }

        /// ===============================================================================================
        private string m_nom;
        /// <summary>
        /// Obtient le nom d'un  membre.
        /// </summary>
        public string Nom
        {
            get { return m_nom; }
        }
        /// ===============================================================================================
        private DateTime m_dateNaissance;
        /// <summary>
        /// Obtient la date de naissance d'un  membre.
        /// </summary>
        public DateTime DateNaissance
        {
            get { return m_dateNaissance; }
        }
        /// ===============================================================================================
        private Image m_photo;
        /// <summary>
        /// Obtient la photo d'un  membre.
        /// </summary>
        public Image Photo
        {
            get { return m_photo; }
        }
        /// ===============================================================================================
        /// <summary>
        /// Obtient l'age d'un  membre.
        /// </summary>
        public int Age
        {
            get
            {
                return (int)((DateTime.Now - m_dateNaissance).TotalDays / 365.25);
            }
        }
        /// ===============================================================================================
        /// <summary>
        /// Collection des membres avec lequel le membre est ami ou amie
        /// </summary>
        private List<Membre> m_colAmis;
        public List<Membre> ColAmis
        {
            get
            {
                return m_colAmis;
            }
        }
        #endregion

        #region champs privé temporaire (NE PAS MODIFIER)
        private string m_chaineAmis = "";
        public string ChaineAmis { get { return m_chaineAmis;  } }
        #endregion

        #region Constructeur (NE PAS MODIFIER)
        /// ===============================================================================================
        /// <summary>
        /// Initialise un membre avec  la chaîne passée en paramètre.
        /// Les données sont séparées par une "|" voici un exemple:
        ///              F|Alexandra Daddario|1986-03-16|True|Aaron Eckhart,Ali Astin,Anne Hathaway
        /// La dernière chaine est composée des noms des amis du membre            
        /// </summary>
        /// <param name="pChaineLue">chaine des données séparées par une |</param>
        public Membre(string pChaineLue)
        {
            string[] tabInfos = pChaineLue.Split('|');
            m_genre = tabInfos[0][0];
            m_nom = tabInfos[1];
            m_dateNaissance = DateTime.Parse(tabInfos[2]);
            try
            {
                m_photo = Image.FromFile("Images\\" + Nom + ".jpg");
            }
            catch(Exception ex)
            {
               
            }
           
            m_estCélibataire = bool.Parse(tabInfos[3]);
            m_chaineAmis = tabInfos[4];
            m_colAmis = new List<Membre>();
        }

        public Membre(string pNom, char pGenre, DateTime pDateDeNaissance, bool pEstCelibataire)
        {

            m_genre = pGenre;
            m_nom = pNom;
            m_dateNaissance = pDateDeNaissance;
            //   m_photo = Image.FromFile("Images\\" + Nom + ".jpg");
            m_estCélibataire = pEstCelibataire;
            //m_chaineAmis = tabInfos[4];
            m_colAmis = new List<Membre>();
        }

        #endregion

        #region ToString (NE PAS MODIFIER)
        /// ===============================================================================================
        /// <summary>
        /// Obtient une chaine composée des informations du membre
        /// </summary>
        /// <returns>Une chaine comprenant toutes les information du membre séparées par une | </returns>
        public override string ToString()
        {
            // On commence par générer une chaîne contenant la liste des amis/amies du membre
            string chaineAmis = "";
            foreach (Membre membre in m_colAmis)
            {
                chaineAmis += membre.Nom + ",";
            }
            if (m_colAmis.Count > 0)
                chaineAmis = chaineAmis.Substring(0, chaineAmis.Length - 1);

            return m_genre + "|" + m_nom + "|" + m_dateNaissance.ToString("yyyy-MM-dd") + "|" + m_estCélibataire
                + "|" + chaineAmis;
        }

        public int CompareTo(object obj)
        {
            return string.Compare(m_nom, ((Membre)obj).m_nom);
        }
        #endregion

    }
}
