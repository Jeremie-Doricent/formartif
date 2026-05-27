namespace AppReseauSocial
{
    partial class FrmPrincipal
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
            this.lsvAmis = new System.Windows.Forms.ListView();
            this.lblMembres = new System.Windows.Forms.Label();
            this.lblAmis = new System.Windows.Forms.Label();
            this.lsvNonAmi = new System.Windows.Forms.ListView();
            this.lblNonAmis = new System.Windows.Forms.Label();
            this.picMembreCourant = new System.Windows.Forms.PictureBox();
            this.cboMembres = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblAge = new System.Windows.Forms.Label();
            this.btnSupprimerAmi = new System.Windows.Forms.Button();
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFichierQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSpécial = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSpécialGestionGroupes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSpécialGestionPublications = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuestionAmis = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuestions1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuestions2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuestions3 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuestions4 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuestions5 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuestions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuestionsQ6 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuestionsQ7 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuestionsQ8 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuestionsQ9 = new System.Windows.Forms.ToolStripMenuItem();
            this.clbGroupes = new System.Windows.Forms.CheckedListBox();
            this.lblGroupes = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblFilActualité = new System.Windows.Forms.Label();
            this.lsvPublications = new System.Windows.Forms.ListView();
            this.columnHeader0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTextePublication = new System.Windows.Forms.Label();
            this.lblVisibilité = new System.Windows.Forms.Label();
            this.cboVisibilité = new System.Windows.Forms.ComboBox();
            this.btnPublier = new System.Windows.Forms.Button();
            this.txtPublication = new System.Windows.Forms.TextBox();
            this.lblSuggestionAmis = new System.Windows.Forms.Label();
            this.lsvSuggestionAmis = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picMembreCourant)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.mnuPrincipal.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsvAmis
            // 
            this.lsvAmis.FullRowSelect = true;
            this.lsvAmis.HideSelection = false;
            this.lsvAmis.Location = new System.Drawing.Point(923, 61);
            this.lsvAmis.MultiSelect = false;
            this.lsvAmis.Name = "lsvAmis";
            this.lsvAmis.Size = new System.Drawing.Size(396, 276);
            this.lsvAmis.TabIndex = 1;
            this.lsvAmis.TileSize = new System.Drawing.Size(128, 128);
            this.lsvAmis.UseCompatibleStateImageBehavior = false;
            this.lsvAmis.SelectedIndexChanged += new System.EventHandler(this.lsvAmis_SelectedIndexChanged);
            this.lsvAmis.DoubleClick += new System.EventHandler(this.lsvAmis_DoubleClick);
            // 
            // lblMembres
            // 
            this.lblMembres.AutoSize = true;
            this.lblMembres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembres.Location = new System.Drawing.Point(9, 19);
            this.lblMembres.Name = "lblMembres";
            this.lblMembres.Size = new System.Drawing.Size(119, 13);
            this.lblMembres.TabIndex = 2;
            this.lblMembres.Text = "Liste des membres :";
            // 
            // lblAmis
            // 
            this.lblAmis.AutoSize = true;
            this.lblAmis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmis.Location = new System.Drawing.Point(920, 45);
            this.lblAmis.Name = "lblAmis";
            this.lblAmis.Size = new System.Drawing.Size(80, 13);
            this.lblAmis.TabIndex = 3;
            this.lblAmis.Text = "Amis/Amies :";
            // 
            // lsvNonAmi
            // 
            this.lsvNonAmi.FullRowSelect = true;
            this.lsvNonAmi.HideSelection = false;
            this.lsvNonAmi.Location = new System.Drawing.Point(923, 534);
            this.lsvNonAmi.MultiSelect = false;
            this.lsvNonAmi.Name = "lsvNonAmi";
            this.lsvNonAmi.Size = new System.Drawing.Size(396, 137);
            this.lsvNonAmi.TabIndex = 4;
            this.lsvNonAmi.TileSize = new System.Drawing.Size(128, 128);
            this.lsvNonAmi.UseCompatibleStateImageBehavior = false;
            this.lsvNonAmi.DoubleClick += new System.EventHandler(this.lsvNonAmis_DoubleClick);
            // 
            // lblNonAmis
            // 
            this.lblNonAmis.AutoSize = true;
            this.lblNonAmis.Location = new System.Drawing.Point(920, 518);
            this.lblNonAmis.Name = "lblNonAmis";
            this.lblNonAmis.Size = new System.Drawing.Size(91, 13);
            this.lblNonAmis.TabIndex = 5;
            this.lblNonAmis.Text = "Non Amis/Amies :";
            // 
            // picMembreCourant
            // 
            this.picMembreCourant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMembreCourant.Location = new System.Drawing.Point(20, 14);
            this.picMembreCourant.Name = "picMembreCourant";
            this.picMembreCourant.Size = new System.Drawing.Size(218, 319);
            this.picMembreCourant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picMembreCourant.TabIndex = 9;
            this.picMembreCourant.TabStop = false;
            // 
            // cboMembres
            // 
            this.cboMembres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMembres.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMembres.FormattingEnabled = true;
            this.cboMembres.Location = new System.Drawing.Point(12, 35);
            this.cboMembres.Name = "cboMembres";
            this.cboMembres.Size = new System.Drawing.Size(288, 33);
            this.cboMembres.TabIndex = 10;
            this.cboMembres.SelectedIndexChanged += new System.EventHandler(this.cboMembres_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(12, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 389);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.lblAge);
            this.panel3.Controls.Add(this.picMembreCourant);
            this.panel3.Location = new System.Drawing.Point(14, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(260, 353);
            this.panel3.TabIndex = 0;
            // 
            // lblAge
            // 
            this.lblAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(215, 319);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(45, 34);
            this.lblAge.TabIndex = 13;
            this.lblAge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSupprimerAmi
            // 
            this.btnSupprimerAmi.Enabled = false;
            this.btnSupprimerAmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerAmi.Location = new System.Drawing.Point(1038, 27);
            this.btnSupprimerAmi.Name = "btnSupprimerAmi";
            this.btnSupprimerAmi.Size = new System.Drawing.Size(278, 29);
            this.btnSupprimerAmi.TabIndex = 12;
            this.btnSupprimerAmi.Text = "Supprimer un ami";
            this.btnSupprimerAmi.UseVisualStyleBackColor = true;
            this.btnSupprimerAmi.Click += new System.EventHandler(this.btnSupprimerAmi_Click);
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichier,
            this.mnuSpécial,
            this.mnuQuestionAmis,
            this.mnuQuestions});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(1331, 24);
            this.mnuPrincipal.TabIndex = 13;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // mnuFichier
            // 
            this.mnuFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichierQuitter});
            this.mnuFichier.Name = "mnuFichier";
            this.mnuFichier.Size = new System.Drawing.Size(54, 20);
            this.mnuFichier.Tag = "H17PCSDLS";
            this.mnuFichier.Text = "&Fichier";
            // 
            // mnuFichierQuitter
            // 
            this.mnuFichierQuitter.Name = "mnuFichierQuitter";
            this.mnuFichierQuitter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mnuFichierQuitter.Size = new System.Drawing.Size(154, 22);
            this.mnuFichierQuitter.Text = "&Quitter";
            this.mnuFichierQuitter.Click += new System.EventHandler(this.mnuFichierQuitter_Click);
            // 
            // mnuSpécial
            // 
            this.mnuSpécial.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSpécialGestionGroupes,
            this.mnuSpécialGestionPublications});
            this.mnuSpécial.Name = "mnuSpécial";
            this.mnuSpécial.Size = new System.Drawing.Size(56, 20);
            this.mnuSpécial.Text = "&Spécial";
            // 
            // mnuSpécialGestionGroupes
            // 
            this.mnuSpécialGestionGroupes.Name = "mnuSpécialGestionGroupes";
            this.mnuSpécialGestionGroupes.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.G)));
            this.mnuSpécialGestionGroupes.Size = new System.Drawing.Size(249, 22);
            this.mnuSpécialGestionGroupes.Text = "Gestion des groupes...";
            this.mnuSpécialGestionGroupes.Click += new System.EventHandler(this.mnuSpécialGestionGroupes_Click);
            // 
            // mnuSpécialGestionPublications
            // 
            this.mnuSpécialGestionPublications.Name = "mnuSpécialGestionPublications";
            this.mnuSpécialGestionPublications.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.mnuSpécialGestionPublications.Size = new System.Drawing.Size(249, 22);
            this.mnuSpécialGestionPublications.Text = "Gestion des publications...";
            this.mnuSpécialGestionPublications.Click += new System.EventHandler(this.mnuSpécialGestionPublications_Click);
            // 
            // mnuQuestionAmis
            // 
            this.mnuQuestionAmis.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQuestions1,
            this.mnuQuestions2,
            this.mnuQuestions3,
            this.mnuQuestions4,
            this.mnuQuestions5});
            this.mnuQuestionAmis.Name = "mnuQuestionAmis";
            this.mnuQuestionAmis.Size = new System.Drawing.Size(160, 20);
            this.mnuQuestionAmis.Text = "&Questions Membre/Amitié";
            // 
            // mnuQuestions1
            // 
            this.mnuQuestions1.Name = "mnuQuestions1";
            this.mnuQuestions1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F1)));
            this.mnuQuestions1.Size = new System.Drawing.Size(660, 22);
            this.mnuQuestions1.Text = "Q1) Afficher le nombre d\'amies/amis du MembreCourant";
            this.mnuQuestions1.Click += new System.EventHandler(this.mnuQuestions1_Click);
            // 
            // mnuQuestions2
            // 
            this.mnuQuestions2.Name = "mnuQuestions2";
            this.mnuQuestions2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F2)));
            this.mnuQuestions2.Size = new System.Drawing.Size(660, 22);
            this.mnuQuestions2.Text = "Q2) Afficher le nombre de membres du même genre et né le même mois que le MembreC" +
    "ourant";
            this.mnuQuestions2.Click += new System.EventHandler(this.mnuQuestions2_Click);
            // 
            // mnuQuestions3
            // 
            this.mnuQuestions3.Name = "mnuQuestions3";
            this.mnuQuestions3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F3)));
            this.mnuQuestions3.Size = new System.Drawing.Size(660, 22);
            this.mnuQuestions3.Text = "Q3) Afficher le nombre de membres du réseau social nés entre 1980 et 1990 inclusi" +
    "vement.";
            this.mnuQuestions3.Click += new System.EventHandler(this.mnuQuestions3_Click);
            // 
            // mnuQuestions4
            // 
            this.mnuQuestions4.Name = "mnuQuestions4";
            this.mnuQuestions4.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuQuestions4.Size = new System.Drawing.Size(660, 22);
            this.mnuQuestions4.Text = "Q4) Afficher le nom du membre le plus âgé parmi les amis du membre courant";
            this.mnuQuestions4.Click += new System.EventHandler(this.mnuQuestions4_Click);
            // 
            // mnuQuestions5
            // 
            this.mnuQuestions5.Name = "mnuQuestions5";
            this.mnuQuestions5.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F5)));
            this.mnuQuestions5.Size = new System.Drawing.Size(660, 22);
            this.mnuQuestions5.Text = "Q5) Afficher sur différentes lignes le nom de chacun des groupes auquel le Membre" +
    "Courant est abonné";
            this.mnuQuestions5.Click += new System.EventHandler(this.mnuQuestions5_Click);
            // 
            // mnuQuestions
            // 
            this.mnuQuestions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQuestionsQ6,
            this.mnuQuestionsQ7,
            this.mnuQuestionsQ8,
            this.mnuQuestionsQ9});
            this.mnuQuestions.Name = "mnuQuestions";
            this.mnuQuestions.Size = new System.Drawing.Size(140, 20);
            this.mnuQuestions.Text = "&Questions publications";
            // 
            // mnuQuestionsQ6
            // 
            this.mnuQuestionsQ6.Name = "mnuQuestionsQ6";
            this.mnuQuestionsQ6.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F2)));
            this.mnuQuestionsQ6.Size = new System.Drawing.Size(712, 22);
            this.mnuQuestionsQ6.Text = "Q6) Afficher le nombre de publications par le MembreCourant depuis le 1 janvier 2" +
    "016";
            this.mnuQuestionsQ6.Click += new System.EventHandler(this.mnuQuestionsQ6_Click);
            // 
            // mnuQuestionsQ7
            // 
            this.mnuQuestionsQ7.Name = "mnuQuestionsQ7";
            this.mnuQuestionsQ7.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuQuestionsQ7.Size = new System.Drawing.Size(712, 22);
            this.mnuQuestionsQ7.Text = "Q7) Afficher le nombre de publications faites dans le groupe \"Hockey\"";
            this.mnuQuestionsQ7.Click += new System.EventHandler(this.mnuQuestionsQ7_Click);
            // 
            // mnuQuestionsQ8
            // 
            this.mnuQuestionsQ8.Name = "mnuQuestionsQ8";
            this.mnuQuestionsQ8.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F7)));
            this.mnuQuestionsQ8.Size = new System.Drawing.Size(712, 22);
            this.mnuQuestionsQ8.Text = "Q8) Afficher le nombre total de publications faites par le MembreCourant dans les" +
    " groupes auxquels il est abonné";
            this.mnuQuestionsQ8.Click += new System.EventHandler(this.mnuQuestionsQ8_Click);
            // 
            // mnuQuestionsQ9
            // 
            this.mnuQuestionsQ9.Name = "mnuQuestionsQ9";
            this.mnuQuestionsQ9.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F8)));
            this.mnuQuestionsQ9.Size = new System.Drawing.Size(712, 22);
            this.mnuQuestionsQ9.Text = "Q9) Afficher le nombre total de publications faites par les amis du MembreCourant" +
    "";
            this.mnuQuestionsQ9.Click += new System.EventHandler(this.mnuQuestionsQ9_Click);
            // 
            // clbGroupes
            // 
            this.clbGroupes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbGroupes.FormattingEnabled = true;
            this.clbGroupes.Location = new System.Drawing.Point(12, 489);
            this.clbGroupes.Name = "clbGroupes";
            this.clbGroupes.Size = new System.Drawing.Size(288, 148);
            this.clbGroupes.TabIndex = 14;
            this.clbGroupes.SelectedIndexChanged += new System.EventHandler(this.clbGroupes_SelectedIndexChanged);
            this.clbGroupes.DoubleClick += new System.EventHandler(this.clbGroupes_SelectedIndexChanged);
            // 
            // lblGroupes
            // 
            this.lblGroupes.AutoSize = true;
            this.lblGroupes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupes.Location = new System.Drawing.Point(9, 473);
            this.lblGroupes.Name = "lblGroupes";
            this.lblGroupes.Size = new System.Drawing.Size(62, 13);
            this.lblGroupes.TabIndex = 15;
            this.lblGroupes.Text = "Groupes :";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.lblFilActualité);
            this.panel4.Controls.Add(this.lsvPublications);
            this.panel4.Controls.Add(this.lblTextePublication);
            this.panel4.Controls.Add(this.lblVisibilité);
            this.panel4.Controls.Add(this.cboVisibilité);
            this.panel4.Controls.Add(this.btnPublier);
            this.panel4.Controls.Add(this.txtPublication);
            this.panel4.Controls.Add(this.lblGroupes);
            this.panel4.Controls.Add(this.clbGroupes);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.cboMembres);
            this.panel4.Controls.Add(this.lblMembres);
            this.panel4.Location = new System.Drawing.Point(7, 26);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(887, 651);
            this.panel4.TabIndex = 16;
            // 
            // lblFilActualité
            // 
            this.lblFilActualité.AutoSize = true;
            this.lblFilActualité.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilActualité.Location = new System.Drawing.Point(316, 21);
            this.lblFilActualité.Name = "lblFilActualité";
            this.lblFilActualité.Size = new System.Drawing.Size(91, 13);
            this.lblFilActualité.TabIndex = 27;
            this.lblFilActualité.Text = "Fil d\'actualité :";
            // 
            // lsvPublications
            // 
            this.lsvPublications.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader0,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lsvPublications.FullRowSelect = true;
            this.lsvPublications.GridLines = true;
            this.lsvPublications.HideSelection = false;
            this.lsvPublications.Location = new System.Drawing.Point(319, 37);
            this.lsvPublications.MultiSelect = false;
            this.lsvPublications.Name = "lsvPublications";
            this.lsvPublications.Size = new System.Drawing.Size(556, 553);
            this.lsvPublications.TabIndex = 26;
            this.lsvPublications.UseCompatibleStateImageBehavior = false;
            this.lsvPublications.View = System.Windows.Forms.View.Details;
            this.lsvPublications.DoubleClick += new System.EventHandler(this.lsvPublications_DoubleClick);
            // 
            // columnHeader0
            // 
            this.columnHeader0.Text = "Visibilité";
            this.columnHeader0.Width = 110;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Membre source";
            this.columnHeader1.Width = 116;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Date";
            this.columnHeader2.Width = 116;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Texte de la publication";
            this.columnHeader3.Width = 284;
            // 
            // lblTextePublication
            // 
            this.lblTextePublication.AutoSize = true;
            this.lblTextePublication.Location = new System.Drawing.Point(464, 593);
            this.lblTextePublication.Name = "lblTextePublication";
            this.lblTextePublication.Size = new System.Drawing.Size(120, 13);
            this.lblTextePublication.TabIndex = 25;
            this.lblTextePublication.Text = "Texte de la publication :";
            // 
            // lblVisibilité
            // 
            this.lblVisibilité.AutoSize = true;
            this.lblVisibilité.Location = new System.Drawing.Point(316, 593);
            this.lblVisibilité.Name = "lblVisibilité";
            this.lblVisibilité.Size = new System.Drawing.Size(50, 13);
            this.lblVisibilité.TabIndex = 24;
            this.lblVisibilité.Text = "Visibilité :";
            // 
            // cboVisibilité
            // 
            this.cboVisibilité.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVisibilité.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVisibilité.FormattingEnabled = true;
            this.cboVisibilité.Items.AddRange(new object[] {
            "Publique",
            "Amis seulement",
            "Groupe courant"});
            this.cboVisibilité.Location = new System.Drawing.Point(319, 609);
            this.cboVisibilité.Name = "cboVisibilité";
            this.cboVisibilité.Size = new System.Drawing.Size(142, 28);
            this.cboVisibilité.TabIndex = 23;
            this.cboVisibilité.SelectedIndexChanged += new System.EventHandler(this.cboPublicCible_SelectedIndexChanged);
            // 
            // btnPublier
            // 
            this.btnPublier.Enabled = false;
            this.btnPublier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPublier.Location = new System.Drawing.Point(800, 611);
            this.btnPublier.Name = "btnPublier";
            this.btnPublier.Size = new System.Drawing.Size(75, 26);
            this.btnPublier.TabIndex = 22;
            this.btnPublier.Text = "Publier";
            this.btnPublier.UseVisualStyleBackColor = true;
            this.btnPublier.Click += new System.EventHandler(this.btnPublier_Click);
            // 
            // txtPublication
            // 
            this.txtPublication.Enabled = false;
            this.txtPublication.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublication.Location = new System.Drawing.Point(467, 611);
            this.txtPublication.Name = "txtPublication";
            this.txtPublication.Size = new System.Drawing.Size(327, 26);
            this.txtPublication.TabIndex = 21;
            // 
            // lblSuggestionAmis
            // 
            this.lblSuggestionAmis.AutoSize = true;
            this.lblSuggestionAmis.Location = new System.Drawing.Point(920, 357);
            this.lblSuggestionAmis.Name = "lblSuggestionAmis";
            this.lblSuggestionAmis.Size = new System.Drawing.Size(124, 13);
            this.lblSuggestionAmis.TabIndex = 19;
            this.lblSuggestionAmis.Text = "Suggestion Amis/Amies :";
            // 
            // lsvSuggestionAmis
            // 
            this.lsvSuggestionAmis.FullRowSelect = true;
            this.lsvSuggestionAmis.HideSelection = false;
            this.lsvSuggestionAmis.Location = new System.Drawing.Point(923, 373);
            this.lsvSuggestionAmis.Name = "lsvSuggestionAmis";
            this.lsvSuggestionAmis.Size = new System.Drawing.Size(396, 137);
            this.lsvSuggestionAmis.TabIndex = 18;
            this.lsvSuggestionAmis.TileSize = new System.Drawing.Size(128, 128);
            this.lsvSuggestionAmis.UseCompatibleStateImageBehavior = false;
            this.lsvSuggestionAmis.DoubleClick += new System.EventHandler(this.lsvSuggestionAmis_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(904, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 652);
            this.panel1.TabIndex = 8;
            // 
            // FrmPrincipal
            // 
            this.AcceptButton = this.btnPublier;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 682);
            this.Controls.Add(this.lblSuggestionAmis);
            this.Controls.Add(this.lsvSuggestionAmis);
            this.Controls.Add(this.btnSupprimerAmi);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.mnuPrincipal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblAmis);
            this.Controls.Add(this.lblNonAmis);
            this.Controls.Add(this.lsvNonAmi);
            this.Controls.Add(this.lsvAmis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[Formatif Final] Réseau social complet ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picMembreCourant)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lsvAmis;
        private System.Windows.Forms.Label lblMembres;
        private System.Windows.Forms.Label lblAmis;
        private System.Windows.Forms.ListView lsvNonAmi;
        private System.Windows.Forms.Label lblNonAmis;
        private System.Windows.Forms.PictureBox picMembreCourant;
        private System.Windows.Forms.ComboBox cboMembres;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSupprimerAmi;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuFichier;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierQuitter;
        private System.Windows.Forms.ToolStripMenuItem mnuSpécial;
        private System.Windows.Forms.ToolStripMenuItem mnuSpécialGestionGroupes;
        private System.Windows.Forms.CheckedListBox clbGroupes;
        private System.Windows.Forms.Label lblGroupes;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ToolStripMenuItem mnuQuestions;
        private System.Windows.Forms.ToolStripMenuItem mnuQuestionsQ6;
        private System.Windows.Forms.ToolStripMenuItem mnuQuestionsQ7;
        private System.Windows.Forms.ToolStripMenuItem mnuQuestionsQ8;
        private System.Windows.Forms.ToolStripMenuItem mnuQuestionsQ9;
        private System.Windows.Forms.Label lblSuggestionAmis;
        private System.Windows.Forms.ListView lsvSuggestionAmis;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboVisibilité;
        private System.Windows.Forms.Button btnPublier;
        private System.Windows.Forms.TextBox txtPublication;
        private System.Windows.Forms.ToolStripMenuItem mnuSpécialGestionPublications;
        private System.Windows.Forms.Label lblTextePublication;
        private System.Windows.Forms.Label lblVisibilité;
        private System.Windows.Forms.ListView lsvPublications;
        private System.Windows.Forms.ColumnHeader columnHeader0;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label lblFilActualité;
        private System.Windows.Forms.ToolStripMenuItem mnuQuestionAmis;
        private System.Windows.Forms.ToolStripMenuItem mnuQuestions1;
        private System.Windows.Forms.ToolStripMenuItem mnuQuestions2;
        private System.Windows.Forms.ToolStripMenuItem mnuQuestions3;
        private System.Windows.Forms.ToolStripMenuItem mnuQuestions4;
        private System.Windows.Forms.ToolStripMenuItem mnuQuestions5;
    }
}

