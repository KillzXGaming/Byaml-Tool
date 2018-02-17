namespace ByamlEditor
{
    partial class ByamlTool
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertToBigEndianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertToLittleEndianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(759, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(0, 195);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(221, 301);
            this.treeView1.TabIndex = 2;
            this.treeView1.Visible = false;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Location = new System.Drawing.Point(545, 27);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(206, 469);
            this.propertyGrid1.TabIndex = 3;
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.convertToBigEndianToolStripMenuItem,
            this.convertToLittleEndianToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            this.toolsToolStripMenuItem.Click += new System.EventHandler(this.toolsToolStripMenuItem_Click);
            // 
            // convertToBigEndianToolStripMenuItem
            // 
            this.convertToBigEndianToolStripMenuItem.Name = "convertToBigEndianToolStripMenuItem";
            this.convertToBigEndianToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.convertToBigEndianToolStripMenuItem.Text = "Convert to Big Endian";
            this.convertToBigEndianToolStripMenuItem.Click += new System.EventHandler(this.convertToBigEndianToolStripMenuItem_Click);
            // 
            // convertToLittleEndianToolStripMenuItem
            // 
            this.convertToLittleEndianToolStripMenuItem.Name = "convertToLittleEndianToolStripMenuItem";
            this.convertToLittleEndianToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.convertToLittleEndianToolStripMenuItem.Text = "Convert to Little Endian";
            this.convertToLittleEndianToolStripMenuItem.Click += new System.EventHandler(this.convertToLittleEndianToolStripMenuItem_Click);
            // 
            // ByamlTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 503);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ByamlTool";
            this.Text = "ByamlTool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertToBigEndianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertToLittleEndianToolStripMenuItem;
    }
}

