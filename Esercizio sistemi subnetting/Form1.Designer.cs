namespace Esercizio_sistemi_subnetting
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Sottoreti = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Host = new System.Windows.Forms.TextBox();
            this.Calcola = new System.Windows.Forms.Button();
            this.Class = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Indirizzoprivato = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inserisci il numero di sottoreti:";
            // 
            // Sottoreti
            // 
            this.Sottoreti.Location = new System.Drawing.Point(32, 53);
            this.Sottoreti.Name = "Sottoreti";
            this.Sottoreti.Size = new System.Drawing.Size(100, 20);
            this.Sottoreti.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Inserisci il numero massimo di host:";
            // 
            // Host
            // 
            this.Host.Location = new System.Drawing.Point(32, 114);
            this.Host.Name = "Host";
            this.Host.Size = new System.Drawing.Size(100, 20);
            this.Host.TabIndex = 3;
            this.Host.TextChanged += new System.EventHandler(this.Host_TextChanged);
            // 
            // Calcola
            // 
            this.Calcola.Location = new System.Drawing.Point(214, 37);
            this.Calcola.Name = "Calcola";
            this.Calcola.Size = new System.Drawing.Size(128, 79);
            this.Calcola.TabIndex = 4;
            this.Calcola.Text = "Clicca per ricavare la tabella di rete:";
            this.Calcola.UseVisualStyleBackColor = true;
            this.Calcola.Click += new System.EventHandler(this.Calcola_Click);
            // 
            // Class
            // 
            this.Class.Location = new System.Drawing.Point(420, 49);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(49, 20);
            this.Class.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(417, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Classe:";
            // 
            // Indirizzoprivato
            // 
            this.Indirizzoprivato.Location = new System.Drawing.Point(420, 114);
            this.Indirizzoprivato.Name = "Indirizzoprivato";
            this.Indirizzoprivato.Size = new System.Drawing.Size(115, 20);
            this.Indirizzoprivato.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(417, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Indirizzo base privato";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(420, 185);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(420, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Subnet mask:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Indirizzoprivato);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Class);
            this.Controls.Add(this.Calcola);
            this.Controls.Add(this.Host);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Sottoreti);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Sottoreti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Host;
        private System.Windows.Forms.Button Calcola;
        private System.Windows.Forms.TextBox Class;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Indirizzoprivato;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
    }
}

