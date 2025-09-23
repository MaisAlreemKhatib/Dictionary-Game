namespace NDP_SozlukSinavi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] dosyalar = Directory.GetFiles(Application.StartupPath, "*.txt");
            foreach (string dosya in dosyalar)
            {
                lstSozlukler.Items.Add(Path.GetFileNameWithoutExtension(dosya));
            }

            btnBaslat.Enabled = false; // Başlat butonu pasif başlasın
        }


        public static Dictionary<string, string> sozluk = new Dictionary<string, string>();
        private void btnYukle_Click(object sender, EventArgs e)
        {

            // Eğer listeden hiçbir şey seçilmemişse kullanıcıyı uyar
            if (lstSozlukler.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir sözlük seçin.");
                return;
            }

            // Önce sözlüğü temizle (birden fazla yüklemeyi engellemek için)
            Form1.sozluk.Clear();

            // Seçilen dosya adını al ve ".txt" uzantısını ekle
            string secilenDosya = lstSozlukler.SelectedItem.ToString();
            string dosyaYolu = Path.Combine(Application.StartupPath, secilenDosya + ".txt");

            // Dosya gerçekten var mı kontrol et (garanti olsun)
            if (!File.Exists(dosyaYolu))
            {
                MessageBox.Show("Seçilen dosya bulunamadı.");
                return;
            }

            try
            {
                // Satırları oku
                string[] satirlar = File.ReadAllLines(dosyaYolu);

                foreach (string satir in satirlar)
                {
                    // Her satırda kelime ve anlam tab ile ayrılmış olmalı
                    string[] parcala = satir.Split('\t');

                    // Eğer gerçekten 2 parça varsa (kelime ve anlam)
                    if (parcala.Length >= 2)
                    {
                        string kelime = parcala[0].Trim();
                        string anlam = parcala[1].Trim();

                        // Tekrarlayan kelimeleri engelle (istenirse)
                        if (!Form1.sozluk.ContainsKey(kelime))
                        {
                            Form1.sozluk.Add(kelime, anlam);
                        }
                    }
                }

                MessageBox.Show("Sözlük başarıyla yüklendi.");
                btnBaslat.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Yükleme sırasında bir hata oluştu:\n" + ex.Message);
            }

        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            if (Form1.sozluk.Count == 0)
            {
                MessageBox.Show("Henüz sözlük yüklenmedi.");
                return;
            }



            Form2 form = new Form2();
            form.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lstSozlukler_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnBaslat.Enabled = false; // Yeni bir sözlük seçilince Başlat butonu pasif olsun
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Uygulamadan çıkmak istediğinize emin misiniz?",
                                         "Çıkış",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (sonuc == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
