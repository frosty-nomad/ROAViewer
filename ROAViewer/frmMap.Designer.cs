
namespace ROAViewer
{
    partial class frmMap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMap));
            this.btnClear = new System.Windows.Forms.Button();
            this.picMap = new System.Windows.Forms.PictureBox();
            this.splitMap = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lstMaps = new System.Windows.Forms.ListBox();
            this.lblMapset = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.lblMapIndex = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblYPos = new System.Windows.Forms.Label();
            this.lblXPos = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitMap)).BeginInit();
            this.splitMap.Panel1.SuspendLayout();
            this.splitMap.Panel2.SuspendLayout();
            this.splitMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(185, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(84, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear Marker";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // picMap
            // 
            this.picMap.Location = new System.Drawing.Point(0, 0);
            this.picMap.Name = "picMap";
            this.picMap.Size = new System.Drawing.Size(86, 43);
            this.picMap.TabIndex = 0;
            this.picMap.TabStop = false;
            this.picMap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picMap_MouseClick);
            this.picMap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picMap_MouseMove);
            // 
            // splitMap
            // 
            this.splitMap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitMap.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMap.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitMap.Location = new System.Drawing.Point(0, 0);
            this.splitMap.Name = "splitMap";
            this.splitMap.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitMap.Panel1
            // 
            this.splitMap.Panel1.Controls.Add(this.lblMapset);
            this.splitMap.Panel1.Controls.Add(this.label8);
            this.splitMap.Panel1.Controls.Add(this.label69);
            this.splitMap.Panel1.Controls.Add(this.lblMapIndex);
            this.splitMap.Panel1.Controls.Add(this.label12);
            this.splitMap.Panel1.Controls.Add(this.lblYPos);
            this.splitMap.Panel1.Controls.Add(this.lblXPos);
            this.splitMap.Panel1.Controls.Add(this.label9);
            this.splitMap.Panel1.Controls.Add(this.btnClear);
            this.splitMap.Panel1.Cursor = System.Windows.Forms.Cursors.Default;
            // 
            // splitMap.Panel2
            // 
            this.splitMap.Panel2.AutoScroll = true;
            this.splitMap.Panel2.Controls.Add(this.splitContainer1);
            this.splitMap.Panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitMap.Size = new System.Drawing.Size(902, 705);
            this.splitMap.SplitterDistance = 35;
            this.splitMap.SplitterWidth = 3;
            this.splitMap.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lstMaps);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.picMap);
            this.splitContainer1.Size = new System.Drawing.Size(902, 667);
            this.splitContainer1.SplitterDistance = 143;
            this.splitContainer1.TabIndex = 0;
            // 
            // lstMaps
            // 
            this.lstMaps.DisplayMember = "Item1";
            this.lstMaps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstMaps.FormattingEnabled = true;
            this.lstMaps.Location = new System.Drawing.Point(0, 0);
            this.lstMaps.Name = "lstMaps";
            this.lstMaps.Size = new System.Drawing.Size(139, 663);
            this.lstMaps.TabIndex = 1;
            this.lstMaps.ValueMember = "Item2";
            this.lstMaps.SelectedIndexChanged += new System.EventHandler(this.lstMaps_SelectedIndexChanged);
            // 
            // lblMapset
            // 
            this.lblMapset.AutoSize = true;
            this.lblMapset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMapset.Location = new System.Drawing.Point(53, 9);
            this.lblMapset.Name = "lblMapset";
            this.lblMapset.Size = new System.Drawing.Size(14, 15);
            this.lblMapset.TabIndex = 16;
            this.lblMapset.Text = "9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Map: Set:";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(66, 10);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(24, 13);
            this.label69.TabIndex = 17;
            this.label69.Text = "Idx:";
            // 
            // lblMapIndex
            // 
            this.lblMapIndex.AutoSize = true;
            this.lblMapIndex.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMapIndex.Location = new System.Drawing.Point(87, 9);
            this.lblMapIndex.Name = "lblMapIndex";
            this.lblMapIndex.Size = new System.Drawing.Size(21, 15);
            this.lblMapIndex.TabIndex = 18;
            this.lblMapIndex.Text = "99";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(144, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Y:";
            // 
            // lblYPos
            // 
            this.lblYPos.AutoSize = true;
            this.lblYPos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblYPos.Location = new System.Drawing.Point(158, 9);
            this.lblYPos.Name = "lblYPos";
            this.lblYPos.Size = new System.Drawing.Size(21, 15);
            this.lblYPos.TabIndex = 15;
            this.lblYPos.Text = "99";
            // 
            // lblXPos
            // 
            this.lblXPos.AutoSize = true;
            this.lblXPos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblXPos.Location = new System.Drawing.Point(124, 9);
            this.lblXPos.Name = "lblXPos";
            this.lblXPos.Size = new System.Drawing.Size(21, 15);
            this.lblXPos.TabIndex = 13;
            this.lblXPos.Text = "99";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(110, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "X:";
            // 
            // frmMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 705);
            this.Controls.Add(this.splitMap);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMap";
            this.Text = "Map Select";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMap_FormClosing);
            this.Load += new System.EventHandler(this.frmMap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMap)).EndInit();
            this.splitMap.Panel1.ResumeLayout(false);
            this.splitMap.Panel1.PerformLayout();
            this.splitMap.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMap)).EndInit();
            this.splitMap.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picMap;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.SplitContainer splitMap;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox lstMaps;
        private System.Windows.Forms.Label lblMapset;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Label lblMapIndex;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblYPos;
        private System.Windows.Forms.Label lblXPos;
        private System.Windows.Forms.Label label9;
    }
}