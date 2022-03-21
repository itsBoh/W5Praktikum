using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrakWeek5
{
    public partial class FormMateri : Form
    {
        int warnaAktif = 0;
        public FormMateri()
        {
            InitializeComponent();
        }

        private void FormMateri_Load(object sender, EventArgs e)
        {
            listData.Text = "";
            lbOutput.Text = "";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!listData.Items.Contains(txtInput.Text))
                listData.Items.Add(txtInput.Text);
            else
            {
                FormError formError = new FormError();
                formError.ShowDialog();
            }
        }

        private void ckAktif_CheckedChanged(object sender, EventArgs e)
        {
            if (ckAktif.Checked == true)
            {
                warnaAktif = 1;
                if (rdMerah.Checked == true)
                    lbOutput.ForeColor = Color.Red;
                if (rdBiru.Checked == true)
                    lbOutput.ForeColor = Color.Blue;
            }
            if (ckAktif.Checked == false)
            {
                warnaAktif = 0;
                lbOutput.ForeColor = Color.Black;
            }
        }
        private void rdMerah_CheckedChanged(object sender, EventArgs e)
        {
            if (warnaAktif == 1)
                if (rdMerah.Checked == true)
                    lbOutput.ForeColor = Color.Red;
        }
        private void btClear_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
            listData.Items.Clear();
            rdBiru.Checked = false;
            rdMerah.Checked = false;
            lbOutput.ForeColor = Color.Black;
            lbOutput.Text = "";
        }

        private void listData_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbOutput.Text = listData.SelectedItem.ToString();
        }

        private void rdBiru_CheckedChanged(object sender, EventArgs e)
        {
            if (warnaAktif == 1)
                if (rdBiru.Checked == true)
                    lbOutput.ForeColor = Color.Blue;
        }
    }
}
