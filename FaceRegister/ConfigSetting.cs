using FaceRegister.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceRegister
{
    public partial class ConfigSetting : Form
    {
        public ConfigSetting()
        {
            InitializeComponent();
        }

        private void cfgClose_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfigSetting_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.mainForm.Visible = true;
            //Program.mainForm.Opacity = 1.0;
            Program.mainForm.Enabled = true;
        }

        private void numface_txtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void urlAPI_label_Click(object sender, EventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ConfigSetting_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> setting = Config.readConfigFile("SettingModel.ini");
            this.preprocess_compbox.Items.Clear();
            this.norm_CompBox.Items.Clear();
            this.model_ComboBox.Items.Clear();

            foreach (string comp in setting["modelName"].Split(','))
            {
                this.model_ComboBox.Items.Add(comp);
            }
            model_ComboBox.SelectedItem = model_ComboBox.Items[0];

            this.registerAPI_bbox.Text = setting["registerAPI"];
            this.verifyAPI_box.Text = setting["verifyAPI"];
            this.feAPI_box.Text = setting["featureAPI"];
            this.infoAPI_box.Text = setting["infoAPI"];

            List<string> selectionModelAction = new List<string> { "False", "True" };
            foreach (string comp in selectionModelAction)
            {
                this.preprocess_compbox.Items.Add(comp);
                this.norm_CompBox.Items.Add(comp);
            }

            preprocess_compbox.SelectedItem = preprocess_compbox.Items[int.Parse(setting["preprocessFace"])];
            norm_CompBox.SelectedItem = norm_CompBox.Items[int.Parse(setting["normalizeFace"])];
        }
    }
}
