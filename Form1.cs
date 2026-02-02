using System.IO;
using System.Text.Json;
using System.Net;

namespace GTAGmodPreset
{
    public partial class Form1 : Form
    {
        string jsonPath = ""; 
        string gamePath = "";
        string baseUrl = "https://raw.githubusercontent.com/Darkrat1/GTAGpresets/main/Mods/"; // My github path, change this if you want to fork this
        ModConfig loadedConfig;

        // WARNING!
        // There are errors when you run this, idk how to fix but it still works I think
        public Form1()
        {
            InitializeComponent();
        }
        public class ModConfig
        {
            public List<string> mods { get; set; }
            public List<string> unknownMods { get; set; }
        }

        private void SelectJson_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JSON (*.json)|*.json";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                jsonPath = ofd.FileName;
                JsonPathLabel.Text = jsonPath;

                string json = File.ReadAllText(jsonPath);
                loadedConfig = JsonSerializer.Deserialize<ModConfig>(json);

                listBox1.Items.Clear();

                foreach (var m in loadedConfig.mods)
                    listBox1.Items.Add("Known: " + m);

                foreach (var u in loadedConfig.unknownMods)
                    listBox1.Items.Add("Custom: " + u);
            }
        }

        private void InstallPreset_Click(object sender, EventArgs e)
        {
            if (loadedConfig == null || gamePath == "")
            {
                MessageBox.Show("No json or game path selected!");
                return;
            }

            WebClient wc = new WebClient();

            // Known mods, inside of my github:
            foreach (var mod in loadedConfig.mods)
            {
                string url = baseUrl + mod + ".dll";
                string dest = Path.Combine(gamePath, mod + ".dll");

                wc.DownloadFile(url, dest);
            }
            // Unknown mods, someone elses github
            foreach (var url in loadedConfig.unknownMods)
            {
                string fileName = Path.GetFileName(url);
                string dest = Path.Combine(gamePath, fileName);

                wc.DownloadFile(url, dest);
            }

            MessageBox.Show("Success!"); // idk, i think everyone hates this but idc
        }

        private void SelectGame_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK) // shows it or sm idk
            {
                gamePath = Path.Combine(fbd.SelectedPath, "BepInEx", "plugins"); // idk, goes to your plugins ig
                GamePathLabel.Text = gamePath; // idfk
            }
        }
    }
}
