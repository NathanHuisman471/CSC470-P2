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
        public string FishToSee;
        public FormMain()
        {
            InitializeComponent();
            CenterToScreen();

            
        }

        private void buttonSeeFish_Click(object sender, EventArgs e)
        {


            if (radioButtonCrappie.Checked)
            {
                FishToSee = "Crappie";
                
            }else if (radioButtonPerch.Checked)
            {
                FishToSee = "Perch";
                
            }
            else if (radioButtonWalleye.Checked)
            {
                FishToSee = "Walleye";
                
            }

            FormSeeFish Create = new FormSeeFish(FishToSee);
            DialogResult result = Create.ShowDialog();

            if (result == DialogResult.OK)
            {
                
            }
            else
            {
                MessageBox.Show("Decision canceled");
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

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
