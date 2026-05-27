namespace AppReseauSocial
{
    partial class FrmListeDesPublications
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.lsvPublications = new System.Windows.Forms.ListView();
            this.columnHeader0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cboMembre = new System.Windows.Forms.ComboBox();
            this.lblMembre = new System.Windows.Forms.Label();
            this.lblVisibilité = new System.Windows.Forms.Label();
            this.cboVisibilité = new System.Windows.Forms.ComboBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblNbPublications = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Publications :";
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
            this.lsvPublications.Location = new System.Drawing.Point(12, 77);
            this.lsvPublications.MultiSelect = false;
            this.lsvPublications.Name = "lsvPublications";
            this.lsvPublications.Size = new System.Drawing.Size(765, 553);
            this.lsvPublications.TabIndex = 19;
            this.lsvPublications.UseCompatibleStateImageBehavior = false;
            this.lsvPublications.View = System.Windows.Forms.View.Details;
            this.lsvPublications.DoubleClick += new System.EventHandler(this.lsvPublications_DoubleClick);
            // 
            // columnHeader0
            // 
            this.columnHeader0.Text = "Visibilité";
            this.columnHeader0.Width = 190;
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
            // cboMembre
            // 
            this.cboMembre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMembre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMembre.FormattingEnabled = true;
            this.cboMembre.Location = new System.Drawing.Point(420, 12);
            this.cboMembre.Name = "cboMembre";
            this.cboMembre.Size = new System.Drawing.Size(184, 28);
            this.cboMembre.TabIndex = 21;
            this.cboMembre.SelectedIndexChanged += new System.EventHandler(this.cboFiltres_SelectedIndexChanged);
            // 
            // lblMembre
            // 
            this.lblMembre.AutoSize = true;
            this.lblMembre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembre.Location = new System.Drawing.Point(290, 16);
            this.lblMembre.Name = "lblMembre";
            this.lblMembre.Size = new System.Drawing.Size(127, 20);
            this.lblMembre.TabIndex = 22;
            this.lblMembre.Text = "Membre source :";
            // 
            // lblVisibilité
            // 
            this.lblVisibilité.AutoSize = true;
            this.lblVisibilité.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisibilité.Location = new System.Drawing.Point(14, 16);
            this.lblVisibilité.Name = "lblVisibilité";
            this.lblVisibilité.Size = new System.Drawing.Size(74, 20);
            this.lblVisibilité.TabIndex = 23;
            this.lblVisibilité.Text = "Visibilité :";
            // 
            // cboVisibilité
            // 
            this.cboVisibilité.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVisibilité.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVisibilité.FormattingEnabled = true;
            this.cboVisibilité.Location = new System.Drawing.Point(91, 12);
            this.cboVisibilité.Name = "cboVisibilité";
            this.cboVisibilité.Size = new System.Drawing.Size(184, 28);
            this.cboVisibilité.TabIndex = 24;
            this.cboVisibilité.SelectedIndexChanged += new System.EventHandler(this.cboFiltres_SelectedIndexChanged);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(649, 53);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(60, 20);
            this.lblCount.TabIndex = 25;
            this.lblCount.Text = "Count :";
            // 
            // lblNbPublications
            // 
            this.lblNbPublications.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNbPublications.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNbPublications.Location = new System.Drawing.Point(715, 53);
            this.lblNbPublications.Name = "lblNbPublications";
            this.lblNbPublications.Size = new System.Drawing.Size(62, 21);
            this.lblNbPublications.TabIndex = 26;
            this.lblNbPublications.Text = "0";
            this.lblNbPublications.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmListeDesPublications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 646);
            this.Controls.Add(this.lblNbPublications);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.cboVisibilité);
            this.Controls.Add(this.lblVisibilité);
            this.Controls.Add(this.lblMembre);
            this.Controls.Add(this.cboMembre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lsvPublications);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmListeDesPublications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListeDesPublications";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lsvPublications;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader0;
        private System.Windows.Forms.ComboBox cboMembre;
        private System.Windows.Forms.Label lblMembre;
        private System.Windows.Forms.Label lblVisibilité;
        private System.Windows.Forms.ComboBox cboVisibilité;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblNbPublications;
    }
}