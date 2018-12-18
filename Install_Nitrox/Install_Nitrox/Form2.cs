using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Install_Nitrox
{
    public partial class Form2 : Form
    {
        byte mode = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void Zurück_Click(object sender, EventArgs e)
        {
            
        }

        private void weiter_Click(object sender, EventArgs e)
        {

            if(mode != 0)
            {
                Form3 form3 = new Form3();
                form3.info(mode, GamePath, ServerPath);
                form3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Select ONE Point to Continue", "ERROR", MessageBoxButtons.OK);
            }

        }

        private void mpbtn_CheckedChanged(object sender, EventArgs e)
        {
            mode = 1;
        }

        private void bothbtn_CheckedChanged(object sender, EventArgs e)
        {
            mode = 2;
        }

        private void serverbtn_CheckedChanged(object sender, EventArgs e)
        {
            mode = 3;
        }

        private void Form2_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
