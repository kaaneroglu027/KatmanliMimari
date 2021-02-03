using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace sqlApp
{
    public partial class frmKitapBul : Form
    {
        private SqlConnection cn = null;

        public frmKitapBul()
        {
            InitializeComponent();
        }

        private void buton_ogrencibul_Click(object sender, EventArgs e)
        {
            //Initial Catalog=OkulDb
            using (cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString))
            {
                //SqlInjection ataklarını kapattık!
                SqlCommand cmd = new SqlCommand("Select OgrenciId, Ad, Soyad, Numara from tbl_Ogrenciler where Numara = @Numara", cn);

                //parametre dizisinde tuttma
                SqlParameter[] p =
                {
                        new SqlParameter("@Numara", textbox_ogrencino.Text.Trim())
                };
                cmd.Parameters.AddRange(p);

                if (cn != null && cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    //acık olan form1 i al frm ye aktar
                    Form1 frm = (Form1)Application.OpenForms["Form1"];
                    frm.textbox_ad.Text = dr["Ad"].ToString();
                    frm.textbox_soyad.Text = dr["Soyad"].ToString();
                    frm.textbox_numara.Text = dr["Numara"].ToString();
                    frm.ogrenciid = Convert.ToInt32(dr["Ogrenciid"]);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Öğrenci bulunamadı");
                }
                dr.Close();
            }
        }
    }

    #region interface, implemek etmek

    //deneme class'ı IDisposable interface'ini implement etti
    //implement uygulamak demek, entegre etmek

    internal class Deneme : IDisposable, IDeneme
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }

    internal class Test : Test2
    {
    }

    internal class Test2
    {
    }

    internal interface IDeneme
    {
    }

    #endregion interface, implemek etmek
}