using System.Diagnostics;
using System.Drawing;
using System.Runtime.Intrinsics.X86;

namespace SlotGame1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int a, b, c, d, j, f, g, h, k, move, balance = 100, sayac = 0, kazanc = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int betAmount = Convert.ToInt32(textBox1.Text);
            if (textBox1.Text == "")
            {
                MessageBox.Show("LÜTFEN BÝR BET MÝKTARI KOYUN...");
            }
            else
            {
                timer1.Enabled = true;
                label3.Text = Convert.ToString(balance);
                textBox1.Enabled = false;
                textBox1.BackColor = Color.Black;
                //BURADA BET ÝÞLEMLERÝNÝ VE MUHTEMEL KAZANÇLARI YAZICAZ...
                balance -= betAmount;
                Game();
                int kazanilanMiktar = betAmount * sayac;
                if (sayac == 0)
                {
                    label6.Text = "EÞLEÞME OLMADI...";
                    Thread.Sleep(1000);
                    label6.Text = "LÜTFEN TEKRAR DENEYÝNÝZ...";
                }
                else
                {
                    label6.Text = $"ÞU KADAR EÞLEÞME BULUNDU:{sayac}";
                    Thread.Sleep(1000);
                    label6.Text = $"KAZANILAN MÝKTAR:{kazanilanMiktar}";
                }
                balance += kazanilanMiktar;
                label3.Text = Convert.ToString(balance);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            move++;
            if (move < 30)
            {
                a = rnd.Next(4);
                b = rnd.Next(4);
                c = rnd.Next(4);
                d = rnd.Next(4);
                j = rnd.Next(4);
                f = rnd.Next(4);
                g = rnd.Next(4);
                h = rnd.Next(4);
                k = rnd.Next(4);
                switch (a)
                {
                    case 1:
                        pictureBox1.Image = Properties.Resources.png_transparent_yellow_star_illustration_yellow_star_color_star_blue_angle_white_thumbnail;
                        break;
                    case 2:
                        pictureBox1.Image = Properties.Resources.png_red_stars_images;
                        break;
                    case 3:
                        pictureBox1.Image = Properties.Resources.png_transparent_frames_star_star_blue_angle_triangle_thumbnail;
                        break;
                }
                switch (b)
                {
                    case 1:
                        pictureBox2.Image = Properties.Resources.png_transparent_yellow_star_illustration_yellow_star_color_star_blue_angle_white_thumbnail;
                        break;
                    case 2:
                        pictureBox2.Image = Properties.Resources.png_red_stars_images;
                        break;
                    case 3:
                        pictureBox2.Image = Properties.Resources.png_transparent_frames_star_star_blue_angle_triangle_thumbnail;
                        break;
                }
                switch (c)
                {
                    case 1:
                        pictureBox3.Image = Properties.Resources.png_transparent_yellow_star_illustration_yellow_star_color_star_blue_angle_white_thumbnail;
                        break;
                    case 2:
                        pictureBox3.Image = Properties.Resources.png_red_stars_images;
                        break;
                    case 3:
                        pictureBox3.Image = Properties.Resources.png_transparent_frames_star_star_blue_angle_triangle_thumbnail;
                        break;
                }
                switch (j)
                {
                    case 1:
                        pictureBox4.Image = Properties.Resources.png_transparent_yellow_star_illustration_yellow_star_color_star_blue_angle_white_thumbnail;
                        break;
                    case 2:
                        pictureBox4.Image = Properties.Resources.png_red_stars_images;
                        break;
                    case 3:
                        pictureBox4.Image = Properties.Resources.png_transparent_frames_star_star_blue_angle_triangle_thumbnail;
                        break;
                }
                switch (f)
                {
                    case 1:
                        pictureBox5.Image = Properties.Resources.png_transparent_yellow_star_illustration_yellow_star_color_star_blue_angle_white_thumbnail;
                        break;
                    case 2:
                        pictureBox5.Image = Properties.Resources.png_red_stars_images;
                        break;
                    case 3:
                        pictureBox5.Image = Properties.Resources.png_transparent_frames_star_star_blue_angle_triangle_thumbnail;
                        break;
                }
                switch (g)
                {
                    case 1:
                        pictureBox6.Image = Properties.Resources.png_transparent_yellow_star_illustration_yellow_star_color_star_blue_angle_white_thumbnail;
                        break;
                    case 2:
                        pictureBox6.Image = Properties.Resources.png_red_stars_images;
                        break;
                    case 3:
                        pictureBox6.Image = Properties.Resources.png_transparent_frames_star_star_blue_angle_triangle_thumbnail;
                        break;
                }
                switch (h)
                {
                    case 1:
                        pictureBox7.Image = Properties.Resources.png_transparent_yellow_star_illustration_yellow_star_color_star_blue_angle_white_thumbnail;
                        break;
                    case 2:
                        pictureBox7.Image = Properties.Resources.png_red_stars_images;
                        break;
                    case 3:
                        pictureBox7.Image = Properties.Resources.png_transparent_frames_star_star_blue_angle_triangle_thumbnail;
                        break;
                }
                switch (k)
                {
                    case 1:
                        pictureBox8.Image = Properties.Resources.png_transparent_yellow_star_illustration_yellow_star_color_star_blue_angle_white_thumbnail;
                        break;
                    case 2:
                        pictureBox8.Image = Properties.Resources.png_red_stars_images;
                        break;
                    case 3:
                        pictureBox8.Image = Properties.Resources.png_transparent_frames_star_star_blue_angle_triangle_thumbnail;
                        break;
                }

                switch (d)
                {
                    case 1:
                        pictureBox9.Image = Properties.Resources.png_transparent_yellow_star_illustration_yellow_star_color_star_blue_angle_white_thumbnail;
                        break;
                    case 2:
                        pictureBox9.Image = Properties.Resources.png_red_stars_images;
                        break;
                    case 3:
                        pictureBox9.Image = Properties.Resources.png_transparent_frames_star_star_blue_angle_triangle_thumbnail;
                        break;
                }

            }
            else
            {
                timer1.Enabled = false;
                move = 0;
            }
        }
        private void Game()
        {
            sayac = 0;
            if (Convert.ToInt16(textBox1.Text) > balance)
            {
                MessageBox.Show("LÜTFEN GEÇERLÝ BÝR BAHÝS MÝKTARI GÝRÝNÝZ...");
                return;
            }
            if (balance <= 0)
            {
                MessageBox.Show("KUMARINIZ BÝTTÝ EFENDÝM...");
                MessageBox.Show($"YENÝDEN OYNAMAK ÝÇÝN BAKÝYE YÜKLEMESÝ YAPINIZ:MEVCUT BAKÝYENÝZ--> {balance}");
                return;
            }

            // BURADA SLOT OYUNLARININ MEKANÝÐÝ ÝLE ÝLGÝLÝ KODLARI YAZICAM.
            // BURADA REFERANS ALDIÐIMIZ KÖÞELERÝN DEÐER DÖNDÜRMELERÝNÝ ÝNCELEYECEÐÝZ.
            if (rsm1(pictureBox1, pictureBox2) && rsm2(pictureBox1, pictureBox3))
            {
                sayac++;
            }
            if (rsm3(pictureBox1, pictureBox4) && rsm4(pictureBox1, pictureBox7))
            {
                sayac++;
            }
            if (rsm5(pictureBox1, pictureBox5) && rsm6(pictureBox1, pictureBox9))
            {
                sayac++;
            }
            if (rsm7(pictureBox3, pictureBox5) && rsm8(pictureBox3, pictureBox7))
            {
                sayac++;
            }
            if (rsm9(pictureBox3, pictureBox6) && rsm10(pictureBox3, pictureBox9))
            {
                sayac++;
            }
            if (rsm11(pictureBox7, pictureBox8) && rsm12(pictureBox7, pictureBox9))
            {
                sayac++;
            }
        }
        private bool rsm1(PictureBox pictureBox1, PictureBox pictureBox2)
        {
            Bitmap bmp1 = new Bitmap(pictureBox1.Image);
            Bitmap bmp2 = new Bitmap(pictureBox2.Image);
            for (int x = 0; x < bmp1.Width; x++)
            {
                for (int y = 0; y < bmp1.Height; y++)
                {
                    if (bmp1.GetPixel(x, y) == bmp2.GetPixel(x, y))
                        return false;
                }
            }
            return true;
        }
        private bool rsm2(PictureBox pictureBox1, PictureBox pictureBox3)
        {
            Bitmap bmp1 = new Bitmap(pictureBox1.Image);
            Bitmap bmp3 = new Bitmap(pictureBox3.Image);
            for (int x = 0; x < bmp1.Width; x++)
            {
                for (int y = 0; y < bmp1.Height; y++)
                {
                    if (bmp1.GetPixel(x, y) != bmp3.GetPixel(x, y))
                        return false;
                }
            }
            return true;
        }
        private bool rsm3(PictureBox pictureBox1, PictureBox pictureBox4)
        {
            Bitmap bmp1 = new Bitmap(pictureBox1.Image);
            Bitmap bmp4 = new Bitmap(pictureBox4.Image);
            for (int x = 0; x < bmp1.Width; x++)
            {
                for (int y = 0; y < bmp1.Height; y++)
                {
                    if (bmp1.GetPixel(x, y) != bmp4.GetPixel(x, y))
                        return false;
                }
            }
            return true;
        }
        private bool rsm4(PictureBox pictureBox1, PictureBox pictureBox7)
        {
            Bitmap bmp1 = new Bitmap(pictureBox1.Image);
            Bitmap bmp7 = new Bitmap(pictureBox7.Image);
            for (int x = 0; x < bmp1.Width; x++)
            {
                for (int y = 0; y < bmp1.Height; y++)
                {
                    if (bmp1.GetPixel(x, y) != bmp7.GetPixel(x, y))
                        return false;
                }
            }
            return true;
        }
        private bool rsm5(PictureBox pictureBox1, PictureBox pictureBox5)
        {
            Bitmap bmp1 = new Bitmap(pictureBox1.Image);
            Bitmap bmp5 = new Bitmap(pictureBox5.Image);
            for (int x = 0; x < bmp1.Width; x++)
            {
                for (int y = 0; y < bmp1.Height; y++)
                {
                    if (bmp1.GetPixel(x, y) != bmp5.GetPixel(x, y))
                        return false;
                }
            }
            return true;
        }
        private bool rsm6(PictureBox pictureBox1, PictureBox pictureBox9)
        {
            Bitmap bmp1 = new Bitmap(pictureBox1.Image);
            Bitmap bmp9 = new Bitmap(pictureBox9.Image);
            for (int x = 0; x < bmp1.Width; x++)
            {
                for (int y = 0; y < bmp1.Height; y++)
                {
                    if (bmp1.GetPixel(x, y) != bmp9.GetPixel(x, y))
                        return false;
                }
            }
            return true;
        }
        private bool rsm7(PictureBox pictureBox3, PictureBox pictureBox5)
        {
            Bitmap bmp3 = new Bitmap(pictureBox3.Image);
            Bitmap bmp5 = new Bitmap(pictureBox5.Image);
            for (int x = 0; x < bmp3.Width; x++)
            {
                for (int y = 0; y < bmp3.Height; y++)
                {
                    if (bmp3.GetPixel(x, y) != bmp5.GetPixel(x, y))
                        return false;
                }
            }
            return true;
        }
        private bool rsm8(PictureBox pictureBox3, PictureBox pictureBox7)
        {
            Bitmap bmp3 = new Bitmap(pictureBox3.Image);
            Bitmap bmp7 = new Bitmap(pictureBox7.Image);
            for (int x = 0; x < bmp3.Width; x++)
            {
                for (int y = 0; y < bmp3.Height; y++)
                {
                    if (bmp3.GetPixel(x, y) != bmp7.GetPixel(x, y))
                        return false;
                }
            }
            return true;
        }
        private bool rsm9(PictureBox pictureBox3, PictureBox pictureBox6)
        {
            Bitmap bmp3 = new Bitmap(pictureBox3.Image);
            Bitmap bmp6 = new Bitmap(pictureBox6.Image);
            for (int x = 0; x < bmp3.Width; x++)
            {
                for (int y = 0; y < bmp3.Height; y++)
                {
                    if (bmp3.GetPixel(x, y) != bmp6.GetPixel(x, y))
                        return false;
                }
            }
            return true;
        }
        private bool rsm10(PictureBox pictureBox3, PictureBox pictureBox9)
        {
            Bitmap bmp3 = new Bitmap(pictureBox3.Image);
            Bitmap bmp9 = new Bitmap(pictureBox9.Image);
            for (int x = 0; x < bmp3.Width; x++)
            {
                for (int y = 0; y < bmp3.Height; y++)
                {
                    if (bmp3.GetPixel(x, y) != bmp9.GetPixel(x, y))
                        return false;
                }
            }
            return true;
        }
        private bool rsm11(PictureBox pictureBox7, PictureBox pictureBox8)
        {
            Bitmap bmp7 = new Bitmap(pictureBox7.Image);
            Bitmap bmp8 = new Bitmap(pictureBox8.Image);
            for (int x = 0; x < bmp7.Width; x++)
            {
                for (int y = 0; y < bmp7.Height; y++)
                {
                    if (bmp7.GetPixel(x, y) != bmp8.GetPixel(x, y))
                        return false;
                }
            }
            return true;
        }
        private bool rsm12(PictureBox pictureBox7, PictureBox pictureBox9)
        {
            Bitmap bmp7 = new Bitmap(pictureBox7.Image);
            Bitmap bmp9 = new Bitmap(pictureBox9.Image);
            for (int x = 0; x < bmp7.Width; x++)
            {
                for (int y = 0; y < bmp7.Height; y++)
                {
                    if (bmp7.GetPixel(x, y) != bmp9.GetPixel(x, y))
                        return false;
                }
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //BURADA HATAM TEXTBOXTAKÝ MEVCUT PARA MÝKTARINI EKLEYEMÝYORUM LABEL3 E BU YÜZDEN BU HATAYI DÜZELT.
            //EKLENECEK ÖZELLÝKLER BAZI YAN ÝFADELER DE HATA VAR BU YÜZDE EKLEMELERÝ TAM YAP ÖRNEÐÝN:
            /*
            *-* 
            --- (BURASI YOK MESELA)
            *--
            */
            //KÜÇÜK BÝR ÝNFORMATÝON EKRANI YAPILABÝLÝR MESELA AT YARIÞINDAKÝ GÝBÝ...
            //SANIRIM BET MÝKTARINI DÜZELTTÝM GÝBÝ ONU DA ÝNFORMATÝON EKRANINDA KAVRARIZ.
            label3.Text = Convert.ToString(balance + Convert.ToInt32(textBox2.Text));
            balance = Convert.ToInt32(label3.Text);
            label3.Text = balance.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Game();
        }
    }
}
