using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
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
        public byte mode = 0;
        public bool finished = false;
        public string Gamezip = null;
        public string Serverzip = null;

        public Subnautica()
        {
            InitializeComponent();
        }

        private void ServerDialog_Click(object sender, EventArgs e)
        {
            if (ServerBox)
            {
                ServerDirFBD.ShowDialog();
                ServerDir.Text = ServerDirFBD.SelectedPath;
                Serverpath = ServerDirFBD.SelectedPath;
            }
        }

        private void GameDialog_Click(object sender, EventArgs e)
        {
            GameDirFBD.ShowDialog();
            GameDir.Text = GameDirFBD.SelectedPath;
            Gamepath = GameDirFBD.SelectedPath;
        }

        private void ServerCB_CheckedChanged(object sender, EventArgs e)
        {
            ServerBox = !ServerBox;
            ServerDir.Text = null;
            Serverpath = null;
        }

        private void NextBTN1_Click(object sender, EventArgs e)
        {
            if (Gamepath != null)
            {
                STATS.SelectedIndex = 1;
            }
            else
            {
                MessageBox.Show("Select a Directory", "ERROR", MessageBoxButtons.OK);
            }
        }

        //###############################################################################################################################


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void weiter_Click_1(object sender, EventArgs e)
        {
            if (mode != 0)
            {
                STATS.SelectedIndex = 2;
                downloadstart();
            }
            else
            {
                MessageBox.Show("Select ONE Point to Continue", "ERROR", MessageBoxButtons.OK);
            }
        }

        private void Zurück_Click_1(object sender, EventArgs e)
        {
            STATS.SelectedIndex = 0;
        }


        private void Form2_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //###############################################################################################################################

        private void downloadstart()
        {
            DL_CL.Text = "Wait for Connection";
            DL_SV.Text = "Wait for Connection";
            UP_CL.Text = "Wait for Prozess";
            UP_SV.Text = "Wait for Prozess";
            IT_CL.Text = "Wait for Prozess";
            IT_SV.Text = "Wait for Prozess";
            switch (mode)
            {
                case 1:
                    {
                        DL_SV.Text = "Finished";
                        UP_SV.Text = "Finished";
                        IT_SV.Text = "Finished";
                        Client();
                        break;
                    }
                case 2:
                    {
                        Client();
                        Server();
                        break;
                    }
                case 3:
                    {
                        DL_CL.Text = "Finished";
                        UP_CL.Text = "Finished";
                        IT_CL.Text = "Finished";
                        Server();
                        break;
                    }
            }
        }

        private void Client()
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedCL);
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChangedDL_CL);
            webClient.DownloadFileAsync(new Uri("https://drive.google.com/uc?authuser=0&id=1WoatwycEsf2AKI31I7FaarWqP2SglxfX&export=download"), "" + Gamepath + "Client.zip");
            Gamezip = "" + Gamepath + "Client.zip";
        }

        private void Server()
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedSV);
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChangedDL_SV);
            webClient.DownloadFileAsync(new Uri("https://drive.google.com/uc?authuser=0&id=1akCtSi-8d-xg3Ch4tExynTOjEhSRJh4g&export=download"), "" + Serverpath + "Server.zip");
            Serverzip = "" + Serverpath + "Server.zip";
        }

        private void ProgressChangedDL_CL(object sender, DownloadProgressChangedEventArgs e)
        {
            DLCL.Value = e.ProgressPercentage;
            DL_CL.Text = "" + e.ProgressPercentage.ToString() + "%";
        }

        private void ProgressChangedDL_SV(object sender, DownloadProgressChangedEventArgs e)
        {
            DLSV.Value = e.ProgressPercentage;
            DL_SV.Text = "" + e.ProgressPercentage.ToString() + "%";
        }

        private void ProgressChangedUP_CL(int e)
        {
            UPCL.Value = e;
            UP_CL.Text = "" + e.ToString() + "%";
        }

        private void ProgressChangedUP_SV(int e)
        {
            UPSV.Value = e;
            UP_SV.Text = "" + e.ToString() + "%";
        }

        private void ProgressChangedIT_CL(int e)
        {
            ITCL.Value = e;
            IT_CL.Text = "" + e.ToString() + "%";
        }

        private void ProgressChangedIT_SV(int e)
        {
            ITSV.Value = e;
            IT_SV.Text = "" + e.ToString() + "%";
        }

        private void CompletedCL(object sender, AsyncCompletedEventArgs e)
        {
            var t = Task.Delay(1000);
            t.Wait();
            ProgressChangedUP_CL(25);
            Directory.Delete("" + Gamepath + "\\Subnautica_Data\\Managed", true);
            Directory.CreateDirectory("" + Gamepath + "\\Subnautica_Data\\Managed");
            ProgressChangedIT_CL(20);
            ZipFile.ExtractToDirectory(Gamezip, "" + Gamepath + "\\Subnautica_Data\\Managed");
            ProgressChangedUP_CL(50);
            ProgressChangedIT_CL(40);
            t.Wait();
            File.Delete(Gamezip);
            ProgressChangedUP_CL(100);
            ProgressChangedIT_CL(100);
            finished = true;

        }

        private void CompletedSV(object sender, AsyncCompletedEventArgs e)
        {
            var t = Task.Delay(1000);
            t.Wait();
            ProgressChangedUP_SV(20);
            ZipFile.ExtractToDirectory(Serverzip, Serverpath);
            ProgressChangedUP_SV(80);
            ProgressChangedIT_SV(20);
            File.Delete(Serverzip);
            ProgressChangedIT_SV(60);
            ProgressChangedUP_SV(100);
            t.Wait();
            using (StreamWriter sw = File.CreateText("" + Serverpath + "\\path.txt"))
            {
                sw.WriteLine(Gamepath);
            }
            ProgressChangedIT_SV(100);
            finished = true;
        }

        void finish()
        {
            if (finished)
            {
                Application.Exit();
            }
            else
            {

                MessageBox.Show("Please Wait a moment", "WORKING", MessageBoxButtons.OK);

            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void Subnautica_Load(object sender, EventArgs e)
        {

        }


        private void FINISH_Click_1(object sender, EventArgs e)
        {
            finish();
        }
    }
}
