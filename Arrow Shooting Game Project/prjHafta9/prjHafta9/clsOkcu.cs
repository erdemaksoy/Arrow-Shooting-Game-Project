using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace prjHafta9
{
    public class clsOkcu
    {
        int _iX;
        int _iY;
        int _iW;
        int _iH;
        int _iAlanW;
        int _iAlanH;
        int _iHareketMiktari;
        Label _lblOkcu;

        public clsOkcu(int iX,int iY, int iW, int iH,int iHareketMiktari,Panel pnlOyun)
        {
            _iX = iX;
            _iY = iY;
            _iW = iW;
            _iH = iH;
            _lblOkcu = new Label();
            _lblOkcu.Location = new Point(_iX, _iY);
            _lblOkcu.Image = Image.FromFile("man.png");
            _lblOkcu.AutoSize = false;
            _lblOkcu.Width = iW;
            _lblOkcu.Height = iH;
            _iAlanW = pnlOyun.Width;
            _iAlanH = pnlOyun.Height;
            _iHareketMiktari = iHareketMiktari;
            pnlOyun.Controls.Add(_lblOkcu);
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
                _lblOkcu.Location = new Point(_iX, _iY);
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
                _lblOkcu.Location = new Point(_iX, _iY);
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
            switch(iYon)
            {
                case (int)YonlerEnum.Asagi:
                    iY+= _iHareketMiktari;
                    break;
                case (int)YonlerEnum.Yukari:
                    iY -= _iHareketMiktari;
                    break;
            }
        }
    }
}
