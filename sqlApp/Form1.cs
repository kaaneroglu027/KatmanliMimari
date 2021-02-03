using Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using BussinesLogicLayer_BLL;

namespace sqlApp
{
    public partial class Form1 : Form
    {
        //hata kodu 87, -1
        private SqlConnection cn = null;

        public int ogrenciid = 0;

        public Form1()
        {
            InitializeComponent();
        }

        #region Notlar

        //sql server'a baglantı yapacagız
        //connectionString : sql server adresi, gereken kimlik dogrulama bilgileri(User=sa;Password=123), veritabanı adi
        //Insert, Update, Delete: ExecuteNonQuery()
        //Select:ExecuteReader()
        //SqlInjection ''+123'' tek tırnak kullanmayla sisteme sızma girme ihtimalleri oluyor

        #endregion Notlar

        private void buton_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                #region Uzun yol

                //Ogrenci o = new Ogrenci();
                //o.Ad = textbox_ad.Text.Trim();
                //o.Soyad = textbox_soyad.Text.Trim();
                //o.Numara = textbox_numara.Text.Trim();
                //bool sonuc = OgrenciEkle(o);

                #endregion Uzun yol

                #region constractor olmadan

                //kısa tek satırda tanımlama
                //bool sonuc = OgrenciEkle(new Ogrenci
                //{
                //    Ad = textbox_ad.Text.Trim(),
                //    Soyad = textbox_soyad.Text.Trim(),
                //    Numara = textbox_numara.Text.Trim()
                //});

                #endregion constractor olmadan

                //constractor kullanılmıs hali
                OgrenciBl obl = new OgrenciBl();
                bool sonuc = obl.OgrenciEkle(new Ogrenci(textbox_ad.Text.Trim(), textbox_soyad.Text.Trim(), textbox_numara.Text.Trim()));

                if (sonuc)
                {
                    MessageBox.Show("işlem basarılı");
                }
                else
                {
                    MessageBox.Show("işlem basarısız, tekrar deneyiniz!");
                }
            }
            catch (SqlException ex)
            {
                //throw;
                if (ex.Number == 2627)
                {
                    //unique key hatası
                    MessageBox.Show("Bu numara daha önce kaydedilmiş!", "Uyarı!");
                }
                else
                {
                    MessageBox.Show($"Veritabanı Hatası! " +
                        $"\nHata Kodu:{ex.Number}", "Uyarı!");
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("sistem hatası!");
                // ex.Message loglanacak.
            }
            catch (Exception)
            {
                MessageBox.Show("Bir şeyler ters gitti!");
            }

            //buna gerek kalmadı, using garbage temizledi
            //finally
            //{
            //    CloseConnection();
            //}

            #region kullanmayacagımız ornekler

            /*SqlCommand cmd = new SqlCommand($"Intert Into tbl_Ogrenciler(Ad, Soyad, Numara) " +
                $"values('{textbox_ad.Text}', '{textbox_soyad.Text}', '{textbox_numara.Text}')", cn);*/
            /*SqlParameter p = new SqlParameter("@Ad", textbox_ad.Text);
            SqlParameter p1 = new SqlParameter("@Soyad", textbox_soyad.Text);
            SqlParameter p2 = new SqlParameter("@Numara", textbox_numara.Text);*/

            //parametreleri ve commandı birbirinden haberdar etme
            /*cmd.Parameters.Add(p);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);*/
            /* if (sonuc > 0)
            {
                MessageBox.Show("Kayıt Yapıldı!", "Uyarı");
            }
            else
            {
                MessageBox.Show("Kayıt Başarısız!", "Uyarı");
            }*/

            #endregion kullanmayacagımız ornekler
        }

        private void CloseConnection()
        {
            //throw
            //null check
            if (cn != null && cn.State != ConnectionState.Closed)
            {
                cn.Close();
            }
        }

        private void Temizle()
        {
            textbox_ad.Text = "";
            textbox_soyad.Text = "";
            textbox_numara.Text = "";
        }

        private frmKitapBul frmogrenci = new frmKitapBul();

        private void buton_aramafrm_Click(object sender, EventArgs e)
        {
            frmogrenci.ShowDialog();
        }

        private void buton_update_Click(object sender, EventArgs e)
        {
            if (ogrenciid == 0)
            {
                MessageBox.Show("Önce öğrenci secmelisiniz!!");
            }
            else
            {
                using (cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString))
                {
                    //SqlInjection ataklarını kapattık!
                    SqlCommand cmd = new SqlCommand("Update tbl_Ogrenciler set Ad= @Ad, Soyad= @Soyad, Numara=@Numara " +
                        "where OgrenciId=@OgrenciId", cn);

                    //parametre dizisinde tuttma
                    SqlParameter[] p =
                    {
                        new SqlParameter("@OgrenciId", ogrenciid),
                        new SqlParameter("@Ad", textbox_ad.Text.Trim()),
                        new SqlParameter("@Soyad", textbox_soyad.Text.Trim()),
                        new SqlParameter("@Numara", textbox_numara.Text.Trim())
                    };
                    cmd.Parameters.AddRange(p);

                    if (cn != null && cn.State != ConnectionState.Open)
                    {
                        cn.Open();
                    }

                    int sonuc = cmd.ExecuteNonQuery();//bu metot yazılan insert kısmını calıstırıyor. - insert, update, delete kısmında kullanılır

                    if (sonuc > 0)
                    {
                        MessageBox.Show("işlem basarılı");
                        Temizle();
                        ogrenciid = 0;
                    }
                    else
                    {
                        MessageBox.Show("işlem basarısız");
                    }
                }
            }
        }

        private void buton_sil_Click(object sender, EventArgs e)
        {
            if (ogrenciid == 0)
            {
                MessageBox.Show("Önce öğrenci secmelisiniz!!");
            }
            else
            {
                DialogResult result = MessageBox.Show("Ögrenciyi silmek istediginizden emin misiniz?", "Kayıt silme onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    using (cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString))
                    {
                        //SqlInjection ataklarını kapattık!
                        SqlCommand cmd = new SqlCommand("Delete from tbl_Ogrenciler where OgrenciId=@OgrenciId", cn);

                        //parametre dizisinde tuttma
                        SqlParameter[] p = { new SqlParameter("@OgrenciId", ogrenciid) };
                        cmd.Parameters.AddRange(p);

                        if (cn != null && cn.State != ConnectionState.Open)
                        {
                            cn.Open();
                        }

                        int sonuc = cmd.ExecuteNonQuery();//bu metot yazılan insert kısmını calıstırıyor. - insert, update, delete kısmında kullanılır

                        if (sonuc > 0)
                        {
                            MessageBox.Show("işlem basarılı");
                            Temizle();
                            ogrenciid = 0;
                        }
                        else
                        {
                            MessageBox.Show("işlem basarısız");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Kayıt işlemi iptal edildi.");
                }
            }
        }
    }
}