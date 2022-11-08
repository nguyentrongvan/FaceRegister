
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.configBtn = new System.Windows.Forms.Button();
            this.panelCount = new System.Windows.Forms.Panel();
            this.countProgress_bar = new System.Windows.Forms.ProgressBar();
            this.countFace_label = new System.Windows.Forms.Label();
            this.panel_picturebox = new System.Windows.Forms.Panel();
            this.face_pictureBox = new System.Windows.Forms.PictureBox();
            this.recordVd_btn = new System.Windows.Forms.Button();
            this.showList_btn = new System.Windows.Forms.Button();
            this.stopRegist_Btn = new System.Windows.Forms.Button();
            this.registerBtn = new System.Windows.Forms.Button();
            this.alarmPanel = new System.Windows.Forms.Panel();
            this.notifiFace_label = new System.Windows.Forms.Label();
            this.icon_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numface_txtBox = new System.Windows.Forms.TextBox();
            this.numFace_label = new System.Windows.Forms.Label();
            this.comp_comboBox = new System.Windows.Forms.ComboBox();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.iD_textBox = new System.Windows.Forms.TextBox();
            this.compLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.idlabel = new System.Windows.Forms.Label();
            this.entryURL_label = new System.Windows.Forms.Label();
            this.videoURL_txtBox = new System.Windows.Forms.TextBox();
            this.videoShow_picBox = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Titlelabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelCount.SuspendLayout();
            this.panel_picturebox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.face_pictureBox)).BeginInit();
            this.alarmPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoShow_picBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(122, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(0, 0);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.closeBtn);
            this.panel2.Controls.Add(this.configBtn);
            this.panel2.Controls.Add(this.panelCount);
            this.panel2.Controls.Add(this.panel_picturebox);
            this.panel2.Controls.Add(this.recordVd_btn);
            this.panel2.Controls.Add(this.showList_btn);
            this.panel2.Controls.Add(this.stopRegist_Btn);
            this.panel2.Controls.Add(this.registerBtn);
            this.panel2.Controls.Add(this.alarmPanel);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.entryURL_label);
            this.panel2.Controls.Add(this.videoURL_txtBox);
            this.panel2.Controls.Add(this.videoShow_picBox);
            this.panel2.Location = new System.Drawing.Point(12, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(933, 576);
            this.panel2.TabIndex = 17;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.closeBtn.Font = new System.Drawing.Font("UD Digi Kyokasho NP-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.closeBtn.ForeColor = System.Drawing.Color.Azure;
            this.closeBtn.Location = new System.Drawing.Point(804, 509);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(113, 52);
            this.closeBtn.TabIndex = 29;
            this.closeBtn.Text = "↩️ Close";
            this.closeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // configBtn
            // 
            this.configBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.configBtn.Font = new System.Drawing.Font("UD Digi Kyokasho NP-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.configBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.configBtn.Location = new System.Drawing.Point(676, 509);
            this.configBtn.Name = "configBtn";
            this.configBtn.Size = new System.Drawing.Size(122, 53);
            this.configBtn.TabIndex = 28;
            this.configBtn.Text = " 📝 Config";
            this.configBtn.UseVisualStyleBackColor = false;
            this.configBtn.Click += new System.EventHandler(this.configBtn_Click);
            // 
            // panelCount
            // 
            this.panelCount.BackColor = System.Drawing.Color.AliceBlue;
            this.panelCount.Controls.Add(this.countProgress_bar);
            this.panelCount.Controls.Add(this.countFace_label);
            this.panelCount.Location = new System.Drawing.Point(19, 511);
            this.panelCount.Name = "panelCount";
            this.panelCount.Size = new System.Drawing.Size(499, 51);
            this.panelCount.TabIndex = 24;
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
            // panel_picturebox
            // 
            this.panel_picturebox.BackColor = System.Drawing.Color.AliceBlue;
            this.panel_picturebox.Controls.Add(this.face_pictureBox);
            this.panel_picturebox.Location = new System.Drawing.Point(547, 450);
            this.panel_picturebox.Name = "panel_picturebox";
            this.panel_picturebox.Size = new System.Drawing.Size(112, 112);
            this.panel_picturebox.TabIndex = 27;
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
            // recordVd_btn
            // 
            this.recordVd_btn.BackColor = System.Drawing.Color.MistyRose;
            this.recordVd_btn.Font = new System.Drawing.Font("UD Digi Kyokasho NP-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.recordVd_btn.ForeColor = System.Drawing.Color.Purple;
            this.recordVd_btn.Location = new System.Drawing.Point(804, 445);
            this.recordVd_btn.Name = "recordVd_btn";
            this.recordVd_btn.Size = new System.Drawing.Size(113, 52);
            this.recordVd_btn.TabIndex = 26;
            this.recordVd_btn.Text = "📽 Record Video ";
            this.recordVd_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.recordVd_btn.UseVisualStyleBackColor = false;
            this.recordVd_btn.Click += new System.EventHandler(this.recordVd_btn_Click);
            // 
            // showList_btn
            // 
            this.showList_btn.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.showList_btn.Font = new System.Drawing.Font("UD Digi Kyokasho NP-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.showList_btn.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.showList_btn.Location = new System.Drawing.Point(676, 445);
            this.showList_btn.Name = "showList_btn";
            this.showList_btn.Size = new System.Drawing.Size(122, 53);
            this.showList_btn.TabIndex = 25;
            this.showList_btn.Text = " 🎞 List Recored";
            this.showList_btn.UseVisualStyleBackColor = false;
            this.showList_btn.Click += new System.EventHandler(this.showList_btn_Click);
            // 
            // stopRegist_Btn
            // 
            this.stopRegist_Btn.BackColor = System.Drawing.Color.Pink;
            this.stopRegist_Btn.Font = new System.Drawing.Font("UD Digi Kyokasho NP-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.stopRegist_Btn.ForeColor = System.Drawing.Color.Crimson;
            this.stopRegist_Btn.Location = new System.Drawing.Point(804, 385);
            this.stopRegist_Btn.Name = "stopRegist_Btn";
            this.stopRegist_Btn.Size = new System.Drawing.Size(113, 52);
            this.stopRegist_Btn.TabIndex = 19;
            this.stopRegist_Btn.Text = "⏹️ Stop Register";
            this.stopRegist_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.stopRegist_Btn.UseVisualStyleBackColor = false;
            this.stopRegist_Btn.Click += new System.EventHandler(this.stopRegist_Btn_Click);
            // 
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.Color.Aquamarine;
            this.registerBtn.Font = new System.Drawing.Font("UD Digi Kyokasho NP-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.registerBtn.ForeColor = System.Drawing.Color.DarkGreen;
            this.registerBtn.Location = new System.Drawing.Point(676, 384);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(122, 53);
            this.registerBtn.TabIndex = 17;
            this.registerBtn.Text = "▶️ Start Register";
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // alarmPanel
            // 
            this.alarmPanel.BackColor = System.Drawing.Color.AliceBlue;
            this.alarmPanel.Controls.Add(this.notifiFace_label);
            this.alarmPanel.Controls.Add(this.icon_label);
            this.alarmPanel.Location = new System.Drawing.Point(19, 450);
            this.alarmPanel.Name = "alarmPanel";
            this.alarmPanel.Size = new System.Drawing.Size(499, 51);
            this.alarmPanel.TabIndex = 23;
            this.alarmPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.alarmPanel_Paint);
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
            this.panel1.Location = new System.Drawing.Point(676, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 325);
            this.panel1.TabIndex = 22;
            // 
            // numface_txtBox
            // 
            this.numface_txtBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numface_txtBox.Location = new System.Drawing.Point(19, 204);
            this.numface_txtBox.Name = "numface_txtBox";
            this.numface_txtBox.Size = new System.Drawing.Size(196, 26);
            this.numface_txtBox.TabIndex = 8;
            this.numface_txtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numFace_label
            // 
            this.numFace_label.AutoSize = true;
            this.numFace_label.Font = new System.Drawing.Font("UD Digi Kyokasho NP-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numFace_label.Location = new System.Drawing.Point(16, 183);
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
            this.comp_comboBox.Location = new System.Drawing.Point(19, 144);
            this.comp_comboBox.Name = "comp_comboBox";
            this.comp_comboBox.Size = new System.Drawing.Size(196, 26);
            this.comp_comboBox.TabIndex = 6;
            // 
            // name_textBox
            // 
            this.name_textBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_textBox.Location = new System.Drawing.Point(19, 87);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(196, 26);
            this.name_textBox.TabIndex = 5;
            this.name_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // iD_textBox
            // 
            this.iD_textBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iD_textBox.Location = new System.Drawing.Point(19, 29);
            this.iD_textBox.Name = "iD_textBox";
            this.iD_textBox.Size = new System.Drawing.Size(196, 26);
            this.iD_textBox.TabIndex = 3;
            this.iD_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // compLabel
            // 
            this.compLabel.AutoSize = true;
            this.compLabel.Font = new System.Drawing.Font("UD Digi Kyokasho NP-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.compLabel.Location = new System.Drawing.Point(16, 122);
            this.compLabel.Name = "compLabel";
            this.compLabel.Size = new System.Drawing.Size(80, 18);
            this.compLabel.TabIndex = 2;
            this.compLabel.Text = "Company";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("UD Digi Kyokasho NP-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nameLabel.Location = new System.Drawing.Point(16, 66);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(52, 18);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            // 
            // idlabel
            // 
            this.idlabel.AutoSize = true;
            this.idlabel.Font = new System.Drawing.Font("UD Digi Kyokasho NP-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.idlabel.Location = new System.Drawing.Point(16, 8);
            this.idlabel.Name = "idlabel";
            this.idlabel.Size = new System.Drawing.Size(57, 18);
            this.idlabel.TabIndex = 0;
            this.idlabel.Text = "No. ID";
            // 
            // entryURL_label
            // 
            this.entryURL_label.AutoSize = true;
            this.entryURL_label.Font = new System.Drawing.Font("UD Digi Kyokasho NP-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.entryURL_label.Location = new System.Drawing.Point(16, 18);
            this.entryURL_label.Name = "entryURL_label";
            this.entryURL_label.Size = new System.Drawing.Size(150, 18);
            this.entryURL_label.TabIndex = 21;
            this.entryURL_label.Text = "URL Stream Video";
            // 
            // videoURL_txtBox
            // 
            this.videoURL_txtBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.videoURL_txtBox.Location = new System.Drawing.Point(172, 14);
            this.videoURL_txtBox.Name = "videoURL_txtBox";
            this.videoURL_txtBox.Size = new System.Drawing.Size(487, 26);
            this.videoURL_txtBox.TabIndex = 20;
            this.videoURL_txtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // videoShow_picBox
            // 
            this.videoShow_picBox.BackColor = System.Drawing.Color.Cornsilk;
            this.videoShow_picBox.Location = new System.Drawing.Point(19, 51);
            this.videoShow_picBox.Name = "videoShow_picBox";
            this.videoShow_picBox.Size = new System.Drawing.Size(640, 384);
            this.videoShow_picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.videoShow_picBox.TabIndex = 18;
            this.videoShow_picBox.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // Titlelabel
            // 
            this.Titlelabel.AutoSize = true;
            this.Titlelabel.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlelabel.Location = new System.Drawing.Point(68, 12);
            this.Titlelabel.Name = "Titlelabel";
            this.Titlelabel.Size = new System.Drawing.Size(319, 36);
            this.Titlelabel.TabIndex = 19;
            this.Titlelabel.Text = "Face Register Application";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel3.Location = new System.Drawing.Point(68, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(889, 10);
            this.panel3.TabIndex = 30;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(957, 668);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Titlelabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Face Register";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelCount.ResumeLayout(false);
            this.panelCount.PerformLayout();
            this.panel_picturebox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.face_pictureBox)).EndInit();
            this.alarmPanel.ResumeLayout(false);
            this.alarmPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoShow_picBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button configBtn;
        private System.Windows.Forms.Panel panelCount;
        private System.Windows.Forms.ProgressBar countProgress_bar;
        private System.Windows.Forms.Label countFace_label;
        private System.Windows.Forms.Panel panel_picturebox;
        private System.Windows.Forms.PictureBox face_pictureBox;
        private System.Windows.Forms.Button recordVd_btn;
        private System.Windows.Forms.Button showList_btn;
        private System.Windows.Forms.Button stopRegist_Btn;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Panel alarmPanel;
        private System.Windows.Forms.Label notifiFace_label;
        private System.Windows.Forms.Label icon_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox numface_txtBox;
        private System.Windows.Forms.Label numFace_label;
        private System.Windows.Forms.ComboBox comp_comboBox;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.TextBox iD_textBox;
        private System.Windows.Forms.Label compLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label idlabel;
        private System.Windows.Forms.Label entryURL_label;
        private System.Windows.Forms.TextBox videoURL_txtBox;
        private System.Windows.Forms.PictureBox videoShow_picBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Titlelabel;
        private System.Windows.Forms.Panel panel3;
    }
}

