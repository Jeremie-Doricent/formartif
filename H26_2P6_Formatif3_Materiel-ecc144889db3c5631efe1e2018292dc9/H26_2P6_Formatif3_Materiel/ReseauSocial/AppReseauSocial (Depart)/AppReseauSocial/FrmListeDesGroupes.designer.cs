namespace AppReseauSocial
{
    partial class FrmListeDesGroupes
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lsvMembres = new System.Windows.Forms.ListView();
            this.lsvMembresDuGroupe = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblListeDeTousLesMembres = new System.Windows.Forms.Label();
            this.lblMembresGroupeCourant = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboGroupes = new System.Windows.Forms.ComboBox();
            this.lblGroupeCourant = new System.Windows.Forms.Label();
            this.lblDateCréation = new System.Windows.Forms.Label();
            this.lblDateCréationInfo = new System.Windows.Forms.Label();
            this.lsvPublications = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.txtPublication = new System.Windows.Forms.TextBox();
            this.btnPublier = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNbPublications = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblNbMembres = new System.Windows.Forms.Label();
            this.lblCountM = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lsvMembres
            // 
            this.lsvMembres.FullRowSelect = true;
            this.lsvMembres.Location = new System.Drawing.Point(1057, 34);
            this.lsvMembres.MultiSelect = false;
            this.lsvMembres.Name = "lsvMembres";
            this.lsvMembres.Size = new System.Drawing.Size(273, 553);
            this.lsvMembres.TabIndex = 0;
            this.lsvMembres.TileSize = new System.Drawing.Size(128, 128);
            this.lsvMembres.UseCompatibleStateImageBehavior = false;
            this.lsvMembres.DoubleClick += new System.EventHandler(this.lsvMembres_DoubleClick);
            // 
            // lsvMembresDuGroupe
            // 
            this.lsvMembresDuGroupe.FullRowSelect = true;
            this.lsvMembresDuGroupe.HideSelection = false;
            this.lsvMembresDuGroupe.Location = new System.Drawing.Point(22, 104);
            this.lsvMembresDuGroupe.MultiSelect = false;
            this.lsvMembresDuGroupe.Name = "lsvMembresDuGroupe";
            this.lsvMembresDuGroupe.Size = new System.Drawing.Size(408, 427);
            this.lsvMembresDuGroupe.TabIndex = 5;
            this.lsvMembresDuGroupe.TileSize = new System.Drawing.Size(128, 128);
            this.lsvMembresDuGroupe.UseCompatibleStateImageBehavior = false;
            this.lsvMembresDuGroupe.SelectedIndexChanged += new System.EventHandler(this.lsvMembresDuGroupe_SelectedIndexChanged);
            this.lsvMembresDuGroupe.DoubleClick += new System.EventHandler(this.lsvMembresDuGroupe_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(1027, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 619);
            this.panel1.TabIndex = 7;
            // 
            // lblListeDeTousLesMembres
            // 
            this.lblListeDeTousLesMembres.AutoSize = true;
            this.lblListeDeTousLesMembres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListeDeTousLesMembres.Location = new System.Drawing.Point(1054, 15);
            this.lblListeDeTousLesMembres.Name = "lblListeDeTousLesMembres";
            this.lblListeDeTousLesMembres.Size = new System.Drawing.Size(175, 16);
            this.lblListeDeTousLesMembres.TabIndex = 8;
            this.lblListeDeTousLesMembres.Text = "Autres membres du réseau :";
            // 
            // lblMembresGroupeCourant
            // 
            this.lblMembresGroupeCourant.AutoSize = true;
            this.lblMembresGroupeCourant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembresGroupeCourant.Location = new System.Drawing.Point(19, 85);
            this.lblMembresGroupeCourant.Name = "lblMembresGroupeCourant";
            this.lblMembresGroupeCourant.Size = new System.Drawing.Size(154, 16);
            this.lblMembresGroupeCourant.TabIndex = 9;
            this.lblMembresGroupeCourant.Text = "Membres de ce groupe :";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(1054, 591);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Double cliquer sur un membre pour l\'ajouter au groupe";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(19, 534);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(408, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Double cliquer sur un membre pour le retirer du gourpe";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboGroupes
            // 
            this.cboGroupes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGroupes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGroupes.FormattingEnabled = true;
            this.cboGroupes.Location = new System.Drawing.Point(22, 34);
            this.cboGroupes.Name = "cboGroupes";
            this.cboGroupes.Size = new System.Drawing.Size(188, 28);
            this.cboGroupes.TabIndex = 12;
            this.cboGroupes.SelectedIndexChanged += new System.EventHandler(this.cboGroupes_SelectedIndexChanged);
            // 
            // lblGroupeCourant
            // 
            this.lblGroupeCourant.AutoSize = true;
            this.lblGroupeCourant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupeCourant.Location = new System.Drawing.Point(22, 15);
            this.lblGroupeCourant.Name = "lblGroupeCourant";
            this.lblGroupeCourant.Size = new System.Drawing.Size(106, 16);
            this.lblGroupeCourant.TabIndex = 13;
            this.lblGroupeCourant.Text = "Groupe courant :";
            // 
            // lblDateCréation
            // 
            this.lblDateCréation.AutoSize = true;
            this.lblDateCréation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateCréation.Location = new System.Drawing.Point(224, 15);
            this.lblDateCréation.Name = "lblDateCréation";
            this.lblDateCréation.Size = new System.Drawing.Size(103, 16);
            this.lblDateCréation.TabIndex = 14;
            this.lblDateCréation.Text = "Groupe créé le :";
            // 
            // lblDateCréationInfo
            // 
            this.lblDateCréationInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDateCréationInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateCréationInfo.Location = new System.Drawing.Point(227, 34);
            this.lblDateCréationInfo.Name = "lblDateCréationInfo";
            this.lblDateCréationInfo.Size = new System.Drawing.Size(206, 28);
            this.lblDateCréationInfo.TabIndex = 16;
            this.lblDateCréationInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lsvPublications
            // 
            this.lsvPublications.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lsvPublications.FullRowSelect = true;
            this.lsvPublications.GridLines = true;
            this.lsvPublications.Location = new System.Drawing.Point(456, 34);
            this.lsvPublications.MultiSelect = false;
            this.lsvPublications.Name = "lsvPublications";
            this.lsvPublications.Size = new System.Drawing.Size(549, 553);
            this.lsvPublications.TabIndex = 17;
            this.lsvPublications.UseCompatibleStateImageBehavior = false;
            this.lsvPublications.View = System.Windows.Forms.View.Details;
            this.lsvPublications.DoubleClick += new System.EventHandler(this.lsvPublications_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Membre source";
            this.columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Date";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Texte de la publication";
            this.columnHeader3.Width = 284;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(453, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Publications concernant le groupe courant :";
            // 
            // txtPublication
            // 
            this.txtPublication.Enabled = false;
            this.txtPublication.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublication.Location = new System.Drawing.Point(22, 576);
            this.txtPublication.Name = "txtPublication";
            this.txtPublication.Size = new System.Drawing.Size(327, 26);
            this.txtPublication.TabIndex = 19;
            // 
            // btnPublier
            // 
            this.btnPublier.Enabled = false;
            this.btnPublier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPublier.Location = new System.Drawing.Point(355, 576);
            this.btnPublier.Name = "btnPublier";
            this.btnPublier.Size = new System.Drawing.Size(75, 26);
            this.btnPublier.TabIndex = 20;
            this.btnPublier.Text = "Publier";
            this.btnPublier.UseVisualStyleBackColor = true;
            this.btnPublier.Click += new System.EventHandler(this.btnPublier_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(453, 590);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(282, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "Double cliquer sur une publication pour la supprimer";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNbPublications
            // 
            this.lblNbPublications.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNbPublications.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNbPublications.Location = new System.Drawing.Point(943, 10);
            this.lblNbPublications.Name = "lblNbPublications";
            this.lblNbPublications.Size = new System.Drawing.Size(62, 21);
            this.lblNbPublications.TabIndex = 28;
            this.lblNbPublications.Text = "0";
            this.lblNbPublications.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(877, 10);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(60, 20);
            this.lblCount.TabIndex = 27;
            this.lblCount.Text = "Count :";
            // 
            // lblNbMembres
            // 
            this.lblNbMembres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNbMembres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNbMembres.Location = new System.Drawing.Point(381, 80);
            this.lblNbMembres.Name = "lblNbMembres";
            this.lblNbMembres.Size = new System.Drawing.Size(49, 21);
            this.lblNbMembres.TabIndex = 30;
            this.lblNbMembres.Text = "0";
            this.lblNbMembres.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCountM
            // 
            this.lblCountM.AutoSize = true;
            this.lblCountM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountM.Location = new System.Drawing.Point(318, 80);
            this.lblCountM.Name = "lblCountM";
            this.lblCountM.Size = new System.Drawing.Size(60, 20);
            this.lblCountM.TabIndex = 29;
            this.lblCountM.Text = "Count :";
            // 
            // FrmListeDesGroupes
            // 
            this.AcceptButton = this.btnPublier;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 623);
            this.Controls.Add(this.lblNbMembres);
            this.Controls.Add(this.lblCountM);
            this.Controls.Add(this.lblNbPublications);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPublier);
            this.Controls.Add(this.txtPublication);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lsvPublications);
            this.Controls.Add(this.lblDateCréationInfo);
            this.Controls.Add(this.lblDateCréation);
            this.Controls.Add(this.lblGroupeCourant);
            this.Controls.Add(this.cboGroupes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMembresGroupeCourant);
            this.Controls.Add(this.lblListeDeTousLesMembres);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lsvMembresDuGroupe);
            this.Controls.Add(this.lsvMembres);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmListeDesGroupes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de plusieurs groupes de membres - ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvMembres;
        private System.Windows.Forms.ListView lsvMembresDuGroupe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblListeDeTousLesMembres;
        private System.Windows.Forms.Label lblMembresGroupeCourant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboGroupes;
        private System.Windows.Forms.Label lblGroupeCourant;
        private System.Windows.Forms.Label lblDateCréation;
        private System.Windows.Forms.Label lblDateCréationInfo;
        private System.Windows.Forms.ListView lsvPublications;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPublication;
        private System.Windows.Forms.Button btnPublier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNbPublications;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblNbMembres;
        private System.Windows.Forms.Label lblCountM;
    }
}

