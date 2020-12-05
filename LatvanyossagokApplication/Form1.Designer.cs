namespace LatvanyossagokApplication
{
    partial class formNevezetesseg
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
            this.textBoxVarosNeve = new System.Windows.Forms.TextBox();
            this.numericUpDownLakossag = new System.Windows.Forms.NumericUpDown();
            this.buttonVarosFelvetele = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxLatvanyossagNeve = new System.Windows.Forms.TextBox();
            this.textBoxLatvanyossagLeiras = new System.Windows.Forms.TextBox();
            this.numericUpDownLatvanyossagAr = new System.Windows.Forms.NumericUpDown();
            this.comboBoxLatvanyossagVaros = new System.Windows.Forms.ComboBox();
            this.buttonLatvanyossagFelvetele = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBoxVarosok = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listBoxLatvanyossagok = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLakossag)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLatvanyossagAr)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxVarosNeve
            // 
            this.textBoxVarosNeve.Location = new System.Drawing.Point(6, 19);
            this.textBoxVarosNeve.Name = "textBoxVarosNeve";
            this.textBoxVarosNeve.Size = new System.Drawing.Size(210, 20);
            this.textBoxVarosNeve.TabIndex = 0;
            // 
            // numericUpDownLakossag
            // 
            this.numericUpDownLakossag.Location = new System.Drawing.Point(6, 46);
            this.numericUpDownLakossag.Maximum = new decimal(new int[] {
            40000000,
            0,
            0,
            0});
            this.numericUpDownLakossag.Name = "numericUpDownLakossag";
            this.numericUpDownLakossag.Size = new System.Drawing.Size(210, 20);
            this.numericUpDownLakossag.TabIndex = 1;
            // 
            // buttonVarosFelvetele
            // 
            this.buttonVarosFelvetele.Location = new System.Drawing.Point(6, 73);
            this.buttonVarosFelvetele.Name = "buttonVarosFelvetele";
            this.buttonVarosFelvetele.Size = new System.Drawing.Size(210, 46);
            this.buttonVarosFelvetele.TabIndex = 2;
            this.buttonVarosFelvetele.Text = "Város felvétele";
            this.buttonVarosFelvetele.UseVisualStyleBackColor = true;
            this.buttonVarosFelvetele.Click += new System.EventHandler(this.buttonVarosFelvetele_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxVarosNeve);
            this.groupBox1.Controls.Add(this.buttonVarosFelvetele);
            this.groupBox1.Controls.Add(this.numericUpDownLakossag);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 125);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Város hozzáadása (név/lakosság)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonLatvanyossagFelvetele);
            this.groupBox2.Controls.Add(this.comboBoxLatvanyossagVaros);
            this.groupBox2.Controls.Add(this.numericUpDownLatvanyossagAr);
            this.groupBox2.Controls.Add(this.textBoxLatvanyossagLeiras);
            this.groupBox2.Controls.Add(this.textBoxLatvanyossagNeve);
            this.groupBox2.Location = new System.Drawing.Point(12, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 199);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Látványosság hozzáadása (név,leírás/ár/Város)";
            // 
            // textBoxLatvanyossagNeve
            // 
            this.textBoxLatvanyossagNeve.Location = new System.Drawing.Point(6, 32);
            this.textBoxLatvanyossagNeve.Name = "textBoxLatvanyossagNeve";
            this.textBoxLatvanyossagNeve.Size = new System.Drawing.Size(210, 20);
            this.textBoxLatvanyossagNeve.TabIndex = 0;
            // 
            // textBoxLatvanyossagLeiras
            // 
            this.textBoxLatvanyossagLeiras.Location = new System.Drawing.Point(6, 59);
            this.textBoxLatvanyossagLeiras.Name = "textBoxLatvanyossagLeiras";
            this.textBoxLatvanyossagLeiras.Size = new System.Drawing.Size(210, 20);
            this.textBoxLatvanyossagLeiras.TabIndex = 1;
            // 
            // numericUpDownLatvanyossagAr
            // 
            this.numericUpDownLatvanyossagAr.Location = new System.Drawing.Point(7, 86);
            this.numericUpDownLatvanyossagAr.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownLatvanyossagAr.Name = "numericUpDownLatvanyossagAr";
            this.numericUpDownLatvanyossagAr.Size = new System.Drawing.Size(209, 20);
            this.numericUpDownLatvanyossagAr.TabIndex = 2;
            // 
            // comboBoxLatvanyossagVaros
            // 
            this.comboBoxLatvanyossagVaros.FormattingEnabled = true;
            this.comboBoxLatvanyossagVaros.Location = new System.Drawing.Point(6, 113);
            this.comboBoxLatvanyossagVaros.Name = "comboBoxLatvanyossagVaros";
            this.comboBoxLatvanyossagVaros.Size = new System.Drawing.Size(210, 21);
            this.comboBoxLatvanyossagVaros.TabIndex = 3;
            // 
            // buttonLatvanyossagFelvetele
            // 
            this.buttonLatvanyossagFelvetele.Location = new System.Drawing.Point(7, 141);
            this.buttonLatvanyossagFelvetele.Name = "buttonLatvanyossagFelvetele";
            this.buttonLatvanyossagFelvetele.Size = new System.Drawing.Size(209, 52);
            this.buttonLatvanyossagFelvetele.TabIndex = 4;
            this.buttonLatvanyossagFelvetele.Text = "Látványosság Felvétele";
            this.buttonLatvanyossagFelvetele.UseVisualStyleBackColor = true;
            this.buttonLatvanyossagFelvetele.Click += new System.EventHandler(this.buttonLatvanyossagFelvetele_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBoxVarosok);
            this.groupBox3.Location = new System.Drawing.Point(285, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(217, 343);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Városok";
            // 
            // listBoxVarosok
            // 
            this.listBoxVarosok.FormattingEnabled = true;
            this.listBoxVarosok.Location = new System.Drawing.Point(7, 18);
            this.listBoxVarosok.Name = "listBoxVarosok";
            this.listBoxVarosok.Size = new System.Drawing.Size(204, 316);
            this.listBoxVarosok.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBoxLatvanyossagok);
            this.groupBox4.Location = new System.Drawing.Point(509, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(217, 343);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Látványosságok";
            // 
            // listBoxLatvanyossagok
            // 
            this.listBoxLatvanyossagok.FormattingEnabled = true;
            this.listBoxLatvanyossagok.Location = new System.Drawing.Point(7, 18);
            this.listBoxLatvanyossagok.Name = "listBoxLatvanyossagok";
            this.listBoxLatvanyossagok.Size = new System.Drawing.Size(204, 316);
            this.listBoxLatvanyossagok.TabIndex = 0;
            // 
            // formNevezetesseg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 377);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "formNevezetesseg";
            this.Text = "Nevezetességek";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLakossag)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLatvanyossagAr)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxVarosNeve;
        private System.Windows.Forms.NumericUpDown numericUpDownLakossag;
        private System.Windows.Forms.Button buttonVarosFelvetele;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonLatvanyossagFelvetele;
        private System.Windows.Forms.ComboBox comboBoxLatvanyossagVaros;
        private System.Windows.Forms.NumericUpDown numericUpDownLatvanyossagAr;
        private System.Windows.Forms.TextBox textBoxLatvanyossagLeiras;
        private System.Windows.Forms.TextBox textBoxLatvanyossagNeve;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBoxVarosok;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox listBoxLatvanyossagok;
    }
}

