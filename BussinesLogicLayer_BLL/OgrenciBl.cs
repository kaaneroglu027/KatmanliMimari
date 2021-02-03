using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DataAccessLayer_DAL;
using System.Data.SqlClient;

namespace BussinesLogicLayer_BLL
{
    public class KitapBl
    {
        public bool KitapEkle(Kitap ktp)
        {
            try
            {
                if (ktp == null)
                {
                    throw new NullReferenceException("Kitap Referansı null geldi!");
                }
                //parametre dizisinde tuttma
                SqlParameter[] p =
                {
                    new SqlParameter("@KitapAD", ktp.Ad),
                    new SqlParameter("@Sayfası", ktp.Sayfasi),
                    new SqlParameter("@Yazari", ktp.Yazari),
                };
                Helper hlp = new Helper();
                return hlp.ExecuteNonQuery("Insert into tbl_Kitap values(@Ad, @Sayfası, @Yazari)", p) > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}