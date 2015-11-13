using ACM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ACM.Win
{
    public partial class CustomerWin : Form
    {
        CustomerRepository customerRepository = new CustomerRepository();
        public CustomerWin()
        {
            InitializeComponent();
        }

        private void GetCustomersButton_Click(object sender, EventArgs e)
        {
            // CustomerGridView.DataSource = customerRepository.Retrieve();


        }

    }
}