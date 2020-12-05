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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLakossag)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxVarosNeve
            // 
            this.textBoxVarosNeve.Location = new System.Drawing.Point(12, 12);
            this.textBoxVarosNeve.Name = "textBoxVarosNeve";
            this.textBoxVarosNeve.Size = new System.Drawing.Size(162, 20);
            this.textBoxVarosNeve.TabIndex = 0;
            // 
            // numericUpDownLakossag
            // 
            this.numericUpDownLakossag.Location = new System.Drawing.Point(12, 39);
            this.numericUpDownLakossag.Maximum = new decimal(new int[] {
            40000000,
            0,
            0,
            0});
            this.numericUpDownLakossag.Name = "numericUpDownLakossag";
            this.numericUpDownLakossag.Size = new System.Drawing.Size(162, 20);
            this.numericUpDownLakossag.TabIndex = 1;
            // 
            // buttonVarosFelvetele
            // 
            this.buttonVarosFelvetele.Location = new System.Drawing.Point(12, 66);
            this.buttonVarosFelvetele.Name = "buttonVarosFelvetele";
            this.buttonVarosFelvetele.Size = new System.Drawing.Size(162, 23);
            this.buttonVarosFelvetele.TabIndex = 2;
            this.buttonVarosFelvetele.Text = "Város felvétele";
            this.buttonVarosFelvetele.UseVisualStyleBackColor = true;
            this.buttonVarosFelvetele.Click += new System.EventHandler(this.buttonVarosFelvetele_Click);
            // 
            // formNevezetesseg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonVarosFelvetele);
            this.Controls.Add(this.numericUpDownLakossag);
            this.Controls.Add(this.textBoxVarosNeve);
            this.Name = "formNevezetesseg";
            this.Text = "Nevezetességek";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLakossag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxVarosNeve;
        private System.Windows.Forms.NumericUpDown numericUpDownLakossag;
        private System.Windows.Forms.Button buttonVarosFelvetele;
    }
}

