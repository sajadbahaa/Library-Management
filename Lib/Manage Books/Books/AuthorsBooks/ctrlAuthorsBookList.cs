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

namespace Lib.Books.AuthorsBooks
{
    public partial class ctrlAuthorsBookList : UserControl
    {
        public ctrlAuthorsBookList()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private int _Athour = -1;
        private DataView _dtv;
        private  void _LoadAuthorBookList() 
        {
            _dtv = clsBooks.GetAllBooksByAuthorID(_Athour).DefaultView;
            dtgview.DataSource = _dtv;
            lbRecord.Text = dtgview.RowCount.ToString();
        }
        public void LoadAuthorData(int AuthorID)
        {
            _Athour = AuthorID;
            ctrlPersoninfo1.LoadPersonInfoByPersonID(_Athour);
            _LoadAuthorBookList();
        }
        private void ctrlAuthorsBookList_Load(object sender, EventArgs e)
        {

        }
    }
}
