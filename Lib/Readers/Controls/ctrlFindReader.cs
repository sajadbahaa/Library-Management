using LibBussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib.Readers
{
    
    public partial class ctrlFindReader : UserControl
    {
        public ctrlFindReader()
        {
            InitializeComponent();
        }
        public class clsReaderInfo
        {
            public  clsReader ReaderInfo { get;}
            public clsReaderInfo(clsReader ReaderInfo)
            {
                this.ReaderInfo = ReaderInfo;
            }
        }
        public event EventHandler<clsReaderInfo> OnReaderSelected;
        public virtual void OnReaderInfoSelected(clsReaderInfo e)
        {
            OnReaderSelected?.Invoke(this, e);
        }
        public void OnReaderInfoSelected(clsReader ReaderInfo)
        {
            OnReaderInfoSelected(new clsReaderInfo(ReaderInfo));
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private clsReader _ReaderInfo;
       
        public clsReader ReaderInfo
        {
            get
            {
                return _ReaderInfo;
            }
            set
            {
                _ReaderInfo = value;
            }
        
        }
        public int ReaderID { get
            {
                return _ReaderID;
            }
        }

        private int _ReaderID = -1 ;

        private void _LoadData()
        {
            ctrlPersoninfo1.LoadPersonInfoByPersonID(_ReaderInfo.PersonID);
            _ReaderID = _ReaderInfo.ReaderID;
        }
        public void LoadDataByPersonID(int PersonID)
        {
            _ReaderInfo = clsReader.FindByPersonID(PersonID);
            if (_ReaderInfo == null)
            {
                _RestDefaultValue();
                MessageBox.Show("this Person ID not Found");
                return;
            }

            _LoadData();

        }
        public void LoadReaderData(int ReaderID)
        {

            cbFilter.SelectedIndex = 1;
            txtFilter.Text = ReaderID.ToString();
            LoadDataByReaderID(ReaderID);
            return;
        }
        private void _RestDefaultValue()
        {

            _ReaderID = -1;
            ctrlPersoninfo1._RestDefualValue();
        }

        public void LoadDataByReaderID (int ReaderID) 
        {
            _ReaderInfo = clsReader.FindByReaderID(ReaderID);
            if (_ReaderInfo==null)
            {
                MessageBox.Show("this Reader ID not Found");
                _RestDefaultValue();
                return;
            }
            _LoadData();
        }
        private bool _FilterEnable = true;
        public bool FilterEnable
        {
            get
            {
                return _FilterEnable;
            }
            set
            {
                _FilterEnable = value;
                gbFilter.Enabled = _FilterEnable;
            }
        }
        public void FindNow()
        {

            switch (cbFilter.Text)
            {
                case "PersonID":
                    LoadDataByPersonID(int.Parse(txtFilter.Text));
                    break;
                case "ReaderID":
                    LoadDataByReaderID(int.Parse(txtFilter.Text));
                    break;
            }
            if (FilterEnable&&OnReaderSelected!=null)
            {
                OnReaderInfoSelected(_ReaderInfo);
            }

        }

        public void GetNewReader(int ReaderID)
        {
            cbFilter.SelectedIndex = 0;
            txtFilter.Text = ReaderID.ToString();
            _ReaderID = ReaderID;
            FindNow();
        }

        private void ctrlReaderInfo_Load(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 1;
        }

        private void Search(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("SomeField are still Required");
                return; 
            }
            if (txtFilter.Text == "")
                return;

            FindNow();
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)13)
            {
                btnSearch.PerformClick();
                txtFilter.Text = "".Trim();
            }
            if (cbFilter.Text == "PersonID")
            {
                e.Handled
        = (!char.IsControl(e.KeyChar) &&!char.IsDigit(e.KeyChar));

            }
            if (cbFilter.Text == "ReaderID")
            {
                e.Handled
        = (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar));
            }

        }

        private void txtFilter_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilter.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFilter,"Error");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtFilter,null);
            }
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter.Text = "".Trim();
        }

        private void AddReader(object sender, EventArgs e)
        {
            frmAddReader frm = new frmAddReader();
            frm._DataBack = GetNewReader;
            frm.ShowDialog();
        }
    
    }
}
