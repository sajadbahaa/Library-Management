using Lib.Manage_Books.Borrowing.RetrievBooks;
using Lib.Manage_Books.Notify;
using Lib.Manage_Books.Reservations;
using Lib.Users;
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
using Vaildation;

namespace Lib
{
    public partial class frmReservationList : Form
    {
        public frmReservationList()
        {
            InitializeComponent();
        }
        private DataView dtv;
        private void frmReservationList_Load(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 0;
            txtFilter.Visible = false;
            cbIsLock.Visible = false;
            dtv = clsReservation.GetAllReservations().DefaultView;
            dtgview.DataSource = dtv;
            lbRecord.Text = dtgview.RowCount.ToString();
        }
        private void GetFilter()
        {
            string FilterColumn = "";

            switch (cbFilter.Text)
            {
                case "ReservationID":
                    FilterColumn = "ReservationID";
                    break;
                case "CopyID":
                    FilterColumn = "CopyID";
                    break;
                case "ReaderID":
                    FilterColumn = "ReaderID";
                    break;
                default:
                    FilterColumn = "None";
                    break;
            }
            if (txtFilter.Text == "" || FilterColumn == "None")
            {
                dtv.RowFilter = "";
                return;
            }
         
            dtv.RowFilter = $"{FilterColumn} = {txtFilter.Text}";
            dtgview.DataSource = dtv;
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool IsNone = cbFilter.Text == "None" ? true : false;
            bool IsLock = cbFilter.Text == "IsLock";
            txtFilter.Visible = !IsNone && !IsLock;
            cbIsLock.Visible = !IsNone && IsLock;
            
            if (cbIsLock.Visible)
                cbIsLock.SelectedIndex = 0;
        }
        private void _GetFilterIsLock()
        {
            if (cbIsLock.Text=="All")
            {
                dtv.RowFilter = "";
                return;
            }
            
           int result = cbIsLock.Text == "yes" ? 1:0;
            dtv.RowFilter = $"{cbFilter.Text} = {result}";

        }
        private void showReservationInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReservationInfo  frm = new frmReservationInfo((int)dtgview.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmReservationList_Load(null, null);
        }
        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text != "None")
                e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);

        }

        private void addReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReservationScreen frm = new frmReservationScreen();
            frm.ShowDialog();
            frmReservationList_Load(null, null);

        }

        private void findReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFindReservation frm = new frmFindReservation();
            frm.ShowDialog();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            GetFilter();
        }

        private void cbIsLock_SelectedIndexChanged(object sender, EventArgs e)
        {
            _GetFilterIsLock();
        }

        private void notifycationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowNotifyInfo frm = new frmShowNotifyInfo((int)dtgview.CurrentRow.Cells[6].Value);
            frm.ShowDialog();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            try
            {
                int? nullable = (int)dtgview.CurrentRow.Cells[6].Value;
                btnnotifycation.Enabled = true ;
            }
            catch (Exception ex)
            {
                btnnotifycation.Enabled = false;
            }


             //   btnnotifycation.Enabled = (clsVaildation.IsNumber(numb));
        }
    }
}
