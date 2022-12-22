using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace prjHafta9
{
    public class clsBalon: IDisposable
    {
        int _iX;
        int _iY;
        int _iW;
        int _iH;
        int _iHareketMiktari;
        Label _lblBalon;

        public clsBalon(int iX,int iY, int iW, int iH, int iHareketMiktari, Panel pnlOyun)
        {
            _iX = iX;
            _iY = iY;
            _iW = iW;
            _iH = iH;
            _lblBalon = new Label();
            _lblBalon.Location = new Point(_iX, _iY);
            _lblBalon.Image = Image.FromFile("balloon.png");
            _lblBalon.AutoSize = false;
            _lblBalon.Width = iW;
            _lblBalon.Height = iH;
            _iHareketMiktari = iHareketMiktari;
            pnlOyun.Controls.Add(_lblBalon);
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
                _lblBalon.Location = new Point(_iX, _iY);
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
                _lblBalon.Location = new Point(_iX, _iY);
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
                case (int)YonlerEnum.Yukari:
                    iY -= _iHareketMiktari;
                    break;
            }
        }

        public void Dispose()
        {
            _lblBalon.Visible = false;
            _lblBalon.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
