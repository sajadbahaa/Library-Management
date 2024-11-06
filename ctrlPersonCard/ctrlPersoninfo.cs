using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ctrlPersonCard.Properties;
using TestOnenericControls;
using Lib.People;
using BankSystem.GlobalClasses;

namespace ctrlPersonCard
{
    public partial class ctrlPersoninfo: UserControl
    {
        public enum enGendor { male =0,female =1}
        
        public ctrlPersoninfo()
        {
            InitializeComponent();
        }
        private int _PersonID = -1;
        public int PersonID
        {
            get
            {
                return _PersonID;
            }
        }

        private clsPerson _PersonInfo;
        public clsPerson PersonSelected
        {
            get
            {
                return _PersonInfo;
            }
        }
        
        private void _HandelImage()
        {
            if (_PersonInfo==null)
            {
                pbImage.Image = Resources.UnKnownPerson;
                return;
            }

            if (_PersonInfo.ImagePath==null)
            {
                if (_PersonInfo.Gendor==(Byte)enGendor.male)
                {
                    pbImage.Image = Resources.man;
                }
                else
                {
                    pbImage.Image = Resources.girl1;
                }
                return;
            }

                pbImage.ImageLocation = _PersonInfo.ImagePath;

            return;

        }
        public  void _RestDefualValue()
        {
            _PersonID = -1;
            lbPersonID.Text  = "[????]";
            lbAddress.Text   = "[????]";
            lbBirth.Text     = "[????]";
            lbEmail.Text     = "[????]";
            lbGendor.Text    = "[????]";
            lbName.Text      = "[????]";
lbNationality.Text           = "[????]";
            lbNationalNo.Text= "[????]";
            lbPhone.Text     = "[????]";
            lleditPerson.Enabled = false;
            _PersonInfo = null;

            _HandelImage();         
        }
        public void LoadPersonInfoByPersonID(int PersonID)
        {
            _PersonInfo = clsPerson.FindByPersonID(PersonID);
            if (_PersonInfo == null)
            {
                MessageBox.Show("this Person ID not found");
                _RestDefualValue();
                return;
            }
            LoadPersonData();
        }
        public void LoadPersonInfoByNationalNo(string NationalNo)
        {
            _PersonInfo = clsPerson.FindByNationalNo(NationalNo);
            if (_PersonInfo == null)
            {
                MessageBox.Show("this Person ID not found");
                _RestDefualValue();
                return;
            }
            LoadPersonData();
        }
        private void LoadPersonData()
        {
            lleditPerson.Enabled = true;

            _PersonID = _PersonInfo.PersonID;
            lbPersonID.Text = _PersonInfo.PersonID.ToString();
            lbAddress.Text = _PersonInfo.Address;
           lbBirth.Text = clsFormat.DateToString(_PersonInfo.Birth);
            lbEmail.Text = _PersonInfo.Email;
            lbGendor.Text = (_PersonInfo.Gendor==0?"Male":"Female");
            lbName.Text = _PersonInfo.Name;
            lbNationality.Text = _PersonInfo.CountryName;
            lbNationalNo.Text = _PersonInfo.NationalNo;
            lbPhone.Text = _PersonInfo.Phone;
            _HandelImage();
        }

        private void EditPerson(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddPerson frm = new frmAddPerson(_PersonID);
            frm.ShowDialog();
            LoadPersonInfoByPersonID(_PersonID);
        }
    
        private void ctrlPersoninfo_Load(object sender, EventArgs e)
        {


        }

        private void pbImage_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
