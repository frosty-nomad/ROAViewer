
namespace ROAViewer
{
    partial class frmFind
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFind));
            this.label1 = new System.Windows.Forms.Label();
            this.cboBuy = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboSell = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboService = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnService = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSearching = new System.Windows.Forms.Label();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnTrain = new System.Windows.Forms.Button();
            this.cboTrain = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buy:";
            // 
            // cboBuy
            // 
            this.cboBuy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboBuy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboBuy.FormattingEnabled = true;
            this.cboBuy.Location = new System.Drawing.Point(42, 16);
            this.cboBuy.Name = "cboBuy";
            this.cboBuy.Size = new System.Drawing.Size(121, 21);
            this.cboBuy.TabIndex = 1;
            this.cboBuy.SelectedIndexChanged += new System.EventHandler(this.cboBuy_SelectedIndexChanged);
            this.cboBuy.TextUpdate += new System.EventHandler(this.cboBuy_TextUpdate);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sell:";
            // 
            // cboSell
            // 
            this.cboSell.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboSell.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboSell.DisplayMember = "Item2";
            this.cboSell.FormattingEnabled = true;
            this.cboSell.Location = new System.Drawing.Point(42, 43);
            this.cboSell.Name = "cboSell";
            this.cboSell.Size = new System.Drawing.Size(121, 21);
            this.cboSell.TabIndex = 3;
            this.cboSell.ValueMember = "Item1";
            this.cboSell.SelectedIndexChanged += new System.EventHandler(this.cboSell_SelectedIndexChanged);
            this.cboSell.TextUpdate += new System.EventHandler(this.cboSell_TextUpdate);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Service:";
            // 
            // cboService
            // 
            this.cboService.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboService.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboService.FormattingEnabled = true;
            this.cboService.Location = new System.Drawing.Point(288, 16);
            this.cboService.Name = "cboService";
            this.cboService.Size = new System.Drawing.Size(121, 21);
            this.cboService.TabIndex = 5;
            this.cboService.SelectedIndexChanged += new System.EventHandler(this.cboService_SelectedIndexChanged);
            this.cboService.TextUpdate += new System.EventHandler(this.cboService_TextUpdate);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTrain);
            this.groupBox1.Controls.Add(this.cboTrain);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnService);
            this.groupBox1.Controls.Add(this.btnSell);
            this.groupBox1.Controls.Add(this.btnBuy);
            this.groupBox1.Controls.Add(this.cboSell);
            this.groupBox1.Controls.Add(this.cboService);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboBuy);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 74);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // btnService
            // 
            this.btnService.Enabled = false;
            this.btnService.Location = new System.Drawing.Point(415, 16);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(53, 21);
            this.btnService.TabIndex = 8;
            this.btnService.Text = "Find";
            this.btnService.UseVisualStyleBackColor = true;
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            // 
            // btnSell
            // 
            this.btnSell.Enabled = false;
            this.btnSell.Location = new System.Drawing.Point(169, 43);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(53, 21);
            this.btnSell.TabIndex = 7;
            this.btnSell.Text = "Find";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.Enabled = false;
            this.btnBuy.Location = new System.Drawing.Point(169, 16);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(53, 21);
            this.btnBuy.TabIndex = 6;
            this.btnBuy.Text = "Find";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSearching);
            this.groupBox2.Controls.Add(this.dgvResults);
            this.groupBox2.Location = new System.Drawing.Point(8, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 420);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results";
            // 
            // lblSearching
            // 
            this.lblSearching.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearching.Location = new System.Drawing.Point(1, 196);
            this.lblSearching.Name = "lblSearching";
            this.lblSearching.Size = new System.Drawing.Size(476, 19);
            this.lblSearching.TabIndex = 1;
            this.lblSearching.Text = "Searching Vendors...";
            this.lblSearching.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvResults
            // 
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3,
            this.Column5});
            this.dgvResults.Location = new System.Drawing.Point(4, 19);
            this.dgvResults.MultiSelect = false;
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.RowHeadersVisible = false;
            this.dgvResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResults.ShowEditingIcon = false;
            this.dgvResults.Size = new System.Drawing.Size(470, 393);
            this.dgvResults.TabIndex = 0;
            this.dgvResults.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResults_CellContentClick);
            this.dgvResults.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvResults_CellFormatting);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.DataPropertyName = "Map";
            this.Column1.HeaderText = "Map";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 34;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.DataPropertyName = "Location";
            this.Column2.HeaderText = "Location";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 54;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.DataPropertyName = "Vendor";
            this.Column4.HeaderText = "Vendor";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column4.Width = 47;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.DataPropertyName = "Item";
            this.Column3.HeaderText = "Item";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 33;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Coords";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            this.Column5.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column5.HeaderText = "";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column5.Text = "Go to Map";
            // 
            // btnTrain
            // 
            this.btnTrain.Enabled = false;
            this.btnTrain.Location = new System.Drawing.Point(415, 43);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(53, 21);
            this.btnTrain.TabIndex = 11;
            this.btnTrain.Text = "Find";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // cboTrain
            // 
            this.cboTrain.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboTrain.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboTrain.FormattingEnabled = true;
            this.cboTrain.Location = new System.Drawing.Point(288, 43);
            this.cboTrain.Name = "cboTrain";
            this.cboTrain.Size = new System.Drawing.Size(121, 21);
            this.cboTrain.TabIndex = 10;
            this.cboTrain.SelectedIndexChanged += new System.EventHandler(this.cboTrain_SelectedIndexChanged);
            this.cboTrain.TextUpdate += new System.EventHandler(this.cboTrain_TextUpdate);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Training:";
            // 
            // frmFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 516);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFind";
            this.Text = "Find Vendor";
            this.Load += new System.EventHandler(this.frmFind_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboBuy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboSell;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboService;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnService;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.Label lblSearching;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.ComboBox cboTrain;
        private System.Windows.Forms.Label label4;
    }
}