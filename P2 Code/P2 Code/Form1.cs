using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2_Code
{
    public partial class FormMain : Form
    {
        public string choice;
        public FormMain()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void buttonSeeFish_Click(object sender, EventArgs e)
        {


            if (radioButtonCrappie.Checked)
            {
                choice = "crappie";
                FormSeeFish formSeeFish = new FormSeeFish(choice);
                DialogResult result = formSeeFish.ShowDialog();
            }else if (radioButtonPerch.Checked)
            {
                choice = "perch";
                FormSeeFish formSeeFish = new FormSeeFish(choice);
                DialogResult result = formSeeFish.ShowDialog();
            }
            else if (radioButtonWalleye.Checked)
            {
                choice = "walleye";
                FormSeeFish formSeeFish = new FormSeeFish(choice);
                DialogResult result = formSeeFish.ShowDialog();
            }
            
        }

        private void radioButtonCrappie_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonPerch_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonWalleye_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
