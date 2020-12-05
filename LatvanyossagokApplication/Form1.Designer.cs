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
            this.buttonVarosTorlese = new System.Windows.Forms.Button();
            this.buttonLatvanyossagTorlese = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonLatvanyossagModosit = new System.Windows.Forms.Button();
            this.comboBoxVarosModosit = new System.Windows.Forms.ComboBox();
            this.numericUpDownArModosit = new System.Windows.Forms.NumericUpDown();
            this.textBoxLeirasModosit = new System.Windows.Forms.TextBox();
            this.textBoxLatvanyossagModosit = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBoxVarosModosit = new System.Windows.Forms.TextBox();
            this.buttonVarosModosit = new System.Windows.Forms.Button();
            this.numericUpDownLakossagModosit = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLakossag)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLatvanyossagAr)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownArModosit)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLakossagModosit)).BeginInit();
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
            this.groupBox3.Controls.Add(this.buttonVarosTorlese);
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
            this.listBoxVarosok.Size = new System.Drawing.Size(204, 277);
            this.listBoxVarosok.TabIndex = 0;
            this.listBoxVarosok.SelectedIndexChanged += new System.EventHandler(this.listBoxVarosok_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonLatvanyossagTorlese);
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
            this.listBoxLatvanyossagok.Size = new System.Drawing.Size(204, 277);
            this.listBoxLatvanyossagok.TabIndex = 0;
            this.listBoxLatvanyossagok.SelectedIndexChanged += new System.EventHandler(this.listBoxLatvanyossagok_SelectedIndexChanged);
            // 
            // buttonVarosTorlese
            // 
            this.buttonVarosTorlese.Location = new System.Drawing.Point(7, 302);
            this.buttonVarosTorlese.Name = "buttonVarosTorlese";
            this.buttonVarosTorlese.Size = new System.Drawing.Size(204, 32);
            this.buttonVarosTorlese.TabIndex = 1;
            this.buttonVarosTorlese.Text = "Város törlése";
            this.buttonVarosTorlese.UseVisualStyleBackColor = true;
            this.buttonVarosTorlese.Click += new System.EventHandler(this.buttonVarosTorlese_Click);
            // 
            // buttonLatvanyossagTorlese
            // 
            this.buttonLatvanyossagTorlese.Location = new System.Drawing.Point(7, 302);
            this.buttonLatvanyossagTorlese.Name = "buttonLatvanyossagTorlese";
            this.buttonLatvanyossagTorlese.Size = new System.Drawing.Size(204, 35);
            this.buttonLatvanyossagTorlese.TabIndex = 1;
            this.buttonLatvanyossagTorlese.Text = "Látványosság törlése";
            this.buttonLatvanyossagTorlese.UseVisualStyleBackColor = true;
            this.buttonLatvanyossagTorlese.Click += new System.EventHandler(this.buttonLatvanyossagTorlese_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonLatvanyossagModosit);
            this.groupBox5.Controls.Add(this.comboBoxVarosModosit);
            this.groupBox5.Controls.Add(this.numericUpDownArModosit);
            this.groupBox5.Controls.Add(this.textBoxLeirasModosit);
            this.groupBox5.Controls.Add(this.textBoxLatvanyossagModosit);
            this.groupBox5.Location = new System.Drawing.Point(788, 158);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(222, 199);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Látványosság módosítása (név,leírás/ár/Város)";
            // 
            // buttonLatvanyossagModosit
            // 
            this.buttonLatvanyossagModosit.Location = new System.Drawing.Point(7, 141);
            this.buttonLatvanyossagModosit.Name = "buttonLatvanyossagModosit";
            this.buttonLatvanyossagModosit.Size = new System.Drawing.Size(209, 52);
            this.buttonLatvanyossagModosit.TabIndex = 4;
            this.buttonLatvanyossagModosit.Text = "Látványosság Módosítása";
            this.buttonLatvanyossagModosit.UseVisualStyleBackColor = true;
            this.buttonLatvanyossagModosit.Click += new System.EventHandler(this.buttonLatvanyossagModosit_Click);
            // 
            // comboBoxVarosModosit
            // 
            this.comboBoxVarosModosit.FormattingEnabled = true;
            this.comboBoxVarosModosit.Location = new System.Drawing.Point(6, 113);
            this.comboBoxVarosModosit.Name = "comboBoxVarosModosit";
            this.comboBoxVarosModosit.Size = new System.Drawing.Size(210, 21);
            this.comboBoxVarosModosit.TabIndex = 3;
            // 
            // numericUpDownArModosit
            // 
            this.numericUpDownArModosit.Location = new System.Drawing.Point(7, 86);
            this.numericUpDownArModosit.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownArModosit.Name = "numericUpDownArModosit";
            this.numericUpDownArModosit.Size = new System.Drawing.Size(209, 20);
            this.numericUpDownArModosit.TabIndex = 2;
            // 
            // textBoxLeirasModosit
            // 
            this.textBoxLeirasModosit.Location = new System.Drawing.Point(6, 59);
            this.textBoxLeirasModosit.Name = "textBoxLeirasModosit";
            this.textBoxLeirasModosit.Size = new System.Drawing.Size(210, 20);
            this.textBoxLeirasModosit.TabIndex = 1;
            // 
            // textBoxLatvanyossagModosit
            // 
            this.textBoxLatvanyossagModosit.Location = new System.Drawing.Point(6, 32);
            this.textBoxLatvanyossagModosit.Name = "textBoxLatvanyossagModosit";
            this.textBoxLatvanyossagModosit.Size = new System.Drawing.Size(210, 20);
            this.textBoxLatvanyossagModosit.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBoxVarosModosit);
            this.groupBox6.Controls.Add(this.buttonVarosModosit);
            this.groupBox6.Controls.Add(this.numericUpDownLakossagModosit);
            this.groupBox6.Location = new System.Drawing.Point(788, 13);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(222, 125);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Város módosítása (név/lakosság)";
            // 
            // textBoxVarosModosit
            // 
            this.textBoxVarosModosit.Location = new System.Drawing.Point(6, 19);
            this.textBoxVarosModosit.Name = "textBoxVarosModosit";
            this.textBoxVarosModosit.Size = new System.Drawing.Size(210, 20);
            this.textBoxVarosModosit.TabIndex = 0;
            // 
            // buttonVarosModosit
            // 
            this.buttonVarosModosit.Location = new System.Drawing.Point(6, 73);
            this.buttonVarosModosit.Name = "buttonVarosModosit";
            this.buttonVarosModosit.Size = new System.Drawing.Size(210, 46);
            this.buttonVarosModosit.TabIndex = 2;
            this.buttonVarosModosit.Text = "Város módosítása";
            this.buttonVarosModosit.UseVisualStyleBackColor = true;
            this.buttonVarosModosit.Click += new System.EventHandler(this.buttonVarosModosit_Click);
            // 
            // numericUpDownLakossagModosit
            // 
            this.numericUpDownLakossagModosit.Location = new System.Drawing.Point(6, 46);
            this.numericUpDownLakossagModosit.Maximum = new decimal(new int[] {
            40000000,
            0,
            0,
            0});
            this.numericUpDownLakossagModosit.Name = "numericUpDownLakossagModosit";
            this.numericUpDownLakossagModosit.Size = new System.Drawing.Size(210, 20);
            this.numericUpDownLakossagModosit.TabIndex = 1;
            // 
            // formNevezetesseg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 367);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
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
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownArModosit)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLakossagModosit)).EndInit();
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
        private System.Windows.Forms.Button buttonVarosTorlese;
        private System.Windows.Forms.Button buttonLatvanyossagTorlese;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonLatvanyossagModosit;
        private System.Windows.Forms.ComboBox comboBoxVarosModosit;
        private System.Windows.Forms.NumericUpDown numericUpDownArModosit;
        private System.Windows.Forms.TextBox textBoxLeirasModosit;
        private System.Windows.Forms.TextBox textBoxLatvanyossagModosit;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBoxVarosModosit;
        private System.Windows.Forms.Button buttonVarosModosit;
        private System.Windows.Forms.NumericUpDown numericUpDownLakossagModosit;
    }
}

