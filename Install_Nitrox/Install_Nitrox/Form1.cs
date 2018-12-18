using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Install_Nitrox
{
    public partial class Subnautica : Form
    {
        public bool ServerBox = false;
        public string Gamepath = null;
        public string Serverpath = null;

        public Subnautica()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Gamepath != null)
            {
                Form2 form = new Form2();
                form.GetPaths(Gamepath, Serverpath);
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Select a Directory", "ERROR", MessageBoxButtons.OK);
            }
        }

        private void ServerCB_CheckedChanged(object sender, EventArgs e)
        {
            ServerBox = !ServerBox;
            ServerDir.Text = null;
            Serverpath = null;
        }

        private void GameDialog_Click(object sender, EventArgs e)
        {
            GameDirFBD.ShowDialog();
            GameDir.Text = GameDirFBD.SelectedPath;
            Gamepath = GameDirFBD.SelectedPath;
        }

        private void ServerDialog_Click(object sender, EventArgs e)
        {
            if(ServerBox)
            {
                ServerDirFBD.ShowDialog();
                ServerDir.Text = ServerDirFBD.SelectedPath;
                Serverpath = ServerDirFBD.SelectedPath;
            }
        }
    }
}
