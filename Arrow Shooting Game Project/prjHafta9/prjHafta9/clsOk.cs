using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace prjHafta9
{
    public class clsOk : IDisposable
    {
        int _iX;
        int _iY;
        int _iW;
        int _iH;
        int _iHareketMiktari;
        Label _lblOk;

        public clsOk(int iX,int iY, int iW, int iH, int iHareketMiktari, Panel pnlOyun)
        {
            _iX = iX;
            _iY = iY;
            _iW = iW;
            _iH = iH;
            _lblOk = new Label();
            _lblOk.Location = new Point(_iX, _iY);
            _lblOk.Image = Image.FromFile("arrow.png");
            _lblOk.AutoSize = false;
            _lblOk.Width = iW;
            _lblOk.Height = iH;
            _iHareketMiktari = iHareketMiktari;
            pnlOyun.Controls.Add(_lblOk);
        }

        public int iX
        {
            get
            {
                return _iX;
            }
            set
            {
                _iX = value;
                _lblOk.Location = new Point(_iX, _iY);
            }
        }

        public int iY
        {
            get
            {
                return _iY;
            }
            set
            {
                _iY = value;
                _lblOk.Location = new Point(_iX, _iY);
            }
        }

        public int iW
        {
            get
            {
                return _iW;
            }
        }

        public int iH
        {
            get
            {
                return _iH;
            }
        }

        public void HareketEttir(int iYon)
        {
            switch (iYon)
            {
                case (int)YonlerEnum.Sag:
                    iX += _iHareketMiktari;
                    break;
            }
        }

        public void Dispose()
        {
            _lblOk.Visible = false;
            _lblOk.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
