
namespace atm
{
    partial class kayitForm
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
            this.sifreTxt = new System.Windows.Forms.TextBox();
            this.girisBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.telefonLabel = new System.Windows.Forms.Label();
            this.telefonTxt = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.soyadTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.adTxt = new System.Windows.Forms.TextBox();
            this.tcTxt = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // sifreTxt
            // 
            this.sifreTxt.Location = new System.Drawing.Point(81, 165);
            this.sifreTxt.Name = "sifreTxt";
            this.sifreTxt.PasswordChar = '*';
            this.sifreTxt.Size = new System.Drawing.Size(100, 20);
            this.sifreTxt.TabIndex = 11;
            // 
            // girisBtn
            // 
            this.girisBtn.Location = new System.Drawing.Point(81, 240);
            this.girisBtn.Name = "girisBtn";
            this.girisBtn.Size = new System.Drawing.Size(100, 25);
            this.girisBtn.TabIndex = 10;
            this.girisBtn.Text = "Kayıt Ol";
            this.girisBtn.UseVisualStyleBackColor = true;
            this.girisBtn.Click += new System.EventHandler(this.girisBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "T.C. Kimlik No";
            // 
            // telefonLabel
            // 
            this.telefonLabel.AutoSize = true;
            this.telefonLabel.Location = new System.Drawing.Point(78, 193);
            this.telefonLabel.Name = "telefonLabel";
            this.telefonLabel.Size = new System.Drawing.Size(90, 13);
            this.telefonLabel.TabIndex = 12;
            this.telefonLabel.Text = "Telefon Numarası";
            // 
            // telefonTxt
            // 
            this.telefonTxt.Location = new System.Drawing.Point(81, 210);
            this.telefonTxt.Mask = "(999) 000 0000";
            this.telefonTxt.Name = "telefonTxt";
            this.telefonTxt.Size = new System.Drawing.Size(100, 20);
            this.telefonTxt.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Soyad";
            // 
            // soyadTxt
            // 
            this.soyadTxt.Location = new System.Drawing.Point(81, 84);
            this.soyadTxt.MaxLength = 32;
            this.soyadTxt.Name = "soyadTxt";
            this.soyadTxt.Size = new System.Drawing.Size(100, 20);
            this.soyadTxt.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Ad";
            // 
            // adTxt
            // 
            this.adTxt.Location = new System.Drawing.Point(81, 43);
            this.adTxt.MaxLength = 0;
            this.adTxt.Name = "adTxt";
            this.adTxt.Size = new System.Drawing.Size(100, 20);
            this.adTxt.TabIndex = 16;
            // 
            // tcTxt
            // 
            this.tcTxt.Location = new System.Drawing.Point(81, 125);
            this.tcTxt.Mask = "00000000000";
            this.tcTxt.Name = "tcTxt";
            this.tcTxt.Size = new System.Drawing.Size(100, 20);
            this.tcTxt.TabIndex = 18;
            // 
            // kayitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 304);
            this.Controls.Add(this.tcTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.adTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.soyadTxt);
            this.Controls.Add(this.telefonTxt);
            this.Controls.Add(this.telefonLabel);
            this.Controls.Add(this.sifreTxt);
            this.Controls.Add(this.girisBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::atm.Properties.Resources.atmIcon;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "kayitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Koç Bank - Kayıt Ol";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.kayitForm_FormClosed);
            this.Load += new System.EventHandler(this.kayitForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox sifreTxt;
        private System.Windows.Forms.Button girisBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label telefonLabel;
        private System.Windows.Forms.MaskedTextBox telefonTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox soyadTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox adTxt;
        private System.Windows.Forms.MaskedTextBox tcTxt;
    }
}