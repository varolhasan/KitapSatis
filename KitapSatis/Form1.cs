using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitapSatis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            double kitapsayisi, kitapfiyati = 8, toplamfiyat;
            kitapsayisi = Convert.ToDouble(txtBx1.Text);
            if (kitapsayisi >= 0 && kitapsayisi <= 20)
            {
                toplamfiyat = (kitapsayisi * kitapfiyati) - ((kitapsayisi * kitapfiyati) * 0.2);
                lbl4.Text = toplamfiyat.ToString() + " TL";
            }
            else if (kitapsayisi >= 21 && kitapsayisi <= 40)
            {
                toplamfiyat = (kitapsayisi * kitapfiyati) - ((kitapsayisi * kitapfiyati) * 0.2);
                lbl4.Text = toplamfiyat.ToString() + " TL";
            }
            else if (kitapsayisi >= 41)
            {
                toplamfiyat = (kitapsayisi * kitapfiyati) - ((kitapsayisi * kitapfiyati) * 0.2);
                lbl4.Text = toplamfiyat.ToString() + " TL";
            }
            else
            {
                lbl4.Text = "Geçerli Adet giriniz.(Sayma Sayısı.)";
            }
        }
    }
}
// 0-20 --> % 20
// 21-40--> % 40
// 41++ --> % 50
// Kitap = 8
