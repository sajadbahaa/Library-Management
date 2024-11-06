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

namespace Lib
{
    public partial class frmNotify : Form
    {
        public frmNotify()
        {
            InitializeComponent();
        }
       

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private DataView dtv;
        private void frmNotify_Load(object sender, EventArgs e)
        {
            dtv = clsNotify.GetAllNotify().DefaultView;
            dtgview.DataSource = dtv;
        }
    }
}
