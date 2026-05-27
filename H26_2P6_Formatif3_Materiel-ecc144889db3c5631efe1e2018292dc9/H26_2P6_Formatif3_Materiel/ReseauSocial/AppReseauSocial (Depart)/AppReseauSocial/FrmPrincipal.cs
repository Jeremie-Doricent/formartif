using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AppReseauSocial
{
    public partial class FrmPrincipal : Form
    {
        public const string APP_INFOS = "(Matériel)";

        private List<Membre> m_colSuggestion;   // collection des membres à suggérer comme amis au membre courant
        private List<Membre> m_colNonAmi;       // collection des membres qui ne sont pas encore amis avec le membre courant
        #region Propriétés (À UTILISER)
        private RéseauSocial LeRéseauSocial { get; }
        private Membre MembreCourant
        {
            get
            {
                if (cboMembres.SelectedIndex != -1 && cboMembres.SelectedIndex < LeRéseauSocial.ColMembres.Count)
                    return LeRéseauSocial.ColMembres[cboMembres.SelectedIndex];
                else
                    return null;
            }
        }
        #endregion

        #region Constructeur (NE PAS MODIFIER)
        //=====================================================================================
        public FrmPrincipal()
        {
            InitializeComponent();
            //-------------------------------
            Text += APP_INFOS;

            LeRéseauSocial = new RéseauSocial();

            AjouterDesMembres();
            PeuplerComboMembres();
            PeuplerCheckListBoxGroupes();

            cboMembres.SelectedIndex = 0;
            cboVisibilité.SelectedIndex = 0;

            //GénérerDesAmiesEtAmis();
            //GénérerDesPublications();

            AfficherFilActualités();
        }
        #endregion

       

        #region PeuplerComboMembres et PeuplerCheckListBoxGroupes (NE PAS MODIFIER)
        //=====================================================================================
        /// <summary>
        /// Peuple cboMembres avec les noms des membres du réseau social
        /// </summary>
        private void PeuplerComboMembres()
        {
            cboMembres.Items.Clear();
            foreach (Membre membre in LeRéseauSocial.ColMembres)
            {
                cboMembres.Items.Add(membre.Nom);
            }
        }
        //=====================================================================================
        /// <summary>
        /// Peuple la checkedListBox clbGroupes avec les noms des groupes du réseau social
        /// </summary>
        private void PeuplerCheckListBoxGroupes()
        {
            clbGroupes.Items.Clear();
            foreach (Groupe groupe in LeRéseauSocial.ColGroupes)
            {
                clbGroupes.Items.Add(groupe.Nom);
            }
        }
        #endregion

        #region AfficherAmisNonAmiEtSuggestions (NE PAS MODIFIER)
        //=====================================================================================
        private void AfficherAmisNonAmiEtSuggestions()
        {
            // Affiche la liste des amis et la liste des non ami
            btnSupprimerAmi.Enabled = false;
            RéseauSocial.AfficherUneListeDeMembres(lsvAmis, MembreCourant.ColAmis);

            m_colSuggestion = LeRéseauSocial.ObtenirSuggestionsAmis(MembreCourant);
            RéseauSocial.AfficherUneListeDeMembres(lsvSuggestionAmis, m_colSuggestion);

            m_colNonAmi = LeRéseauSocial.ObtenirLesNonAmi(MembreCourant,m_colSuggestion);
            RéseauSocial.AfficherUneListeDeMembres(lsvNonAmi, m_colNonAmi);
        }
        #endregion

        #region Événement : cboMembres_SelectedIndexChanged (NE PAS MODIFIER)
        //=====================================================================================
        /// <summary>
        /// Affiche les informations du membre courant
        /// Affiche les membres qui ne sont pas des amis du membre courant
        /// Affiche les groupes auxquels appartient le membre en cochant l'item de clbGroupes(la CheckedListBox)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboMembres_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMembres.SelectedIndex != -1)
            {
                // Affiche les informations du membre courant
                picMembreCourant.Image = MembreCourant.Photo;
                lblAge.Text = MembreCourant.Age.ToString();
                lblGroupes.Text = MembreCourant.Nom + " est membre des groupes :";
                lblFilActualité.Text = "Fil d'actualité pour " + MembreCourant.Nom + " : ";
                AfficherAmisNonAmiEtSuggestions();
                AfficherLesGroupesDuMembreCourant();
                AfficherFilActualités();
            }
            else
            {
                picMembreCourant.Image = null;
                lblAge.Text = "";
            }
        }
        #endregion

        #region Événement : lsvNonAmis_DoubleClick (NE PAS MODIFIER)
        //=====================================================================================
        /// <summary>
        /// Ajoute le membre sélectionné aux amis du membre courant
        /// Ajoute le membre courant aux amis du membre sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lsvNonAmis_DoubleClick(object sender, EventArgs e)
        {
            if (MembreCourant != null)
            {
                int selectedIndex = lsvNonAmi.SelectedIndices[0];

                Membre membreSélectionné = m_colNonAmi[selectedIndex];

                MembreCourant.ColAmis.Add(membreSélectionné);
                membreSélectionné.ColAmis.Add(MembreCourant);

                AfficherAmisNonAmiEtSuggestions();
                AfficherFilActualités();
            }
        }
        #endregion

        #region Événement : lsvAmis_DoubleClick (NE PAS MODIFIER)
        //=====================================================================================
        /// <summary>
        /// Le membre sélectionné devient le membre courant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lsvAmis_DoubleClick(object sender, EventArgs e)
        {
            btnSupprimerAmi.Enabled = false;
            string nomDuMembre = lsvAmis.SelectedItems[0].Text.Split('\n')[0];
            cboMembres.Text = nomDuMembre;
            AfficherFilActualités();
        }
        #endregion

        #region Événement : lsvAmis_SelectedIndexChanged (NE PAS MODIFIER)
        //=====================================================================================

        private void lsvAmis_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSupprimerAmi.Enabled = lsvAmis.SelectedIndices.Count > 0;
        }
        #endregion

        #region Événement : btnSupprimerAmi_Click (NE PAS MODIFIER)
        //=====================================================================================
        /// <summary>
        /// Supprime le membre sélelectionné dea amis du membre courant
        /// Supprime le membre courant des amis du membre sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimerAmi_Click(object sender, EventArgs e)
        {
            if (MembreCourant != null)
            {
                int selectedIndex = lsvAmis.SelectedIndices[0];

                Membre membreAmi = MembreCourant.ColAmis[selectedIndex];
                MembreCourant.ColAmis.Remove(membreAmi);
                membreAmi.ColAmis.Remove(MembreCourant);

                AfficherAmisNonAmiEtSuggestions();
                AfficherFilActualités();
                MettreAJourSelonContexte();
            }
        }
        #endregion

        #region Événements : FrmPrincipal_FormClosing,mnuFichierQuitter_Click et mnuAdminListeAmitiés_Click (NE PAS MODIFIER)
        //=====================================================================================
        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            LeRéseauSocial.Enregistrer();
        }
        //=====================================================================================
        private void mnuFichierQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }
        //=====================================================================================
        /// <summary>
        /// Instancie le formulaire FrmListeDesGroupes en passant m_réseauSocial en paramétre
        /// Affiche le formulaire
        /// Affiche les groupes du membre courant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuSpécialGestionGroupes_Click(object sender, EventArgs e)
        {
            FrmListeDesGroupes frm = new FrmListeDesGroupes(LeRéseauSocial);
            frm.ShowDialog();
            AfficherLesGroupesDuMembreCourant();
        }

        //=====================================================================================
        /// <summary>
        /// Instancie le formulaire FrmListeDesPublications en passant m_réseauSocial en paramétre
        /// Affiche le formulaire
        /// Affiche les groupes du membre courant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuSpécialGestionPublications_Click(object sender, EventArgs e)
        {
            FrmListeDesPublications frm = new FrmListeDesPublications(LeRéseauSocial);
            frm.ShowDialog();
        }
        #endregion

        #region AfficherLesGroupesDuMembreCourant (NE PAS MODIFIER)
        //=====================================================================================
        /// <summary>
        /// Utilise clbGroupes (CheckedListBox) pour marquer (cocher) les groupes auxquels appartient le membre courant
        /// </summary>
        private void AfficherLesGroupesDuMembreCourant()
        {
            if (MembreCourant != null)
            {
                for (int index = 0; index < clbGroupes.Items.Count; index++)
                {
                    clbGroupes.SetItemChecked(index, LeRéseauSocial.MembreEstDansGroupe(MembreCourant, clbGroupes.Items[index].ToString()));
                }
                clbGroupes.SelectedIndex = -1;
            }
        }
        #endregion

        #region Événement : clbGroupes_SelectedIndexChanged (NE PAS MODIFIER)
        //=====================================================================================
        /// <summary>
        /// Ajoute/supprime un membre du groupe sélectionné dans la clbGroupes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clbGroupes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 
            if (clbGroupes.SelectedIndex != -1 && MembreCourant != null)
            {
                string nomDuGroupe = clbGroupes.SelectedItem.ToString();
                bool etatCaseACocher = clbGroupes.GetItemChecked(clbGroupes.SelectedIndex);
                Groupe groupeSélectionné = LeRéseauSocial.ColGroupes[clbGroupes.SelectedIndex];
                bool actuellementMembreDuGroupe = groupeSélectionné.ColMembres.Contains(MembreCourant);

                // la case est cochée actuellement et le membre n'est pas dans le groupe
                if (etatCaseACocher && !actuellementMembreDuGroupe) 
                { // dans ce cas il faut ajouter le membre dans le groupe
                    groupeSélectionné.ColMembres.Add(MembreCourant);
                }
                if (!etatCaseACocher && actuellementMembreDuGroupe)
                {
                    groupeSélectionné.ColMembres.Remove(MembreCourant);
                }
            }
            MettreAJourSelonContexte();
            AfficherFilActualités();
        }
        #endregion

        #region Événement : lsvSuggestionAmis_DoubleClick (NE PAS MODIFIER)
        //=====================================================================================

        private void lsvSuggestionAmis_DoubleClick(object sender, EventArgs e)
        {
            if (MembreCourant != null)
            {
                int selectedIndex = lsvSuggestionAmis.SelectedIndices[0];

                Membre membreSélectionné = m_colSuggestion[selectedIndex];

                MembreCourant.ColAmis.Add(membreSélectionné);
                membreSélectionné.ColAmis.Add(MembreCourant);

                AfficherAmisNonAmiEtSuggestions();
                AfficherFilActualités();
            }
        }

        #endregion

        #region Événement : lsvPublications_DoubleClick (NE PAS MODIFIER)
        private void lsvPublications_DoubleClick(object sender, EventArgs e)
        {
            if (lsvPublications.SelectedIndices.Count > 0)
            {
                int selectedIndex = lsvPublications.SelectedIndices[0];
                string nomDuMembreSource = lsvPublications.Items[selectedIndex].SubItems[1].Text;
                cboMembres.Text = nomDuMembreSource;
            }
        }
        #endregion

        #region Autres méthodes utiles (NE PAS MODIFIER)
        private void MettreAJourSelonContexte()
        {
            btnPublier.Enabled = (cboVisibilité.SelectedIndex < 2) || (cboVisibilité.SelectedIndex == 2 && clbGroupes.SelectedIndex != -1 && clbGroupes.GetItemChecked(clbGroupes.SelectedIndex));
            txtPublication.Enabled = btnPublier.Enabled;
        }
        private void cboPublicCible_SelectedIndexChanged(object sender, EventArgs e)
        {
            MettreAJourSelonContexte();
        }
        private void btnPublier_Click(object sender, EventArgs e)
        {
            string nomDuGroupe = "AUCUN";
            if (cboVisibilité.SelectedIndex == (int)enuVisibilité.Groupe)
                nomDuGroupe = clbGroupes.Text;

            Publication publication = new Publication((enuVisibilité)cboVisibilité.SelectedIndex, nomDuGroupe, MembreCourant.Nom, txtPublication.Text);
            LeRéseauSocial.ColPublications.Add(publication);
            txtPublication.Clear();
            AfficherFilActualités();
        }

        private void AfficherFilActualités()
        {
            // On va afficher toutes les publications que le MembreCourant devrait pourvoir voir soit :
            // 1) Toutes les publications faites par lui-même ou qui sont publiques
            // 2) Toutes les publications faites par ses amis qui sont destinées aux amis
            // 3) Toutes les publications faites dans un groupe auquel MembreCourant est abonné
            List<Publication> colPublicationsPourMembreCourant = new List<Publication>();
            const int MAX_PUBLICATIONS_FIL = 50;
            int cptPublications = 0;
            for (int index = LeRéseauSocial.ColPublications.Count - 1; index >= 0 && cptPublications < MAX_PUBLICATIONS_FIL; index--)
            {
                Publication publication = LeRéseauSocial.ColPublications[index];
                // Condition #1
                if (publication.Visibilité == enuVisibilité.Publique || publication.NomMembreSource == MembreCourant.Nom)
                {
                    colPublicationsPourMembreCourant.Add(publication);
                    cptPublications++;
                }
                // Condition #2
                else if (publication.Visibilité == enuVisibilité.Amis)
                {
                    Membre membreParSonNom = LeRéseauSocial.ObtenirUnMembreParSonNom(publication.NomMembreSource);
                    if (MembreCourant.ColAmis.Contains(membreParSonNom))
                    {
                        colPublicationsPourMembreCourant.Add(publication);
                        cptPublications++;
                    }
                }
                // Condition #3
                else if (publication.Visibilité == enuVisibilité.Groupe)
                {
                    Groupe groupe = LeRéseauSocial.ObtenirUnGroupeParSonNom(publication.NomGroupe);
                    if (groupe.ColMembres.Contains(MembreCourant))
                    {
                        colPublicationsPourMembreCourant.Add(publication);
                        cptPublications++;
                    }
                }
            }
            colPublicationsPourMembreCourant.Reverse();
            FrmListeDesPublications.AfficherPublications(lsvPublications, colPublicationsPourMembreCourant);
        }
        #endregion



       
       


        //#############################################################################################################

        #region QUESTIONS 1 à 4 (Publications)
       
        //=============================================================================================
        private void mnuQuestionsQ6_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Q6\n Nombre de publications du membre courant depuis le 1 janvier 2016 : " + Questions6().ToString());
        }

        //=============================================================================================
        private void mnuQuestionsQ7_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show("Q7\n Le nombre de publications faites dans le groupe Hockey : " + Questions7().ToString());
        }
        //=============================================================================================

        private void mnuQuestionsQ8_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show("Q8\n Le nombre total de publications pour les groupes auxquels le MembreCourant est abonné : " + Questions8().ToString());
        }
        //=============================================================================================
        private void mnuQuestionsQ9_Click(object sender, EventArgs e)
        {
           

            MessageBox.Show("Q9\n Le nombre total de publications faites par le MembreCourant dans les groupes auxquels il est abonné : " + Questions9().ToString());
        }
        //=============================================================================================
       
      
     
          
        #endregion
        #region QUESTIONS 1 à 5 (Amitié) Évènements
        private void mnuQuestions1_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show("Q1\n Le nombre d'amis : " + Question1().ToString());
        }

        private void mnuQuestions2_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show("Q2\n Le nombre de membres du même genre et nés au même mois que le membre courant : " + Question2().ToString());
        }

        private void mnuQuestions3_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show("Q3\n Le nombre de membres nés entre 1980 et 1990 : " + Question3().ToString());
        }

        private void mnuQuestions4_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show("Q4\n Le membre le plus agé des amis du membre courant : " + Question4().ToString());
        }

        private void mnuQuestions5_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show("Q5\n Les groupes auquels le membre courant est abonnée : \n" + Question5().ToString());
        }






        #endregion



        #region QUESTIONS 1 à 5 (Amitié) À Compléter
        /// <summary>
        /// TODO Q1 : Retourne le nombre d'amies/amis du MembreCourant
        /// </summary>
        private int Question1()
        {
            int a = 0;
            foreach(Membre membre in MembreCourant.ColAmis)
            {
                a =  membre.ColAmis.Count; 
            }
            return a ;
        }
        /// <summary>
        /// TODO Q2 : Retourner le nombre de membres du même genre et né le même mois que le MembreCourant
        /// </summary>
        private int Question2()
        {
            int scs = 0;
          
            foreach(Membre membre in LeRéseauSocial.ColMembres)

            {
                if(membre.DateNaissance.Month == MembreCourant.DateNaissance.Month && membre.Genre==MembreCourant.Genre)
                {

                     scs++;
                }
            }
           
            return scs;
        }
        /// <summary>
        /// TODO Q3 : Retourne le nombre de membres du réseau social nés entre 1980 et 1990 inclusivement.
        /// </summary>
        private int Question3()
        {
            int a = 0;
            foreach(Membre membre in LeRéseauSocial.ColMembres)
            {
                if(membre.DateNaissance.Year >= 1980 && membre.DateNaissance.Year <= 1990)
                {
                    a++;
                }
            }
           
            return a;
        }
        /// <summary>
        /// TODO Q4 : Retourne le nom du membre le plus âgé parmi les amis du membre courant.
        /// </summary>
        private string Question4()
        {
            string nom = "";
            int ageMax = 0;
            foreach (Membre membre in MembreCourant.ColAmis)
            {
                if(ageMax< membre.Age)
                {
                
                    nom = membre.Nom;
                    ageMax = membre.Age;
                }

            }


            return nom;
        }

        /// <summary>
        /// TODO Q5 : Retourne sur différentes lignes le nom de chacun des groupes auquel le MembreCourant est abonné
        /// </summary>
        private string Question5()
        {
            string ncn = "";
            foreach (Groupe groupe in LeRéseauSocial.ColGroupes)
            {
                if (groupe.ColMembres.Contains(MembreCourant))
                {

                    ncn = groupe.Nom;
                }



            }
            #endregion
            return ncn;
        }

        #region QUESTIONS 6 à 10 (Publications) À Compléter
       
        //=============================================================================================
        private int Questions6()
        {
            // TODO Q06 : Retourner le nombre de publications du MembreCourant depuis le 1 janvier 2016
            int xs = 0; 
            DateTime dateTime = new DateTime(2016,1,1);
            foreach(Publication publication in LeRéseauSocial.ColPublications)
            {
               
                if(publication.Date >= dateTime && publication.NomMembreSource == MembreCourant.Nom)
                {
                    xs++;
                }
            }
            return xs;
        }
        //============================================================================================= 
      
        private int Questions7()
        { string a = "Hockey";
            int at = 0;
            // TODO Q07 : Retourner le nombre de publications faites dans le groupe "Hockey"
            foreach (Publication publication in LeRéseauSocial.ColPublications)
            {
                if(a == publication.NomGroupe)
                {
                    at++;
                }
            }
            return at;
        }
        //=============================================================================================      
       
        private int Questions8()
        {
            int bas = 0;
            // TODO Q08 : Retourner le nombre total de publications du membre courant pour les groupes auxquels il est abonné
            // Vous pouvez utiliser la méthode MembreEstDansGroupe du réseau social
            foreach(Publication publication in LeRéseauSocial.ColPublications)
            {
         
                if (LeRéseauSocial.MembreEstDansGroupe(MembreCourant, publication.NomGroupe))
                {
                    bas++;
                }
            }
            
            return bas;
        }
        //=============================================================================================
      
        private int Questions9()
        {
            // TODO Q09 : Retourner le nombre total de publications faites par les amis du MembreCourant
            // Vous pouvez utiliser la méthode ObtenirUnMembreParSonNom du réseau social
            int dwsa = 0;
            foreach (Publication publication in LeRéseauSocial.ColPublications) 
            {
                Membre membre = LeRéseauSocial.ObtenirUnMembreParSonNom(publication.NomMembreSource);
                if (MembreCourant.ColAmis.Contains(membre)) 
                { 
                dwsa++;
                }

            }
           
            return dwsa;
        }


        void AjouterDesMembres()
        {

            // TODO Q10 : Créer trois membres du réseau social avec les informations fournies :
            //            Ajouter les membres au réseau social.
            //            Ajouter Alex Martin et Emma Dubois comme amis de Sarah Tremblay.
            
            // Informations des 3 membres
            // - Sarah Tremblay (F), née le 15 mai 2002, en couple
            // - Alex Martin (H), né le 10 octobre 2001, célibataire
            // - Emma Dubois (F), née le 22 janvier 2003, en couple
           DateTime time = new DateTime(2002,5,15);
            DateTime time1 = new DateTime(2001, 10, 10);
            DateTime time2 = new DateTime(2003, 1, 22);
            Membre membreList = new Membre("Sarah Tremblay",'F',time,false);
            Membre membreList1 = new Membre("Alex Martin", 'H', time1, true);
            Membre membreList2 = new Membre("Emma Dubois", 'F', time2, false);

             LeRéseauSocial.ColMembres.AddRange(new List<Membre> {membreList, membreList1, membreList2 });
            
           
            membreList.ColAmis.Add(membreList1);
            membreList.ColAmis.Add(membreList2);

        }


        #endregion


    }
}