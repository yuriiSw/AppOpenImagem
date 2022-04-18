using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gameplay
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           
        }

        private void gameplaybotao_Click(object sender, EventArgs e)
        {
            GameplayOpenFile.Filter = "Arquivos bmp | *.bmp |Arquivos jpg | *.jpg";
            if(GameplayOpenFile.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = GameplayOpenFile.FileName;
            }
        }
    }
}
