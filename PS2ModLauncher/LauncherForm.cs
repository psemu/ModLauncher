using Microsoft.Win32;
using Newtonsoft.Json.Linq;
using PS2ModLauncher.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;


namespace PS2ModLauncher
{
    public enum LaunchMethod
    {
        None,
        LooseFiles,
        ExtraAssetPack, 
    }

    public enum LaunchDomain
    {
        Test,
        PSG_Test,
#if HACKS
        Live,
        PSG_Live,
#endif
    }

    public partial class LauncherForm : Form
    {       
        Process ps2;
        string LooseFileDirectory = "";

        LaunchDomain domain = LaunchDomain.Test;

        Dictionary<LaunchDomain, string> domains = new Dictionary<LaunchDomain, string>()
        {
            { LaunchDomain.Test, "https://lp.soe.com/ps2/test" },
            { LaunchDomain.PSG_Test, "https://lp.soe.com/ps2/psg-livetest" },
#if HACKS
            { LaunchDomain.Live, "https://lp.soe.com/ps2/live" },
            { LaunchDomain.PSG_Live, "https://lp.soe.com/ps2/psg" },
#endif
        };

        const string LoggingArgs = "Logging:ConsoleLogLevel=999 Logging:FileLogLevel=999 Logging:LocalLogLevel=999 Logging:Directory=.\\testdir Logging:LocalDirectory=.\\testdirloc Logging:FailureDirectory=.\\testdirfail";

        public LauncherForm()
        {

            InitializeComponent();
            if(Settings.Default.PS2Path == "")
            {
                Settings.Default.PS2Path = getDefaultDirectory();
            }

            planetside2PathTextField.Text = Settings.Default.PS2Path;

            applyMethod.Items.Clear();
            applyMethod.Items.AddRange(Enum.GetNames(typeof(LaunchMethod)));
            applyMethod.SelectedIndex = 0;

            domainBox.Items.Clear();
            domainBox.Items.AddRange(Enum.GetNames(typeof(LaunchDomain)));
            domainBox.SelectedIndex = Settings.Default.DomainIndex;

            this.ufpTextBox.Text = FindUFP();

            if (Settings.Default.LastPack != null)
            {
                foreach (string s in Settings.Default.LastPack)
                {
                    filesToPackBox.Items.Add(s);
                }
            }

            luaFileName.Text = Settings.Default.luaFileName;
            luaBox.Text = Settings.Default.LuaText;

            this.launchArgs.Text = Settings.Default.ExtraArgs;

            loggingCheckBox.Checked = Settings.Default.Logging;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult r = findPTRDirDialogue.ShowDialog();
            if (r == DialogResult.OK)
            {
                planetside2PathTextField.Text = findPTRDirDialogue.SelectedPath;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            DialogResult r = savePackDialogue.ShowDialog();
            if (r == DialogResult.OK)
            {
                List<string> files = new List<string>(filesToPackBox.Items.Cast<string>());
                PackCreator.CreatePackFromFiles(files.ToArray(), savePackDialogue.FileName);

                Settings.Default.LastPack.Clear();
                foreach (string item in filesToPackBox.Items.Cast<string>())
                {
                    Settings.Default.LastPack.Add(item);
                }

                Settings.Default.Save();
               
                MessageBox.Show("Pack Created");

                
            }
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void AddFileToPack_Click(object sender, EventArgs e)
        {
            DialogResult r = selectFileForPack.ShowDialog();
            if (r == DialogResult.OK)
            {
                filesToPackBox.Items.AddRange(selectFileForPack.FileNames);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<object> removals = new List<object>();
            foreach (object o in filesToPackBox.SelectedItems)
            {
                removals.Add(o);
            }
            foreach (object o in removals)
            {
                filesToPackBox.Items.Remove(o);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            long ts = DateTime.Now.ToFileTime();

            string path = planetside2PathTextField.Text;
            string file = path + "/Planetside2.exe";


            if (!File.Exists(file))
            {
                MessageBox.Show("Error: Cannot open planetside2.exe (did you select the wrong directory?)", "Can't Find Executable", MessageBoxButtons.OK);
                return;
            }

            //Save the ps2 path
            if(Settings.Default.PS2Path != path)
            {
                Settings.Default.PS2Path = path;
            }
            //And the extra launch args
            if(Settings.Default.ExtraArgs != launchArgs.Text)
            {
                Settings.Default.ExtraArgs = this.launchArgs.Text;
            }
            


            string cookie = loginWebBrowser.Document.Cookie;
            string requestpath = domains[domain] + "/get_play_session?ts=" + ts;
            HttpWebRequest request = WebRequest.Create(requestpath) as HttpWebRequest;
            request.CookieContainer = new CookieContainer();
            request.CookieContainer.MaxCookieSize = 4000;
            string[] cks = cookie.Split(';');
            foreach (string cook in cks)
            {
                string[] sp = cook.Split('=');
                Cookie c = new Cookie(sp[0].Trim(), sp[1].Trim());
                request.CookieContainer.Add(request.RequestUri, c);


            }
            HttpWebResponse r;
            try
            {
                r = request.GetResponse() as HttpWebResponse;
            }
            catch (WebException x)
            {
                MessageBox.Show("Log in on the side over there");
                return;
            }
            StreamReader reader = new StreamReader(r.GetResponseStream());
            string text = reader.ReadToEnd();

            JObject obj = JObject.Parse(text);

            string launch_args = "";

            launch_args += (string)obj["launch_args"];
            launch_args = launch_args.Replace("LaunchPad:SessionId=", "LaunchPad:SessionId="+ ts);


            string UFP = this.ufpTextBox.Text;
            launch_args = launch_args.Replace("LaunchPad:Ufp=", "LaunchPad:Ufp="+UFP);

            //Launch Mode: Loose Files.
            LaunchMethod method = (LaunchMethod)Enum.Parse(typeof(LaunchMethod), (string)applyMethod.SelectedItem);
            if (method == LaunchMethod.LooseFiles)
            {
                launch_args += @" AssetDelivery:AdditionalPaths=.\CommonData\;.\GraphicsData\;"+LooseFileDirectory;
                launch_args += " AssetDelivery:IndirectEnabled=0 AssetsDelivery:PreferDirect=1";
            }

            if(loggingCheckBox.Checked)
            {
                launch_args += LoggingArgs;
            }

            string ExtraLaunchArgs = launchArgs.Text;

            launch_args += ExtraLaunchArgs;
            

            ps2 = new Process();

            ps2.StartInfo.WorkingDirectory = path;
            ps2.StartInfo.FileName = path + "\\Planetside2.exe";
            ps2.StartInfo.Arguments = launch_args;
            ps2.StartInfo.RedirectStandardOutput = true;
            ps2.StartInfo.UseShellExecute = false;

            ps2.Exited += new EventHandler(ps2_Exited);

            ps2.OutputDataReceived += new DataReceivedEventHandler(ps2_OutputDataReceived);

            ps2.Start();

          
        }

        void ps2_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            List<string> lines = new List<string>(ps2_consoleOutput.Lines);
            while (!ps2.StandardOutput.EndOfStream)
            {
                lines.Add(ps2.StandardOutput.ReadLine());

            }

            ps2_consoleOutput.Lines = lines.ToArray();

        }

        void ps2_Exited(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }




        private static string getDefaultDirectory()
        {
            RegistryKey key = null;

            // non-steam install
            key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\App Paths\LaunchPad.exe");

            if (key != null && key.GetValue("") != null)
            {
                String defaultDirectory;
                defaultDirectory = key.GetValue("").ToString();
                defaultDirectory = Path.GetDirectoryName(defaultDirectory);

                if (Directory.Exists(defaultDirectory))
                {
                    return defaultDirectory;
                }
            }

            return "";

        }

        private void ApplyMethod_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LaunchMethod method = (LaunchMethod)Enum.Parse(typeof(LaunchMethod), (string)applyMethod.SelectedItem);
            if (method == LaunchMethod.LooseFiles)
            {
                FolderBrowserDialog d = new FolderBrowserDialog();
                d.Description = "Directory to find packs for";
                DialogResult r = d.ShowDialog();
                
                if (r == System.Windows.Forms.DialogResult.OK)
                {
                    LooseFileDirectory = d.SelectedPath;
                }
            }

            if (method == LaunchMethod.ExtraAssetPack)
            {
                OpenFileDialog op = new OpenFileDialog();
                op.Title = "Extra .pack file";
                op.Filter = "Pack Files (*.pack)|*.pack";
                DialogResult r = op.ShowDialog();
                if (r == DialogResult.OK)
                {
                    File.Copy(op.FileName, planetside2PathTextField.Text + "\\Resources\\Assets\\Assets_256.pack", true);
                }
            }
        }
               
        

        private void deleteExtraPacks_Click(object sender, EventArgs e)
        {
            if (File.Exists(planetside2PathTextField.Text + "\\Resources\\Assets\\Assets_256.pack"))
            {
                File.Delete(planetside2PathTextField.Text + "\\Resources\\Assets\\Assets_256.pack");
                MessageBox.Show("Deleted Assets_256.pack");
            }

             string scriptsbinx86 = Settings.Default.PS2Path + "\\UI\\scriptsbase.bin";
            string scriptsbinx64 = Settings.Default.PS2Path + "\\UI\\scriptsbase_x64.bin";

            if (File.Exists(scriptsbinx86 + ".bak"))
            {
                File.Copy(scriptsbinx86 + ".bak", scriptsbinx86, true);
            }
            if (File.Exists(scriptsbinx64 + ".bak"))
            {
                File.Copy(scriptsbinx64 + ".bak", scriptsbinx64, true);
            }
        }

        private void findUFP_Click(object sender, EventArgs e)
        {
            this.ufpTextBox.Text = FindUFP();
        }

        private string FindUFP()
        {
            string path = planetside2PathTextField.Text;

            //Find the user fingerprint
            string UFP = "";
            if (File.Exists(path + "\\LaunchPad.libs\\Logs\\GameLauncherView.log"))
            {
                using (StreamReader ufpreader = new StreamReader(path + "\\LaunchPad.libs\\Logs\\GameLauncherView.log"))
                {
                    while (!ufpreader.EndOfStream)
                    {
                        string line = ufpreader.ReadLine();
                        if (line.Contains("propertyName=UserFingerprint, value="))
                        {
                            int wheretoLook = line.IndexOf("propertyName=UserFingerprint, value=") + "propertyName=UserFingerprint, value=".Length;
                            UFP = line.Substring(wheretoLook, 44);
                            break;
                        }
                    }
                }
            }
            if (UFP == "")
            {
                DialogResult re = MessageBox.Show("Warning: User Fingerprint not found.  \n This could be dangerous as SOE may be able to detect that.\n Press Cancel to cancel launching", "Warning", MessageBoxButtons.OKCancel);
                if (re == System.Windows.Forms.DialogResult.Cancel) return "";
            }
            return UFP;
        }

        private void GenerateUFP_Click(object sender, EventArgs e)
        {
            Guid g = Guid.NewGuid();
            
        }

        private void domainBox_SelectedValueChanged(object sender, EventArgs e)
        {
            LaunchDomain d = (LaunchDomain)Enum.Parse(typeof(LaunchDomain), (string)domainBox.SelectedItem);
            domain = d;
            loginWebBrowser.Navigate(domains[d]);     

        }

        private void luaApplyButton_Click(object sender, EventArgs e)
        {
            string ps2Path = Settings.Default.PS2Path;
            string LuaPath = ps2Path + "\\Resources\\Scripts";
            Directory.CreateDirectory(LuaPath);

            if(luaFileName.Text != Settings.Default.luaFileName)
            {
                Settings.Default.luaFileName = luaFileName.Text;
            }

            //Write the file 
            File.WriteAllText(LuaPath + luaFileName.Text, luaBox.Text);

            Settings.Default.LuaText = luaBox.Text;
                    
            string scriptsbinx86 = ps2Path + "\\UI\\scriptsbase.bin";
            string scriptsbinx64 = ps2Path + "\\UI\\scriptsbase_x64.bin";

            //back up the scriptsbase        

            File.Copy(scriptsbinx86, ps2Path + "\\UI\\ScriptsBase_real.bin", true);
            File.Copy(scriptsbinx64, ps2Path + "\\UI\\ScriptsBase_x64_real.bin", true);

            //And write out the new replacement
            File.WriteAllText(scriptsbinx86, Resources.LuaApplyx86);
            File.WriteAllText(scriptsbinx64, Resources.LuaApplyx64);

            MessageBox.Show("Lua Applied!");

        }

        private void loggingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.Logging = loggingCheckBox.Checked;
        }
       
    }

   
}
