using Global;
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

namespace Lib.Users.Registers.RegisterByUser
{
    public partial class frmRegisterByUser : Form
    {
        
        public frmRegisterByUser()
        {
            InitializeComponent();

        }

        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }
        private DataView dtv;
        private void frmRegisterByUser_Load(object sender, EventArgs e)
        {
            dtv = clsRegisters.GetRegisterByUserID(12).DefaultView;
            dtgview.DataSource = dtv;
            lbRecord.Text = dtgview.RowCount.ToString();
        }
    }
}
