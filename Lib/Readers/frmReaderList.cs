using Lib.People;
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
using TestOnenericControls;

namespace Lib.Readers
{
    public partial class frmReaderList : Form
    {
        public frmReaderList()
        {
            InitializeComponent();
        }
        private DataView dtviw;
        private void frmReaderList_Load(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 0;
            txtFilter.Visible = false;

            dtviw = clsReader.GetAllReader_View().DefaultView;
            dtgReader.DataSource = dtviw;
            lbRecord.Text = dtgReader.RowCount.ToString();
        }

        private void OnAddReader(object sender, EventArgs e)
        {
            frmAddReader frm = new frmAddReader();
            frm.ShowDialog();
            frmReaderList_Load(null,null);
        }

        private void updatePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateReader frm = new frmUpdateReader((int)dtgReader.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmReaderList_Load(null, null);

        }

        private void findPersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFindReader frm = new frmFindReader((int)dtgReader.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmReaderList_Load(null, null);

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure delete this Person? ",
              "Person Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
              == DialogResult.No)
                return;

            if (clsReader.Delete((int)dtgReader.CurrentRow.Cells[0].Value))
                MessageBox.Show("Deleted Successfully");
            else
                MessageBox.Show("error: this Reader linked with Another Table"
                    , "Delete Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
            frmReaderList_Load(null, null);

        }

        private void showPersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowPersonInfo frm = new frmShowPersonInfo((int)dtgReader.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
            frmReaderList_Load(null, null);

        }

        private void showReaderInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowReaderInfo frm = new frmShowReaderInfo((int)dtgReader.CurrentRow.Cells[0].Value);
            frm.ShowDialog() ;
            frmReaderList_Load(null, null);
        }

        private void _GetFilter()
        {
            string FilterColumn = "";
            switch (cbFilter.Text)
            {
                case "PersonID":
                    FilterColumn = "PersonID";
                    break;
                case "ReaderID":
                    FilterColumn = "ReaderID";
                    break;
                case "Name":
                    FilterColumn = "Name";
                    break;
                case "Username":
                    FilterColumn = "Username";
                    break;
                case "LibraryCardNumber":
                    FilterColumn = "LibraryCardNumber";
                    break;
                default:
                    FilterColumn = "None";
                        break;
            }
            if (txtFilter.Text=="".Trim()||FilterColumn=="None")
            {
                dtviw.RowFilter = "";
                return;
            }
            if (FilterColumn!="Name"&&FilterColumn!="LibraryCardNumber"
                &&FilterColumn!="Username")
            {
                dtviw.RowFilter = $"{FilterColumn} = {txtFilter.Text}";
            }
            else
            {
                dtviw.RowFilter = $"{FilterColumn}  Like'" +txtFilter.Text+ "%'";
            }
            dtgReader.DataSource = dtviw;
        }
        

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.Text!="None")
            {
                txtFilter.Visible = true;
            }
            else
            {
                txtFilter.Visible = false;
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            _GetFilter();
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text=="PersonID"||cbFilter.Text=="ReaderID")
            {
                e.Handled = (!char.IsControl(e.KeyChar)&&!char.IsDigit(e.KeyChar));
            }
        }
    }
}
