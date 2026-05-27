using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppReseauSocial
{
    public partial class FrmListeDesPublications : Form
    {
        private RéseauSocial m_réseauSocial;
        private List<Publication> m_colPublicationsFiltrées;
        public FrmListeDesPublications(RéseauSocial pRéseauSocial)
        {
            InitializeComponent();
            m_réseauSocial = pRéseauSocial;
            PeuplerLesCombos();
            cboVisibilité.SelectedIndex = 0;
            cboMembre.SelectedIndex = 0;
        }

        private void PeuplerLesCombos()
        {
            cboVisibilité.Items.Clear();
            cboVisibilité.Items.Add("Peu importe");
            cboVisibilité.Items.Add("Publique");
            cboVisibilité.Items.Add("Amis");
            foreach (Groupe groupe in m_réseauSocial.ColGroupes)
            {
                cboVisibilité.Items.Add("Groupe " + groupe.Nom);
            }
            cboMembre.Items.Clear();
            cboMembre.Items.Add("Tous");
            foreach(Membre membre in m_réseauSocial.ColMembres)
            {
                cboMembre.Items.Add(membre.Nom);
            }
        }
        #region AfficherPublications
        /// <summary>
        /// </summary>
        public static void AfficherPublications(ListView pListView,List<Publication> pColPublications)
        {
            pListView.Items.Clear();
            for (int index = pColPublications.Count - 1; index >= 0; index--)
            {
                Publication publication = pColPublications[index];
                {
                    ListViewItem item;
                    if (publication.Visibilité == enuVisibilité.Groupe)
                        item = new ListViewItem("Groupe " + publication.NomGroupe);
                    else
                        item = new ListViewItem(publication.Visibilité.ToString());
                    item.SubItems.Add(publication.NomMembreSource);
                    item.SubItems.Add(publication.Date.ToString("yyyy-MM-dd HH:mm:ss"));
                    item.SubItems.Add(publication.Texte);
                    pListView.Items.Add(item);
                }
            }
        }
        #endregion

        #region cboFlitres_SelectedIndexChanged
        //========================================================================================================
        /// <summary>
        /// Permet de filtrer selon les 2 critères sélectionnés dans le 2 comboBox  cboGenre et cboGroupeAge
        /// Affiche tous les membres résultat du filtrage dans la liste en utilisant la méthode  AfficherUneListeDeMembres();
        /// </summary>

        private void cboFiltres_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboVisibilité.SelectedIndex == -1 || cboMembre.SelectedIndex == -1) return;

           // if (cboVisibilité.SelectedIndex == 0 && cboMembre.SelectedIndex == 0)
             //   AfficherPublications(m_réseauSocial.c);
            else // dans ce cas il faut créer une liste avec uniquement les membres qui répondent aux critères
            {
                m_colPublicationsFiltrées = new List<Publication>();
                foreach (Publication publication in m_réseauSocial.ColPublications)
                    m_colPublicationsFiltrées.Add(publication);

                FilterSelonVisibilité(); // on va enlever toutes les publications qui ne possèdent pas la visibilité choisie
                FilterSelonMembre(); // on va enlever toutes les publications dont le membre source n'est celui sélectionné
                FrmListeDesPublications.AfficherPublications(lsvPublications,m_colPublicationsFiltrées);
                lblNbPublications.Text = m_colPublicationsFiltrées.Count.ToString();
            }
        }
        #endregion

        #region FiltrerSelon Visibilité et Membre
        //========================================================================================================
        /// <summary>
        /// Filtre les membres de pColMembresFiltrés selon le critère du Genre sélectionné dans le cboGenre.
        /// Remarque: le filtrage est fait en supprimant de la liste pColMembresFiltrés ceux qui n'ont pas le genre sélectionné
        /// </summary>
        private void FilterSelonVisibilité()
        {
            if (cboVisibilité.SelectedIndex == 0) return; // rien à filtrer

            for (int index = m_colPublicationsFiltrées.Count - 1; index >= 0; index--)
            {
                Publication publication = m_colPublicationsFiltrées[index];

                if (cboVisibilité.SelectedIndex > 2) // alors il s'agit d'un groupe
                {
                    if (publication.Visibilité != enuVisibilité.Groupe || (publication.Visibilité == enuVisibilité.Groupe && "Groupe " + publication.NomGroupe != cboVisibilité.Text))
                        m_colPublicationsFiltrées.RemoveAt(index);
                }
                else if ((int)publication.Visibilité + 1 != cboVisibilité.SelectedIndex)
                    m_colPublicationsFiltrées.RemoveAt(index);
            }
        }
        //========================================================================================================
        /// <summary>
        /// Filtre les membres de pColMembresFiltrés selon le critère de groupe d'age  sélectionné dans le cboGroupeAge.
        /// Remarque: le filtrage est fait en supprimant de la liste pColMembresFiltrés ceux qui n'ont pas le groupe d'age sélectionné
        /// </summary>
        private void FilterSelonMembre()
        {
            if (cboMembre.SelectedIndex == 0) return; // cas du Tous, alors rien à filtrer

            for (int index = m_colPublicationsFiltrées.Count - 1; index >= 0; index--)
            {
                Publication publication = m_colPublicationsFiltrées[index];
                if (publication.NomMembreSource != cboMembre.Text)
                    m_colPublicationsFiltrées.RemoveAt(index);
            }
        }
        #endregion
        //========================================================================================================
        private void lsvPublications_DoubleClick(object sender, EventArgs e)
        {
            // on va supprimer la publication
            if (lsvPublications.SelectedIndices.Count == 0) return;

            int selectedIndex = lsvPublications.SelectedIndices[0];
            Publication aSupprimer = m_colPublicationsFiltrées[selectedIndex];

            lsvPublications.Items.RemoveAt(selectedIndex);
            m_réseauSocial.ColPublications.Remove(aSupprimer);
            lblNbPublications.Text = lsvPublications.Items.Count.ToString();
        }
    }
}
