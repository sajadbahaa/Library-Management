using LibBussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib.Manging_Fines.Controls
{
    public partial class ctrlFindFineWithFilter : UserControl
    {
        public event Action<clsFines> OnFineInfoSelected;
        
        public virtual void OnFineSelected(clsFines e)
        {
            OnFineInfoSelected?.Invoke(e);
        }
        public ctrlFindFineWithFilter()
        {
            InitializeComponent();
        }
        public clsFines FineInfoSelected
        {
            get
            {
                return ctrlFineInfo1.FineInfo;
            }
        }
        private void FindNow()
        {
            switch (cbFilter.Text)
            {
                case "ReaderID":
                    ctrlFineInfo1.LoadFineInfoReaderID(int.Parse(txtSearch.Text));
                    break;
                case "FineID":
                    ctrlFineInfo1.LoadFineInfoByFineID(int.Parse(txtSearch.Text));
                    break;
                default :
                    ctrlFineInfo1.LoadFineInfoReaderID(int.Parse(txtSearch.Text));
                    break;
            }

            if (FilterEnable&&OnFineInfoSelected!=null)
            {
                OnFineSelected(FineInfoSelected);
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
        
        public void LoadFineData(int FineID)
        {
            cbFilter.SelectedIndex = 2;
            txtSearch.Text = FineID.ToString();
            FindNow();
        }
        private void ctrlFindFineWithFilter_Load(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 2; 
        }
        public void RestDefualtData()
        {
            ctrlFineInfo1._RestDefaultValue();
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnSearch.PerformClick();
                txtSearch.Text = "".Trim();
            }

            if (cbFilter.Text == "ReaderID"|| cbFilter.Text == "ReaderID"||cbFilter.Text=="None")
                e.Handled = (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar));
        
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("some field is required");
                return;
            }
            if (txtSearch.Text == "")
                return;
            
            FindNow();
        }

        private void txtSearch_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                e.Cancel = true;
                txtSearch.Focus();
                errorProvider1.SetError(txtSearch, "this Field Is Required");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtSearch, "");
            }
            
        }
    }
}
