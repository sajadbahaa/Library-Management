using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib.People
{
    public partial class frmFindPerson : Form
    {
        public frmFindPerson()
        {
            InitializeComponent();
        }

        public frmFindPerson(int PersonID)
        {
            InitializeComponent();
            ctrlPersonWithFilter1.FilterEnable = false;
            ctrlPersonWithFilter1.LoadDataPerson(PersonID);
        }

        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFindPerson_Load(object sender, EventArgs e)
        {

        }
    }
}
