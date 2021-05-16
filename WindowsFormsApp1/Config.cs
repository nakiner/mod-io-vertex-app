using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace WindowsFormsApp1
{
    public class ConfigItem
    {
        public string mod_path = "";
    }

    class Config
    {
        private string config_name = "D:/Vertex/config.json";
        private ConfigItem configInstance;

        public Config()
        {
            readConfig();
        }

        public string getModPath()
        {
            return this.configInstance.mod_path;
        }

        private void readConfig()
        {
            if (!File.Exists(this.config_name))
            {
                this.configInstance = new ConfigItem();
                this.writeConfig();
            }
            else
            {
                using (StreamReader r = new StreamReader(this.config_name))
                {
                    string json = r.ReadToEnd();
                    this.configInstance = JsonConvert.DeserializeObject<ConfigItem>(json);
                }
            }
        }

        public void writeConfig()
        {
            using (StreamWriter sw = File.CreateText(this.config_name))
            {
                string configString = JsonConvert.SerializeObject(this.configInstance);
                sw.WriteLine(configString);
                sw.Close();
            }
        }

        public void setModPath(string path)
        {
            this.configInstance.mod_path = path;
        }
    }
}