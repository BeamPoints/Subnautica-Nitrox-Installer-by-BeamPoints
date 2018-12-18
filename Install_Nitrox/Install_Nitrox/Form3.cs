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

namespace Install_Nitrox
{
    public partial class Form3 : Form
    {
        string GamePath = null;
        string ServerPath = null;
        string Gamezip = null;
        string Serverzip = null;
        byte DLmode = 0;
        bool finished = false;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_FormClosed(object sender, EventArgs e)
        {
            finish();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void info(byte mode, string Game, string Server)
        {
            DLmode = mode;
            GamePath = Game;
            ServerPath = Server;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            DL_CL.Text = "Wait for Connection";
            DL_SV.Text = "Wait for Connection";
            UP_CL.Text = "Wait for Prozess";
            UP_SV.Text = "Wait for Prozess";
            IT_CL.Text = "Wait for Prozess";
            IT_SV.Text = "Wait for Prozess";
            switch (DLmode)
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
            webClient.DownloadFileAsync(new Uri("https://drive.google.com/uc?authuser=0&id=1WoatwycEsf2AKI31I7FaarWqP2SglxfX&export=download"), ""+GamePath+"Client.zip");
            Gamezip = "" + GamePath + "Client.zip";
        }

        private void Server()
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedSV);
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChangedDL_SV);
            webClient.DownloadFileAsync(new Uri("https://drive.google.com/uc?authuser=0&id=1akCtSi-8d-xg3Ch4tExynTOjEhSRJh4g&export=download"), ""+ServerPath+"Server.zip");
            Serverzip = "" + ServerPath + "Server.zip";
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
            ProgressChangedUP_CL(25);
            Directory.Delete("" + GamePath + "\\Subnautica_Data\\Managed",true);
            Directory.CreateDirectory("" + GamePath + "\\Subnautica_Data\\Managed");
            ProgressChangedIT_CL(20);
            ZipFile.ExtractToDirectory(Gamezip, "" + GamePath + "\\Subnautica_Data\\Managed");
            ProgressChangedUP_CL(50);
            ProgressChangedIT_CL(40);
            File.Delete(Gamezip);
            ProgressChangedUP_CL(100);
            ProgressChangedIT_CL(100);
            finished = true;

        }

        private void CompletedSV(object sender, AsyncCompletedEventArgs e)
        {
            ProgressChangedUP_SV(20);
            ZipFile.ExtractToDirectory(Serverzip, ServerPath);
            ProgressChangedUP_SV(80);
            ProgressChangedIT_SV(20);
            File.Delete(Serverzip);
            ProgressChangedIT_SV(60);
            ProgressChangedUP_SV(100);
            using (StreamWriter sw = File.CreateText(""+ServerPath+"\\path.txt"))
            {
                sw.WriteLine(GamePath);
            }
            ProgressChangedIT_SV(100);
            finished = true;
        }

        private void FINISH_Click(object sender, EventArgs e)
        {
            finish();
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
    }
}
