
using ctrlAddPerson;
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
    public partial class frmAddPerson : Form
    {
        public  enum enMode { add = 1,update = 2}
        
        public frmAddPerson()
        {
            InitializeComponent();  
            ctrlAddPerson1.LoadDataPerson();
        }
        public Action<int> AddNewPerson  = null;

        public frmAddPerson(int PersonID)
        {
            InitializeComponent();
           ctrlAddPerson1.LoadDataPerson(PersonID);
        }
       
        private void frmAddPerson_Load(object sender, EventArgs e)
        {
        }

        private void Close(object sender, EventArgs e)
        {
            if (ctrlAddPerson1.PersonID == -1)
            {
                this.Close();
                return;
            }

            AddNewPerson?.Invoke(ctrlAddPerson1.PersonID);
            
                this.Close();

            }

        private void ctrlAddPerson1_Load(object sender, EventArgs e)
        {

        }
    }
    }
