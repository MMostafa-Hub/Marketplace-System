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
    public partial class ProductForm : GenericForm
    {
        Product pro;
        Form ProForm;

        public ProductForm(Product pro , Form ProForm)
        {
            InitializeComponent();
            this.pro = pro;
            this.ProForm = ProForm;
        }



        private void BT2_Click(object sender, EventArgs e)
        {

        }
    }
}
