using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceRegister.Common
{
    class Config
    {
        public static Dictionary<string, string> readConfigFile(string fname="")
        {
            if (string.IsNullOrEmpty(fname))
            {
                fname = "AppSetting.ini";
            }

            Dictionary<string, string> dataInFile = getDictionaryConfig(fname);
            return dataInFile;
        }

        public static Dictionary<string, string> getDictionaryConfig(string path)
        {
            Dictionary<string, string> Config = new Dictionary<string, string>();
            List<string> result = readDataFile(path);
            foreach (string line in result)
            {
                if (!line.Contains("="))
                {
                    MessageBox.Show("Config file have Incorrect syntax!",
                                   "Format Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(0);
                }
                string[] temp = line.Split('=');
                Config[temp[0].Trim()] = temp[1].Trim();
            }
            return Config;
        }

        public static List<string> readDataFile(string path)
        {
            List<string> result = new List<string>();
            if (!File.Exists(path))
            {
                MessageBox.Show("Error. Can not found file!\nPlease add config file! ",
                                   "Can not found file!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
            else
                try
                {
                    StreamReader sr = new StreamReader(path);
                    string line = sr.ReadLine();
                    while (line != null)
                    {
                        result.Add(line);
                        line = sr.ReadLine();
                    }
                    sr.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error. Can not read file!" + "\n" + e,
                                   "Can not read file!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(0);
                }
            return result;
        }
    }
}
