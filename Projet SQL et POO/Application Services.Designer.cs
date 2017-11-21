namespace Projet_SQL_et_POO
{
    partial class Application_Services
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
            this.components = new System.ComponentModel.Container();
            this.Ajouter = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.Quitter = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.IDEmploye = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomEmploye = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrenomEmploye = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateNaissanceEmploye = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdresseL1Employe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdresseL2Employe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPEmploye = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VilleEmploye = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelephoneEmploye = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._ProjetC_DataSet = new Projet_SQL_et_POO._ProjetC_DataSet();
            this.Diplomes = new System.Windows.Forms.Button();
            this.Services = new System.Windows.Forms.Button();
            this.contratTableAdapter1 = new Projet_SQL_et_POO._ProjetC_DataSetTableAdapters.ContratTableAdapter();
            this.projetCDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeTableAdapter = new Projet_SQL_et_POO._ProjetC_DataSetTableAdapters.EmployeTableAdapter();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceTableAdapter = new Projet_SQL_et_POO._ProjetC_DataSetTableAdapters.ServiceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ProjetC_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetCDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Ajouter
            // 
            this.Ajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.Ajouter.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Ajouter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Ajouter.FlatAppearance.BorderSize = 2;
            this.Ajouter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ajouter.ForeColor = System.Drawing.Color.Black;
            this.Ajouter.Location = new System.Drawing.Point(12, 21);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(197, 34);
            this.Ajouter.TabIndex = 0;
            this.Ajouter.Text = "Ajouter une personne";
            this.Ajouter.UseVisualStyleBackColor = false;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Personne_Click);
            // 
            // Modifier
            // 
            this.Modifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.Modifier.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Modifier.FlatAppearance.BorderSize = 2;
            this.Modifier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Modifier.Location = new System.Drawing.Point(12, 61);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(197, 34);
            this.Modifier.TabIndex = 1;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = false;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // Quitter
            // 
            this.Quitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.Quitter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Quitter.FlatAppearance.BorderSize = 2;
            this.Quitter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Quitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Quitter.Location = new System.Drawing.Point(12, 209);
            this.Quitter.Name = "Quitter";
            this.Quitter.Size = new System.Drawing.Size(197, 34);
            this.Quitter.TabIndex = 2;
            this.Quitter.Text = "Quitter l\'application";
            this.Quitter.UseVisualStyleBackColor = false;
            this.Quitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDEmploye,
            this.NomEmploye,
            this.PrenomEmploye,
            this.DateNaissanceEmploye,
            this.AdresseL1Employe,
            this.AdresseL2Employe,
            this.CPEmploye,
            this.VilleEmploye,
            this.TelephoneEmploye});
            this.dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(61)))), ((int)(((byte)(0)))));
            this.dataGridView.Location = new System.Drawing.Point(227, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1243, 720);
            this.dataGridView.TabIndex = 3;
            // 
            // IDEmploye
            // 
            this.IDEmploye.HeaderText = "ID";
            this.IDEmploye.Name = "IDEmploye";
            this.IDEmploye.ReadOnly = true;
            // 
            // NomEmploye
            // 
            this.NomEmploye.HeaderText = "Nom";
            this.NomEmploye.Name = "NomEmploye";
            this.NomEmploye.ReadOnly = true;
            // 
            // PrenomEmploye
            // 
            this.PrenomEmploye.HeaderText = "Prénom";
            this.PrenomEmploye.Name = "PrenomEmploye";
            this.PrenomEmploye.ReadOnly = true;
            // 
            // DateNaissanceEmploye
            // 
            this.DateNaissanceEmploye.HeaderText = "Date de Naissance";
            this.DateNaissanceEmploye.Name = "DateNaissanceEmploye";
            this.DateNaissanceEmploye.ReadOnly = true;
            // 
            // AdresseL1Employe
            // 
            this.AdresseL1Employe.HeaderText = "Adresse";
            this.AdresseL1Employe.Name = "AdresseL1Employe";
            this.AdresseL1Employe.ReadOnly = true;
            // 
            // AdresseL2Employe
            // 
            this.AdresseL2Employe.HeaderText = "Complément d\'adresse";
            this.AdresseL2Employe.Name = "AdresseL2Employe";
            this.AdresseL2Employe.ReadOnly = true;
            // 
            // CPEmploye
            // 
            this.CPEmploye.HeaderText = "Code Postal";
            this.CPEmploye.Name = "CPEmploye";
            this.CPEmploye.ReadOnly = true;
            // 
            // VilleEmploye
            // 
            this.VilleEmploye.HeaderText = "Ville";
            this.VilleEmploye.Name = "VilleEmploye";
            this.VilleEmploye.ReadOnly = true;
            // 
            // TelephoneEmploye
            // 
            this.TelephoneEmploye.HeaderText = "Téléphone";
            this.TelephoneEmploye.Name = "TelephoneEmploye";
            this.TelephoneEmploye.ReadOnly = true;
            // 
            // employeBindingSource
            // 
            this.employeBindingSource.DataMember = "Employe";
            this.employeBindingSource.DataSource = this._ProjetC_DataSet;
            // 
            // _ProjetC_DataSet
            // 
            this._ProjetC_DataSet.DataSetName = "_ProjetC_DataSet";
            this._ProjetC_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Diplomes
            // 
            this.Diplomes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.Diplomes.Location = new System.Drawing.Point(12, 101);
            this.Diplomes.Name = "Diplomes";
            this.Diplomes.Size = new System.Drawing.Size(197, 34);
            this.Diplomes.TabIndex = 4;
            this.Diplomes.Text = "Diplomes";
            this.Diplomes.UseVisualStyleBackColor = false;
            this.Diplomes.Click += new System.EventHandler(this.Diplomes_Click_1);
            // 
            // Services
            // 
            this.Services.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.Services.Location = new System.Drawing.Point(12, 141);
            this.Services.Name = "Services";
            this.Services.Size = new System.Drawing.Size(197, 34);
            this.Services.TabIndex = 5;
            this.Services.Text = "Services";
            this.Services.UseVisualStyleBackColor = false;
            this.Services.Click += new System.EventHandler(this.Services_Click);
            // 
            // contratTableAdapter1
            // 
            this.contratTableAdapter1.ClearBeforeFill = true;
            // 
            // projetCDataSetBindingSource
            // 
            this.projetCDataSetBindingSource.DataSource = this._ProjetC_DataSet;
            this.projetCDataSetBindingSource.Position = 0;
            // 
            // employeTableAdapter
            // 
            this.employeTableAdapter.ClearBeforeFill = true;
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataMember = "Service";
            this.serviceBindingSource.DataSource = this._ProjetC_DataSet;
            // 
            // serviceTableAdapter
            // 
            this.serviceTableAdapter.ClearBeforeFill = true;
            // 
            // Application_Services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(138)))), ((int)(((byte)(168)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.Services);
            this.Controls.Add(this.Diplomes);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.Quitter);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.Ajouter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Application_Services";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application_Services";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Application_Services_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ProjetC_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetCDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Button Quitter;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.Button Diplomes;
		private System.Windows.Forms.Button Services;
        private _ProjetC_DataSetTableAdapters.ContratTableAdapter contratTableAdapter1;
        private _ProjetC_DataSet _ProjetC_DataSet;
        private System.Windows.Forms.BindingSource projetCDataSetBindingSource;
        private System.Windows.Forms.BindingSource employeBindingSource;
        private _ProjetC_DataSetTableAdapters.EmployeTableAdapter employeTableAdapter;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private _ProjetC_DataSetTableAdapters.ServiceTableAdapter serviceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDEmploye;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomEmploye;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrenomEmploye;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateNaissanceEmploye;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdresseL1Employe;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdresseL2Employe;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPEmploye;
        private System.Windows.Forms.DataGridViewTextBoxColumn VilleEmploye;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelephoneEmploye;
	}
}

