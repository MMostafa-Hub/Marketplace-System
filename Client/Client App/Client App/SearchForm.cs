using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_App
{
    public partial class SearchForm : Form
    {
        private Form backForm;
        public SearchForm(Form backForm)
        {
            InitializeComponent();
            this.backForm = backForm;   
        }

		private void btn_back_Click(object sender, EventArgs e)
		{
            this.Close();
            backForm.Show();
        }
	}
}
