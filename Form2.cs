using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDP_SozlukSinavi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }



        Random rnd = new Random();
        List<KeyValuePair<string, string>> sorular;
        int soruIndex = 0;
        int puan = 0;
        string dogruCevap = "";
        bool ilkCevap = true;
        int dogruSayisi = 0;
        int yanlisSayisi = 0;




        private void Form2_Load(object sender, EventArgs e)
        {
            sorular = Form1.sozluk.ToList();
            sorular = sorular.OrderBy(x => rnd.Next()).ToList(); // Rastgele sırala

            // Soruların şablonlarını ekle
            btnSecenek1.Click += btnSecenek_Click;
            btnSecenek2.Click += btnSecenek_Click;
            btnSecenek3.Click += btnSecenek_Click;
            btnSecenek4.Click += btnSecenek_Click;

            YeniSoruGetir(); // İlk soruyu getir
        }


        void YeniSoruGetir()
        {


            // Eğer tüm soruları bitirdiysek, sonucu göster
            if (soruIndex >= sorular.Count)
            {
                MessageBox.Show($"Test tamamlandı!\nToplam puan: {puan}\nDoğru Sayısı: {dogruSayisi}\nYanlış Sayısı: {yanlisSayisi}", "Sınav Sonucu");
                this.Close();
                return;
            }


            ilkCevap = true;

            // Şu anda sıradaki soruyu al
            var soru = sorular[soruIndex];
            dogruCevap = soru.Value;

            lblKelime.Text = soru.Key; // Kelimeyi göster
            lblPuan.Text = puan.ToString();
            lblSoruDurum.Text = $"{soruIndex + 1} / {sorular.Count}";

            // Seçenekleri rastgele karıştır
            List<string> secenekler = new List<string> { dogruCevap };

            while (secenekler.Count < 4)
            {
                var rastgele = Form1.sozluk.Values.ElementAt(rnd.Next(Form1.sozluk.Count));
                if (!secenekler.Contains(rastgele))
                {
                    secenekler.Add(rastgele);
                }
            }

            secenekler = secenekler.OrderBy(x => rnd.Next()).ToList(); // Seçenekleri karıştır

            // Seçenek butonlarına yerleştir
            btnSecenek1.Text = secenekler[0];
            btnSecenek2.Text = secenekler[1];
            btnSecenek3.Text = secenekler[2];
            btnSecenek4.Text = secenekler[3];

            // Butonları sıfırla
            foreach (var btn in new[] { btnSecenek1, btnSecenek2, btnSecenek3, btnSecenek4 })
            {
                btn.Enabled = true;
                btn.BackColor = DefaultBackColor;
            }
        }



        private async void btnSecenek_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn == null)
                return;

            if (btn.Text == dogruCevap)
            {
                if (ilkCevap)
                {
                    puan += 10; // Her doğru cevap için 10 puan
                    dogruSayisi++;
                }

                btn.BackColor = Color.LightGreen; // Doğru cevap yeşil

                await Task.Delay(1000); // 2 saniye bekle, sonra bir sonraki soruya geç

                soruIndex++;
                YeniSoruGetir(); // Yeni soru göster
            }
            else
            {
                if (ilkCevap)
                {
                    yanlisSayisi++; // Yanlış sayısını artır
                }

                // İlk cevap hatalıysa artık puan kazanamayacak
                ilkCevap = false;

                btn.BackColor = Color.Red; // Yanlış cevap kırmızı
                btn.Enabled = false; // Seçenekler etkin değil
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblKelime_Click(object sender, EventArgs e)
        {

        }
    }
}
