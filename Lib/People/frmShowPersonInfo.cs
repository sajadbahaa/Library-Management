﻿using System;
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
    public partial class frmShowPersonInfo : Form
    {
        private int _PersonID = -1;
        public frmShowPersonInfo(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
            ctrlPersoninfo1.LoadPersonInfoByPersonID(_PersonID);
        }
        public frmShowPersonInfo(string NationalNo)
        {
            InitializeComponent();
            
            ctrlPersoninfo1.LoadPersonInfoByNationalNo(NationalNo);
            _PersonID = ctrlPersoninfo1.PersonID;
        }
        private void frmShowPersonInfo_Load(object sender, EventArgs e)
        {
        }

        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
