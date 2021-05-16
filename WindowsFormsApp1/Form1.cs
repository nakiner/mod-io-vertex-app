using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Config configInstance;
        public List<Mod> modList;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.configInstance = new Config();
            string configPath = this.configInstance.getModPath();

            if (configPath.Length < 1)
            {
                string modPath = this.showModpathSelectDialog();

                if (modPath.Length > 0)
                {
                    this.configInstance.setModPath(modPath);
                    this.configInstance.writeConfig();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Please select mod path!", "Fatal error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string modPath = this.showModpathSelectDialog();

            if (modPath.Length > 0)
            {
                this.configInstance.setModPath(modPath);
                this.configInstance.writeConfig();
            }
            else
            {
                MessageBox.Show("Mod path not updated!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Show();
            }
        }

        private string showModpathSelectDialog()
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            DialogResult result = folderDlg.ShowDialog();

            if (result == DialogResult.OK)
            {
                return folderDlg.SelectedPath;
            }
            else
            {
                return "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Http client = new Http();
            JObject jsonResponseObject = client.getMods();
            JArray array = (JArray)jsonResponseObject["data"];

            this.modList = array.ToObject<List<Mod>>();

            foreach(Mod mod in this.modList)
            {
                listBox1.Items.Add(mod.Name);
            }         

            MessageBox.Show("Mods fethed.", "Cool", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("selectwd", "Cool", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string modName = listBox1.SelectedItem.ToString();
            string logoPath = Mod.getByName(this.modList, modName).Logo.Original.ToString();
            pictureBox1.Load(logoPath);
        }
    }
}
