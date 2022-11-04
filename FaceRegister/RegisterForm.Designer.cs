
namespace FaceRegister
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.registerBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.videoShow_picBox = new System.Windows.Forms.PictureBox();
            this.stopRegist_Btn = new System.Windows.Forms.Button();
            this.videoURL_txtBox = new System.Windows.Forms.TextBox();
            this.entryURL_label = new System.Windows.Forms.Label();
            this.notifiFace_label = new System.Windows.Forms.Label();
            this.icon_label = new System.Windows.Forms.Label();
            this.face_pictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numface_txtBox = new System.Windows.Forms.TextBox();
            this.numFace_label = new System.Windows.Forms.Label();
            this.comp_comboBox = new System.Windows.Forms.ComboBox();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.iD_textBox = new System.Windows.Forms.TextBox();
            this.compLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.idlabel = new System.Windows.Forms.Label();
            this.alarmPanel = new System.Windows.Forms.Panel();
            this.showList_btn = new System.Windows.Forms.Button();
            this.recordVd_btn = new System.Windows.Forms.Button();
            this.panel_picturebox = new System.Windows.Forms.Panel();
            this.panelCount = new System.Windows.Forms.Panel();
            this.countProgress_bar = new System.Windows.Forms.ProgressBar();
            this.countFace_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoShow_picBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.face_pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.alarmPanel.SuspendLayout();
            this.panel_picturebox.SuspendLayout();
            this.panelCount.SuspendLayout();
            this.SuspendLayout();
            // 
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.Color.Aquamarine;
            this.registerBtn.Font = new System.Drawing.Font("UD Digi Kyokasho NP-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.registerBtn.ForeColor = System.Drawing.Color.DarkGreen;
            this.registerBtn.Location = new System.Drawing.Point(686, 459);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(122, 53);
            this.registerBtn.TabIndex = 1;
            this.registerBtn.Text = "▶️ Start Register";
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(122, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(0, 0);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // videoShow_picBox
            // 
            this.videoShow_picBox.BackColor = System.Drawing.Color.Cornsilk;
            this.videoShow_picBox.Location = new System.Drawing.Point(29, 62);
            this.videoShow_picBox.Name = "videoShow_picBox";
            this.videoShow_picBox.Size = new System.Drawing.Size(640, 384);
            this.videoShow_picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.videoShow_picBox.TabIndex = 3;
            this.videoShow_picBox.TabStop = false;
            // 
            // stopRegist_Btn
            // 
            this.stopRegist_Btn.BackColor = System.Drawing.Color.Pink;
            this.stopRegist_Btn.Font = new System.Drawing.Font("UD Digi Kyokasho NP-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.stopRegist_Btn.ForeColor = System.Drawing.Color.Crimson;
            this.stopRegist_Btn.Location = new System.Drawing.Point(814, 460);
            this.stopRegist_Btn.Name = "stopRegist_Btn";
            this.stopRegist_Btn.Size = new System.Drawing.Size(113, 52);
            this.stopRegist_Btn.TabIndex = 4;
            this.stopRegist_Btn.Text = "⏹️ Stop Register";
            this.stopRegist_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.stopRegist_Btn.UseVisualStyleBackColor = false;
            this.stopRegist_Btn.Click += new System.EventHandler(this.stopRegist_Btn_Click);
            // 
            // videoURL_txtBox
            // 
            this.videoURL_txtBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.videoURL_txtBox.Location = new System.Drawing.Point(182, 25);
            this.videoURL_txtBox.Name = "videoURL_txtBox";
            this.videoURL_txtBox.Size = new System.Drawing.Size(487, 26);
            this.videoURL_txtBox.TabIndex = 5;
            this.videoURL_txtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // entryURL_label
            // 
            this.entryURL_label.AutoSize = true;
            this.entryURL_label.Font = new System.Drawing.Font("UD Digi Kyokasho NP-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.entryURL_label.Location = new System.Drawing.Point(26, 29);
            this.entryURL_label.Name = "entryURL_label";
            this.entryURL_label.Size = new System.Drawing.Size(150, 18);
            this.entryURL_label.TabIndex = 6;
            this.entryURL_label.Text = "URL Stream Video";
            // 
            // notifiFace_label
            // 
            this.notifiFace_label.AutoSize = true;
            this.notifiFace_label.Font = new System.Drawing.Font("UD Digi Kyokasho NP-R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.notifiFace_label.Location = new System.Drawing.Point(60, 13);
            this.notifiFace_label.Name = "notifiFace_label";
            this.notifiFace_label.Size = new System.Drawing.Size(213, 22);
            this.notifiFace_label.TabIndex = 7;
            this.notifiFace_label.Text = "NO FACE DETECTED!";
            this.notifiFace_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // icon_label
            // 
            this.icon_label.AutoSize = true;
            this.icon_label.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icon_label.Location = new System.Drawing.Point(3, 3);
            this.icon_label.Name = "icon_label";
            this.icon_label.Size = new System.Drawing.Size(51, 45);
            this.icon_label.TabIndex = 8;
            this.icon_label.Text = "O";
            this.icon_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // face_pictureBox
            // 
            this.face_pictureBox.Location = new System.Drawing.Point(3, 3);
            this.face_pictureBox.Name = "face_pictureBox";
            this.face_pictureBox.Size = new System.Drawing.Size(106, 106);
            this.face_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.face_pictureBox.TabIndex = 9;
            this.face_pictureBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OldLace;
            this.panel1.Controls.Add(this.numface_txtBox);
            this.panel1.Controls.Add(this.numFace_label);
            this.panel1.Controls.Add(this.comp_comboBox);
            this.panel1.Controls.Add(this.name_textBox);
            this.panel1.Controls.Add(this.iD_textBox);
            this.panel1.Controls.Add(this.compLabel);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Controls.Add(this.idlabel);
            this.panel1.Location = new System.Drawing.Point(686, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 384);
            this.panel1.TabIndex = 10;
            // 
            // numface_txtBox
            // 
            this.numface_txtBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numface_txtBox.Location = new System.Drawing.Point(19, 297);
            this.numface_txtBox.Name = "numface_txtBox";
            this.numface_txtBox.Size = new System.Drawing.Size(196, 26);
            this.numface_txtBox.TabIndex = 8;
            this.numface_txtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numFace_label
            // 
            this.numFace_label.AutoSize = true;
            this.numFace_label.Font = new System.Drawing.Font("UD Digi Kyokasho NP-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numFace_label.Location = new System.Drawing.Point(16, 276);
            this.numFace_label.Name = "numFace_label";
            this.numFace_label.Size = new System.Drawing.Size(160, 18);
            this.numFace_label.TabIndex = 7;
            this.numFace_label.Text = "Number of face get";
            // 
            // comp_comboBox
            // 
            this.comp_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comp_comboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comp_comboBox.FormattingEnabled = true;
            this.comp_comboBox.Location = new System.Drawing.Point(19, 206);
            this.comp_comboBox.Name = "comp_comboBox";
            this.comp_comboBox.Size = new System.Drawing.Size(196, 26);
            this.comp_comboBox.TabIndex = 6;
            // 
            // name_textBox
            // 
            this.name_textBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_textBox.Location = new System.Drawing.Point(19, 119);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(196, 26);
            this.name_textBox.TabIndex = 5;
            this.name_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // iD_textBox
            // 
            this.iD_textBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iD_textBox.Location = new System.Drawing.Point(19, 34);
            this.iD_textBox.Name = "iD_textBox";
            this.iD_textBox.Size = new System.Drawing.Size(196, 26);
            this.iD_textBox.TabIndex = 3;
            this.iD_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // compLabel
            // 
            this.compLabel.AutoSize = true;
            this.compLabel.Font = new System.Drawing.Font("UD Digi Kyokasho NP-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.compLabel.Location = new System.Drawing.Point(16, 184);
            this.compLabel.Name = "compLabel";
            this.compLabel.Size = new System.Drawing.Size(80, 18);
            this.compLabel.TabIndex = 2;
            this.compLabel.Text = "Company";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("UD Digi Kyokasho NP-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nameLabel.Location = new System.Drawing.Point(16, 98);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(52, 18);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            // 
            // idlabel
            // 
            this.idlabel.AutoSize = true;
            this.idlabel.Font = new System.Drawing.Font("UD Digi Kyokasho NP-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.idlabel.Location = new System.Drawing.Point(16, 13);
            this.idlabel.Name = "idlabel";
            this.idlabel.Size = new System.Drawing.Size(57, 18);
            this.idlabel.TabIndex = 0;
            this.idlabel.Text = "No. ID";
            // 
            // alarmPanel
            // 
            this.alarmPanel.BackColor = System.Drawing.Color.AliceBlue;
            this.alarmPanel.Controls.Add(this.notifiFace_label);
            this.alarmPanel.Controls.Add(this.icon_label);
            this.alarmPanel.Location = new System.Drawing.Point(29, 461);
            this.alarmPanel.Name = "alarmPanel";
            this.alarmPanel.Size = new System.Drawing.Size(499, 51);
            this.alarmPanel.TabIndex = 11;
            // 
            // showList_btn
            // 
            this.showList_btn.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.showList_btn.Font = new System.Drawing.Font("UD Digi Kyokasho NP-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.showList_btn.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.showList_btn.Location = new System.Drawing.Point(686, 520);
            this.showList_btn.Name = "showList_btn";
            this.showList_btn.Size = new System.Drawing.Size(122, 53);
            this.showList_btn.TabIndex = 12;
            this.showList_btn.Text = " 🎞 List Recored";
            this.showList_btn.UseVisualStyleBackColor = false;
            this.showList_btn.Click += new System.EventHandler(this.showList_btn_Click);
            // 
            // recordVd_btn
            // 
            this.recordVd_btn.BackColor = System.Drawing.Color.MistyRose;
            this.recordVd_btn.Font = new System.Drawing.Font("UD Digi Kyokasho NP-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.recordVd_btn.ForeColor = System.Drawing.Color.Purple;
            this.recordVd_btn.Location = new System.Drawing.Point(814, 520);
            this.recordVd_btn.Name = "recordVd_btn";
            this.recordVd_btn.Size = new System.Drawing.Size(113, 52);
            this.recordVd_btn.TabIndex = 13;
            this.recordVd_btn.Text = "📽 Record Video ";
            this.recordVd_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.recordVd_btn.UseVisualStyleBackColor = false;
            // 
            // panel_picturebox
            // 
            this.panel_picturebox.BackColor = System.Drawing.Color.AliceBlue;
            this.panel_picturebox.Controls.Add(this.face_pictureBox);
            this.panel_picturebox.Location = new System.Drawing.Point(557, 461);
            this.panel_picturebox.Name = "panel_picturebox";
            this.panel_picturebox.Size = new System.Drawing.Size(112, 112);
            this.panel_picturebox.TabIndex = 14;
            // 
            // panelCount
            // 
            this.panelCount.BackColor = System.Drawing.Color.AliceBlue;
            this.panelCount.Controls.Add(this.countProgress_bar);
            this.panelCount.Controls.Add(this.countFace_label);
            this.panelCount.Location = new System.Drawing.Point(29, 522);
            this.panelCount.Name = "panelCount";
            this.panelCount.Size = new System.Drawing.Size(499, 51);
            this.panelCount.TabIndex = 12;
            // 
            // countProgress_bar
            // 
            this.countProgress_bar.Location = new System.Drawing.Point(0, 28);
            this.countProgress_bar.Name = "countProgress_bar";
            this.countProgress_bar.Size = new System.Drawing.Size(499, 23);
            this.countProgress_bar.TabIndex = 10;
            // 
            // countFace_label
            // 
            this.countFace_label.AutoSize = true;
            this.countFace_label.Font = new System.Drawing.Font("UD Digi Kyokasho NP-R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.countFace_label.ForeColor = System.Drawing.Color.DarkRed;
            this.countFace_label.Location = new System.Drawing.Point(3, 3);
            this.countFace_label.Name = "countFace_label";
            this.countFace_label.Size = new System.Drawing.Size(210, 22);
            this.countFace_label.TabIndex = 9;
            this.countFace_label.Text = "Count Face Recorded";
            this.countFace_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(976, 597);
            this.Controls.Add(this.panelCount);
            this.Controls.Add(this.panel_picturebox);
            this.Controls.Add(this.recordVd_btn);
            this.Controls.Add(this.showList_btn);
            this.Controls.Add(this.stopRegist_Btn);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.alarmPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.entryURL_label);
            this.Controls.Add(this.videoURL_txtBox);
            this.Controls.Add(this.videoShow_picBox);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Face Register";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoShow_picBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.face_pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.alarmPanel.ResumeLayout(false);
            this.alarmPanel.PerformLayout();
            this.panel_picturebox.ResumeLayout(false);
            this.panelCount.ResumeLayout(false);
            this.panelCount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox videoShow_picBox;
        private System.Windows.Forms.Button stopRegist_Btn;
        private System.Windows.Forms.TextBox videoURL_txtBox;
        private System.Windows.Forms.Label entryURL_label;
        private System.Windows.Forms.Label notifiFace_label;
        private System.Windows.Forms.Label icon_label;
        private System.Windows.Forms.PictureBox face_pictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label idlabel;
        private System.Windows.Forms.Panel alarmPanel;
        private System.Windows.Forms.Label compLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.TextBox iD_textBox;
        private System.Windows.Forms.ComboBox comp_comboBox;
        private System.Windows.Forms.Button showList_btn;
        private System.Windows.Forms.Button recordVd_btn;
        private System.Windows.Forms.Panel panel_picturebox;
        private System.Windows.Forms.TextBox numface_txtBox;
        private System.Windows.Forms.Label numFace_label;
        private System.Windows.Forms.Panel panelCount;
        private System.Windows.Forms.Label countFace_label;
        private System.Windows.Forms.ProgressBar countProgress_bar;
    }
}

