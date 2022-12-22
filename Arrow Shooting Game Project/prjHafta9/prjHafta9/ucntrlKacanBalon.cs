using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjHafta9
{
    public partial class ucntrlKacanBalon : UserControl
    {
        public ucntrlKacanBalon()
        {
            int iSayac;
            PictureBox pb;

            InitializeComponent();

            for (iSayac = 0; iSayac < 5; iSayac++)
            {
                pb = new PictureBox();
                pb.Width = 25;
                pb.Height = 28;
                pb.Location = new Point(5+ iSayac * 30, 5);
                pb.Name = "pbBalon" + iSayac.ToString();
                pb.ImageLocation = "balloon.png";
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Visible = false;
                this.Controls.Add(pb);
            }
        }
        int _iKacanBalonSayisi=0;
        public int iKacanBalonSayisi
        {
            set
            {
                int iSayac;
                _iKacanBalonSayisi = value;

                for(iSayac=0; iSayac<5; iSayac++)
                {
                    this.Controls.Find("pbBalon" + iSayac.ToString(), true)[0].Visible = _iKacanBalonSayisi > iSayac;
                }
            }
        }
    }
}
