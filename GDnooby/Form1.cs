using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Threading;
using System.Windows.Forms;
using VelocityAPI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.InteropServices;
namespace GDnooby
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        VelAPI vel = new VelAPI();
        private System.Windows.Forms.Timer timer1;

        private System.Windows.Forms.Timer timer2;
        public Form1()
        {
            InitializeComponent();
            guna2BorderlessForm1.DragForm = false;
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000;
            timer1.Tick += Timer_Tick;
            timer1.Start();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadScriptsIntoListBox();

            this.MaximizeBox = false;
            vel.StartCommunication();
        }



        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            vel.StopCommunication();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            int pid = 0;

            Process[] robloxProcesses = Process.GetProcessesByName("RobloxPlayerBeta");

            if (robloxProcesses.Length > 0)
            {
                Process roblox = robloxProcesses[0];
                pid = roblox.Id;


                await vel.Attach(pid);


            }
            else
            {
                MessageBox.Show($"injection failed PID: {pid}", "Fail");
                return;
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Application.StartupPath, "WaterMark", "WaterMark.lua");

            if (File.Exists(filePath))
            {
                richTextBox1.Text = File.ReadAllText(filePath);
            }
            else
            {
                MessageBox.Show("WaterMark.lua not found in Scripts folder!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            vel.Execute(richTextBox1.Text);
            label1.Text = "Executed !";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string scriptsFolder = Path.Combine(Application.StartupPath, "Scripts");
            Directory.CreateDirectory(scriptsFolder);

            SaveFileDialog saveDialog = new SaveFileDialog();

            saveDialog.Filter = "Lua Files (*.lua)|*.lua";
            saveDialog.DefaultExt = "lua";
            saveDialog.FileName = "script.lua";


            saveDialog.InitialDirectory = scriptsFolder;

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveDialog.FileName, richTextBox1.Text);
                MessageBox.Show("Saved!");
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Process[] robloxProcesses = Process.GetProcessesByName("RobloxPlayerBeta");

            if (robloxProcesses.Length > 0)
            {
                int pid = robloxProcesses[0].Id;

                if (vel.IsAttached(pid))
                {
                    label1.Text = "Status = Injected";
                }
                else
                {
                    label1.Text = "Status = Idle";
                }
            }
            else
            {
                label1.Text = "Status = Idle";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }
        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedItem == null) return;

            string scriptsFolder = Path.Combine(Application.StartupPath, "Scripts");
            string fileName = listBox1.SelectedItem.ToString();
            string filePath = Path.Combine(scriptsFolder, fileName);

            if (!File.Exists(filePath))
            {
                MessageBox.Show("File not found:\n" + filePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string content = File.ReadAllText(filePath);
                richTextBox1.Text = content;
                richTextBox1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading file:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadScriptsIntoListBox()
        {
            string scriptsFolder = Path.Combine(Application.StartupPath, "Scripts");

            listBox1.Items.Clear();

            if (!Directory.Exists(scriptsFolder))
            {

                Directory.CreateDirectory(scriptsFolder);
                MessageBox.Show("Scripts folder was created at:\n" + scriptsFolder + "\n\nPut your script files there.", "Folder Created");
                return;
            }

            try
            {
                var files = Directory.GetFiles(scriptsFolder, "*.*")
                                     .Where(f => !string.IsNullOrEmpty(Path.GetExtension(f)))
                                     .Select(f => Path.GetFileName(f))
                                     .OrderBy(f => f);

                foreach (string file in files)
                {
                    listBox1.Items.Add(file);
                }

                if (listBox1.Items.Count == 0)
                {
                    MessageBox.Show("No files found in Scripts folder.\n\nPut some script files there!", "No Scripts");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading scripts:\n" + ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LoadScriptsIntoListBox();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void guna2Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.TopMost = !this.TopMost;

            if (this.TopMost)
                button6.Text = "TopMost: ON";
            else
                button6.Text = "TopMost: OFF";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}
 