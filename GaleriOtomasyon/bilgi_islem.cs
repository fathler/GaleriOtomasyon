using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GaleriFacade;
using GaleriOtomasyon;
using Galeri;
using Galeri.Entity;
using System.Data.SqlClient;
using Galeri.DAL;
namespace GaleriOtomasyon
{
    public partial class bilgi_islem : Form
    {
        public bilgi_islem()
        {
            InitializeComponent();
        }
        //Personel Ekleme
        private void personelButon_Click(object sender, EventArgs e)
        {
            PersonelEntity EklenecekpersonelEntity = new PersonelEntity();
            BilgiislemFacade EklenecekPersonelFacade = new BilgiislemFacade();

            EklenecekpersonelEntity.PersonelTC = personelTCtxtBx.Text;
            EklenecekpersonelEntity.PersonelAd =personelAdtxtbx.Text;
            EklenecekpersonelEntity.PersonelSoyad = personelSoyadTxtbx.Text;
            EklenecekpersonelEntity.PersonelTEL = personelTelTxtBx.Text;
            EklenecekpersonelEntity.PersonelAdres = personelAdresTxtbx.Text;
            EklenecekpersonelEntity.PersonelMaas = Decimal.Parse(personelMaasTxtbx.Text);
            EklenecekpersonelEntity.iseGirisTarihi = Convert.ToDateTime(isegirisdatetime.Value);
            EklenecekpersonelEntity.istenAyrilmaTarihi = Convert.ToDateTime(istenayrilmadatetime.Value);
            int netice1 = EklenecekPersonelFacade.PersonelEklemeSPile(EklenecekpersonelEntity);
            MessageBox.Show(netice1 > 0 ? "Personel başarı ile eklendi" : "Ekleme başarısız");
        }

        private void musteriEkleButo_Click(object sender, EventArgs e)
        {

        }

        private void bilgi_islem_Load(object sender, EventArgs e)
        {
            // listview sütunlarının oluşturulması 
            BilgiislemListview.Items.Clear();
            BilgiislemListview.GridLines = true;
            BilgiislemListview.View = View.Details;
            BilgiislemListview.Columns.Add("Personel ID", 50);
            BilgiislemListview.Columns.Add("Personel TC", 150);
            BilgiislemListview.Columns.Add("Ad", 100);
            BilgiislemListview.Columns.Add("Soyad", 100);
            BilgiislemListview.Columns.Add("Tel", 150);
            BilgiislemListview.Columns.Add("Adres", 80);
            BilgiislemListview.Columns.Add("Maaş", 100);
            BilgiislemListview.Columns.Add("İşe Giriş Tarihi", 100);
            BilgiislemListview.Columns.Add("İşten Ayrılma Tarihi", 100);


            SqlDataReader dr = HelperSql.SqlOkuyucuDondurWithSp("Select * from tbl_personel", false, null);

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["personelID"].ToString());
                    item.SubItems.Add(dr["personelTC"].ToString());
                    item.SubItems.Add(dr["personelAd"].ToString());
                    item.SubItems.Add(dr["personelSoyad"].ToString());
                    item.SubItems.Add(dr["personelTel"].ToString());
                    item.SubItems.Add(dr["personelAdres"].ToString());
                    item.SubItems.Add(dr["personelMaas"].ToString());
                    item.SubItems.Add(dr["iseGirisTarihi"].ToString());
                    item.SubItems.Add(dr["istenAyrilmaTarihi"].ToString());
                    BilgiislemListview.Items.Add(item);
                }

            }
        }
        //Tıklanan Textbox Textinin silinmesi
        private void personelTCtxtBx_Click(object sender, EventArgs e)
        {
            personelTCtxtBx.Clear();
        }

        private void personelAdtxtbx_Click(object sender, EventArgs e)
        {
            personelAdtxtbx.Clear();
        }

        private void personelSoyadTxtbx_Click(object sender, EventArgs e)
        {
            personelSoyadTxtbx.Clear();
        }

        private void personelTelTxtBx_Click(object sender, EventArgs e)
        {
            personelTelTxtBx.Clear();
        }

        private void personelAdresTxtbx_Click(object sender, EventArgs e)
        {
            personelAdresTxtbx.Clear();
        }

        private void personelMaasTxtbx_Click(object sender, EventArgs e)
        {
            personelMaasTxtbx.Clear();
        }

        //Boş kalan Textbox isminin geri yazılması
        private void bilgi_islem_Click(object sender, EventArgs e)
        {
            if (personelTCtxtBx.Text == "")
            {
                personelTCtxtBx.Text = "TC Kimlik";
            }
            if (personelAdtxtbx.Text == "")
            {
                personelAdtxtbx.Text = "İsim";
            }
            if (personelSoyadTxtbx.Text == "")
            {
                personelSoyadTxtbx.Text = "Soyisim";

            }
            if (personelTelTxtBx.Text == "")
            {
                personelTelTxtBx.Text = "Telefon";
            }
            if (personelAdresTxtbx.Text == "")
            {
                personelAdresTxtbx.Text = "Adres";
            }
            if (personelMaasTxtbx.Text == "")
            {
                personelMaasTxtbx.Text = "Maaş";
            }
        }

        private void personelMaasTxtbx_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
    
