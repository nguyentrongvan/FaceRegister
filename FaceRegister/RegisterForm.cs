using FaceRegister.Camera;
using FaceRegister.Common;
using FaceRegister.FaceMoudule;
using sun.awt;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace FaceRegister
{
    public partial class RegisterForm : Form
    {
        private CameraControl camControl = null;
        private bool IsPlaying = false;
        private string URLVideo = "";
        private int skipframeProcess = 10;
        private Image emptyface = new Bitmap(100, 100);
        private Image checkedBox = new Bitmap(100,100);
        private string [] company = { "Comp01", "Tech03", "BoshTech00"};
        private string pathSaveface = @"FaceRecored";
        private bool continueRegister = false;
        private int numFaceGet = 10;
        private string facedetected_msg = "Yes! Please keep your face to register!";
        private string no_facedetected_msg = "No face detected! Looking for face...";
        private string ico_facedetected = "🤗";
        private string ico_no_face_detected = "😢";
        private string resource = "";
        private Image loader = new Bitmap(100, 100);
        private string path_save = "";
        ConfigSetting configForm = new ConfigSetting();

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddCompanyList()
        {
            foreach(string comp in company)
            {
                comp_comboBox.Items.Add(comp);
            }
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            this.videoShow_picBox.Image = loader;
            if (videoURL_txtBox.Text != URLVideo || continueRegister == false)
            {
                this.URLVideo = videoURL_txtBox.Text;
                Task.Run(()=> this.camControl.StreamVideo(URLVideo));
            }

            EnableButton(this.stopRegist_Btn, true);
            DisableButton(this.registerBtn);
            this.numFaceGet = Int32.Parse(this.numface_txtBox.Text);
            this.countProgress_bar.Minimum = 0;
            this.countProgress_bar.Maximum = numFaceGet;
            this.countProgress_bar.Visible = true;

            if (!this.IsPlaying)
            {
                this.continueRegister = false;
                this.IsPlaying = true;
                Task.Run(() => PlayVideo(this.path_save));
            }
            else
            {
                this.continueRegister = true;
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> setting = Config.readConfigFile();
            updateSetting(setting);

            this.videoURL_txtBox.Text = this.URLVideo;
            this.camControl = new CameraControl();
            this.numface_txtBox.Text = this.numFaceGet.ToString();
            this.countFace_label.Text = "";
            this.countProgress_bar.Visible = false;

            emptyface = new Bitmap(emptyface, new Size(face_pictureBox.Width, face_pictureBox.Height));
            icon_label.Text = "";
            notifiFace_label.Text = "";

            if (!Directory.Exists(this.pathSaveface))
            {
                Directory.CreateDirectory(this.pathSaveface);
            }
            this.path_save = Path.Combine(pathSaveface, DateTime.Now.ToString("yyyyMMdd"));
            createFolderNotExist(path_save);

            AddCompanyList();
            EnableButton(this.registerBtn);
            DisableButton(this.stopRegist_Btn);
        }

        private void updateSetting(Dictionary<string, string> dataUpdate)
        {         
            this.company = dataUpdate["company"].Split(',');

            this.URLVideo = dataUpdate["URLVideo"];
            this.pathSaveface = dataUpdate["pathSaveface"];
            this.facedetected_msg = dataUpdate["facedetected_msg"];
            this.no_facedetected_msg = dataUpdate["no_facedetected_msg"];
            this.ico_facedetected = dataUpdate["ico_facedetected"];
            this.ico_no_face_detected = dataUpdate["ico_no_face_detected"];

            this.skipframeProcess = Int32.Parse(dataUpdate["skipframeProcess"]);
            this.numFaceGet = Int32.Parse(dataUpdate["numFaceGet"]);

            this.resource = dataUpdate["resource"];
            this.emptyface = Bitmap.FromFile(Path.Combine(this.resource,dataUpdate["emptyface"]));
            this.checkedBox = Bitmap.FromFile(Path.Combine(this.resource,dataUpdate["checkedBox"]));
            this.loader = Bitmap.FromFile(Path.Combine(this.resource, dataUpdate["loader"]));
        }


        private void resetAllRegisterControl()
        {
            //Bitmap
            videoShow_picBox.Invoke(new Action(() => videoShow_picBox.Image = new Bitmap(videoShow_picBox.Width, videoShow_picBox.Height)));
            face_pictureBox.Invoke(new Action(() => face_pictureBox.Image = new Bitmap(face_pictureBox.Width, face_pictureBox.Height)));

            //Textbox
            videoURL_txtBox.Invoke(new Action(() => videoURL_txtBox.ReadOnly = false));
            icon_label.Invoke(new Action(() => icon_label.Text = ""));
            notifiFace_label.Invoke(new Action(() => notifiFace_label.Text = ""));
            countFace_label.Invoke(new Action(() => countFace_label.Text = ""));

            //Panel
            panel_picturebox.Invoke(new Action(() => panel_picturebox.BackColor = Color.AliceBlue));

            //Progressbar
            countProgress_bar.Invoke(new Action(() => countProgress_bar.Visible = false));
            countProgress_bar.Invoke(new Action(() => countProgress_bar.Value = 0));
        }

        private int updateVideoShow(Bitmap face, int countFace_get)
        {
            if (face == null)
            {
                icon_label.Invoke(new Action(() => icon_label.Text = ico_no_face_detected));
                notifiFace_label.Invoke(new Action(() => notifiFace_label.Text = no_facedetected_msg));
                notifiFace_label.Invoke(new Action(() => notifiFace_label.ForeColor = Color.Red));
                panel_picturebox.Invoke(new Action(() => panel_picturebox.BackColor = Color.Crimson));
                face_pictureBox.Invoke(new Action(() => face_pictureBox.Image = emptyface));
            }
            else
            {
                countFace_get++;
                icon_label.Invoke(new Action(() => icon_label.Text = ico_facedetected));
                notifiFace_label.Invoke(new Action(() => notifiFace_label.Text = facedetected_msg));
                notifiFace_label.Invoke(new Action(() => notifiFace_label.ForeColor = Color.Green));
                panel_picturebox.Invoke(new Action(() => panel_picturebox.BackColor = Color.DarkGreen));
                face_pictureBox.Invoke(new Action(() => face_pictureBox.Image = new Bitmap(face, new Size(face_pictureBox.Width, face_pictureBox.Height))));
            }

            return countFace_get;
        }

        private void PlayVideo(string path_save)
        {
         
            int countframe = 0;
            int countFace_get = 0;

            if (this.camControl == null)
            {
                ControlTextBox();
                return;
            }
            try
            {
                ControlTextBox(false);
                //ShowLoading(false);

                while (true)
                {                
                    if (!IsPlaying)
                    {
                        resetAllRegisterControl();
                        return;
                    }

                    if (continueRegister)
                    {
                        countFace_get = 0;
                        ControlTextBox(false);
                        continueRegister = false;
                    }

                    //ShowLoading(false);
                    Bitmap currentFrame = camControl.GetImage();

                    if(currentFrame == null)
                    {
                        continue;
                    }

                    Bitmap resized = new Bitmap(currentFrame, new Size(videoShow_picBox.Width, videoShow_picBox.Height));
                    if (countframe == skipframeProcess)
                    {
                        if (countFace_get < numFaceGet)
                        {
                            Bitmap face = FaceDetector.detectFace(resized);
                            int countFace = updateVideoShow(face, countFace_get);

                            if(countFace > countFace_get)
                            {
                                countFace_get = countFace;

                                string path_save_img = Path.Combine(path_save, string.Format("{0}_{1}_{2}_{3}.jpg", DateTime.Now.ToString("HHmmss"), iD_textBox.Text, name_textBox.Text, ""));
                                face.Save(path_save_img);

                                byte[] imageArray = File.ReadAllBytes(path_save_img);
                                string base64ImageRepresentation = Convert.ToBase64String(imageArray);

                                countProgress_bar.Invoke(new Action(() => countProgress_bar.Value = countFace_get));
                                Task.Run(() => RegisterMaster.APIRegistMaster(base64ImageRepresentation));
                            }
                            countframe = 0;
                        }
                        else
                        {
                            ControlTextBox();
                            registerBtn.Invoke(new Action(() => registerBtn.Enabled = true));
                            registerBtn.Invoke(new Action(() => registerBtn.BackColor = Color.Aquamarine));
                            registerBtn.Invoke(new Action(() => registerBtn.ForeColor = Color.DarkGreen));
                            
                            face_pictureBox.Invoke(new Action(() => face_pictureBox.Image = new Bitmap(checkedBox, new Size(face_pictureBox.Width, face_pictureBox.Height))));                               
                        }
                    }
                    else
                    {                            
                        countframe++;
                    }

                    countFace_label.Invoke(new Action(() => countFace_label.Text = string.Format("{0}/{1} face is recorded", countFace_get, numFaceGet.ToString())));                     
                    videoShow_picBox.Image = resized;                   
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                ControlTextBox();
            }
        }

        private void stopRegist_Btn_Click(object sender, EventArgs e)
        {
            this.IsPlaying = false;
            this.registerBtn.Enabled = true;
            this.stopRegist_Btn.Enabled = false;

            this.panel_picturebox.BackColor = Color.AliceBlue;
            this.camControl.StopStream();

            ControlTextBox();
            EnableButton(this.registerBtn);
            DisableButton(this.stopRegist_Btn);
        }

        public void DrawRectangleRectangle(PaintEventArgs e, Color color, Rectangle rect)
        {
            Pen blackPen = new Pen(color, 3);
            e.Graphics.DrawRectangle(blackPen, rect);
        }

        private void EnableButton(Button btn, bool stop=false)
        {
            btn.Enabled = true;
            if (stop)
            {
                btn.BackColor = Color.Pink;
                btn.ForeColor = Color.Crimson;
            }
            else
            {
                btn.BackColor = Color.Aquamarine;
                btn.ForeColor = Color.DarkGreen;
            }
        }

        private void DisableButton(Button btn)
        {
            btn.Enabled = false;
            btn.BackColor = Color.Gray;
            btn.ForeColor = Color.DarkGray;
        }

        private void ControlTextBox(bool enable = true)
        {
            List<Control> ControlTxtBox = new List<Control> { videoURL_txtBox, name_textBox, iD_textBox, comp_comboBox, numface_txtBox };
            foreach (Control control in ControlTxtBox)
            {
                if (enable)
                { 
                    control.Invoke(new Action(() => control.Enabled = true)); 
                }
                else
                {
                    control.Invoke(new Action(() => control.Enabled = false));
                }
            }
        }

        private void createFolderNotExist(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }

        private void showList_btn_Click(object sender, EventArgs e)
        {
            Process.Start(pathSaveface);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void configBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Enabled = false;
            this.configForm.ShowDialog();
        }

        private void alarmPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void recordVd_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
