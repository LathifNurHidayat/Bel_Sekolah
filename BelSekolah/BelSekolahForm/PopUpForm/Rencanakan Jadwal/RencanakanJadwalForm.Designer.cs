﻿namespace BelSekolah.BelSekolahForm.PopUpForm.Jadwalkan_Form
{
    partial class RencanakanJadwalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RencanakanJadwalForm));
            RencanakanJadwalGrid = new DataGridView();
            TambahButton = new Button();
            panel1 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)RencanakanJadwalGrid).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // RencanakanJadwalGrid
            // 
            RencanakanJadwalGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            RencanakanJadwalGrid.BackgroundColor = SystemColors.Control;
            RencanakanJadwalGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RencanakanJadwalGrid.Location = new Point(12, 72);
            RencanakanJadwalGrid.MultiSelect = false;
            RencanakanJadwalGrid.Name = "RencanakanJadwalGrid";
            RencanakanJadwalGrid.ReadOnly = true;
            RencanakanJadwalGrid.RowHeadersWidth = 51;
            RencanakanJadwalGrid.RowTemplate.Height = 29;
            RencanakanJadwalGrid.SelectionMode = DataGridViewSelectionMode.CellSelect;
            RencanakanJadwalGrid.Size = new Size(571, 315);
            RencanakanJadwalGrid.TabIndex = 24;
            RencanakanJadwalGrid.TabStop = false;
            // 
            // TambahButton
            // 
            TambahButton.Anchor = AnchorStyles.None;
            TambahButton.BackColor = Color.Goldenrod;
            TambahButton.BackgroundImageLayout = ImageLayout.Zoom;
            TambahButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TambahButton.ForeColor = Color.White;
            TambahButton.Location = new Point(12, 400);
            TambahButton.Name = "TambahButton";
            TambahButton.Size = new Size(109, 39);
            TambahButton.TabIndex = 22;
            TambahButton.Text = "Tambah";
            TambahButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            TambahButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.LightGray;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(RencanakanJadwalGrid);
            panel1.Controls.Add(TambahButton);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 453);
            panel1.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(72, 18);
            label2.Name = "label2";
            label2.Size = new Size(275, 35);
            label2.TabIndex = 27;
            label2.Text = "JADWALKAN BEL";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.schedule;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 52);
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // RencanakanJadwalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 477);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RencanakanJadwalForm";
            StartPosition = FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)RencanakanJadwalGrid).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView RencanakanJadwalGrid;
        private Button TambahButton;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
    }
}