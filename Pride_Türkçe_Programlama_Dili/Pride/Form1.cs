using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace Pride
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void projeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ızgara.Text = "Program{\n\n\n\n}";
            program.Text = "";
            listBox1.Items.Clear();

        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Proje Dosyası|*.amo";
            openFileDialog1.ShowDialog();
            try { ızgara.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText); this.Text = "Ahmetet"; this.Text += "     "+openFileDialog1.SafeFileName.ToString(); } catch { }
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Proje Dosyası|*.amo";
            saveFileDialog1.ShowDialog();

            try { ızgara.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText); } catch { }
        }

        private void derleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            goruntuler.Items.Clear();
            sayilar.Items.Clear();
            listBox1.Items.Clear();
            main.Text = ızgara.Text.ToLower();
            only_fonksiyon.Items.Clear();
            program.Text = "";

            // PROGRAM ve parantezlerini kontrol et BAŞLA
            int a, b, program_satırı;
            program_satırı = -1;
            int suslu_parantez_baslangic = -1;
            int suslu_parantez_bitis = -1;
            b = main.Lines.Length;
            for (a = 0; a < b; a++)     // BÜTÜN SATIRLARI TARA
            {
                if (main.Lines[a].Contains("program")) { program_satırı = a; break; } // EĞER ilk satırdan son satıra kadar program görürsen ilk görüdğün programı main olarak al

            }
            for (a = 0; a < b; a++)     // SUSLU BASLANGIC
            {
                if (program_satırı <= a)
                {
                    if (main.Lines[a].Contains("{")) { suslu_parantez_baslangic = a; break; } // EĞER ilk satırdan son satıra kadar } görürsen ilk görüdğün programı main olarak al
                }
                else
                {
                    // bb
                }
            }
            for (a = 0; a < b; a++)     // SUSLU BİTİŞ
            {
                if (program_satırı <= a)
                {
                    if (main.Lines[a].Contains("}")) { suslu_parantez_bitis = a; break; } // EĞER ilk satırdan son satıra kadar { görürsen ilk görüdğün programı main olarak al
                }
                else
                {
                    // bb
                }
            }
            //  MessageBox.Show("Program satırı: " + program_satırı.ToString() + "\t suslu baslangic: " + suslu_parantez_baslangic.ToString() + "\t suslu bitis: " + suslu_parantez_bitis.ToString());


            // PROGRAM ve parantezlerini kontrol et BİTİR

            // PROGRAM KODLARINI AYIKLA
            program.Text = "";
            String icinitoparla = "";
            bool sinyal = false;
            if (suslu_parantez_baslangic == suslu_parantez_bitis)
            {
                //    MessageBox.Show("beynim yandı");
                // Program{blabla}
                int referanssatir = suslu_parantez_baslangic; // veya bitis aynı zaten
                foreach (char eleman in ızgara.Lines[referanssatir])
                {
                    if (eleman == '{')
                    {
                        //Başladı
                        sinyal = true;

                    }
                    else if (eleman == '}')
                    {

                        // Bitir
                        break;
                    }

                    if (sinyal == true)
                    {
                        icinitoparla = icinitoparla + eleman.ToString();
                    }



                }
                icinitoparla = icinitoparla.Substring(1, icinitoparla.Length - 1);
                //   MessageBox.Show(icinitoparla);
                program.Text = icinitoparla;
            }


            else
            {
                for (int suslu_baslangic_prototip = program_satırı + 1; suslu_baslangic_prototip < suslu_parantez_bitis; suslu_baslangic_prototip++)
                {
                    program.Text = program.Text + ızgara.Lines[suslu_baslangic_prototip] + Environment.NewLine;


                }
            }


            // kaç tane { var o kadar fonk vardır
            int adet = 0;

            for (int basla = 0; basla < ızgara.Lines.Length; basla++)
            {
                //MessageBox.Show(ızgara.Lines[basla]);
                if (main.Lines[basla].Contains("{")) { adet += 1; }
            }


            int[] parantezler = new int[adet];

            int saytekrar = -1;
            for (int basla = 0; basla < ızgara.Lines.Length; basla++)
            {
                //MessageBox.Show(ızgara.Lines[basla]);
                if (main.Lines[basla].Contains("{")) { saytekrar += 1; parantezler[saytekrar] = basla; }
            }
            //    MessageBox.Show(adet.ToString() + " Adet yapı bulundu!");
            int kisacasay = 0;
            string parantezekadarolan = "";
            string yapiicerigi = "";
            foreach (int hereleman in parantezler)
            {
                parantezekadarolan = "";
                kisacasay = 0;
                yapiicerigi = "";
                // MessageBox.Show(hereleman.ToString());
                // HER BİR PARANTEZİN OLDUĞU SATIR İÇİN
                foreach (char karakter in ızgara.Lines[hereleman]) // PARANTEZİN OLDUĞU SATIRDAKİ DİĞER ŞEYLER
                {
                    kisacasay += 1;

                    // MessageBox.Show(karakter.ToString());
                }
                if (kisacasay == 1)
                {
                    parantezekadarolan = ızgara.Lines[hereleman - 1].ToString();

                    //  MessageBox.Show("Satırda sadece parantez var");
                    // ARKADAKİ SATIRLARI KONTROL ET!!
                }
                else
                {

                    // MessageBox.Show("yalız değil");
                    kisacasay = 0;
                    // PARANTEZE KADAR OLANLAR FONKSİYON İSMİDİR!!
                    foreach (char karakter in ızgara.Lines[hereleman]) // PARANTEZİN OLDUĞU SATIRDAKİ DİĞER ŞEYLER
                    {
                        kisacasay += 1;
                        if (karakter == '{')
                        {
                            break;
                        }
                        else
                        {
                            parantezekadarolan = parantezekadarolan + karakter.ToString();
                        }
                        // MessageBox.Show(karakter.ToString());
                    }
                }



                int o = 0;
                int herparantezinoldugusatir = hereleman;
                while (herparantezinoldugusatir < main.Lines.Length) // Her bir parantez için,olduğu satır ve sonraki satırlara bakacak } bulursa duracak
                {


                    foreach (char herbirsatirdakiherbirelemanicin in main.Lines[herparantezinoldugusatir])
                    {
                        if (herbirsatirdakiherbirelemanicin == '}')
                        {
                            //    MessageBox.Show("Şu:" + hereleman.ToString() + " " + herparantezinoldugusatir.ToString());
                            o = herparantezinoldugusatir;
                            // yapiicerigi degiskenini doldur... // Fonksiyonun içeriği
                            int start, finish;

                            finish = herparantezinoldugusatir;
                            for (start = hereleman + 1; start < finish; start++)
                            {
                                //    MessageBox.Show(ızgara.Lines[start]);
                                yapiicerigi = yapiicerigi + ızgara.Lines[start] + Environment.NewLine;
                            }
                            break;
                        }
                    }

                    if (o > 0)
                    {
                        break;
                    }
                    else
                    {
                        herparantezinoldugusatir += 1;
                    }
                }



                if (parantezekadarolan == "")
                { // nothing

                }
                else
                {

                    //     MessageBox.Show("Bulunan yapı ismi: " + parantezekadarolan);
                }

                listBox1.Items.Add(parantezekadarolan + "→" + yapiicerigi + "");
                only_fonksiyon.Items.Add(parantezekadarolan);
                //  MessageBox.Show("Kısacasay: " + kisacasay.ToString());

            }


            Mainicin();

            // PROGRAM KODLARI AYIKLANDI
        }
        String orjprogram;
        void Mainicin() // yapı bloklarını dahil et
        {

            foreach (String satır in program.Lines)
            {
                orjprogram = program.Text;
                if (satır == "") { }
                else
                {
                    // MessageBox.Show(satır);
                    foreach (string hersınıf in only_fonksiyon.Items)
                    {
                        if (satır.Contains(hersınıf))
                        {
                            program.Text = orjprogram;
                            // SATIRDA YAPILARDAN BİRİSİ BULUNDU
                            program.Text = program.Text.Replace(satır, listBox1.Items[only_fonksiyon.Items.IndexOf(hersınıf)].ToString().Split('→')[1]);
                            // MessageBox.Show(listBox1.Items[only_fonksiyon.Items.IndexOf(hersınıf)].ToString().Split('→')[1]);
                        }
                        else
                        {
                            // BULUNAMADI
                        }
                    }


                }

            }
            İşle(program);

            ÖZEL_FONKSİYON_YAZ(program);

        }
        void İşle(RichTextBox RTB)
        {
            foreach (String satır in RTB.Lines)
            {

                if (satır.ToLower().Contains("saat"))
                {
                    program.Text = program.Text.Replace("saat", DateTime.Now.TimeOfDay.ToString());

                }

                if (satır.ToLower().Contains("tarih"))
                {

                    program.Text = program.Text.Replace("tarih", DateTime.Now.ToString("M/d/yyyy"));
                }
                if (satır.ToLower().Contains("sayı"))
                {

                    // Sayı x = 5
                    //  0   1 2 3
                    //MessageBox.Show(satır.Split()[1]+" = " +satır.Split()[3]);

                    if (sayilar.Items.Contains(satır.Split()[1]))
                    {
                        // ekleme

                        foreach (string a in sayilar.Items)
                        {
                            if (satır.Split()[1] == a)
                            {
                                goruntuler.Items[sayilar.Items.IndexOf(satır.Split()[1])] = satır.Split()[3]; break;
                            }


                        }
                    
                    }

                    else
                    {
                        try
                        {
                            sayilar.Items.Add(satır.Split()[1]);
                            goruntuler.Items.Add(satır.Split()[3]);
                        }
                        catch
                        {

                        }

                    }

                 


                }
                if (satır.ToLower().Contains("=") && !satır.ToLower().Contains("sayı"))
                {
                 
                    String kafa = satır.Split('=')[0].Trim();
                    if (sayilar.Items.Contains(kafa))
                    {
                        String topla = satır.Split('=')[1].Trim();
                        bool herangi = false;

                        if (topla.Contains("+"))
                        {
                            foreach (string degerlendir in topla.Split(new Char[] { ' ', '+', '-', '/', '*' }))
                            {
                                if (sayilar.Items.Contains(degerlendir))
                                {
                                    topla = topla.Replace(degerlendir, goruntuler.Items[sayilar.Items.IndexOf(degerlendir)].ToString());
                                }

                            }

                        //    MessageBox.Show(topla);
                            int sayı1, sayı2;

                            if (int.TryParse(topla.Split('+')[0].Trim(), out sayı1) && int.TryParse(topla.Split('+')[1].Trim(), out sayı2))
                            {
                                // sayı1 + sayı2
                                goruntuler.Items[sayilar.Items.IndexOf(kafa)] = (sayı1+sayı2).ToString();
                                herangi = true;
                            }
                           
                        }

                        if (topla.Contains("-"))
                        {
                            foreach (string degerlendir in topla.Split(new Char[] { ' ', '+', '-', '/', '*' }))
                            {
                                if (sayilar.Items.Contains(degerlendir))
                                {
                                    topla = topla.Replace(degerlendir, goruntuler.Items[sayilar.Items.IndexOf(degerlendir)].ToString());
                                }

                            }

                            //    MessageBox.Show(topla);
                            int sayı1, sayı2;

                            if (int.TryParse(topla.Split('-')[0].Trim(), out sayı1) && int.TryParse(topla.Split('-')[1].Trim(), out sayı2))
                            {
                                // sayı1 + sayı2
                                goruntuler.Items[sayilar.Items.IndexOf(kafa)] = (sayı1 - sayı2).ToString();
                                herangi = true;
                            }

                        }

                        if (topla.Contains("/"))
                        {
                            foreach (string degerlendir in topla.Split(new Char[] { ' ', '+', '-', '/', '*' }))
                            {
                                if (sayilar.Items.Contains(degerlendir))
                                {
                                    topla = topla.Replace(degerlendir, goruntuler.Items[sayilar.Items.IndexOf(degerlendir)].ToString());
                                }

                            }

                            //    MessageBox.Show(topla);
                            int sayı1, sayı2;

                            if (int.TryParse(topla.Split('/')[0].Trim(), out sayı1) && int.TryParse(topla.Split('/')[1].Trim(), out sayı2))
                            {
                                // sayı1 + sayı2
                                goruntuler.Items[sayilar.Items.IndexOf(kafa)] = (sayı1 / sayı2).ToString();
                                herangi = true;
                            }

                        }
                        if (topla.Contains("*"))
                        {
                            foreach (string degerlendir in topla.Split(new Char[] { ' ', '+', '-', '/', '*' }))
                            {
                                if (sayilar.Items.Contains(degerlendir))
                                {
                                    topla = topla.Replace(degerlendir, goruntuler.Items[sayilar.Items.IndexOf(degerlendir)].ToString());
                                }

                            }

                            //    MessageBox.Show(topla);
                            int sayı1, sayı2;

                            if (int.TryParse(topla.Split('*')[0].Trim(), out sayı1) && int.TryParse(topla.Split('*')[1].Trim(), out sayı2))
                            {
                                // sayı1 + sayı2
                                goruntuler.Items[sayilar.Items.IndexOf(kafa)] = (sayı1 * sayı2).ToString();
                                herangi = true;
                            }

                        }




                        if (herangi == true)
                        {

                        }
                        else
                        {
                            goruntuler.Items[sayilar.Items.IndexOf(kafa)] = satır.Split('=')[1].Trim();

                        }

                    }
                    else
                    {

                    }
                }


            }



            //x = 5    sayilar x goruntu 5
            //yaz "x"  yaz 5
            //x = 6    sayilar x goruntu 6
            //yaz "x"  yaz 6
        
        }
        void ÖZEL_FONKSİYON_YAZ(RichTextBox RTB)
        {
            foreach (String satır in RTB.Lines)
            {
                if (satır.ToLower().Contains("yaz"))
                {
                    // MessageBox.Show(satır);

                    String topla = "";
                    try
                    {
                        topla = satır.ToString().Split('"')[1].Replace('"', ' ').TrimEnd();


                        foreach (string degerlendir in topla.Split(new Char[] { ' ', '+', '-', '/', '*' }))
                        {
                            if (sayilar.Items.Contains(degerlendir))
                            {
                                topla = topla.Replace(degerlendir, goruntuler.Items[sayilar.Items.IndexOf(degerlendir)].ToString());
                            }

                        }

                        bool herangi = false;

                        if (topla.Contains("+"))
                        {

                            int sayı1, sayı2;
                            if (int.TryParse(topla.Split('+')[0].Trim(), out sayı1) && int.TryParse(topla.Split('+')[1].Trim(), out sayı2))
                            {
                                MessageBox.Show((sayı1 + sayı2).ToString());
                                herangi = true;
                            }
                        }
                        if (topla.Contains("-"))
                        {
                            int sayı1, sayı2;
                            if (int.TryParse(topla.Split('-')[0].Trim(), out sayı1) && int.TryParse(topla.Split('-')[1].Trim(), out sayı2))
                            {
                                MessageBox.Show((sayı1 - sayı2).ToString());
                                herangi = true;
                            }
                        }
                        if (topla.Contains("/"))
                        {
                            int sayı1, sayı2;
                            if (int.TryParse(topla.Split('/')[0].Trim(), out sayı1) && int.TryParse(topla.Split('/')[1].Trim(), out sayı2))
                            {
                                MessageBox.Show((sayı1 / sayı2).ToString());
                                herangi = true;
                            }
                        }
                        if (topla.Contains("*"))
                        {
                            int sayı1, sayı2;
                            if (int.TryParse(topla.Split('*')[0].Trim(), out sayı1) && int.TryParse(topla.Split('*')[1].Trim(), out sayı2))
                            {
                                MessageBox.Show((sayı1 * sayı2).ToString());
                                herangi = true;
                            }
                        }
                        if (herangi == true)
                        {

                        }
                        else
                        {
                            MessageBox.Show(topla);

                        }

                    }


                    catch { }
                    // yaz "ahmetet"
                    // ahmetet"


                }
            }

        }
        int bul(string bulunacak) { return main.GetLineFromCharIndex(main.Find(bulunacak)); }

        void SatırDeğiştir(RichTextBox RTB, int satır, string yazı)
        {
            int s1 = RTB.GetFirstCharIndexFromLine(satır);
            int s2 = satır < RTB.Lines.Count() - 1 ?
                      RTB.GetFirstCharIndexFromLine(satır + 1) - 1 :
                      RTB.Text.Length;
            RTB.Select(s1, s2 - s1);
            RTB.SelectedText = yazı;

        }

        private void fonksiyonToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            String fonksiyon_ismi = "Örnek";

            ızgara.Text = ızgara.Text + "\n" + fonksiyon_ismi + "{\n\n\n}";

        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ızgara.Text = "Test1{\nYaz \"Bunu kesinlikle almayacaksın\"\n}\nProgram{\nYaz \"Bunu alacaksın\"\n}\nTest2{\nYaz \"Bunu da almayacaksın\"\n}";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(listBox1.SelectedItem.ToString());
                MessageBox.Show(listBox1.SelectedItem.ToString().Split('→')[1]);
            }
            catch { }
        }

     
    }
}
