using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vlc.DotNet.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ZooManagementSystem
{
    public partial class Accessibity : Form
    {
        private int userId;
        private bool isPlaying = false;
        private bool endReached = false;
        string imagePath1 = @"C:\Users\Lenovo\source\repos\ZooManagementSystemSln\ZooManagementSystem\Resources\play.png";
        string imagePath2 = @"C:\Users\Lenovo\source\repos\ZooManagementSystemSln\ZooManagementSystem\Resources\pause.png";
        public Accessibity(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            string videoPath = @"C:\Users\Lenovo\source\repos\ZooManagementSystemSln\ZooManagementSystem\Resources\zoo_video.mp4";

            if (!File.Exists(videoPath))
            {
                MessageBox.Show("Video not found: " + videoPath);
                return;
            }
            try
            {
                vlcControl1.SetMedia(new FileInfo(videoPath));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading video: {ex.Message}");
            }
            vlcControl1.EndReached += VlcControl1_EndReached;


        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            AccessInfo.Visible = false;
            textInfo.Visible = true;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Accessibity_Load(object sender, EventArgs e)
        {
            
            if (File.Exists(imagePath1))
            {
                playPauseCB.Image = Image.FromFile(imagePath1);
                playPauseCB.ImageSize = new Size(40, 40);
            }
            else
            {
                MessageBox.Show("Image not found at: " + imagePath1);
            }
        }

        private void vlcControl1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            vlcControl1.Pause();
            isPlaying = false;
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                vlcControl1.Pause();
                timer1.Stop();
                isPlaying = false;
                if (File.Exists(imagePath2))
                {
                    playPauseCB.Image = Image.FromFile(imagePath1);
                    playPauseCB.ImageSize = new Size(44, 44);
                    
                }
                else
                {
                    MessageBox.Show("Image not found at: " + imagePath1);
                }
            }
            else
            {
                vlcControl1.Play();
                timer1.Start();
                isPlaying = true;
                if (File.Exists(imagePath1))
                {
                    playPauseCB.Image = Image.FromFile(imagePath2);
                    playPauseCB.ImageSize = new Size(40, 40);
                }
                else
                {
                    MessageBox.Show("Image not found at: " + imagePath2);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (vlcControl1.IsPlaying)
            {
                vedioTrackBar.Value = (int)(vlcControl1.Position * 100);
            }
        }

        private void guna2TrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            bool wasPlaying = vlcControl1.IsPlaying;
            if (wasPlaying)
            {
                vlcControl1.Pause();
            } 
            vlcControl1.Position = vedioTrackBar.Value / 100f;
            if (wasPlaying)
            {
                vlcControl1.Play();
            }
            
            if (endReached)
            {
                float newPosition = vedioTrackBar.Value / 100f;
                vlcControl1.Stop();
                vlcControl1.Position = newPosition;
                vlcControl1.Play();
                isPlaying = true;

                if (File.Exists(imagePath2))
                {
                    playPauseCB.Image = Image.FromFile(imagePath2);
                    playPauseCB.ImageSize = new Size(40, 40);
                }

                timer1.Start();
                endReached = false;
            }
        }

        private void vedioTrackBar_ValueChanged(object sender, EventArgs e)
        {
           
        }
        private void VlcControl1_EndReached(object sender, Vlc.DotNet.Core.VlcMediaPlayerEndReachedEventArgs e)
        {
            isPlaying = false;
            timer1.Stop();
            endReached = true;

            if (File.Exists(imagePath1))
            {
                playPauseCB.Image = Image.FromFile(imagePath1);
                playPauseCB.ImageSize = new Size(44, 44);
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click_1(object sender, EventArgs e)
        {
            isPlaying = false;
            timer1.Stop();
            vlcControl1.Stop();
            vlcControl1.Position = 0f;
            vedioTrackBar.Value = 0;
            visitorHome mainForm = new visitorHome(userId);
            this.Hide();
            mainForm.Show();
        }
    }
}
