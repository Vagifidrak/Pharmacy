using Pharmacy.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class AddMedicine : Form
    {
        PharmacyDB DB;
        int LocX = 10;
        int LocY = 20;
        int LocXMar = 10;
        int LocYMar = 20;

        public AddMedicine()
        {
            DB = new PharmacyDB();
            InitializeComponent();
        }
        #region Exit Button
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        #endregion

        #region Fill Select Combo
        private void FillSelectCombo(string name)
        {
            if (name == "Firm")
            {
                cmbFirms.Items.AddRange(DB.Firms.Select(fr => fr.FIrmName).ToArray());

            }
            else
            {
                cmbTags.Items.AddRange(DB.Tags.Select(tg => tg.TagName).ToArray());
            }
        }
        #endregion


        #region AddMedicine Load
        private void AddMedicine_Load(object sender, EventArgs e)
        {
            FillSelectCombo("Firm");
            FillSelectCombo("");
        }
        #endregion

        #region Add Tags
        private void AddAllTags()
        {
            if (SameTag(cmbTags.Text))
                {
                Button btnTag = new Button();
                btnTag.Text = cmbTags.Text;
                btnTag.FlatStyle = FlatStyle.Flat;
                btnTag.BackColor = Color.LightGreen;
                btnTag.ForeColor = Color.White;
                btnTag.Location = new Point(LocX, LocY);

                if (btnTag.Width + LocX >= grpTagGroup.Width)
                {
                    LocX = LocXMar;
                    LocY += btnTag.Height + LocYMar;
                }

                btnTag.Location = new Point(LocX, LocY);
                LocX += btnTag.Width + LocXMar;
                grpTagGroup.Controls.Add(btnTag);
            }
        }
        #endregion

        #region SameTag
        private bool SameTag(string btnText)
        {
            foreach (Control bt  in grpTagGroup.Controls)
            {
                if(bt.Text == btnText)
                {
                    return false;
                }
            }
            return true;
        }


        #endregion


        private void cmbTags_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddAllTags();
        }
    }
}
