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

namespace Lib.Manging_Fines
{
    public partial class frmPayFine : Form
    {

        int _FineID = -1;
        
    enum enUpdate { Manualy =1,Dirctlly = 2}
        enUpdate Mode = enUpdate.Manualy;
        public frmPayFine(int FineID)
        {
            InitializeComponent();
            ctrlShareScreen1.LoadTitleInfo("Pay Fine");
            ctrlFindFineWithFilter1.FilterEnable = false;
            _FineID = FineID;
            Mode = enUpdate.Dirctlly;
        }

        private void _LoadData()
        {
            ctrlFindFineWithFilter1.LoadFineData(_FineID);
            if (ctrlFindFineWithFilter1.FineInfoSelected.IsPay)
            {
                chIsPay.Checked = true;
                _RestDefualtValue();
                return;
            }
            lbMessage.Visible = false;
            btnPayFine.Enabled = true;
            ctrlFindFineWithFilter1.FilterEnable = true;
            chIsPay.Enabled = true;
        }

        public frmPayFine()
        {
            InitializeComponent();
        
            ctrlShareScreen1.LoadTitleInfo("Pay Fine");
        
        }

        private void frmPayFine_Load(object sender, EventArgs e)
        {
            if (Mode == enUpdate.Dirctlly)
                _LoadData();
            else
                lbMessage.Visible = false;
        }

    private void Close(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ctrlFindFineWithFilter1_OnFineInfoSelected(LibBussiness.clsFines obj)
        {
           
            if (obj==null)
            {
                lbMessage.Visible = false;
                return;
            }

            if (obj.IsPay)
            {
                chIsPay.Checked = true;
                _RestDefualtValue();
                return;
            }

            btnPayFine.Enabled = true;
            ctrlFindFineWithFilter1.FilterEnable = true;
            chIsPay.Enabled = true;

        }
        private void _RestDefualtValue()
        {
            lbMessage.Visible = true;
            btnPayFine.Enabled = false;
           // ctrlFindFineWithFilter1.FilterEnable = false;
            chIsPay.Enabled = false;
        }
        private void OnbtnPayFine(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some Field is required");
                return;
            }
            
            ctrlFindFineWithFilter1.FineInfoSelected.IsPay = chIsPay.Checked ? true : false;
            ctrlFindFineWithFilter1.FineInfoSelected.UserID = clsGlobal.CurrentUser.UserID;
            if (!ctrlFindFineWithFilter1.FineInfoSelected.Save())
            {
                MessageBox.Show("Failed Paying Fine");
                return;
            }

            MessageBox.Show("Paying Fine Successfully");
            btnPayFine.Enabled = false;
        }
    }
}
