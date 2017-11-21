namespace Projet_SQL_et_POO
{
    partial class Formulaire
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
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._ProjetC_DataSet = new Projet_SQL_et_POO._ProjetC_DataSet();
            this.Valider = new System.Windows.Forms.Button();
            this.Annuler = new System.Windows.Forms.Button();
            this.textBoxAdresseL1 = new System.Windows.Forms.TextBox();
            this.textBoxAdresseL2 = new System.Windows.Forms.TextBox();
            this.textBoxCP = new System.Windows.Forms.TextBox();
            this.Adresse_l1 = new System.Windows.Forms.Label();
            this.Adresse_l2 = new System.Windows.Forms.Label();
            this.Code_Postal = new System.Windows.Forms.Label();
            this.Ville = new System.Windows.Forms.Label();
            this.textBoxVille = new System.Windows.Forms.TextBox();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.Date_De_Naissance = new System.Windows.Forms.Label();
            this.Telephone = new System.Windows.Forms.Label();
            this.dateTimePickerDDN = new System.Windows.Forms.DateTimePicker();
            this.serviceTableAdapter = new Projet_SQL_et_POO._ProjetC_DataSetTableAdapters.ServiceTableAdapter();
            this.LblTitreAjout = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ProjetC_DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNom
            // 
            this.textBoxNom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxNom.Location = new System.Drawing.Point(194, 104);
            this.textBoxNom.Multiline = true;
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(219, 26);
            this.textBoxNom.TabIndex = 0;
            this.textBoxNom.TextChanged += new System.EventHandler(this.textBoxNom_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prénom";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxPrenom.Location = new System.Drawing.Point(194, 156);
            this.textBoxPrenom.Multiline = true;
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(219, 26);
            this.textBoxPrenom.TabIndex = 3;
            this.textBoxPrenom.TextChanged += new System.EventHandler(this.textBoxPrenom_TextChanged);
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataMember = "Service";
            this.serviceBindingSource.DataSource = this._ProjetC_DataSet;
            // 
            // _ProjetC_DataSet
            // 
            this._ProjetC_DataSet.DataSetName = "_ProjetC_DataSet";
            this._ProjetC_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Valider
            // 
            this.Valider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(236)))), ((int)(((byte)(149)))));
            this.Valider.ForeColor = System.Drawing.Color.Black;
            this.Valider.Location = new System.Drawing.Point(423, 445);
            this.Valider.Name = "Valider";
            this.Valider.Size = new System.Drawing.Size(190, 46);
            this.Valider.TabIndex = 5;
            this.Valider.Text = "Valider";
            this.Valider.UseVisualStyleBackColor = false;
            this.Valider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // Annuler
            // 
            this.Annuler.BackColor = System.Drawing.Color.Tomato;
            this.Annuler.ForeColor = System.Drawing.Color.Black;
            this.Annuler.Location = new System.Drawing.Point(308, 445);
            this.Annuler.Name = "Annuler";
            this.Annuler.Size = new System.Drawing.Size(92, 46);
            this.Annuler.TabIndex = 6;
            this.Annuler.Text = "Annuler";
            this.Annuler.UseVisualStyleBackColor = false;
            this.Annuler.Click += new System.EventHandler(this.Annuler_Click);
            // 
            // textBoxAdresseL1
            // 
            this.textBoxAdresseL1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxAdresseL1.Location = new System.Drawing.Point(194, 202);
            this.textBoxAdresseL1.Multiline = true;
            this.textBoxAdresseL1.Name = "textBoxAdresseL1";
            this.textBoxAdresseL1.Size = new System.Drawing.Size(219, 26);
            this.textBoxAdresseL1.TabIndex = 7;
            this.textBoxAdresseL1.TextChanged += new System.EventHandler(this.textBoxAdresseL1_TextChanged);
            // 
            // textBoxAdresseL2
            // 
            this.textBoxAdresseL2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxAdresseL2.Location = new System.Drawing.Point(194, 247);
            this.textBoxAdresseL2.Multiline = true;
            this.textBoxAdresseL2.Name = "textBoxAdresseL2";
            this.textBoxAdresseL2.Size = new System.Drawing.Size(219, 26);
            this.textBoxAdresseL2.TabIndex = 8;
            this.textBoxAdresseL2.TextChanged += new System.EventHandler(this.textBoxAdresseL2_TextChanged);
            // 
            // textBoxCP
            // 
            this.textBoxCP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxCP.Location = new System.Drawing.Point(194, 295);
            this.textBoxCP.Multiline = true;
            this.textBoxCP.Name = "textBoxCP";
            this.textBoxCP.Size = new System.Drawing.Size(219, 26);
            this.textBoxCP.TabIndex = 9;
            this.textBoxCP.TextChanged += new System.EventHandler(this.textBoxCP_TextChanged);
            // 
            // Adresse_l1
            // 
            this.Adresse_l1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adresse_l1.Location = new System.Drawing.Point(76, 193);
            this.Adresse_l1.Name = "Adresse_l1";
            this.Adresse_l1.Size = new System.Drawing.Size(95, 38);
            this.Adresse_l1.TabIndex = 10;
            this.Adresse_l1.Text = "Adresse l1";
            this.Adresse_l1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Adresse_l2
            // 
            this.Adresse_l2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adresse_l2.Location = new System.Drawing.Point(80, 238);
            this.Adresse_l2.Name = "Adresse_l2";
            this.Adresse_l2.Size = new System.Drawing.Size(91, 38);
            this.Adresse_l2.TabIndex = 11;
            this.Adresse_l2.Text = "Adresse l2";
            this.Adresse_l2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Code_Postal
            // 
            this.Code_Postal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Code_Postal.Location = new System.Drawing.Point(68, 286);
            this.Code_Postal.Name = "Code_Postal";
            this.Code_Postal.Size = new System.Drawing.Size(103, 38);
            this.Code_Postal.TabIndex = 12;
            this.Code_Postal.Text = "Code Postal";
            this.Code_Postal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ville
            // 
            this.Ville.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ville.Location = new System.Drawing.Point(101, 337);
            this.Ville.Name = "Ville";
            this.Ville.Size = new System.Drawing.Size(70, 38);
            this.Ville.TabIndex = 13;
            this.Ville.Text = "Ville";
            this.Ville.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxVille
            // 
            this.textBoxVille.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxVille.Location = new System.Drawing.Point(194, 346);
            this.textBoxVille.Multiline = true;
            this.textBoxVille.Name = "textBoxVille";
            this.textBoxVille.Size = new System.Drawing.Size(219, 26);
            this.textBoxVille.TabIndex = 14;
            this.textBoxVille.TextChanged += new System.EventHandler(this.textBoxVille_TextChanged);
            // 
            // textBoxTel
            // 
            this.textBoxTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxTel.Location = new System.Drawing.Point(587, 159);
            this.textBoxTel.Multiline = true;
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(260, 26);
            this.textBoxTel.TabIndex = 17;
            this.textBoxTel.TextChanged += new System.EventHandler(this.textBoxTel_TextChanged);
            // 
            // Date_De_Naissance
            // 
            this.Date_De_Naissance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_De_Naissance.Location = new System.Drawing.Point(431, 98);
            this.Date_De_Naissance.Name = "Date_De_Naissance";
            this.Date_De_Naissance.Size = new System.Drawing.Size(150, 38);
            this.Date_De_Naissance.TabIndex = 18;
            this.Date_De_Naissance.Text = "Date de naissance";
            this.Date_De_Naissance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Date_De_Naissance.Click += new System.EventHandler(this.label7_Click);
            // 
            // Telephone
            // 
            this.Telephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telephone.Location = new System.Drawing.Point(450, 150);
            this.Telephone.Name = "Telephone";
            this.Telephone.Size = new System.Drawing.Size(102, 38);
            this.Telephone.TabIndex = 19;
            this.Telephone.Text = "Téléphone";
            this.Telephone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePickerDDN
            // 
            this.dateTimePickerDDN.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(236)))), ((int)(((byte)(149)))));
            this.dateTimePickerDDN.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(236)))), ((int)(((byte)(149)))));
            this.dateTimePickerDDN.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(236)))), ((int)(((byte)(149)))));
            this.dateTimePickerDDN.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(236)))), ((int)(((byte)(149)))));
            this.dateTimePickerDDN.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(236)))), ((int)(((byte)(149)))));
            this.dateTimePickerDDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDDN.Location = new System.Drawing.Point(587, 108);
            this.dateTimePickerDDN.Name = "dateTimePickerDDN";
            this.dateTimePickerDDN.Size = new System.Drawing.Size(260, 26);
            this.dateTimePickerDDN.TabIndex = 20;
            this.dateTimePickerDDN.ValueChanged += new System.EventHandler(this.dateTimePickerDDN_ValueChanged);
            // 
            // serviceTableAdapter
            // 
            this.serviceTableAdapter.ClearBeforeFill = true;
            // 
            // LblTitreAjout
            // 
            this.LblTitreAjout.AutoSize = true;
            this.LblTitreAjout.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitreAjout.Location = new System.Drawing.Point(395, 37);
            this.LblTitreAjout.Name = "LblTitreAjout";
            this.LblTitreAjout.Size = new System.Drawing.Size(208, 24);
            this.LblTitreAjout.TabIndex = 38;
            this.LblTitreAjout.Text = "Ajout d\'un employé";
            // 
            // Formulaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1060, 503);
            this.Controls.Add(this.LblTitreAjout);
            this.Controls.Add(this.dateTimePickerDDN);
            this.Controls.Add(this.Telephone);
            this.Controls.Add(this.Date_De_Naissance);
            this.Controls.Add(this.textBoxTel);
            this.Controls.Add(this.textBoxVille);
            this.Controls.Add(this.Ville);
            this.Controls.Add(this.Code_Postal);
            this.Controls.Add(this.Adresse_l2);
            this.Controls.Add(this.Adresse_l1);
            this.Controls.Add(this.textBoxCP);
            this.Controls.Add(this.textBoxAdresseL2);
            this.Controls.Add(this.textBoxAdresseL1);
            this.Controls.Add(this.Annuler);
            this.Controls.Add(this.Valider);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNom);
            this.Name = "Formulaire";
            this.Text = "Formulaire";
            this.Load += new System.EventHandler(this.Formulaire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ProjetC_DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.Button Valider;
        private System.Windows.Forms.Button Annuler;
        private System.Windows.Forms.TextBox textBoxAdresseL1;
        private System.Windows.Forms.TextBox textBoxAdresseL2;
        private System.Windows.Forms.TextBox textBoxCP;
        private System.Windows.Forms.Label Adresse_l1;
        private System.Windows.Forms.Label Adresse_l2;
        private System.Windows.Forms.Label Code_Postal;
        private System.Windows.Forms.Label Ville;
        private System.Windows.Forms.TextBox textBoxVille;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.Label Date_De_Naissance;
        private System.Windows.Forms.Label Telephone;
        private System.Windows.Forms.DateTimePicker dateTimePickerDDN;
        private _ProjetC_DataSet _ProjetC_DataSet;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private _ProjetC_DataSetTableAdapters.ServiceTableAdapter serviceTableAdapter;
        private System.Windows.Forms.Label LblTitreAjout;
    }
}