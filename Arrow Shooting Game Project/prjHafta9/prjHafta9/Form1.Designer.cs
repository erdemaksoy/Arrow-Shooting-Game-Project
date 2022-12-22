namespace prjHafta9
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
            this.pnlOyun = new System.Windows.Forms.Panel();
            this.lbl = new System.Windows.Forms.Label();
            this.lblPuan = new System.Windows.Forms.Label();
            this.lblOkSayisi = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.ucntrlKacanBalon1 = new prjHafta9.ucntrlKacanBalon();
            this.SuspendLayout();
            // 
            // pnlOyun
            // 
            this.pnlOyun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlOyun.BackColor = System.Drawing.Color.Green;
            this.pnlOyun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOyun.Location = new System.Drawing.Point(12, 44);
            this.pnlOyun.Name = "pnlOyun";
            this.pnlOyun.Size = new System.Drawing.Size(790, 574);
            this.pnlOyun.TabIndex = 0;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(14, 19);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(55, 20);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "Puan:";
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuan.Location = new System.Drawing.Point(81, 19);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(19, 20);
            this.lblPuan.TabIndex = 2;
            this.lblPuan.Text = "0";
            // 
            // lblOkSayisi
            // 
            this.lblOkSayisi.AutoSize = true;
            this.lblOkSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOkSayisi.Location = new System.Drawing.Point(780, 20);
            this.lblOkSayisi.Name = "lblOkSayisi";
            this.lblOkSayisi.Size = new System.Drawing.Size(19, 20);
            this.lblOkSayisi.TabIndex = 4;
            this.lblOkSayisi.Text = "0";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(686, 20);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(88, 20);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "Ok Sayısı:";
            // 
            // ucntrlKacanBalon1
            // 
            this.ucntrlKacanBalon1.BackColor = System.Drawing.Color.Green;
            this.ucntrlKacanBalon1.Location = new System.Drawing.Point(338, 4);
            this.ucntrlKacanBalon1.Name = "ucntrlKacanBalon1";
            this.ucntrlKacanBalon1.Size = new System.Drawing.Size(158, 40);
            this.ucntrlKacanBalon1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(814, 630);
            this.Controls.Add(this.ucntrlKacanBalon1);
            this.Controls.Add(this.lblOkSayisi);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lblPuan);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.pnlOyun);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlOyun;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblPuan;
        private System.Windows.Forms.Label lblOkSayisi;
        private System.Windows.Forms.Label lbl2;
        private ucntrlKacanBalon ucntrlKacanBalon1;
    }
}

