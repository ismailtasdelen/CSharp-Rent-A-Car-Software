﻿namespace ARAC_KIRALAMA_OTOMASYONU
{
    partial class ADMIN_SOZLESMEIPTALET
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADMIN_SOZLESMEIPTALET));
            this.BTN_SOZLESMEIPTALETMEBOLUMU = new MetroFramework.Controls.MetroButton();
            this.SOZLESME_IPTAL_ETME_BOLUMU_TEXTBOX_TCNO = new MetroFramework.Controls.MetroTextBox();
            this.SOZLESME_IPTAL_ETME_BOLUMU_LABEL_TCNO = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // BTN_SOZLESMEIPTALETMEBOLUMU
            // 
            this.BTN_SOZLESMEIPTALETMEBOLUMU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_SOZLESMEIPTALETMEBOLUMU.Location = new System.Drawing.Point(11, 107);
            this.BTN_SOZLESMEIPTALETMEBOLUMU.Name = "BTN_SOZLESMEIPTALETMEBOLUMU";
            this.BTN_SOZLESMEIPTALETMEBOLUMU.Size = new System.Drawing.Size(458, 53);
            this.BTN_SOZLESMEIPTALETMEBOLUMU.Style = MetroFramework.MetroColorStyle.Green;
            this.BTN_SOZLESMEIPTALETMEBOLUMU.TabIndex = 0;
            this.BTN_SOZLESMEIPTALETMEBOLUMU.Text = "SÖZLEŞMEYİ İPTAL ETME BÖLÜMÜ";
            this.BTN_SOZLESMEIPTALETMEBOLUMU.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BTN_SOZLESMEIPTALETMEBOLUMU.UseSelectable = true;
            this.BTN_SOZLESMEIPTALETMEBOLUMU.Click += new System.EventHandler(this.BTN_SOZLESMEIPTALETMEBOLUMU_Click);
            // 
            // SOZLESME_IPTAL_ETME_BOLUMU_TEXTBOX_TCNO
            // 
            this.SOZLESME_IPTAL_ETME_BOLUMU_TEXTBOX_TCNO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.SOZLESME_IPTAL_ETME_BOLUMU_TEXTBOX_TCNO.Lines = new string[0];
            this.SOZLESME_IPTAL_ETME_BOLUMU_TEXTBOX_TCNO.Location = new System.Drawing.Point(73, 73);
            this.SOZLESME_IPTAL_ETME_BOLUMU_TEXTBOX_TCNO.MaxLength = 32767;
            this.SOZLESME_IPTAL_ETME_BOLUMU_TEXTBOX_TCNO.Name = "SOZLESME_IPTAL_ETME_BOLUMU_TEXTBOX_TCNO";
            this.SOZLESME_IPTAL_ETME_BOLUMU_TEXTBOX_TCNO.PasswordChar = '\0';
            this.SOZLESME_IPTAL_ETME_BOLUMU_TEXTBOX_TCNO.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SOZLESME_IPTAL_ETME_BOLUMU_TEXTBOX_TCNO.SelectedText = "";
            this.SOZLESME_IPTAL_ETME_BOLUMU_TEXTBOX_TCNO.Size = new System.Drawing.Size(396, 23);
            this.SOZLESME_IPTAL_ETME_BOLUMU_TEXTBOX_TCNO.Style = MetroFramework.MetroColorStyle.Green;
            this.SOZLESME_IPTAL_ETME_BOLUMU_TEXTBOX_TCNO.TabIndex = 1;
            this.SOZLESME_IPTAL_ETME_BOLUMU_TEXTBOX_TCNO.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SOZLESME_IPTAL_ETME_BOLUMU_TEXTBOX_TCNO.UseSelectable = true;
            // 
            // SOZLESME_IPTAL_ETME_BOLUMU_LABEL_TCNO
            // 
            this.SOZLESME_IPTAL_ETME_BOLUMU_LABEL_TCNO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.SOZLESME_IPTAL_ETME_BOLUMU_LABEL_TCNO.AutoSize = true;
            this.SOZLESME_IPTAL_ETME_BOLUMU_LABEL_TCNO.Location = new System.Drawing.Point(11, 73);
            this.SOZLESME_IPTAL_ETME_BOLUMU_LABEL_TCNO.Name = "SOZLESME_IPTAL_ETME_BOLUMU_LABEL_TCNO";
            this.SOZLESME_IPTAL_ETME_BOLUMU_LABEL_TCNO.Size = new System.Drawing.Size(56, 19);
            this.SOZLESME_IPTAL_ETME_BOLUMU_LABEL_TCNO.Style = MetroFramework.MetroColorStyle.Green;
            this.SOZLESME_IPTAL_ETME_BOLUMU_LABEL_TCNO.TabIndex = 2;
            this.SOZLESME_IPTAL_ETME_BOLUMU_LABEL_TCNO.Text = "TC NO :";
            this.SOZLESME_IPTAL_ETME_BOLUMU_LABEL_TCNO.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ADMIN_SOZLESMEIPTALET
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 173);
            this.Controls.Add(this.SOZLESME_IPTAL_ETME_BOLUMU_LABEL_TCNO);
            this.Controls.Add(this.SOZLESME_IPTAL_ETME_BOLUMU_TEXTBOX_TCNO);
            this.Controls.Add(this.BTN_SOZLESMEIPTALETMEBOLUMU);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ADMIN_SOZLESMEIPTALET";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "SÖZLEŞME İPTAL ETME BÖLÜMÜ";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.ADMIN_SOZLESMEIPTALET_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton BTN_SOZLESMEIPTALETMEBOLUMU;
        private MetroFramework.Controls.MetroTextBox SOZLESME_IPTAL_ETME_BOLUMU_TEXTBOX_TCNO;
        private MetroFramework.Controls.MetroLabel SOZLESME_IPTAL_ETME_BOLUMU_LABEL_TCNO;
    }
}
