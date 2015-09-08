namespace MähenZeit
{
    partial class MähenZeit
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.hausLängeFeld = new System.Windows.Forms.TextBox();
            this.hausBreitFeld = new System.Windows.Forms.TextBox();
            this.HausBlkLängeFeld = new System.Windows.Forms.TextBox();
            this.HausBlkBreitFeld = new System.Windows.Forms.TextBox();
            this.Ziel = new System.Windows.Forms.Label();
            this.Antwort = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rate = new System.Windows.Forms.TextBox();
            this.erreichenTaste = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hausLängeFeld
            // 
            this.hausLängeFeld.Location = new System.Drawing.Point(12, 55);
            this.hausLängeFeld.Name = "hausLängeFeld";
            this.hausLängeFeld.Size = new System.Drawing.Size(100, 20);
            this.hausLängeFeld.TabIndex = 0;
            this.hausLängeFeld.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.hausLängeFeld.TextChanged += new System.EventHandler(this.hausLängeFeld_TextChanged);
            // 
            // hausBreitFeld
            // 
            this.hausBreitFeld.Location = new System.Drawing.Point(12, 81);
            this.hausBreitFeld.Name = "hausBreitFeld";
            this.hausBreitFeld.Size = new System.Drawing.Size(100, 20);
            this.hausBreitFeld.TabIndex = 1;
            this.hausBreitFeld.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // HausBlkLängeFeld
            // 
            this.HausBlkLängeFeld.Location = new System.Drawing.Point(12, 107);
            this.HausBlkLängeFeld.Name = "HausBlkLängeFeld";
            this.HausBlkLängeFeld.Size = new System.Drawing.Size(100, 20);
            this.HausBlkLängeFeld.TabIndex = 2;
            this.HausBlkLängeFeld.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // HausBlkBreitFeld
            // 
            this.HausBlkBreitFeld.Location = new System.Drawing.Point(12, 133);
            this.HausBlkBreitFeld.Name = "HausBlkBreitFeld";
            this.HausBlkBreitFeld.Size = new System.Drawing.Size(100, 20);
            this.HausBlkBreitFeld.TabIndex = 3;
            this.HausBlkBreitFeld.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Ziel
            // 
            this.Ziel.AutoSize = true;
            this.Ziel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Ziel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ziel.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ziel.Location = new System.Drawing.Point(8, 9);
            this.Ziel.Name = "Ziel";
            this.Ziel.Size = new System.Drawing.Size(276, 38);
            this.Ziel.TabIndex = 8;
            this.Ziel.Text = "Diese Anwendung findet wie lange \r\nes dauert um Ihr Hof zu mähen.";
            // 
            // Antwort
            // 
            this.Antwort.AutoSize = true;
            this.Antwort.Location = new System.Drawing.Point(12, 240);
            this.Antwort.Name = "Antwort";
            this.Antwort.Size = new System.Drawing.Size(0, 13);
            this.Antwort.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Hauslänge";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Haus Breit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Haus Block Länge";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Haus Block Breit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Rate (Normalweise 2 qm pro Min.)";
            // 
            // rate
            // 
            this.rate.Location = new System.Drawing.Point(12, 162);
            this.rate.Name = "rate";
            this.rate.Size = new System.Drawing.Size(100, 20);
            this.rate.TabIndex = 15;
            this.rate.Text = "2";
            this.rate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // erreichenTaste
            // 
            this.erreichenTaste.Location = new System.Drawing.Point(204, 189);
            this.erreichenTaste.Name = "erreichenTaste";
            this.erreichenTaste.Size = new System.Drawing.Size(75, 23);
            this.erreichenTaste.TabIndex = 16;
            this.erreichenTaste.Text = "Erreichen";
            this.erreichenTaste.UseVisualStyleBackColor = true;
            this.erreichenTaste.Click += new System.EventHandler(this.erreichenTaste_Click);
            // 
            // MähenZeit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 262);
            this.Controls.Add(this.erreichenTaste);
            this.Controls.Add(this.rate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Antwort);
            this.Controls.Add(this.Ziel);
            this.Controls.Add(this.HausBlkBreitFeld);
            this.Controls.Add(this.HausBlkLängeFeld);
            this.Controls.Add(this.hausBreitFeld);
            this.Controls.Add(this.hausLängeFeld);
            this.Name = "MähenZeit";
            this.Text = "Mähen Zeit";
            this.Load += new System.EventHandler(this.MähenZeit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox hausLängeFeld;
        private System.Windows.Forms.TextBox hausBreitFeld;
        private System.Windows.Forms.TextBox HausBlkLängeFeld;
        private System.Windows.Forms.TextBox HausBlkBreitFeld;
        private System.Windows.Forms.Label Ziel;
        private System.Windows.Forms.Label Antwort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox rate;
        private System.Windows.Forms.Button erreichenTaste;
    }
}

