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
using Galeri.Entity;
using Galeri.DAL;
using System.Data.SqlClient;
using System.Configuration;

namespace GaleriOtomasyon
{
    public partial class Envanter : Form
    {
        public Envanter()
        {
            InitializeComponent();
        }


        //Comboboxlar için veri çekme
        public void Envanter_Load(object sender, EventArgs e)
        {
            SqlDataReader Okuyucu = HelperSql.SqlOkuyucuDondurWithSp("sp_AracMarkaTablosuDoldurma", true, null);
            if (Okuyucu.HasRows)
            {
                while (Okuyucu.Read())
                {
                    MarkaCombobox.Items.Add(Okuyucu["marka"].ToString());
                }
            }
            Okuyucu.Close();
            aracgoruntulemeListView.LabelEdit = true;

            // listview sütunlarının oluşturulması 
            aracgoruntulemeListView.Items.Clear();
            aracgoruntulemeListView.GridLines = true;
            aracgoruntulemeListView.View = View.Details;
            aracgoruntulemeListView.Columns.Add("Araç ID", 50);
            aracgoruntulemeListView.Columns.Add("Araç Plaka", 150);
            aracgoruntulemeListView.Columns.Add("Marka", 100);
            aracgoruntulemeListView.Columns.Add("Model", 100);
            aracgoruntulemeListView.Columns.Add("Araç Durum", 150);
            aracgoruntulemeListView.Columns.Add("Trafiğe Çıkış", 80);
            aracgoruntulemeListView.Columns.Add("Araç Km", 100);
            aracgoruntulemeListView.Columns.Add("Araç Geliş Fiyat", 100);
            aracgoruntulemeListView.Columns.Add("Araç Satış Fiyat", 100);
            aracgoruntulemeListView.Columns.Add("Satış Durumu", 100);

            SqlDataReader dr = HelperSql.SqlOkuyucuDondurWithSp("Select * from tbl_arac", false, null);

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["aracID"].ToString());
                    item.SubItems.Add(dr["aracPlaka"].ToString());
                    item.SubItems.Add(dr["markaID"].ToString());
                    item.SubItems.Add(dr["modelID"].ToString());
                    item.SubItems.Add(dr["aracDurum"].ToString());
                    item.SubItems.Add(dr["aracYil"].ToString());
                    item.SubItems.Add(dr["aracKM"].ToString());
                    item.SubItems.Add(dr["aracGelisFiyat"].ToString());
                    item.SubItems.Add(dr["aracSatisFiyat"].ToString());
                    aracgoruntulemeListView.Items.Add(item);
                }

            }

            satilmisAraclistView.Items.Clear();
            satilmisAraclistView.GridLines = true;
            satilmisAraclistView.View = View.Details;
            satilmisAraclistView.Columns.Add("Araç ID", 50);
            satilmisAraclistView.Columns.Add("Araç Plaka", 150);
            satilmisAraclistView.Columns.Add("Marka", 100);
            satilmisAraclistView.Columns.Add("Model", 100);
            satilmisAraclistView.Columns.Add("Araç Durum", 150);
            satilmisAraclistView.Columns.Add("Trafiğe Çıkış", 80);
            satilmisAraclistView.Columns.Add("Araç Km", 100);
            satilmisAraclistView.Columns.Add("Araç Geliş Fiyat", 100);
            satilmisAraclistView.Columns.Add("Araç Satış Fiyat", 100);
            satilmisAraclistView.Columns.Add("Satış Durumu", 100);

        }



        //Yeni Araç Kayıt
        public void aracEkleButton_Click(object sender, EventArgs e)
        {
            AracFacade Aracekleme = new AracFacade();
            AracEntity eklenecekArac = new AracEntity();
            eklenecekArac.AracPlaka = plakatextbox.Text;
            eklenecekArac.AracMarka = MarkaCombobox.SelectedIndex;
            eklenecekArac.AracModel = ModelcomboBox.SelectedIndex;
            eklenecekArac.AracDurum = aracdurumtextBox.Text;
            eklenecekArac.AracYil = trafigecikistextBox.Text;
            eklenecekArac.AracKm = arackmtextbox.Text;
            eklenecekArac.AracGelisFiyat = Decimal.Parse(GelisfiyatTextBox.Text);
            eklenecekArac.AracSatisFiyat = Decimal.Parse(istenenfiyatTextBox.Text);
            eklenecekArac.AracSatisDurumu = satildicheckBox.Checked;
            int netice = Aracekleme.AracEkleSPile(eklenecekArac);
            MessageBox.Show(netice > 0 ? "Araç ekleme başarılı" : "Ekleme başarısız");

            ResimlerEntity resimentit = new ResimlerEntity();
            ResimlerFacade resimfasad = new ResimlerFacade();
            ImageConverter fotodonusturucu = new ImageConverter();

            Image fotograf = pictureBox2.Image;

            byte[] foto = (byte[])fotodonusturucu.ConvertTo(fotograf, typeof(byte[]));
            resimentit.resim = foto;
            int netice1 = resimfasad.ResimEklemeSpile(resimentit);
            MessageBox.Show(netice1 > 0 ? "Resim ekleme başarılı" : "Ekleme başarısız");
        }


        //Tıklanan textboxun Textinin silinmesi
        private void plakatextbox_Click(object sender, EventArgs e)
        {
            plakatextbox.Clear();
        }
        private void trafigecikistextBox_Click(object sender, EventArgs e)
        {
            trafigecikistextBox.Clear();
        }
        private void aracdurumtextBox_Click(object sender, EventArgs e)
        {
            aracdurumtextBox.Clear();
        }
        private void arackmtextbox_Click(object sender, EventArgs e)
        {
            arackmtextbox.Clear();
        }
        private void GelisfiyatTextBox_Click(object sender, EventArgs e)
        {
            GelisfiyatTextBox.Clear();
        }
        private void istenenfiyatTextBox_Click(object sender, EventArgs e)
        {
            istenenfiyatTextBox.Clear();
        }


        //Silinen Textboxun Textinin Geri Getirilmesi
        private void Envanter_Click(object sender, EventArgs e)
        {
            if (plakatextbox.Text == "")
            {
                plakatextbox.Text = "Plaka";
            }
            if (trafigecikistextBox.Text == "")
            {
                trafigecikistextBox.Text = "Trafiğe Çıkış";
            }
            if (aracdurumtextBox.Text == "")
            {
                aracdurumtextBox.Text = "Araç Durum";
            }
            if (arackmtextbox.Text == "")

            {
                arackmtextbox.Text = "Araç Kilometresi";
            }
            if (GelisfiyatTextBox.Text == "")
            {
                GelisfiyatTextBox.Text = "Geliş Fiyatı";
            }
            if (istenenfiyatTextBox.Text == "")
            {
                istenenfiyatTextBox.Text = "İstenen Fiyat";
            }
        }
        //Seçilen Markanın Modellerinin Getirilmesi
        private void MarkaCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ModelcomboBox.Items.Clear();
            //SqlParameter[] prm = new SqlParameter[1];
            //SqlDataReader Okuyucu1 = HelperSql.SqlOkuyucuDondurWithSp("sp_AracModelTablosuDoldurma", true, prm);
            //prm[0] = new SqlParameter("markaID", MarkaCombobox.SelectedIndex + 1);
            int a = MarkaCombobox.SelectedIndex + 1;
            SqlDataReader Okuyucu1 = HelperSql.SqlOkuyucuDondurWithSp("select modelAd from [dbo].[tbl_aracModel] where markaID=" + a, false, null);
            if (Okuyucu1.HasRows)
            {
                while (Okuyucu1.Read())
                {
                    ModelcomboBox.Items.Add(Okuyucu1["modelAd"].ToString());
                }
            }
            Okuyucu1.Close();
        }
        //Fotoğraf seçilmesi
        private void fotosecButon_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Multiselect = true;
                dialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox2.Image = Image.FromFile(dialog.FileName);
                    //imageLocation = dialog.FileName;
                    //pictureBox2.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata meydana geldi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Veritabanına seçilen fotoğrafın kayıt edilmesi
        private void degisikliklerikaydetButon_Click(object sender, EventArgs e)
        {
            //AracEntity guncellenecekAracentity = new AracEntity();
            //AracFacade guncellemeFacad = new AracFacade();

            //guncellenecekAracentity.AracPlaka = plakatextbox.Text;
            //guncellenecekAracentity.AracMarka = MarkaCombobox.SelectedIndex;
            //guncellenecekAracentity.AracModel = ModelcomboBox.SelectedIndex;
            //guncellenecekAracentity.AracDurum = aracdurumtextBox.Text;
            //guncellenecekAracentity.AracYil = trafigecikistextBox.Text;
            //guncellenecekAracentity.AracKm = arackmtextbox.Text;
            //guncellenecekAracentity.AracGelisFiyat = Decimal.Parse(GelisfiyatTextBox.Text);
            //guncellenecekAracentity.AracSatisFiyat = Decimal.Parse(istenenfiyatTextBox.Text);
            //guncellenecekAracentity.AracSatisDurumu = satildicheckBox.Checked;
            //int netice1 = guncellemeFacad.Arac (guncellenecekAracentity);
            //MessageBox.Show(netice1 > 0 ? "Araç başarı ile güncellendi" : "Güncelleme başarısız");

        }
        //Tıklanan araç bilgilerinin ID'si alınarak güncellenmek üzere Textboxlara getirilmesi
        public void aracgoruntulemeListView_DoubleClick(object sender, EventArgs e)
        {
            /*AracEntity AracIDentity = new AracEntity();*/
            //AracIDentity.AracID = Convert.ToInt32(aracgoruntulemeListView.SelectedItems[0].SubItems[0].Text);
            //AracFacade bilgisigelecekaracfasad = new AracFacade();
            //AracEntity bilgisigelecekaracentity = new AracEntity();
            int p = Convert.ToInt32(aracgoruntulemeListView.SelectedItems[0].SubItems[0].Text);
            SqlParameter[] ID = new SqlParameter[1];
            ID[0] = new SqlParameter("aracID",p);
            SqlDataReader dr = HelperSql.SqlOkuyucuDondurWithSp("sp_birlestirilmisAracGoruntuleme",true,ID);
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    /*bilgisigelecekaracentity.AracPlaka            */
                    plakatextbox.Text = (dr["aracPlaka"].ToString());
                    /*bilgisigelecekaracentity.AracMarka           */
                    MarkaCombobox.Text = (dr["markaID"].ToString());
                    /*bilgisigelecekaracentity.AracModel           */
                    ModelcomboBox.Text = (dr["modelID"].ToString());
                    /*bilgisigelecekaracentity.AracDurum          */
                    aracdurumtextBox.Text = (dr["aracDurum"].ToString());
                    /*bilgisigelecekaracentity.AracYil                 */
                    trafigecikistextBox.Text = (dr["aracYil"].ToString());
                    /*bilgisigelecekaracentity.AracKm                */
                    arackmtextbox.Text = (dr["aracKM"].ToString());
                    /*bilgisigelecekaracentity.AracGelisFiyat     */
                    GelisfiyatTextBox.Text = /*Convert.ToDecimal*/(dr["aracGelisFiyat"].ToString());
                    /*bilgisigelecekaracentity.AracSatisFiyat     */
                    istenenfiyatTextBox.Text = /*Convert.ToDecimal*/(dr["aracSatisFiyat"].ToString());
                    /*bilgisigelecekaracentity.AracSatisDurumu*/
                    satildicheckBox.Checked = Convert.ToBoolean(dr["satisDurum"]);
                    /*bilgisigelecekaracentity.resimID                */ /*= int.Parse(dr["resimID"].ToString());*/
                    //result.Add(bilgisigelecekaracentity);
                }
                dr.Close();
                MessageBox.Show(p.ToString());
                //plakatextbox.Text                = bilgisigelecekaracentity.AracPlaka;
                //MarkaCombobox.Text         = bilgisigelecekaracentity.AracMarka.ToString();
                //ModelcomboBox.Text          =bilgisigelecekaracentity.AracModel.ToString();
                //trafigecikistextBox.Text       = bilgisigelecekaracentity.AracYil;
                //arackmtextbox.Text             = bilgisigelecekaracentity.AracKm;
                //GelisfiyatTextBox.Text          = (bilgisigelecekaracentity.AracGelisFiyat).ToString();
                //istenenfiyatTextBox.Text     = (bilgisigelecekaracentity.AracSatisFiyat).ToString();
                //satildicheckBox.Checked     = Convert.ToBoolean(bilgisigelecekaracentity.AracSatisDurumu);

                //bilgisigelecekaracfasad.AracBilgiGetirmeSpile(bilgisigelecekaracentity);

            }
        }
    }
}