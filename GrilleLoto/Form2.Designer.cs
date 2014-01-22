namespace GrilleLoto
{
    partial class Form2
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
            this.b_new = new System.Windows.Forms.Button();
            this.b_end = new System.Windows.Forms.Button();
            this.cb_parties = new System.Windows.Forms.ComboBox();
            this.b_load = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_new
            // 
            this.b_new.AccessibleDescription = "((Label)dynCont).ForeColor = Color.White;";
            this.b_new.Location = new System.Drawing.Point(13, 13);
            this.b_new.Name = "b_new";
            this.b_new.Size = new System.Drawing.Size(90, 23);
            this.b_new.TabIndex = 0;
            this.b_new.Text = "Nouvelle partie";
            this.b_new.UseVisualStyleBackColor = true;
            this.b_new.Click += new System.EventHandler(this.b_new_Click);
            // 
            // b_end
            // 
            this.b_end.AccessibleDescription = "((Label)dynCont).ForeColor = Color.White;";
            this.b_end.Location = new System.Drawing.Point(121, 13);
            this.b_end.Name = "b_end";
            this.b_end.Size = new System.Drawing.Size(87, 23);
            this.b_end.TabIndex = 1;
            this.b_end.Text = "Terminer partie";
            this.b_end.UseVisualStyleBackColor = true;
            // 
            // cb_parties
            // 
            this.cb_parties.FormattingEnabled = true;
            this.cb_parties.Location = new System.Drawing.Point(13, 60);
            this.cb_parties.Name = "cb_parties";
            this.cb_parties.Size = new System.Drawing.Size(121, 21);
            this.cb_parties.TabIndex = 2;
            // 
            // b_load
            // 
            this.b_load.AccessibleDescription = "((Label)dynCont).ForeColor = Color.White;";
            this.b_load.Location = new System.Drawing.Point(170, 58);
            this.b_load.Name = "b_load";
            this.b_load.Size = new System.Drawing.Size(87, 23);
            this.b_load.TabIndex = 3;
            this.b_load.Text = "Charger partie";
            this.b_load.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 102);
            this.Controls.Add(this.b_load);
            this.Controls.Add(this.cb_parties);
            this.Controls.Add(this.b_end);
            this.Controls.Add(this.b_new);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_new;
        private System.Windows.Forms.Button b_end;
        private System.Windows.Forms.ComboBox cb_parties;
        private System.Windows.Forms.Button b_load;
    }
}