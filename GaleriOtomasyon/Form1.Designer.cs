using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace GaleriOtomasyon
{
    partial class AnaEkran : Form
    {
        
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaEkran));
            this.sabitUstPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gosteriPaneli = new System.Windows.Forms.Panel();
            this.AracSatisButon = new GaleriOtomasyon.CustomElements.CustomButton();
            this.BilgiislemButon = new GaleriOtomasyon.CustomElements.CustomButton();
            this.GarajButon = new GaleriOtomasyon.CustomElements.CustomButton();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sabitUstPanel
            // 
            this.sabitUstPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sabitUstPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sabitUstPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sabitUstPanel.BackgroundImage")));
            this.sabitUstPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sabitUstPanel.Location = new System.Drawing.Point(0, 3);
            this.sabitUstPanel.Name = "sabitUstPanel";
            this.sabitUstPanel.Size = new System.Drawing.Size(1478, 174);
            this.sabitUstPanel.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.gosteriPaneli);
            this.panel2.Controls.Add(this.AracSatisButon);
            this.panel2.Controls.Add(this.BilgiislemButon);
            this.panel2.Controls.Add(this.GarajButon);
            this.panel2.Location = new System.Drawing.Point(0, 170);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1478, 674);
            this.panel2.TabIndex = 2;
            // 
            // gosteriPaneli
            // 
            this.gosteriPaneli.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gosteriPaneli.Location = new System.Drawing.Point(227, 3);
            this.gosteriPaneli.Name = "gosteriPaneli";
            this.gosteriPaneli.Size = new System.Drawing.Size(1251, 671);
            this.gosteriPaneli.TabIndex = 8;
            // 
            // AracSatisButon
            // 
            this.AracSatisButon.BackColor = System.Drawing.Color.White;
            this.AracSatisButon.BackgroundColor = System.Drawing.Color.White;
            this.AracSatisButon.BorderColor = System.Drawing.Color.SlateGray;
            this.AracSatisButon.BorderRadius = 40;
            this.AracSatisButon.BorderSize = 3;
            this.AracSatisButon.FlatAppearance.BorderSize = 0;
            this.AracSatisButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AracSatisButon.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AracSatisButon.ForeColor = System.Drawing.Color.Black;
            this.AracSatisButon.Image = ((System.Drawing.Image)(resources.GetObject("AracSatisButon.Image")));
            this.AracSatisButon.Location = new System.Drawing.Point(17, 375);
            this.AracSatisButon.Name = "AracSatisButon";
            this.AracSatisButon.Size = new System.Drawing.Size(204, 194);
            this.AracSatisButon.TabIndex = 7;
            this.AracSatisButon.Text = "Satış İşlemleri";
            this.AracSatisButon.TextColor = System.Drawing.Color.Black;
            this.AracSatisButon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AracSatisButon.UseVisualStyleBackColor = false;
            this.AracSatisButon.Click += new System.EventHandler(this.AracSatisButon_Click);
            // 
            // BilgiislemButon
            // 
            this.BilgiislemButon.BackColor = System.Drawing.Color.White;
            this.BilgiislemButon.BackgroundColor = System.Drawing.Color.White;
            this.BilgiislemButon.BorderColor = System.Drawing.Color.SlateGray;
            this.BilgiislemButon.BorderRadius = 40;
            this.BilgiislemButon.BorderSize = 3;
            this.BilgiislemButon.FlatAppearance.BorderSize = 0;
            this.BilgiislemButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BilgiislemButon.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BilgiislemButon.ForeColor = System.Drawing.Color.Black;
            this.BilgiislemButon.Image = ((System.Drawing.Image)(resources.GetObject("BilgiislemButon.Image")));
            this.BilgiislemButon.Location = new System.Drawing.Point(17, 190);
            this.BilgiislemButon.Name = "BilgiislemButon";
            this.BilgiislemButon.Size = new System.Drawing.Size(204, 179);
            this.BilgiislemButon.TabIndex = 6;
            this.BilgiislemButon.Text = "Bilgi İşlem";
            this.BilgiislemButon.TextColor = System.Drawing.Color.Black;
            this.BilgiislemButon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BilgiislemButon.UseVisualStyleBackColor = false;
            this.BilgiislemButon.Click += new System.EventHandler(this.BilgiislemButon_Click);
            // 
            // GarajButon
            // 
            this.GarajButon.AutoEllipsis = true;
            this.GarajButon.BackColor = System.Drawing.Color.White;
            this.GarajButon.BackgroundColor = System.Drawing.Color.White;
            this.GarajButon.BorderColor = System.Drawing.Color.SlateGray;
            this.GarajButon.BorderRadius = 40;
            this.GarajButon.BorderSize = 3;
            this.GarajButon.FlatAppearance.BorderSize = 0;
            this.GarajButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GarajButon.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GarajButon.ForeColor = System.Drawing.Color.Black;
            this.GarajButon.Image = ((System.Drawing.Image)(resources.GetObject("GarajButon.Image")));
            this.GarajButon.Location = new System.Drawing.Point(17, 6);
            this.GarajButon.Name = "GarajButon";
            this.GarajButon.Size = new System.Drawing.Size(205, 181);
            this.GarajButon.TabIndex = 5;
            this.GarajButon.Text = "Garaj";
            this.GarajButon.TextColor = System.Drawing.Color.Black;
            this.GarajButon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.GarajButon.UseVisualStyleBackColor = false;
            this.GarajButon.Click += new System.EventHandler(this.GarajButon_Click);
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1474, 788);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.sabitUstPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IsMdiContainer = true;
            this.Name = "AnaEkran";
            this.Text = "Galeri Dünyası";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel sabitUstPanel;
        private System.Windows.Forms.Panel panel2;
        private CustomElements.CustomButton AracSatisButon;
        private CustomElements.CustomButton BilgiislemButon;
        private CustomElements.CustomButton GarajButon;
        private System.Windows.Forms.Panel gosteriPaneli;
    }
 }


