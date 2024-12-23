﻿namespace BelSekolah.BelSekolahForm
{
    partial class JadwalBelForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JadwalBelForm));
            MainPanel = new Panel();
            JadwalkanButton = new Button();
            JadwalNormalRadio = new RadioButton();
            TambahNormalButton = new Button();
            DeleteNormalButton = new Button();
            JadwalNormalGrid = new DataGridView();
            JadwalKhususGrid = new DataGridView();
            TambahKhususButton = new Button();
            DeleteKhususButton = new Button();
            JadwalKhususRadio = new RadioButton();
            StartStopButton = new Button();
            HariCombo = new ComboBox();
            panel5 = new Panel();
            RunningLabel = new Label();
            label3 = new Label();
            HariText = new TextBox();
            contextMenuStrip2 = new ContextMenuStrip(components);
            JadwalKhususToolStripMenuItem = new ToolStripMenuItem();
            JadwalUjianToolStripMenuItem1 = new ToolStripMenuItem();
            panel2 = new Panel();
            DetailJadwalLinkLabel = new LinkLabel();
            JamLabel = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)JadwalNormalGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)JadwalKhususGrid).BeginInit();
            panel5.SuspendLayout();
            contextMenuStrip2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MainPanel.BackColor = Color.LightGray;
            MainPanel.BorderStyle = BorderStyle.FixedSingle;
            MainPanel.Controls.Add(JadwalkanButton);
            MainPanel.Controls.Add(JadwalNormalRadio);
            MainPanel.Controls.Add(TambahNormalButton);
            MainPanel.Controls.Add(DeleteNormalButton);
            MainPanel.Controls.Add(JadwalNormalGrid);
            MainPanel.Controls.Add(JadwalKhususGrid);
            MainPanel.Controls.Add(TambahKhususButton);
            MainPanel.Controls.Add(DeleteKhususButton);
            MainPanel.Controls.Add(JadwalKhususRadio);
            MainPanel.Controls.Add(StartStopButton);
            MainPanel.Controls.Add(HariCombo);
            MainPanel.Controls.Add(panel5);
            MainPanel.Location = new Point(10, 90);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1208, 576);
            MainPanel.TabIndex = 0;
            // 
            // JadwalkanButton
            // 
            JadwalkanButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            JadwalkanButton.BackColor = Color.DarkKhaki;
            JadwalkanButton.BackgroundImageLayout = ImageLayout.Stretch;
            JadwalkanButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            JadwalkanButton.ForeColor = Color.WhiteSmoke;
            JadwalkanButton.Image = Properties.Resources.schedule__1_;
            JadwalkanButton.Location = new Point(922, 48);
            JadwalkanButton.Name = "JadwalkanButton";
            JadwalkanButton.Size = new Size(140, 39);
            JadwalkanButton.TabIndex = 7;
            JadwalkanButton.Text = "Jadwalkan Bel";
            JadwalkanButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            JadwalkanButton.UseVisualStyleBackColor = false;
            // 
            // JadwalNormalRadio
            // 
            JadwalNormalRadio.AutoSize = true;
            JadwalNormalRadio.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            JadwalNormalRadio.Location = new Point(20, 93);
            JadwalNormalRadio.Name = "JadwalNormalRadio";
            JadwalNormalRadio.Size = new Size(145, 27);
            JadwalNormalRadio.TabIndex = 1;
            JadwalNormalRadio.Text = "Jadwal Normal";
            JadwalNormalRadio.UseVisualStyleBackColor = true;
            // 
            // TambahNormalButton
            // 
            TambahNormalButton.Anchor = AnchorStyles.None;
            TambahNormalButton.BackColor = Color.Goldenrod;
            TambahNormalButton.BackgroundImageLayout = ImageLayout.Zoom;
            TambahNormalButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TambahNormalButton.ForeColor = Color.White;
            TambahNormalButton.ImageAlign = ContentAlignment.MiddleLeft;
            TambahNormalButton.Location = new Point(20, 513);
            TambahNormalButton.Name = "TambahNormalButton";
            TambahNormalButton.Size = new Size(109, 39);
            TambahNormalButton.TabIndex = 2;
            TambahNormalButton.Text = "Tambah";
            TambahNormalButton.TextImageRelation = TextImageRelation.TextAboveImage;
            TambahNormalButton.UseVisualStyleBackColor = false;
            // 
            // DeleteNormalButton
            // 
            DeleteNormalButton.Anchor = AnchorStyles.None;
            DeleteNormalButton.BackColor = Color.Red;
            DeleteNormalButton.BackgroundImageLayout = ImageLayout.Zoom;
            DeleteNormalButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteNormalButton.ForeColor = Color.White;
            DeleteNormalButton.Location = new Point(135, 513);
            DeleteNormalButton.Name = "DeleteNormalButton";
            DeleteNormalButton.Size = new Size(109, 39);
            DeleteNormalButton.TabIndex = 3;
            DeleteNormalButton.Text = "Delete";
            DeleteNormalButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            DeleteNormalButton.UseVisualStyleBackColor = false;
            // 
            // JadwalNormalGrid
            // 
            JadwalNormalGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            JadwalNormalGrid.BackgroundColor = SystemColors.Control;
            JadwalNormalGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            JadwalNormalGrid.Location = new Point(20, 140);
            JadwalNormalGrid.MultiSelect = false;
            JadwalNormalGrid.Name = "JadwalNormalGrid";
            JadwalNormalGrid.ReadOnly = true;
            JadwalNormalGrid.RowHeadersWidth = 51;
            JadwalNormalGrid.RowTemplate.Height = 29;
            JadwalNormalGrid.SelectionMode = DataGridViewSelectionMode.CellSelect;
            JadwalNormalGrid.Size = new Size(561, 334);
            JadwalNormalGrid.TabIndex = 22;
            JadwalNormalGrid.TabStop = false;
            // 
            // JadwalKhususGrid
            // 
            JadwalKhususGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            JadwalKhususGrid.BackgroundColor = SystemColors.Control;
            JadwalKhususGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            JadwalKhususGrid.Location = new Point(615, 140);
            JadwalKhususGrid.MultiSelect = false;
            JadwalKhususGrid.Name = "JadwalKhususGrid";
            JadwalKhususGrid.ReadOnly = true;
            JadwalKhususGrid.RowHeadersWidth = 51;
            JadwalKhususGrid.RowTemplate.Height = 29;
            JadwalKhususGrid.SelectionMode = DataGridViewSelectionMode.CellSelect;
            JadwalKhususGrid.Size = new Size(570, 334);
            JadwalKhususGrid.TabIndex = 21;
            JadwalKhususGrid.TabStop = false;
            // 
            // TambahKhususButton
            // 
            TambahKhususButton.Anchor = AnchorStyles.None;
            TambahKhususButton.BackColor = Color.Goldenrod;
            TambahKhususButton.BackgroundImageLayout = ImageLayout.Zoom;
            TambahKhususButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TambahKhususButton.ForeColor = Color.White;
            TambahKhususButton.Location = new Point(615, 513);
            TambahKhususButton.Name = "TambahKhususButton";
            TambahKhususButton.Size = new Size(109, 39);
            TambahKhususButton.TabIndex = 5;
            TambahKhususButton.Text = "Tambah";
            TambahKhususButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            TambahKhususButton.UseVisualStyleBackColor = false;
            // 
            // DeleteKhususButton
            // 
            DeleteKhususButton.Anchor = AnchorStyles.None;
            DeleteKhususButton.BackColor = Color.Red;
            DeleteKhususButton.BackgroundImageLayout = ImageLayout.Zoom;
            DeleteKhususButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteKhususButton.ForeColor = Color.White;
            DeleteKhususButton.Location = new Point(730, 513);
            DeleteKhususButton.Name = "DeleteKhususButton";
            DeleteKhususButton.Size = new Size(109, 39);
            DeleteKhususButton.TabIndex = 6;
            DeleteKhususButton.Text = "Delete";
            DeleteKhususButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            DeleteKhususButton.UseVisualStyleBackColor = false;
            // 
            // JadwalKhususRadio
            // 
            JadwalKhususRadio.AutoSize = true;
            JadwalKhususRadio.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            JadwalKhususRadio.Location = new Point(600, 93);
            JadwalKhususRadio.Name = "JadwalKhususRadio";
            JadwalKhususRadio.Size = new Size(142, 27);
            JadwalKhususRadio.TabIndex = 4;
            JadwalKhususRadio.Text = "Jadwal Khusus";
            JadwalKhususRadio.UseVisualStyleBackColor = true;
            // 
            // StartStopButton
            // 
            StartStopButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            StartStopButton.BackColor = Color.LimeGreen;
            StartStopButton.BackgroundImageLayout = ImageLayout.Zoom;
            StartStopButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            StartStopButton.ForeColor = Color.White;
            StartStopButton.Location = new Point(1076, 49);
            StartStopButton.Name = "StartStopButton";
            StartStopButton.Size = new Size(109, 39);
            StartStopButton.TabIndex = 8;
            StartStopButton.Text = "Start";
            StartStopButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            StartStopButton.UseVisualStyleBackColor = false;
            // 
            // HariCombo
            // 
            HariCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            HariCombo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            HariCombo.FormattingEnabled = true;
            HariCombo.Location = new Point(20, 54);
            HariCombo.Name = "HariCombo";
            HariCombo.Size = new Size(151, 36);
            HariCombo.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Gainsboro;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(RunningLabel);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1206, 42);
            panel5.TabIndex = 1;
            // 
            // RunningLabel
            // 
            RunningLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RunningLabel.AutoSize = true;
            RunningLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            RunningLabel.Location = new Point(1069, 7);
            RunningLabel.Name = "RunningLabel";
            RunningLabel.Size = new Size(123, 25);
            RunningLabel.TabIndex = 15;
            RunningLabel.Text = "Stopped . . . .";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(633, 28);
            label3.Name = "label3";
            label3.Size = new Size(53, 22);
            label3.TabIndex = 17;
            label3.Text = "Hari :";
            // 
            // HariText
            // 
            HariText.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            HariText.BackColor = Color.WhiteSmoke;
            HariText.BorderStyle = BorderStyle.FixedSingle;
            HariText.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            HariText.Location = new Point(689, 25);
            HariText.Name = "HariText";
            HariText.ReadOnly = true;
            HariText.Size = new Size(92, 28);
            HariText.TabIndex = 16;
            HariText.TabStop = false;
            HariText.TextAlign = HorizontalAlignment.Center;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { JadwalKhususToolStripMenuItem, JadwalUjianToolStripMenuItem1 });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(195, 60);
            // 
            // JadwalKhususToolStripMenuItem
            // 
            JadwalKhususToolStripMenuItem.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            JadwalKhususToolStripMenuItem.Image = Properties.Resources.schedule;
            JadwalKhususToolStripMenuItem.Name = "JadwalKhususToolStripMenuItem";
            JadwalKhususToolStripMenuItem.Size = new Size(194, 28);
            JadwalKhususToolStripMenuItem.Text = "Jadwal Khusus";
            // 
            // JadwalUjianToolStripMenuItem1
            // 
            JadwalUjianToolStripMenuItem1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            JadwalUjianToolStripMenuItem1.Image = Properties.Resources.time;
            JadwalUjianToolStripMenuItem1.Name = "JadwalUjianToolStripMenuItem1";
            JadwalUjianToolStripMenuItem1.Size = new Size(194, 28);
            JadwalUjianToolStripMenuItem1.Text = "Jadwal Ujian";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.LightGray;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(DetailJadwalLinkLabel);
            panel2.Controls.Add(JamLabel);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(HariText);
            panel2.Location = new Point(10, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(1207, 75);
            panel2.TabIndex = 5;
            // 
            // DetailJadwalLinkLabel
            // 
            DetailJadwalLinkLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DetailJadwalLinkLabel.AutoSize = true;
            DetailJadwalLinkLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            DetailJadwalLinkLabel.Location = new Point(823, 28);
            DetailJadwalLinkLabel.Name = "DetailJadwalLinkLabel";
            DetailJadwalLinkLabel.Size = new Size(215, 23);
            DetailJadwalLinkLabel.TabIndex = 18;
            DetailJadwalLinkLabel.Text = "Detail Jadwal Yang Diputar";
            // 
            // JamLabel
            // 
            JamLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            JamLabel.AutoSize = true;
            JamLabel.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            JamLabel.Location = new Point(1068, 18);
            JamLabel.Name = "JamLabel";
            JamLabel.Size = new Size(127, 38);
            JamLabel.TabIndex = 5;
            JamLabel.Text = "00:00:00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(100, 21);
            label1.Name = "label1";
            label1.Size = new Size(330, 35);
            label1.TabIndex = 3;
            label1.Text = "BEL SMKN 1 BANTUL";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.SMKN___BANTUL;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(-19, -19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(117, 115);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // JadwalBelForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1227, 676);
            Controls.Add(panel2);
            Controls.Add(MainPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "JadwalBelForm";
            StartPosition = FormStartPosition.CenterScreen;
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)JadwalNormalGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)JadwalKhususGrid).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            contextMenuStrip2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button TambahKhususButton;
        private Panel MainPanel;
        private DataGridView JadwalNormalGrid;
        private Panel panel5;
        private RadioButton JadwalKhususRadio;
        private ComboBox HariCombo;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem JadwalKhususToolStripMenuItem;
        private ToolStripMenuItem JadwalUjianToolStripMenuItem1;
        private Panel panel2;
        private Label JamLabel;
        private Label label1;
        private PictureBox pictureBox1;
        private Button StartStopButton;
        private Label RunningLabel;
        private TextBox HariText;
        private Label label3;
        private Button DeleteKhususButton;
        private Button TambahNormalButton;
        private Button DeleteNormalButton;
        private Panel JadwalNormalPanel;
        private Panel JadwalKhususPanel;
        private DataGridView JadwalKhususGrid;
        private RadioButton JadwalNormalRadio;
        private Button JadwalkanButton;
        private LinkLabel DetailJadwalLinkLabel;
    }
}