using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DKBACleaner
{
    public partial class frmMain : Form
    {
        private const int ISUCCESSFUL = 0;
        private const int IFAILED = 999;

        private bool bIs64Bit = false;

        private string[] directories = new string[10000];

        private string sModernWarfareDirectory;
        private string sColdWarDirectory;
        private string sGameDirectory;

        public frmMain()
        {
            InitializeComponent();
        }

        private int fCleanTraces()
        {
            return IFAILED;
        }

        private int fCleanRegistry()
        {
            if (bIs64Bit)
            {
                RegistryKey rkLMBlizzardEntertainment64Bit = Registry.LocalMachine.OpenSubKey("Software\\WOW6432Node\\Blizzard Entertainment");
                if (rkLMBlizzardEntertainment64Bit == null)
                {
                    AddToLog("Traces from registry have already cleaned.");
                    return ISUCCESSFUL;
                }

                if (rkLMBlizzardEntertainment64Bit.SubKeyCount > 0)
                {
                    AddToLog("Found traces in the registry. Starting cleaning process.");

                    rkLMBlizzardEntertainment64Bit.DeleteSubKeyTree("Battle.net");

                    if (rkLMBlizzardEntertainment64Bit.SubKeyCount > 0)
                    {
                        AddToLog("Traces weren't able to be cleaned from the registry!");
                    }
                    else if (rkLMBlizzardEntertainment64Bit.SubKeyCount == 0)
                    {
                        AddToLog("Traces successfully deleted from the registry.");
                        return ISUCCESSFUL;
                    }
                }
            } else
            {
                RegistryKey rkLMBlizzardEntertainment32Bit = Registry.CurrentUser.OpenSubKey("Software\\Blizzard Entertainment");
                if (rkLMBlizzardEntertainment32Bit == null)
                {
                    AddToLog("Traces from registry have already cleaned.");
                    return ISUCCESSFUL;
                }

                if (rkLMBlizzardEntertainment32Bit.SubKeyCount > 0)
                {
                    AddToLog("Found traces in the registry. Starting cleaning process.");

                    rkLMBlizzardEntertainment32Bit.DeleteSubKeyTree("Battle.net");

                    if (rkLMBlizzardEntertainment32Bit.SubKeyCount > 0)
                    {
                        AddToLog("Traces weren't able to be cleaned from the registry!");
                    }
                    else if (rkLMBlizzardEntertainment32Bit.SubKeyCount == 0)
                    {
                        AddToLog("Traces successfully deleted from the registry.");
                        return ISUCCESSFUL;
                    }
                }
            }

            return IFAILED;
        }

        private int fKillTasks()
        {
            Process[] ps = Process.GetProcessesByName("IM Agent.exe");
            foreach (Process p in ps)
                p.Kill();

            Process[] ps2 = Process.GetProcessesByName("IM Battle.exe");
            foreach (Process p in ps)
                p.Kill();

            // Need to verify processes are actually closed still..

            return ISUCCESSFUL;
        }


        private int fCleanFiles()
        {
            for (int i = 0; i < directories.Length; i++) {
                if (Directory.Exists(directories[i].ToString()))
                {
                    AddToLog("Deleting directory: " + i.ToString());
                }
            }

            for (int j=0; j < directories.Length; j++)
            {
                if (Directory.Exists(directories[j].ToString()))
                {
                    AddToLog("Unable to deleted directory: " + j.ToString());
                }
            }
            return IFAILED;
        }

        public void AddToLog(String sText)
        {
            try
            {
                // I created this function to make it easier to log things.
                // This also scrolls automatically to the bottom of the text box when adding new text. User experience FTW?
                txtLog.AppendText("\n" + sText);
                txtLog.ScrollToCaret();
            }
            catch (Exception ex)
            {
                txtLog.Text += "Error adding to log: " + ex.ToString();
            }
        }

        private void btn_CleanTraces_Click(object sender, EventArgs e)
        {
            if (txtColdWarDirectory.Text == "" && txtModernWarfareDirectory.Text == "")
            {
                MessageBox.Show("You are required to select at least of the games directories.");
            }
            else
            {
                //fCleanRegistry();
                fKillTasks();
                //fCleanFiles();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            bIs64Bit = Environment.Is64BitOperatingSystem;

            if (bIs64Bit)
                AddToLog("Detected current OS as 64 bit.");
            else
                AddToLog("Detected current OS as 32 bit.");

            directories.Append("C:\\Users\\DJr\\AppData\\Roaming\\Battle.net");
            directories.Append("%localappdata%\\Activision\\Call Of Duty Black Ops Cold War");
            directories.Append("%localappdata%\\Blizzard Entertainment");
            directories.Append("%appdata%\\Battle.net");
            directories.Append("%programdata%\\Activision");
            directories.Append("%programdata%\\Battle.net");
            directories.Append("%programdata%\\Blizzard Entertainment");
            directories.Append("%USERPROFILE%\\Documents\\Call of Duty Modern Warfare");
            directories.Append("%USERPROFILE%\\Documents\\Call Of Duty Black Ops Cold War");

            if (Directory.Exists("%USERPROFILE%\\Documents\\Call of Duty Modern Warfare"))
                txtModernWarfareDirectory.Text = "%USERPROFILE%\\Documents\\Call of Duty Modern Warfare";

            if (Directory.Exists("%USERPROFILE%\\Documents\\Call Of Duty Black Ops Cold War"))
                txtColdWarDirectory.Text = "%USERPROFILE%\\Documents\\Call Of Duty Black Ops Cold War";

        }

        private void DeleteDirectory(string path)
        {
            if (Directory.Exists(path))
            {
                foreach (string file in Directory.GetFiles(path))
                {
                    File.Delete(file);
                }
                foreach (string directory in Directory.GetDirectories(path))
                {
                    DeleteDirectory(directory);
                }
                Directory.Delete(path);
            }
        }

        private void btnSetCWDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtColdWarDirectory.Text = fbd.SelectedPath;
            }
            else
            {
                txtColdWarDirectory.Text = "No directory selected...";
            }
        }

        private void fSaveCWDirectoryToRegistry()
        {

        }

        private void fSaveMWDirectoryToRegistry()
        {

        }

        private string fGetCWDirectoryFromRegistry()
        {
            string sCWDir = "";

            return sCWDir;
        }

        private string fGetMWDirectoryFromRegistry()
        {
            string sMWDir = "";
            return sMWDir;
        }
    }
}
