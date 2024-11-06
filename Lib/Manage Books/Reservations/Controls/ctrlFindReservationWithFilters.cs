using LibBussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib.Manage_Books.Reservations.Controls
{
    public partial class ctrlFindReservationWithFilters : UserControl
    {
        public ctrlFindReservationWithFilters()
        {
            InitializeComponent();
        }
        public Action<clsReservation> OnReservationSelected;
        public virtual void OnReservationInfoSelected(clsReservation e)
        {
            OnReservationSelected?.Invoke(e);
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
        public clsReservation ReservationSelected
        {
            get
            {
                return ctrlReservationInfo1.ReservationInfo;
            }
        }
        public void FindNow()
        {
            switch (cbFilter.Text)
            {
                case "ReservationID":
                    ctrlReservationInfo1.LoadDataByReservationID(int.Parse(txtFilter.Text));
                    break;
            }
            if (FilterEnable && OnReservationSelected != null)
                OnReservationInfoSelected(ReservationSelected);
        }
        private void ctrlFindReservationWithFilters_Load(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 0;
        }

        private void txtFilter_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilter.Text))
            {
                e.Cancel = true;
                txtFilter.Focus();
                errorProvider1.SetError(txtFilter, "this field is required!");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtFilter,"");
            }
        }

        
        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        
        {
            if (e.KeyChar==(char)13)
            {
                btnSearch.PerformClick();
                txtFilter.Text = "".Trim();
            }
            if (cbFilter.Text == "ReservationID")
                e.Handled = (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar));

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("some field are still required");
                return;
            }
            if (txtFilter.Text == "")
                return;

            FindNow();
        }

        private void ctrlReservationInfo1_Load(object sender, EventArgs e)
        {

        }
    }
}
