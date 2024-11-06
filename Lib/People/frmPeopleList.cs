using Lib.People;
using LibBussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestOnenericControls;

namespace Lib
{
    public partial class frmPeopleList : Form
    {
        public frmPeopleList()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private DataView dtv;
         private async Task  GetRecords()
        {
            dtv = clsPerson.GetAllPeople().DefaultView;
            dtgPeople.DataSource = dtv;
            lbRecord.Text = dtv.Count.ToString();
            await Task.Delay(0);
        }
         private void frmPeopleList_Load(object sender, EventArgs e)
        {
            
            //DataTable dt = clsPerson.GetAllPeople();
            Task t1 = GetRecords();
            cbFilter.SelectedIndex = 0;
            txtFilter.Visible = false;
            
            //dtv = clsPerson.GetAllPeople().DefaultView;
            //dtgPeople.DataSource = dtv;
            //lbRecord.Text = dtv.Count.ToString();
        
        }
        private void GetFilter()
        {
            string FilterColumn = "";
            
            switch (cbFilter.Text)
            {
                case "PersonID":
                    FilterColumn = "PersonID";
                    break;
                case "NationalNo":
                    FilterColumn = "NationalNo";
                    break;
                case "FullName":
                    FilterColumn = "FullName";
                    break;
                default:
                    FilterColumn = "None";
                    break;
            }
            if (txtFilter.Text==""||FilterColumn =="None")
            {
                dtv.RowFilter = "";
                return;
            }
            if (FilterColumn != "NationalNo"&& FilterColumn != "FullName")
            {
                dtv.RowFilter = $"{FilterColumn} = {txtFilter.Text}";

            }
            else
            {
                dtv.RowFilter = $"{FilterColumn} Like'" + txtFilter.Text + "%'";

            }
            dtgPeople.DataSource = dtv;
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
            GetFilter();
        }

        private void AddPerson(object sender, EventArgs e)
        {
            frmAddPerson frm = new frmAddPerson();
            frm.ShowDialog();
            frmPeopleList_Load(null, null);
        }

        private void UpdatePerson(object sender, EventArgs e)
        {
            frmAddPerson frm = new frmAddPerson((int)dtgPeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmPeopleList_Load(null, null);
        }

        private void showPersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowPersonInfo frm = new frmShowPersonInfo((int)dtgPeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmPeopleList_Load(null, null);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure delete this Person? ",
                "Person Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.No)
                return;

            if (clsPerson.Delete((int)dtgPeople.CurrentRow.Cells[0].Value))
                MessageBox.Show("Deleted Successfully");
            else
                MessageBox.Show("error: this Person linked with Another Table"
                    , "Delete Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
            frmPeopleList_Load(null, null);

        }

        private void findPersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFindPerson frm = new frmFindPerson((int)dtgPeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmPeopleList_Load(null, null);
        }

        
    }
}
