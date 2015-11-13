using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACM;

namespace ACM.Win
{
    public partial class customerWin : Form
    {
        CustomerRepository CustomerRepository = new CustomerRepository();
        public CustomerWin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CustomerGridView.DataSource = CustomerRepository.Retrieve();
        }
    }
}
