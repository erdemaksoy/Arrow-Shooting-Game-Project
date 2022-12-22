using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjHafta9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int iYon = (int)YonlerEnum.Asagi;
            switch(e.KeyChar)
            {
                case 'w':
                case 'W':
                    iYon = (int)YonlerEnum.Yukari;
                    clsOyun.HareketEttir(iYon);
                    break;
                case 's':
                case 'S':
                    iYon = (int)YonlerEnum.Asagi;
                    clsOyun.HareketEttir(iYon);
                    break;
                case ' ':
                    clsOyun.OkOlustur();
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clsOyun.OyunKur(5, pnlOyun,lblPuan,lblOkSayisi, ucntrlKacanBalon1);
        }
    }
}
