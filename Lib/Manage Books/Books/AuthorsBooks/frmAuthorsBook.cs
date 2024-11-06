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

namespace Lib.Books.AuthorsBooks
{
    public partial class frmAuthorsBook : Form
    {
        private int _AuthorID;
        public frmAuthorsBook(int AuthorID)
        {
            InitializeComponent();
            _AuthorID = AuthorID;
        }

        private void frmAuthorsBook_Load(object sender, EventArgs e)
        {
            ctrlAuthorsBookList1.LoadAuthorData(_AuthorID);
        }
    }
}
