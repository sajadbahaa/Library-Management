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

namespace Lib.Users.Registers
{
    public partial class frmAllRegisters : Form
    {
        public frmAllRegisters()
        {
            InitializeComponent();
        }
        private DataView dtview;
        private void frmAllRegisters_Load(object sender, EventArgs e)
        {
            dtview = clsRegisters.GetAllRegisters().DefaultView;
            dtgview.DataSource = dtview;
            lbRecord.Text = dtview.Count.ToString();
        }
        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
