namespace GrilleLoto
{
    partial class Form3
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
            this.NewJournee = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.JourneeListBox = new System.Windows.Forms.ListBox();
            this.LoadJournee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewJournee
            // 
            this.NewJournee.Location = new System.Drawing.Point(119, 12);
            this.NewJournee.Name = "NewJournee";
            this.NewJournee.Size = new System.Drawing.Size(100, 23);
            this.NewJournee.TabIndex = 0;
            this.NewJournee.Text = "Nouvelle Journée";
            this.NewJournee.UseVisualStyleBackColor = true;
            this.NewJournee.Click += new System.EventHandler(this.NewJournee_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // JourneeListBox
            // 
            this.JourneeListBox.FormattingEnabled = true;
            this.JourneeListBox.Location = new System.Drawing.Point(13, 41);
            this.JourneeListBox.Name = "JourneeListBox";
            this.JourneeListBox.Size = new System.Drawing.Size(100, 95);
            this.JourneeListBox.TabIndex = 2;
            // 
            // LoadJournee
            // 
            this.LoadJournee.Location = new System.Drawing.Point(119, 78);
            this.LoadJournee.Name = "LoadJournee";
            this.LoadJournee.Size = new System.Drawing.Size(75, 23);
            this.LoadJournee.TabIndex = 3;
            this.LoadJournee.Text = "Charger";
            this.LoadJournee.UseVisualStyleBackColor = true;
            this.LoadJournee.Click += new System.EventHandler(this.LoadJournee_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 151);
            this.Controls.Add(this.LoadJournee);
            this.Controls.Add(this.JourneeListBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.NewJournee);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewJournee;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox JourneeListBox;
        private System.Windows.Forms.Button LoadJournee;
    }
}