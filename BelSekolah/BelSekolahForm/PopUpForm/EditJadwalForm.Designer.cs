﻿namespace BelSekolah.BelSekolahForm.PopUpForm
{
    partial class EditJadwalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditJadwalForm));
            SaveButton = new Button();
            WaktuPicker = new DateTimePicker();
            panel1 = new Panel();
            KeteranganText = new TextBox();
            panel3 = new Panel();
            label1 = new Label();
            label3 = new Label();
            SoundFileText = new TextBox();
            label4 = new Label();
            PausePlayButton = new Button();
            BrowseButton = new Button();
            JenisJadwalLabel = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.LimeGreen;
            SaveButton.FlatAppearance.BorderColor = Color.Black;
            SaveButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SaveButton.ForeColor = Color.White;
            SaveButton.Location = new Point(317, 394);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(115, 38);
            SaveButton.TabIndex = 76;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            // 
            // WaktuPicker
            // 
            WaktuPicker.CustomFormat = "HH:mm";
            WaktuPicker.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            WaktuPicker.Format = DateTimePickerFormat.Custom;
            WaktuPicker.Location = new Point(13, 14);
            WaktuPicker.Name = "WaktuPicker";
            WaktuPicker.ShowUpDown = true;
            WaktuPicker.Size = new Size(83, 30);
            WaktuPicker.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(WaktuPicker);
            panel1.Location = new Point(20, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(412, 59);
            panel1.TabIndex = 64;
            // 
            // KeteranganText
            // 
            KeteranganText.BorderStyle = BorderStyle.FixedSingle;
            KeteranganText.Location = new Point(3, 4);
            KeteranganText.MaxLength = 30;
            KeteranganText.Multiline = true;
            KeteranganText.Name = "KeteranganText";
            KeteranganText.Size = new Size(404, 68);
            KeteranganText.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(KeteranganText);
            panel3.Location = new Point(20, 176);
            panel3.Name = "panel3";
            panel3.Size = new Size(412, 78);
            panel3.TabIndex = 66;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(20, 42);
            label1.Name = "label1";
            label1.Size = new Size(58, 23);
            label1.TabIndex = 63;
            label1.Text = "Waktu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(20, 150);
            label3.Name = "label3";
            label3.Size = new Size(98, 23);
            label3.TabIndex = 68;
            label3.Text = "Keterangan";
            // 
            // SoundFileText
            // 
            SoundFileText.BorderStyle = BorderStyle.FixedSingle;
            SoundFileText.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            SoundFileText.Location = new Point(20, 301);
            SoundFileText.Name = "SoundFileText";
            SoundFileText.ReadOnly = true;
            SoundFileText.Size = new Size(251, 30);
            SoundFileText.TabIndex = 70;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(20, 271);
            label4.Name = "label4";
            label4.Size = new Size(84, 23);
            label4.TabIndex = 72;
            label4.Text = "SoundFile";
            // 
            // PausePlayButton
            // 
            PausePlayButton.BackColor = Color.Gainsboro;
            PausePlayButton.BackgroundImageLayout = ImageLayout.Zoom;
            PausePlayButton.FlatAppearance.BorderColor = Color.Black;
            PausePlayButton.FlatStyle = FlatStyle.Flat;
            PausePlayButton.Location = new Point(292, 300);
            PausePlayButton.Name = "PausePlayButton";
            PausePlayButton.Size = new Size(30, 30);
            PausePlayButton.TabIndex = 74;
            PausePlayButton.UseVisualStyleBackColor = false;
            // 
            // BrowseButton
            // 
            BrowseButton.BackColor = Color.Gainsboro;
            BrowseButton.FlatAppearance.BorderColor = Color.Black;
            BrowseButton.FlatStyle = FlatStyle.Flat;
            BrowseButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            BrowseButton.Location = new Point(338, 300);
            BrowseButton.Name = "BrowseButton";
            BrowseButton.Size = new Size(94, 29);
            BrowseButton.TabIndex = 75;
            BrowseButton.Text = "Browse";
            BrowseButton.UseVisualStyleBackColor = false;
            // 
            // JenisJadwalLabel
            // 
            JenisJadwalLabel.AutoSize = true;
            JenisJadwalLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            JenisJadwalLabel.Location = new Point(175, 11);
            JenisJadwalLabel.Name = "JenisJadwalLabel";
            JenisJadwalLabel.Size = new Size(96, 23);
            JenisJadwalLabel.TabIndex = 78;
            JenisJadwalLabel.Text = "JenisJadwal";
            // 
            // EditJadwalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(453, 449);
            Controls.Add(JenisJadwalLabel);
            Controls.Add(SaveButton);
            Controls.Add(BrowseButton);
            Controls.Add(PausePlayButton);
            Controls.Add(label4);
            Controls.Add(SoundFileText);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditJadwalForm";
            StartPosition = FormStartPosition.CenterParent;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SaveButton;
        private DateTimePicker WaktuPicker;
        private Panel panel1;
        private TextBox KeteranganText;
        private Panel panel3;
        private Label label1;
        private Label label3;
        private TextBox SoundFileText;
        private Label label4;
        private Button PausePlayButton;
        private Button BrowseButton;
        private Label JenisJadwalLabel;
    }
}