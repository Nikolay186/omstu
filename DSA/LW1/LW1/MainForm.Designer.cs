
namespace LW1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddNewButton = new System.Windows.Forms.ToolStripButton();
            this.sendOnTheRouteButton = new System.Windows.Forms.ToolStripButton();
            this.takeOffTheRouteButton = new System.Windows.Forms.ToolStripButton();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.sourceDataGrid = new System.Windows.Forms.DataGridView();
            this.busIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routeDataGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waitingDataGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sourceDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waitingDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNewButton,
            this.sendOnTheRouteButton,
            this.takeOffTheRouteButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AddNewButton
            // 
            this.AddNewButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AddNewButton.Image = ((System.Drawing.Image)(resources.GetObject("AddNewButton.Image")));
            this.AddNewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddNewButton.Name = "AddNewButton";
            this.AddNewButton.Size = new System.Drawing.Size(58, 22);
            this.AddNewButton.Text = "Add new";
            this.AddNewButton.Click += new System.EventHandler(this.AddNewButton_Click);
            // 
            // sendOnTheRouteButton
            // 
            this.sendOnTheRouteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.sendOnTheRouteButton.Image = ((System.Drawing.Image)(resources.GetObject("sendOnTheRouteButton.Image")));
            this.sendOnTheRouteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sendOnTheRouteButton.Name = "sendOnTheRouteButton";
            this.sendOnTheRouteButton.Size = new System.Drawing.Size(105, 22);
            this.sendOnTheRouteButton.Text = "Send on the route";
            this.sendOnTheRouteButton.Click += new System.EventHandler(this.sendOnTheRouteButton_Click);
            // 
            // takeOffTheRouteButton
            // 
            this.takeOffTheRouteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.takeOffTheRouteButton.Image = ((System.Drawing.Image)(resources.GetObject("takeOffTheRouteButton.Image")));
            this.takeOffTheRouteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.takeOffTheRouteButton.Name = "takeOffTheRouteButton";
            this.takeOffTheRouteButton.Size = new System.Drawing.Size(103, 22);
            this.takeOffTheRouteButton.Text = "Take off the route";
            this.takeOffTheRouteButton.Click += new System.EventHandler(this.takeOffTheRouteButton_Click);
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(443, 59);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(69, 13);
            this.InfoLabel.TabIndex = 5;
            this.InfoLabel.Text = "On the route:";
            // 
            // sourceDataGrid
            // 
            this.sourceDataGrid.AllowUserToAddRows = false;
            this.sourceDataGrid.AllowUserToDeleteRows = false;
            this.sourceDataGrid.AllowUserToResizeColumns = false;
            this.sourceDataGrid.AllowUserToResizeRows = false;
            this.sourceDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sourceDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.busIdColumn,
            this.driverColumn,
            this.routeColumn});
            this.sourceDataGrid.Location = new System.Drawing.Point(15, 59);
            this.sourceDataGrid.Name = "sourceDataGrid";
            this.sourceDataGrid.ReadOnly = true;
            this.sourceDataGrid.RowHeadersVisible = false;
            this.sourceDataGrid.Size = new System.Drawing.Size(270, 380);
            this.sourceDataGrid.TabIndex = 6;
            // 
            // busIdColumn
            // 
            this.busIdColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.busIdColumn.HeaderText = "Id";
            this.busIdColumn.Name = "busIdColumn";
            this.busIdColumn.ReadOnly = true;
            // 
            // driverColumn
            // 
            this.driverColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.driverColumn.HeaderText = "Driver";
            this.driverColumn.Name = "driverColumn";
            this.driverColumn.ReadOnly = true;
            // 
            // routeColumn
            // 
            this.routeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.routeColumn.HeaderText = "Route";
            this.routeColumn.Name = "routeColumn";
            this.routeColumn.ReadOnly = true;
            // 
            // routeDataGrid
            // 
            this.routeDataGrid.AllowUserToAddRows = false;
            this.routeDataGrid.AllowUserToDeleteRows = false;
            this.routeDataGrid.AllowUserToResizeColumns = false;
            this.routeDataGrid.AllowUserToResizeRows = false;
            this.routeDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.routeDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.routeDataGrid.Location = new System.Drawing.Point(518, 59);
            this.routeDataGrid.Name = "routeDataGrid";
            this.routeDataGrid.ReadOnly = true;
            this.routeDataGrid.RowHeadersVisible = false;
            this.routeDataGrid.Size = new System.Drawing.Size(270, 190);
            this.routeDataGrid.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Driver";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Route";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // waitingDataGrid
            // 
            this.waitingDataGrid.AllowUserToAddRows = false;
            this.waitingDataGrid.AllowUserToDeleteRows = false;
            this.waitingDataGrid.AllowUserToResizeColumns = false;
            this.waitingDataGrid.AllowUserToResizeRows = false;
            this.waitingDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.waitingDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.waitingDataGrid.Location = new System.Drawing.Point(518, 248);
            this.waitingDataGrid.Name = "waitingDataGrid";
            this.waitingDataGrid.ReadOnly = true;
            this.waitingDataGrid.RowHeadersVisible = false;
            this.waitingDataGrid.Size = new System.Drawing.Size(270, 190);
            this.waitingDataGrid.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "Id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.HeaderText = "Driver";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.HeaderText = "Route";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Waiting for dispatch:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.waitingDataGrid);
            this.Controls.Add(this.routeDataGrid);
            this.Controls.Add(this.sourceDataGrid);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sourceDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waitingDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton AddNewButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn busId;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.DataGridView sourceDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn busIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn routeColumn;
        private System.Windows.Forms.DataGridView routeDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ToolStripButton sendOnTheRouteButton;
        private System.Windows.Forms.ToolStripButton takeOffTheRouteButton;
        private System.Windows.Forms.DataGridView waitingDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label label2;
    }
}

