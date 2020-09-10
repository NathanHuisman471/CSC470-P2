using P2_Code.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2_Code
{
    public partial class FormSeeFish : Form
    {
        public string _Fish;
        
        
        public FormSeeFish(string selectedFish)
        {
            InitializeComponent();
            _Fish = selectedFish;
            

        }

        private void FormSeeFish_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            LoadPictures();
        }

        void LoadPictures()
        {
            switch (_Fish)
            {
                case "Crappie":
                    pictureBoxFish.Image = Resources.Crappie;
                    break;

                case "Perch":
                    pictureBoxFish.Image = Resources.Perch;
                    break;

                case "Walleye":
                    pictureBoxFish.Image = Resources.Walleye;
                    break;

            }

            pictureBoxFish.SizeMode = PictureBoxSizeMode.StretchImage;

                    
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            
            this.Close();
            
        }

        private void buttonThrowItBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonKeepIt_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }
    }
}
