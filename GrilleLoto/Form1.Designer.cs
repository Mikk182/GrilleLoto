namespace GrilleLoto
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.TB_Saisie = new System.Windows.Forms.TextBox();
            this.B_Ajout = new System.Windows.Forms.Button();
            this.B_Efface = new System.Windows.Forms.Button();
            this.b_gestion = new System.Windows.Forms.Button();
            this.nbEntries = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saisir un numéro :";
            // 
            // TB_Saisie
            // 
            this.TB_Saisie.Location = new System.Drawing.Point(111, 7);
            this.TB_Saisie.Name = "TB_Saisie";
            this.TB_Saisie.Size = new System.Drawing.Size(100, 20);
            this.TB_Saisie.TabIndex = 1;
            this.TB_Saisie.TextChanged += new System.EventHandler(this.TB_Saisie_TextChanged);
            this.TB_Saisie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Saisie_KeyPress);
            // 
            // B_Ajout
            // 
            this.B_Ajout.Location = new System.Drawing.Point(218, 5);
            this.B_Ajout.Name = "B_Ajout";
            this.B_Ajout.Size = new System.Drawing.Size(75, 23);
            this.B_Ajout.TabIndex = 2;
            this.B_Ajout.Text = "Ajouter";
            this.B_Ajout.UseVisualStyleBackColor = true;
            this.B_Ajout.Click += new System.EventHandler(this.B_Ajout_Click);
            // 
            // B_Efface
            // 
            this.B_Efface.Location = new System.Drawing.Point(306, 5);
            this.B_Efface.Name = "B_Efface";
            this.B_Efface.Size = new System.Drawing.Size(75, 23);
            this.B_Efface.TabIndex = 3;
            this.B_Efface.Text = "Tout Effacer";
            this.B_Efface.UseVisualStyleBackColor = true;
            this.B_Efface.Click += new System.EventHandler(this.B_Efface_Click);
            // 
            // b_gestion
            // 
            this.b_gestion.Location = new System.Drawing.Point(872, 4);
            this.b_gestion.Name = "b_gestion";
            this.b_gestion.Size = new System.Drawing.Size(75, 23);
            this.b_gestion.TabIndex = 14;
            this.b_gestion.Text = "Gestion";
            this.b_gestion.UseVisualStyleBackColor = true;
            this.b_gestion.Click += new System.EventHandler(this.b_gestion_Click);
            // 
            // nbEntries
            // 
            this.nbEntries.AutoSize = true;
            this.nbEntries.Location = new System.Drawing.Point(573, 14);
            this.nbEntries.Name = "nbEntries";
            this.nbEntries.Size = new System.Drawing.Size(35, 13);
            this.nbEntries.TabIndex = 15;
            this.nbEntries.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 565);
            this.Controls.Add(this.nbEntries);
            this.Controls.Add(this.b_gestion);
            this.Controls.Add(this.B_Efface);
            this.Controls.Add(this.B_Ajout);
            this.Controls.Add(this.TB_Saisie);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_Saisie;
        private System.Windows.Forms.Button B_Ajout;
        private System.Windows.Forms.Button B_Efface;
        private System.Windows.Forms.Button b_gestion;
        private System.Windows.Forms.Label nbEntries;
    }
}

