using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestOnenericControls;

namespace Lib.People
{
    public partial class ctrlPersonWithFilter : UserControl
    {
        public ctrlPersonWithFilter()
        {
            InitializeComponent();
        }

        private void ctrlPersonWithFilter_Load(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 0;
        }
        public clsPerson PersonSelected
        {
            get
            {
                return ctrlPersoninfo1.PersonSelected;
            }
        }

        private bool _FilterEnable = true;
        public bool FilterEnable
        {
            get
            {
                return _FilterEnable;
            }
            set
            {
                _FilterEnable = value;
                gbFilter.Enabled = _FilterEnable;
            }

        }


        public int PersonID
        {
            get
            {
                return ctrlPersoninfo1.PersonID;
            }
        }
        private void FindNow()
        {
            switch (cbFilter.Text)
            {

                case "PersonID":
                    ctrlPersoninfo1.LoadPersonInfoByPersonID(int.Parse(txtFilter.Text));
                    break;
                case "NationalNo":
                    ctrlPersoninfo1.LoadPersonInfoByNationalNo(txtFilter.Text.Trim());
                    break;
            }

        }

        private void SeachFor(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("some field are still not completed");
                return;
            }
            if (txtFilter.Text == "")
                return;

            FindNow();
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)13)
            {
                btnSearch.PerformClick();
                txtFilter.Text = "".Trim();
            }

            if (cbFilter.Text == "PersonID")
            {
                e.Handled = (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar));
            }



        }

        private void txtFilter_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilter.Text))
            {
                e.Cancel = true;
                txtFilter.Focus();
                errorProvider1.SetError(txtFilter, "this fild is requied");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtFilter, null);
            }
        }

        public void FilterFocuse()
        {
            txtFilter.Focus();
        }

        private void ctrlPersonCardWithFilter_Load(object sender, EventArgs e)
        {



        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter.Text = "".Trim();
        }
        public void LoadDataPerson(int PersonID)
        {
            cbFilter.SelectedIndex = 1;
            txtFilter.Text = PersonID.ToString();
            ctrlPersoninfo1.LoadPersonInfoByPersonID(PersonID);
        }
        private void _LoadPersonData(int PersonID)
        {
            LoadDataPerson(PersonID);
        }

        private void AddPerson(object sender, EventArgs e)
        {
            frmAddPerson frm = new frmAddPerson();
            frm.AddNewPerson += _LoadPersonData;
            frm.ShowDialog();
        }

        private void ctrlPersoninfo1_Load(object sender, EventArgs e)
        {

        }
    }
}
