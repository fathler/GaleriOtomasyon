using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaleriOtomasyon
{
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            gosteriPaneli.Controls.Add(childForm);
            gosteriPaneli.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        //bilgi_islem bilgiislemform = new bilgi_islem();


        private void BilgiislemButon_Click(object sender, EventArgs e)
        {
            //bilgiislemform.MdiParent = this;
            //bilgiislemform.Show();
            openChildForm(new bilgi_islem());
        }

        private void GarajButon_Click(object sender, EventArgs e)
        {
            openChildForm(new Envanter());
        }

        private void AracSatisButon_Click(object sender, EventArgs e)
        {
            openChildForm(new AracSatisSayfası());
        }
    }
}
