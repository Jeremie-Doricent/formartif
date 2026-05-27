using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.ListViewItem;

namespace AppReseauSocial
{
    public partial class FrmListeDesGroupes : Form
    {
        private List<Membre> m_colMembresNonAbonné;
        private List<Publication> m_colPublications;
        private RéseauSocial m_réseauSocial;
        //=====================================================================================
        public FrmListeDesGroupes(RéseauSocial pRéseauSocial)
        {
            InitializeComponent();
            m_colMembresNonAbonné = new List<Membre>();
            m_colPublications = new List<Publication>();
            m_réseauSocial = pRéseauSocial;
            PeuplerLeComboDesGroupes();

            cboGroupes.SelectedIndex = 0;
            cboGroupes.Select();
        }

        #region PeuplerLeComboDesGroupes
        //=====================================================================================
        /// <summary>
        /// Peupler le cboGroupes avec les noms des groupes du réseau social
        /// </summary>
        private void PeuplerLeComboDesGroupes()
        {
            foreach (Groupe groupe in m_réseauSocial.ColGroupes)
            {
                cboGroupes.Items.Add(groupe.Nom);
            }
        }
        #endregion

        #region AfficherPublicationsDansLeGroupe
        /// <summary>
        /// </summary>
        private void AfficherPublicationsDansLeGroupe(Groupe pGroupeCourant)
        {
            lsvPublications.Items.Clear();
            m_colPublications.Clear();
            for (int index = m_réseauSocial.ColPublications.Count - 1; index >= 0; index--)
            {
                Publication publication = m_réseauSocial.ColPublications[index];
                if (publication.Visibilité == enuVisibilité.Groupe && publication.NomGroupe == cboGroupes.Text)
                {
                    ListViewItem item = new ListViewItem(publication.NomMembreSource);
                    item.SubItems.Add(publication.Date.ToString("yyyy-MM-dd HH:mm:ss"));
                    item.SubItems.Add(publication.Texte);
                    lsvPublications.Items.Add(item);
                }
                m_colPublications.Add(publication);
            }
            lblNbPublications.Text = lsvPublications.Items.Count.ToString();
        }
        #endregion

        #region Événement : lsvMembres_DoubleClick (Ajoute le membre sélectionné au groupe courant)
        //=====================================================================================
        /// <summary>
        /// Ajoute le membre sélectionné au groupe courant
        /// Affiche les membres du groupe sélectionné
        /// Affiche les membres du réseau social qui ne sont pas dans ce groupe courant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lsvMembres_DoubleClick(object sender, EventArgs e)
        {
            if (lsvMembres.SelectedIndices.Count > 0)
            {
                Groupe groupeCourant = m_réseauSocial.ColGroupes[cboGroupes.SelectedIndex];
                int selectedIndex = lsvMembres.SelectedIndices[0];
                Membre membreSélectionné = m_colMembresNonAbonné[selectedIndex];
                groupeCourant.ColMembres.Add(membreSélectionné);
                RéseauSocial.AfficherUneListeDeMembres(lsvMembresDuGroupe, groupeCourant.ColMembres);
                lblNbMembres.Text = groupeCourant.ColMembres.Count.ToString();
                AfficherLesMembresQuiNeSontPasAbonné(groupeCourant);
            }
        }
        #endregion

        #region Événement : lsvMembresDuGroupe_DoubleClick (Supprime un membre du groupe)
        //=====================================================================================
        /// <summary>
        /// Supprime le membre sélectionné du groupe courant
        /// Affiche les membres du groupe sélectionné
        /// Affiche les membres du réseau social qui ne sont pas dans ce groupe courant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lsvMembresDuGroupe_DoubleClick(object sender, EventArgs e)
        {
            if (lsvMembresDuGroupe.SelectedIndices.Count > 0)
            {
                Groupe groupeCourant = m_réseauSocial.ColGroupes[cboGroupes.SelectedIndex];
                int selectedIndex = lsvMembresDuGroupe.SelectedIndices[0];
                Membre membreASupprimer = groupeCourant.ColMembres[selectedIndex];
                groupeCourant.ColMembres.RemoveAt(selectedIndex);
                RéseauSocial.AfficherUneListeDeMembres(lsvMembresDuGroupe, groupeCourant.ColMembres);
                AfficherLesMembresQuiNeSontPasAbonné(groupeCourant);
            }
        }
        #endregion

        #region AfficherLesMembresQuiNeSontPasAbonné
        //=====================================================================================
        /// <summary>
        /// Affiche les membres du réseau social qui ne sont pas dans le groupe passé en paramétre
        /// </summary>
        /// <param name="pGroupe">Le groupe </param>
        private void AfficherLesMembresQuiNeSontPasAbonné(Groupe pGroupe)
        {
            m_colMembresNonAbonné.Clear();
            foreach (Membre membre in m_réseauSocial.ColMembres)
            {
                if (!pGroupe.ColMembres.Contains(membre))
                    m_colMembresNonAbonné.Add(membre);
            }
            RéseauSocial.AfficherUneListeDeMembres(lsvMembres, m_colMembresNonAbonné);
        }
        #endregion

        #region Événement : cboGroupes_SelectedIndexChanged
        //=====================================================================================
        /// <summary>
        /// Sélectionne un groupe
        /// Affiche les informations du groupe
        /// Affiche les membres du groupe
        /// Affiche les membres qui ne sont pas dans le groupe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboGroupes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Groupe groupeCourant = m_réseauSocial.ColGroupes[cboGroupes.SelectedIndex];
            lblDateCréationInfo.Text = groupeCourant.DateDeCréation.ToString("dd/MMMM/yyyy à HH:mm:ss");
            RéseauSocial.AfficherUneListeDeMembres(lsvMembresDuGroupe, groupeCourant.ColMembres);
            lblNbMembres.Text = groupeCourant.ColMembres.Count.ToString();
            AfficherLesMembresQuiNeSontPasAbonné(groupeCourant);
            AfficherPublicationsDansLeGroupe(groupeCourant);
        }
        #endregion
        //=====================================================================================
        private void lsvMembresDuGroupe_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnPublier.Enabled = lsvMembresDuGroupe.SelectedIndices.Count > 0;
            txtPublication.Enabled = btnPublier.Enabled;
        }
        //=====================================================================================
        private void btnPublier_Click(object sender, EventArgs e)
        {
            Groupe groupeCourant = m_réseauSocial.ColGroupes[cboGroupes.SelectedIndex];
            Membre membreCourant = groupeCourant.ColMembres[lsvMembresDuGroupe.SelectedIndices[0]];
            Publication publication = new Publication(enuVisibilité.Groupe, groupeCourant.Nom, membreCourant.Nom, txtPublication.Text);
            m_réseauSocial.ColPublications.Add(publication);
            AfficherPublicationsDansLeGroupe(groupeCourant);
            txtPublication.Clear();
        }
        //=====================================================================================
        private void lsvPublications_DoubleClick(object sender, EventArgs e)
        {
            if (lsvPublications.SelectedIndices.Count > 0)
            {
                int selectedIndex = lsvPublications.SelectedIndices[0];
                Publication publication = m_colPublications[selectedIndex];
                m_réseauSocial.ColPublications.Remove(publication);
                Groupe groupeCourant = m_réseauSocial.ColGroupes[cboGroupes.SelectedIndex];
                AfficherPublicationsDansLeGroupe(groupeCourant);
            }
        }
    }
}