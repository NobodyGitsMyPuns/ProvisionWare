using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proCart;

namespace ProvisionwareClient
{
    public partial class NameForm : Form
    {
        private Requestor requestor;

        public NameForm()
        {
            InitializeComponent();
            requestor = new Requestor("default", "user");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //click on the Submit Button
        private void Button1_Click(object sender, EventArgs e)
        {
            FormCli session = new FormCli(requestor);
            Hide();
            session.FormClosed += (s, args) => Close();
            session.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //text box for first name
        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {
            this.requestor.setFirstName(textBoxFirstName.Text);
        }

        //text box for last name
        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {
            this.requestor.setLastName(textBoxLastName.Text);
        }
    }
}
