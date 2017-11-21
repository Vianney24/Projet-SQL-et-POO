namespace Projet_SQL_et_POO
{
    partial class Modifier
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
			this.Nouveau_service = new System.Windows.Forms.ListBox();
			this.Valider = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Nouveau_service
			// 
			this.Nouveau_service.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(236)))), ((int)(((byte)(149)))));
			this.Nouveau_service.FormattingEnabled = true;
			this.Nouveau_service.ItemHeight = 16;
			this.Nouveau_service.Location = new System.Drawing.Point(384, 36);
			this.Nouveau_service.Name = "Nouveau_service";
			this.Nouveau_service.Size = new System.Drawing.Size(217, 324);
			this.Nouveau_service.TabIndex = 0;
			this.Nouveau_service.SelectedIndexChanged += new System.EventHandler(this.Nouveau_service_SelectedIndexChanged);
			// 
			// Valider
			// 
			this.Valider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(236)))), ((int)(((byte)(149)))));
			this.Valider.ForeColor = System.Drawing.Color.Black;
			this.Valider.Location = new System.Drawing.Point(397, 394);
			this.Valider.Name = "Valider";
			this.Valider.Size = new System.Drawing.Size(190, 46);
			this.Valider.TabIndex = 6;
			this.Valider.Text = "Valider";
			this.Valider.UseVisualStyleBackColor = false;
			this.Valider.Click += new System.EventHandler(this.Valider_Click);
			// 
			// Modifier
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(145)))), ((int)(((byte)(26)))));
			this.ClientSize = new System.Drawing.Size(988, 452);
			this.Controls.Add(this.Valider);
			this.Controls.Add(this.Nouveau_service);
			this.Name = "Modifier";
			this.Text = "Modifier";
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Nouveau_service;
        private System.Windows.Forms.Button Valider;
    }
}