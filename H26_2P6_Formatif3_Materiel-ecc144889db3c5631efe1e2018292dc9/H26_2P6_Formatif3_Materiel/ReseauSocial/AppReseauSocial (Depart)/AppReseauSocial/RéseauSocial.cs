using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace AppReseauSocial
{
    //=====================================================================================
    /// <summary>
    /// Modélise un réseau social avec des membres
    /// </summary>
    public class RéseauSocial
    {
        #region Propriétés
        //=====================================================================================
        private List<Membre> m_colMembres;
        /// <summary>
        /// Obtient la collection de tous les membres du réseau social
        /// </summary>
        public List<Membre> ColMembres {  get { return m_colMembres;  } }
        //=====================================================================================
        private List<Groupe> m_colGroupes;
        /// <summary>
        /// Obtient la collection de tous les groupes du réseau social
        /// </summary>
        public List<Groupe> ColGroupes { get { return m_colGroupes; } }
        //=====================================================================================
        private List<Publication> m_colPublications;
        /// <summary>
        /// Obtient la collection de toutes les publications du réseau social
        /// </summary>
        public List<Publication> ColPublications { get { return m_colPublications; } }
        #endregion

        #region Constructeur
        //=====================================================================================
        /// <summary>
        /// Initialise un RéseauSocial en peuplant les collections m_colMembres et m_colGroupes
        /// Ajoute les références aux amis de chaque membre de m_colMembres
        /// Ajoute les références aux membres (abonnés) de chaque groupe de m_colGroupes
        /// </summary>
        public RéseauSocial()
        {
            m_colMembres = new List<Membre>();
            ChargerMembres();
            
            m_colGroupes = new List<Groupe>();
            ChargerGroupes();

            m_colPublications = new List<Publication>();
            ChargerPublications();

            foreach (Membre membre in m_colMembres)
                RéférencerLesAmisDunMembre(membre);

            foreach (Groupe groupe in m_colGroupes)
                RéférencerLesMembresDuGroupe(groupe);
        }
        #endregion

        #region ChargerMembres, ChargerGroupes et ChargerPublications
        //=====================================================================================
        /// <summary>
        /// Peuple la collection m_colMembres de membres instantiés à partir de données lues dans le fichier "Membres.txt"
        /// </summary>
        private void ChargerMembres()
        {
            StreamReader objFichier = new StreamReader("Membres.txt");
            while (!objFichier.EndOfStream)
            {
                Membre membre = new Membre(objFichier.ReadLine());
                m_colMembres.Add(membre);
            }
            objFichier.Close();
        }
        //=====================================================================================
        /// <summary>
        /// Peuple la collection m_colGroupes de groupes instantiés à partir de données lues dans le fichier "Groupes.txt"
        /// </summary>
        private void ChargerGroupes()
        {
            m_colGroupes.Clear();
            StreamReader objFichier = new StreamReader("Groupes.txt");
            while (!objFichier.EndOfStream)
            {
                Groupe groupe = new Groupe(objFichier.ReadLine());
                m_colGroupes.Add(groupe);
            }
            objFichier.Close();
        }
        //=====================================================================================
        /// <summary>
        /// Peuple la collection m_colPublications des Publications instantiées à partir de données lues dans le fichier "Publications.txt"
        /// </summary>
        private void ChargerPublications()
        {
            m_colPublications.Clear();
            StreamReader objFichier = new StreamReader("Publications.txt");
            while (!objFichier.EndOfStream)
            {
                
                    Publication publication = new Publication(objFichier.ReadLine());
                    m_colPublications.Add(publication);
            }
            objFichier.Close();
        }
        #endregion

        #region Enregistrer les Membres, les Groupes et les Publications
        //=====================================================================================
        /// <summary>
        /// Enregistre toutes les informations nécessaires au fonctionnement du RéseauSocial
        /// </summary>
        public void Enregistrer()
        {
            EnregistrerMembres();
            EnregistrerGroupes();
            EnregistrerPublications();
        }
        //=====================================================================================
        /// <summary>
        /// Enregistre chacun des membres du réseau social
        /// </summary>
        private void EnregistrerMembres()
        {
            StreamWriter objFichier = new StreamWriter("Membres.txt");
            foreach (Membre membre in m_colMembres)
                objFichier.WriteLine(membre.ToString());
            objFichier.Close();
        }
        //=====================================================================================
        /// <summary>
        /// Enregistre chacun des groupes du réseau social
        /// </summary>
        private void EnregistrerGroupes()
        {
            StreamWriter objFichier = new StreamWriter("Groupes.txt");
            foreach (Groupe groupe in m_colGroupes)
                objFichier.WriteLine(groupe.ToString());
            objFichier.Close();
        }
        //=====================================================================================
        /// <summary>
        /// Enregistre toutes les publications du réseau social
        /// </summary>
        private void EnregistrerPublications()
        {
            StreamWriter objFichier = new StreamWriter("Publications.txt");
            foreach (Publication publication in m_colPublications)
                objFichier.WriteLine(publication.ToString());
            objFichier.Close();
        }
        #endregion

        #region MembreEstDansGroupe
        //=====================================================================================
        /// <summary>
        /// Recherche un groupe par son nom dans la collection m_colGroupes
        /// </summary>
        /// <param name="pNomDuGroupe">nom du groupe recherché</param>
        /// <returns></returns>
        public Groupe ObtenirUnGroupeParSonNom(string pNomDuGroupe)
        {
            foreach (Groupe groupe in m_colGroupes)
            {
                if (groupe.Nom == pNomDuGroupe)
                    return groupe;
            }
            return null;
        }
        //=====================================================================================
        /// <summary>
        /// Vérifie si un membre est abonné à un groupe donné
        /// </summary>
        /// <param name="pMembre">membre rechercher</param>
        /// <param name="pNomDuGroupe">nom du groupe dans lequel on recherche le membre</param>
        /// <returns>True si le membre est abonné au groupe, false autrement</returns>
        public bool MembreEstDansGroupe(Membre pMembre, string pNomDuGroupe)
        {
            Groupe groupe = ObtenirUnGroupeParSonNom(pNomDuGroupe);
            return groupe != null && groupe.ColMembres.Contains(pMembre);
        }
        #endregion

        #region ObtenirLesNonAmi
        //=====================================================================================
        /// <summary>
        /// Obtient la collection des membres du réseau social qui ne sont pas des amis d'un membre passé en paramétre
        /// et qui ne sont pas non plus dans la liste des membres suggérés.
        /// </summary>
        /// <param name="pMembre">un membre </param>
        /// <param name="pColSuggestions">collection des amis à suggérer</param>
        /// <returns></returns>
        public List<Membre> ObtenirLesNonAmi(Membre pMembre, List<Membre> pColSuggestions)
        {
            List<Membre> colMembresNonAmi = new List<Membre>();
            foreach (Membre membre in m_colMembres)
            {
               if (!pMembre.ColAmis.Contains(membre) && ! pColSuggestions.Contains(membre) && membre != pMembre)
                {
                    colMembresNonAmi.Add(membre);
                }
            }
            return colMembresNonAmi;
        }
        #endregion

        #region ObtenirSuggestionsAmis
        public List<Membre> ObtenirSuggestionsAmis(Membre pMembre)
        {
            List<Membre> colSuggestionsAmis = new List<Membre>();

            colSuggestionsAmis.Clear();
            foreach (Membre amiDuMembreCourant in pMembre.ColAmis)
            {
                foreach (Membre ami in amiDuMembreCourant.ColAmis)
                {
                    // Pas lui-même, pas déjà un ami, et pas déjà dans les suggestions
                    if (!colSuggestionsAmis.Contains(ami) && ami != pMembre && !pMembre.ColAmis.Contains(ami))
                        colSuggestionsAmis.Add(ami);
                }
            }
            return colSuggestionsAmis;
        }

        #endregion

        #region ObtenirUnMembreParSonNom
        //=====================================================================================
        /// <summary>
        /// Obtient par son nom, un membre du réseau social.
        /// </summary>
        /// <param name="pNomDuMembre">nom du membre à obtenir</param>
        /// <returns></returns>
        public Membre ObtenirUnMembreParSonNom(string pNomDuMembre)
        {
            foreach (Membre membre in m_colMembres)
                if (membre.Nom == pNomDuMembre)
                    return membre;
            return null;
        }
        #endregion 

        #region RéférencerLesMembres et RéférencerLesAmis
        /// <summary>
        /// Référence les membres du groupe passé en paramètre
        /// </summary>
        /// <param name="pGroupe">Groupe à traiter</param>
        public void RéférencerLesMembresDuGroupe(Groupe pGroupe)
        {
            if (pGroupe.ChaineMembres.Length == 0) return;

            string[] tabChaineMembres = pGroupe.ChaineMembres.Split(',');
            foreach (string nomMembre in tabChaineMembres)
            {
                Membre unMembreDansCeGroupe = ObtenirUnMembreParSonNom(nomMembre);
                pGroupe.ColMembres.Add(unMembreDansCeGroupe);
            }
        }
        /// <summary>
        /// Référence les membres amis du membre passé en paramètre
        /// </summary>
        /// <param name="pMembre">Membre à traiter</param>
        public void RéférencerLesAmisDunMembre(Membre pMembre)
        {
            if (pMembre.ChaineAmis.Length == 0) return;

            string[] tabChaineAmis = pMembre.ChaineAmis.Split(',');
            foreach (string nomMembre in tabChaineAmis)
            {
                Membre unMembreDansMesAmis = ObtenirUnMembreParSonNom(nomMembre);
                pMembre.ColAmis.Add(unMembreDansMesAmis);
            }
        }
        #endregion

        #region Méthode utilitaire pour les formulaires : AfficherUneListeDeMembres
        //=====================================================================================
        /// <summary>
        /// Affiche une collection de membre dans un ListView
        /// </summary>
        /// <param name="pListView"></param>
        /// <param name="pListeMembres"></param>
        public static void AfficherUneListeDeMembres(ListView pListView, List<Membre> pListeMembres)
        {
            pListView.BeginUpdate();
            pListView.Items.Clear();

            ImageList imageListLarge = new ImageList();
            imageListLarge.ImageSize = new Size(64, 96);
            imageListLarge.ColorDepth = ColorDepth.Depth32Bit;

            for (int index = 0; index < pListeMembres.Count; index++)
            {
                Membre membreCourant = pListeMembres[index];
                if(membreCourant.Photo != null)
                    imageListLarge.Images.Add(membreCourant.Photo);
                pListView.Items.Add(new ListViewItem(membreCourant.Nom + "\n" + membreCourant.Age, index));
            }

            pListView.LargeImageList = imageListLarge;
            pListView.EndUpdate();
        }
        #endregion
    }
}
