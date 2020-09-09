using P2_Code.Properties;
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
    public partial class FormSeeFish : Form
    {
        public string _SelectedFish;
        
        public FormSeeFish(string selectedFish)
        {
            InitializeComponent();
            _SelectedFish = selectedFish;
            

        }

        private void FormSeeFish_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            LoadPictures();
        }

        void LoadPictures()
        {
            if (_SelectedFish == "crappie")
            {
                
                pictureBoxFish.Image = Resources.Crappie;
            }
            else if(_SelectedFish == "perch")
            {
                
                pictureBoxFish.Image = Resources.Perch;
            }else if(_SelectedFish == "walleye")
            {
                
                pictureBoxFish.Image = Resources.Walleye;
            }

                    
        }
    }
}
