using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibBussiness;
using System.IO;
using Util;
using Vaildation;
using ctrlAddPerson.Properties;
using TestOnenericControls;

namespace ctrlAddPerson
{
    public partial class ctrlAddPerson: UserControl
    {
        public ctrlAddPerson()
        {
            InitializeComponent();
        }
        

         public void GetNewPersonID(int PersonID)
        {
            lbPersonID.Text = PersonID.ToString();
            _PersonID = PersonID;
        }

        
        public Action<int> NewPersonID = null;
        public enum enGendor { male = 0,female= 1}
         public enum enMode { add =1,update =2}
        public  enMode _Mode = enMode.add;
        
        private clsPerson _PersonInfo;
        private void _FillComboBoxCountries()
        {
            DataTable dt = clsCountries.GetAllCountries();
            foreach (DataRow row in dt.Rows)
            {
                cbCountry.Items.Add(row["CountryName"]);
            }
        }
        private void _FillDefaultValue()
        {
            _FillComboBoxCountries();
            if (_Mode == enMode.add)
            {
                lbMode.Text = "Add Person";
                lbPersonID.Text = "[????]";
                dt.MaxDate = DateTime.Now.AddYears(-18);
                dt.MinDate = DateTime.Now.AddYears(-100);
                dt.Value = dt.MaxDate;
                cbCountry.SelectedIndex = cbCountry.FindString("Iraq");
                lRemove.Visible = false;
                _PersonInfo = new clsPerson();
                return;
            }
            else
                lbMode.Text = "Update Person";

        }
        private int _PersonID = -1;
        private void _LoadData()
        {
            
            _PersonInfo = clsPerson.FindByPersonID(_PersonID);
            if (_PersonInfo == null)
            {
                MessageBox.Show("this Person ID not Found", "Load Data", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                return;
            }
            txtAddress.Text = _PersonInfo.Address.Trim();
            txtEmail.Text = _PersonInfo.Email;
            txtFullName.Text = _PersonInfo.Name;
            txtPhone.Text = _PersonInfo.Phone;
            txtNationalNo.Text = _PersonInfo.NationalNo;
            dt.Value = _PersonInfo.Birth;
            cbCountry.SelectedIndex =
                    cbCountry.FindString(_PersonInfo.CountryName);
            if (_PersonInfo.ImagePath != null)
                pbImage.ImageLocation = _PersonInfo.ImagePath;

            lRemove.Visible = pbImage.ImageLocation != null;

            lbPersonID.Text = _PersonInfo.PersonID.ToString();

            if (_PersonInfo.Gendor == (Byte)enGendor.male)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;
        }
public int PersonID
        {
            get
            {
                return _PersonID;
            }
        }

        public void LoadDataPerson(int PersonID = -1)
        {
            _Mode = (PersonID==-1?enMode.add:enMode.update);

            _FillDefaultValue();

            if (_Mode == enMode.update)
            {
                _PersonID = PersonID;
                _LoadData();
            }
        }
        private bool _HandelImage()
        {
            if (_PersonInfo.ImagePath!=pbImage.ImageLocation)
            {
                if (_PersonInfo.ImagePath!=null)
                {
                    File.Delete(_PersonInfo.ImagePath);
                }
                if (pbImage.ImageLocation != null)
                {
                    string Path = pbImage.ImageLocation;
                
                   if(!clsUtil.CopyImageToProjectFolder(ref Path))
                    {
                        MessageBox.Show("Failed Create Image in Folder");
                        return false;
                    }

                    else
                    {
                        pbImage.ImageLocation = Path;
                        return true;
                    }
                }
                
            }
            return true;
        }
        private void txtFullName_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtFullName.Text))
            {
                e.Cancel = true;
                txtFullName.Focus();
                errorProvider1.SetError(txtFullName, "this Field is Required");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtFullName, null);
            }
            //handel prevent user enter numbers
            if (clsVaildation.IsNumber(txtFullName.Text))
            {
                e.Cancel = true;
                txtFullName.Focus();
                errorProvider1.SetError(txtFullName, "Wrong this field should not put numbers");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtFullName, null);

            }
        }

        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {
            //if ((_Mode==enMode.update&& txtNationalNo.Text == _PersonInfo.NationalNo))
            //{
            //    e.Cancel = true;
            //    txtNationalNo.Focus();
            //    errorProvider1.SetError(txtNationalNo, "this Nationa No Used By Another Person");
            //    return;
            //}
            //else
            //{
            //    e.Cancel = false;
            //    errorProvider1.SetError(txtNationalNo, null);
            //}
            if (string.IsNullOrEmpty(txtNationalNo.Text))
            {
                e.Cancel = true;
                txtNationalNo.Focus();
                errorProvider1.SetError(txtNationalNo, "this Field is Required");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNationalNo, null);

            }
            if (clsVaildation.IsNumber(txtNationalNo.Text))
            {
                e.Cancel = true;
                txtNationalNo.Focus();
                errorProvider1.SetError(txtNationalNo, "you should not enter numbers");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNationalNo, null);
            }

            if (clsPerson.IsNationalNoExist(txtNationalNo.Text)
                && txtNationalNo.Text != _PersonInfo.NationalNo)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNationalNo, "this National no used by another person.");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNationalNo, null);
            }




        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                e.Cancel = true;
                txtPhone.Focus();
                errorProvider1.SetError(txtPhone, "this Field is Required");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPhone, null);

            }
            // handel txtPhone must be numbers
            if (!clsVaildation.IsNumber(txtPhone.Text))
            {
                e.Cancel = true;
                txtPhone.Focus();
                errorProvider1.SetError(txtPhone, "you must enter only Numbers");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPhone, null);

            }

        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (txtEmail.Text == "")
            {
                return;
            }

            // handel Email Patteren
            if (!clsVaildation.VaildationEmail(txtEmail.Text))
            {
                e.Cancel = true;
                txtEmail.Focus();
                errorProvider1.SetError(txtEmail, "this Email not vail");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtEmail, null);

            }

        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            //txtAddress
            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                e.Cancel = true;
                txtAddress.Focus();
                errorProvider1.SetError(txtAddress, "this Field is Required");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtAddress, null);
            }
            // handel address should not enter numbers first.
            if (clsVaildation.IsNumber(txtAddress.Text))
            {
                e.Cancel = true;
                txtAddress.Focus();
                errorProvider1.SetError(txtAddress, "you should not enter numbers");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtAddress, null);
            }
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            NewPersonID = GetNewPersonID;
        }
 

        private void Save(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some Fiels are still Empty");
                return;
            }

            // handel Image
            if (!_HandelImage())
                return;

            int CountryID = clsCountries.FindByCountryName(cbCountry.Text).CountryID;
            _PersonInfo.Name = txtFullName.Text;
            _PersonInfo.NationalNo = txtNationalNo.Text;
            _PersonInfo.Email = txtEmail.Text;
            _PersonInfo.Nationality = CountryID;
            _PersonInfo.Birth = dt.Value;
            _PersonInfo.Phone = txtPhone.Text;
            _PersonInfo.Address = txtAddress.Text;
            
            if (rbMale.Checked)
                _PersonInfo.Gendor = (Byte)enGendor.male;
            else
                _PersonInfo.Gendor = (Byte)enGendor.female;

            if (pbImage.ImageLocation != null)
                _PersonInfo.ImagePath = pbImage.ImageLocation;

            if (!_PersonInfo.Save())
            {
                MessageBox.Show("Failed Saving Data",
                                "Add Person", MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Saved Successfully");
            NewPersonID(_PersonInfo.PersonID);
            _Mode = enMode.update;
            btnSave.Enabled = false;
            lbMode.Text = "Update Person";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void OnChangeGendor(object sender, EventArgs e)
        {
            if (rbFemale.Checked)
            {
                pbImage.Image = Resources.girl;
            }
            else
            {
                pbImage.Image = Resources.man;
            }

        }

        private void pbImage_Click(object sender, EventArgs e)
        {

        }

        private void SaveImage(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Images File |*.png;*.jpeg;*.jpg;*.bmp;*.gif";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                string Path = openFileDialog1.FileName;
                pbImage.ImageLocation = Path;
            }
        
            lRemove.Visible = true;
        
        }

        private void Remove(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbImage.ImageLocation = null;
            
            if (rbFemale.Checked)
            {
                pbImage.Image = Resources.girl;
            }
            else
            {
                pbImage.Image = Resources.man;
            }
            lRemove.Visible = false;
        }
    }
}
