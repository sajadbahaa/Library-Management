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

namespace Lib.Books.BookTypes
{
    public partial class frmBookTypesList : Form
    {
        public frmBookTypesList()
        {
            InitializeComponent();
        }
        DataView dtv;
        private void frmBookTypesList_Load(object sender, EventArgs e)
        {
            dtv = clsBookTypes.GetAllBookType().DefaultView;
            dtgview.DataSource = dtv;
            lbRecord.Text = dtgview.RowCount.ToString();
        }
    }
}
