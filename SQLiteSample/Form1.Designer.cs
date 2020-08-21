namespace SQLiteSample
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.createStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readAllStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearTableStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbStatusText = new System.Windows.Forms.Label();
            this.dgView = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createStripMenuItem,
            this.connectStripMenuItem,
            this.readAllStripMenuItem,
            this.clearTableStripMenuItem,
            this.addStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(346, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip";
            // 
            // createStripMenuItem
            // 
            this.createStripMenuItem.Name = "createStripMenuItem";
            this.createStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.createStripMenuItem.Text = "Create";
            // 
            // connectStripMenuItem
            // 
            this.connectStripMenuItem.Name = "connectStripMenuItem";
            this.connectStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.connectStripMenuItem.Text = "Connect";
            // 
            // readAllStripMenuItem
            // 
            this.readAllStripMenuItem.Name = "readAllStripMenuItem";
            this.readAllStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.readAllStripMenuItem.Text = "Read all";
            // 
            // clearTableStripMenuItem
            // 
            this.clearTableStripMenuItem.Name = "clearTableStripMenuItem";
            this.clearTableStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.clearTableStripMenuItem.Text = "Clear table";
            // 
            // addStripMenuItem
            // 
            this.addStripMenuItem.Name = "addStripMenuItem";
            this.addStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.addStripMenuItem.Text = "Add";
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colAuthor
            // 
            this.colAuthor.HeaderText = "Author";
            this.colAuthor.Name = "colAuthor";
            this.colAuthor.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colBook
            // 
            this.colBook.HeaderText = "Book";
            this.colBook.Name = "colBook";
            this.colBook.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // lbStatusText
            // 
            this.lbStatusText.AutoSize = true;
            this.lbStatusText.Location = new System.Drawing.Point(0, 260);
            this.lbStatusText.Name = "lbStatusText";
            this.lbStatusText.Size = new System.Drawing.Size(0, 15);
            this.lbStatusText.TabIndex = 3;
            // 
            // dgView
            // 
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.colAuthor,
            this.colBook});
            this.dgView.Location = new System.Drawing.Point(0, 27);
            this.dgView.Name = "dgView";
            this.dgView.Size = new System.Drawing.Size(344, 226);
            this.dgView.TabIndex = 2;
            this.dgView.Text = "dataGridView1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 289);
            this.Controls.Add(this.lbStatusText);
            this.Controls.Add(this.dgView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem createStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readAllStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearTableStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStripMenuItem;
        private System.Windows.Forms.DataGridView dgView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBook;
        private System.Windows.Forms.Label lbStatusText;
    }
}

