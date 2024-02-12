namespace stack_koleksiyonu
{
    partial class Form1
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
            this.BtnEkle = new System.Windows.Forms.Button();
            this.btnCikart = new System.Windows.Forms.Button();
            this.lbStack = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(46, 122);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(97, 41);
            this.BtnEkle.TabIndex = 0;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // btnCikart
            // 
            this.btnCikart.Location = new System.Drawing.Point(149, 122);
            this.btnCikart.Name = "btnCikart";
            this.btnCikart.Size = new System.Drawing.Size(97, 41);
            this.btnCikart.TabIndex = 1;
            this.btnCikart.Text = "Çıkart";
            this.btnCikart.UseVisualStyleBackColor = true;
            this.btnCikart.Click += new System.EventHandler(this.btnCikart_Click);
            // 
            // lbStack
            // 
            this.lbStack.FormattingEnabled = true;
            this.lbStack.Location = new System.Drawing.Point(274, 51);
            this.lbStack.Name = "lbStack";
            this.lbStack.Size = new System.Drawing.Size(120, 160);
            this.lbStack.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ad Soyad";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(46, 86);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(200, 20);
            this.txtAdSoyad.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 282);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbStack);
            this.Controls.Add(this.btnCikart);
            this.Controls.Add(this.BtnEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Button btnCikart;
        private System.Windows.Forms.ListBox lbStack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdSoyad;
    }
}

