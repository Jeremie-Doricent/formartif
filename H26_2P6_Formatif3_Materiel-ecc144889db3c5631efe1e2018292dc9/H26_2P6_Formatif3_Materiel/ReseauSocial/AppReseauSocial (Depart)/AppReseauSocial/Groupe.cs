using System;
using System.Collections.Generic;
using System.Text;

namespace AppReseauSocial
{
    /// <summary>
    /// Modélise un groupe de membres abonnés pour un sujet donné dans un réseau social
    /// </summary>
    public class Groupe
    {
        #region Propriétés (NE PAS MODIFIER)
        /// ===============================================================================================
        private string m_nom;
        /// <summary>
        /// Obtient le nom du groupe.
        /// </summary>
        public string Nom
        {
            get { return m_nom; }
        }
        /// ===============================================================================================
        private DateTime m_dateDeCréation;
        /// <summary>
        /// Obtient la date de création du groupe.
        /// </summary>
        public DateTime DateDeCréation
        {
            get { return m_dateDeCréation; }
        }
        /// ===============================================================================================
        private List<Membre> m_colMembres;
        /// <summary>
        /// Obtient la collection des membres du groupe
        /// </summary>
        public List<Membre> ColMembres
        {
            get { return m_colMembres; }
        }
        #endregion

        #region champs privé temporaire (NE PAS MODIFIER)
        /// ===============================================================================================
        private string m_chaineMembres = "";
        public string ChaineMembres { get { return m_chaineMembres; } }
        #endregion

        #region Constructeurs (NE PAS MODIFIER)
        /// <summary>
        /// Initialise un groupe avec  la chaîne passée en paramètre.
        /// Les données sont séparées par une "|" voici un exemple:
        ///              Cuisine|2010-01-12 22:25:30|Ali Astin,Ana de Armas,Anne Hathaway
        /// La dernière chaine est composée des noms des membres du groupe            
        /// </summary>
        /// <param name="pChaineLue">chaine des données séparées par une |</param>
        public Groupe (string pInfosLigneLue)
        {
            string[] tabInfos = pInfosLigneLue.Split('|');
            m_nom = tabInfos[0];
            m_dateDeCréation = DateTime.Parse(tabInfos[1]);
            m_chaineMembres = tabInfos[2];
            m_colMembres = new List<Membre>();
        }
        ///===============================================================================================
        /// <summary>
        /// Initialise un groupe 
        /// </summary>
        /// <param name="pNom">nom du groupe</param>
        /// <param name="pDateCréation">date de création du groupe</param>
        public Groupe(string pNom,DateTime pDateCréation)
        {
            m_nom = pNom;
            m_dateDeCréation = pDateCréation;
            m_chaineMembres = "";
            m_colMembres = new List<Membre>();                        
        }
        #endregion

        #region ToString (NE PAS MODIFIER)
        ///===============================================================================================
        /// <summary>
        /// Obtient une chaine composée des informations du groupe
        /// </summary>
        /// <returns>Une chaine comprenant toutes les informations du groupe séparées par | </returns>
        public override string ToString()
        {
            string chaineMembres = "";
            foreach (Membre membre in ColMembres)
            {
                chaineMembres += membre.Nom + ",";
            }
            if (ColMembres.Count > 0)
                chaineMembres = chaineMembres.Substring(0, chaineMembres.Length - 1);

            return Nom + "|" + DateDeCréation.ToString("yyyy-MM-dd HH:mm:ss") + "|" + chaineMembres;
        }
        #endregion
    }
}
