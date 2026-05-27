using System;
using System.Collections.Generic;
using System.Text;

namespace AppReseauSocial
{
    public enum enuVisibilité { Publique, Amis, Groupe } // Différentes visibilités pour une publication
    /// <summary>
    /// Réprésente une publication faite par un membre dans un réseau social, la publication sera soit :
    /// Publique    : visible par tous
    /// Amis        : uniquement visible par les amis et amies du membre
    /// Groupe      : uniquement par des membres qui sont abonnés au groupe en question
    /// </summary>
    public class Publication
    {
        #region Propriétés (NE PAS MODIFIER)
        public enuVisibilité Visibilité { get; }
        /// ===============================================================================================
        /// <summary>
        /// Contient le nom du groupe destinataire si applicable
        /// </summary>
        public string NomGroupe { get; }
        /// ===============================================================================================
        /// <summary>
        /// 
        /// </summary>
        public string NomMembreSource { get; }
        /// ===============================================================================================
        /// <summary>
        /// Obtient la date de la publication.
        /// </summary>
        public DateTime Date { get; }
        /// ===============================================================================================
        /// <summary>
        /// Obtient le texte de la publication.
        /// </summary>
        public string Texte { get; }
        #endregion

        #region Constructeurs (NE PAS MODIFIER)
        /// <summary>
        /// Initialise une Publication avec la chaîne passée en paramètre. 
        /// </summary>
        /// <param name="pChaineLue">chaine des données séparées par |</param>
        public Publication(string pInfosLigneLue)
        {
            string[] tabInfos = pInfosLigneLue.Split('|');
            Visibilité = (enuVisibilité)int.Parse(tabInfos[0]);
            NomGroupe = tabInfos[1];
            NomMembreSource = tabInfos[2];
            Date = DateTime.Parse(tabInfos[3]);
            Texte = tabInfos[4];
        }
        /// <summary>
        /// Initialise une Publication.
        /// </summary>
        /// <param name="pVisibilité">Visibilité de la Publication</param>
        /// <param name="pNomGroupe">Nom du groupe (si applicable)</param>
        /// <param name="pNomMembre">Nom du membre ayant créée la Publication</param>
        /// <param name="pTexte">Texte de la Publication</param>
        public Publication(enuVisibilité pVisibilité, string pNomGroupe, string pNomMembre, string pTexte)
        {
            Visibilité = pVisibilité;
            NomGroupe = pNomGroupe;
            NomMembreSource = pNomMembre;
            Texte = pTexte;
            Date = DateTime.Now;
        }
        #endregion

        #region ToString (NE PAS MODIFIER)
        ///===============================================================================================
        /// <summary>
        /// Obtient une chaine composée des informations de la publication
        /// </summary>
        /// <returns>Une chaine comprenant toutes les informations de la publication séparées par | </returns>
        public override string ToString()
        {
            return (int)Visibilité + "|" + NomGroupe + "|" + NomMembreSource + "|" + Date.ToString("yyyy-MM-dd HH:mm:ss") + "|" + Texte;
        }
        #endregion

    }
}

