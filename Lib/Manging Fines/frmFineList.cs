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

namespace Lib.Manging_Fines
{
    public partial class frmFineList : Form
    {
        public frmFineList()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        DataView dtv;
        private void frmFineList_Load(object sender, EventArgs e)
        {
            dtv = clsFines.GetAllFines().DefaultView;
            dtgview.DataSource = dtv;
            lbRecord.Text = dtgview.RowCount.ToString();
        }

        private void showFineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowFineInfo frm = new frmShowFineInfo((int)dtgview.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void OnPayFine(object sender, EventArgs e)
        {
            frmPayFine frm = new frmPayFine();
            frm.ShowDialog();
            frmFineList_Load(null, null);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            //bool IsPay = (!(bool)dtgview.CurrentRow.Cells[5].Value);
       
        }

        private void btnpayFine_Click(object sender, EventArgs e)
        {
            frmPayFine frm = new frmPayFine((int)dtgview.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmFineList_Load(null, null);
        }

        private void hisoryOfReaderFinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHistoryReader frm = new frmHistoryReader((int)dtgview.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
            frmFineList_Load(null, null);
        }

        private void findFineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFindFine frm = new frmFindFine();
            frm.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Delete Copy Book",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                if (clsFines.Delete((int)dtgview.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Deleted Successfully");
                    frmFineList_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Fialed Deleting");
                }
            }


        }
    }
}
