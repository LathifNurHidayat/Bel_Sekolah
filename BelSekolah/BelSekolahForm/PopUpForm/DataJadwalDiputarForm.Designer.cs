﻿namespace BelSekolah.BelSekolahForm.PopUpForm
{
    partial class DataJadwalDiputarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataJadwalDiputarForm));
            DataDiputarGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DataDiputarGrid).BeginInit();
            SuspendLayout();
            // 
            // DataDiputarGrid
            // 
            DataDiputarGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataDiputarGrid.BackgroundColor = Color.WhiteSmoke;
            DataDiputarGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataDiputarGrid.Location = new Point(12, 12);
            DataDiputarGrid.Name = "DataDiputarGrid";
            DataDiputarGrid.ReadOnly = true;
            DataDiputarGrid.RowHeadersWidth = 51;
            DataDiputarGrid.RowTemplate.Height = 29;
            DataDiputarGrid.Size = new Size(776, 426);
            DataDiputarGrid.TabIndex = 0;
            // 
            // DataJadwalDiputarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DataDiputarGrid);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DataJadwalDiputarForm";
            StartPosition = FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)DataDiputarGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DataDiputarGrid;
    }
}