using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjHafta9
{
    public static class clsOyun
    {
        static int _iOkSayisi = 5;
        static int _iBalonOlusturmaZamani = 5;
        static List<object> nesneler = new List<object>();
        static Timer timer = new Timer();
        static Panel _pnlOyun;
        static clsOkcu okcu;
        static Label _lblPuan, _lblOkSayisi;
        static int _iPuan;
        static int _iKacanBalonSayisi;
        static ucntrlKacanBalon _ucntrlKacanBalon1;

        public static void HareketEttir(int iYon)
        {
            okcu.HareketEttir(iYon);
        }

        public static void AutoHareketEttir()
        {
            clsOk ok;
            clsBalon balon;
            int iSayac;
            for (iSayac = 0; iSayac < nesneler.Count; iSayac++)
            {
                if (nesneler[iSayac] is clsOk && nesneler[iSayac]!=null)
                {
                    ok = nesneler[iSayac] as clsOk;
                    ok.HareketEttir((int)YonlerEnum.Sag);
                    if(ok.iX>=_pnlOyun.Width)
                    {
                        (nesneler[iSayac] as clsOk).Dispose();
                        nesneler[iSayac] = null;
                        _iOkSayisi++;
                    }
                }
            }

            for (iSayac = 0; iSayac < nesneler.Count; iSayac++)
            {
                if (nesneler[iSayac] is clsBalon && nesneler[iSayac] != null)
                {
                    balon = nesneler[iSayac] as clsBalon;
                    balon.HareketEttir((int)YonlerEnum.Yukari);
                    if (balon.iY <= 0- balon.iH)
                    {
                        (nesneler[iSayac] as clsBalon).Dispose();
                        nesneler[iSayac] = null;
                        _iKacanBalonSayisi++;
                    }
                }
            }

            Kontrol();
        }

        public static void OyunKur(int iOkSayisi, Panel pnlOyun,Label lblPuan,Label lblOkSayisi, ucntrlKacanBalon ucntrlKacanBalon1)
        {
            _iOkSayisi = iOkSayisi;
            _pnlOyun = pnlOyun;
            timer.Tick += timer_Tick;
            timer.Interval = 1;
            timer.Enabled = true;
            okcu = new clsOkcu(0, _pnlOyun.Height / 2 - 60, 100, 120, 1, pnlOyun);

            _lblPuan = lblPuan;
            _lblOkSayisi = lblOkSayisi;

            _iPuan = 0;

            _lblPuan.Text = _iPuan.ToString();
            _lblOkSayisi.Text = _iOkSayisi.ToString();
            _ucntrlKacanBalon1 = ucntrlKacanBalon1;
        }

        private static void timer_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            AutoHareketEttir();
            if (_iBalonOlusturmaZamani > 0)
                _iBalonOlusturmaZamani--;
            if (_iBalonOlusturmaZamani == 0)
            {
                _iBalonOlusturmaZamani = (rnd.Next(5) + 1)*50;
                BalonOlustur();
            }

            if(_iKacanBalonSayisi==5)
            {
                timer.Enabled = false;
                MessageBox.Show("Oyun bitti :)");
            }
        }

        private static void BalonOlustur()
        {
            clsBalon balon;
            Random rnd = new Random();
            int iX, iY, iHareketMiktari;
            iX = rnd.Next(_pnlOyun.Width - 200) + 100;
            iY = _pnlOyun.Height;
            iHareketMiktari = 1;
            balon = new clsBalon(iX, iY,25,28, iHareketMiktari, _pnlOyun);
            nesneler.Add(balon);
        }

        public static void OkOlustur()
        {
            clsOk ok;
            Random rnd = new Random();
            int iX, iY, iHareketMiktari;

            if (_iOkSayisi == 0)
                return;

            _iOkSayisi--;

            iX = okcu.iX + okcu.iW - 10;
            iY = okcu.iY + okcu.iH / 2;
            iHareketMiktari = 10;
            ok = new clsOk(iX, iY,49,7, iHareketMiktari, _pnlOyun);
            nesneler.Add(ok);

            _lblOkSayisi.Text = _iOkSayisi.ToString();
        }

        public static void Kontrol()
        {
            clsOk ok;
            clsBalon balon;
            Rectangle rectangle1, rectangle2;
            int iSayac1, iSayac2;
            for(iSayac1=0; iSayac1<nesneler.Count;iSayac1++)
            {
                if (nesneler[iSayac1] is clsOk)
                {
                    ok = nesneler[iSayac1] as clsOk;
                    rectangle1 = new Rectangle(ok.iX, ok.iY, ok.iW, ok.iH);
                    for (iSayac2 = 0; iSayac2 < nesneler.Count; iSayac2++)
                    {
                        if (nesneler[iSayac2] is clsBalon)
                        {
                            balon = nesneler[iSayac2] as clsBalon;
                            rectangle2 = new Rectangle(balon.iX, balon.iY, balon.iW, balon.iH);
                            if (rectangle1.IntersectsWith(rectangle2))
                            {
                                (nesneler[iSayac2] as clsBalon).Dispose();
                                nesneler[iSayac2] = null;
                                _iPuan += 1;
                            }
                        }
                    }
                }
            }

            _lblPuan.Text = _iPuan.ToString();
            _lblOkSayisi.Text = _iOkSayisi.ToString();
            _ucntrlKacanBalon1.iKacanBalonSayisi = _iKacanBalonSayisi;
        }

    }
}
