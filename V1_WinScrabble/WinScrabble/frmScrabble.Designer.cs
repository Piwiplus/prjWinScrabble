namespace WinScrabble
{
    partial class frmScrabble
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScrabble));
            this.label1 = new System.Windows.Forms.Label();
            this.txtMot = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnAutre = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPoints = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.totPoints = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.resClickk = new System.Windows.Forms.Label();
            this.txtBoxMots = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(246, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saisir un mot";
            // 
            // txtMot
            // 
            this.txtMot.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMot.ForeColor = System.Drawing.Color.Black;
            this.txtMot.Location = new System.Drawing.Point(359, 53);
            this.txtMot.Name = "txtMot";
            this.txtMot.Size = new System.Drawing.Size(215, 23);
            this.txtMot.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.CadetBlue;
            this.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.Black;
            this.btnOK.Location = new System.Drawing.Point(469, 131);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(88, 30);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOkClick);
            // 
            // btnAutre
            // 
            this.btnAutre.BackColor = System.Drawing.Color.CadetBlue;
            this.btnAutre.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnAutre.FlatAppearance.BorderSize = 0;
            this.btnAutre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutre.ForeColor = System.Drawing.Color.Black;
            this.btnAutre.Location = new System.Drawing.Point(359, 131);
            this.btnAutre.Name = "btnAutre";
            this.btnAutre.Size = new System.Drawing.Size(87, 30);
            this.btnAutre.TabIndex = 3;
            this.btnAutre.Text = "Autre mot";
            this.btnAutre.UseVisualStyleBackColor = false;
            this.btnAutre.Click += new System.EventHandler(this.btnAutreClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(246, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ce mot rapporte";
            // 
            // txtPoints
            // 
            this.txtPoints.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPoints.ForeColor = System.Drawing.Color.Black;
            this.txtPoints.Location = new System.Drawing.Point(402, 225);
            this.txtPoints.Name = "txtPoints";
            this.txtPoints.ReadOnly = true;
            this.txtPoints.Size = new System.Drawing.Size(93, 23);
            this.txtPoints.TabIndex = 5;
            this.txtPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPoints.TextChanged += new System.EventHandler(this.txtPoints_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(522, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "points";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(246, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cumul des points";
            // 
            // totPoints
            // 
            this.totPoints.BackColor = System.Drawing.Color.WhiteSmoke;
            this.totPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totPoints.ForeColor = System.Drawing.Color.Black;
            this.totPoints.Location = new System.Drawing.Point(402, 270);
            this.totPoints.Name = "totPoints";
            this.totPoints.ReadOnly = true;
            this.totPoints.Size = new System.Drawing.Size(93, 23);
            this.totPoints.TabIndex = 8;
            this.totPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(522, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "points";
            // 
            // resClickk
            // 
            this.resClickk.AutoSize = true;
            this.resClickk.BackColor = System.Drawing.Color.Transparent;
            this.resClickk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resClickk.ForeColor = System.Drawing.Color.Black;
            this.resClickk.Location = new System.Drawing.Point(12, 324);
            this.resClickk.Name = "resClickk";
            this.resClickk.Size = new System.Drawing.Size(157, 13);
            this.resClickk.TabIndex = 12;
            this.resClickk.Text = "Vous avez saisie : aucun Mot(s)";
            this.resClickk.Click += new System.EventHandler(this.resClick);
            // 
            // txtBoxMots
            // 
            this.txtBoxMots.CausesValidation = false;
            this.txtBoxMots.Location = new System.Drawing.Point(42, 53);
            this.txtBoxMots.Multiline = true;
            this.txtBoxMots.Name = "txtBoxMots";
            this.txtBoxMots.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxMots.ShortcutsEnabled = false;
            this.txtBoxMots.Size = new System.Drawing.Size(160, 231);
            this.txtBoxMots.TabIndex = 13;
            this.txtBoxMots.TabStop = false;
            this.txtBoxMots.WordWrap = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(85, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Vos Mots";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(336, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = " ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // frmScrabble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::WinScrabble.Properties.Resources.FondScrabble;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(656, 350);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxMots);
            this.Controls.Add(this.resClickk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.totPoints);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPoints);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAutre);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtMot);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmScrabble";
            this.Text = "JEU DU SCRABBLE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMot;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnAutre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPoints;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox totPoints;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label resClickk;
        private System.Windows.Forms.TextBox txtBoxMots;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

