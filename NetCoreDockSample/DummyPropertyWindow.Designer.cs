namespace NetCoreDockSample
{
    partial class DummyPropertyWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DummyPropertyWindow));
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.mainMenu1 = new System.Windows.Forms.MenuStrip();
            this.menuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SuspendLayout();
            // 
            // propertyGrid
            // 
            this.propertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid.LineColor = System.Drawing.SystemColors.ScrollBar;
            this.propertyGrid.Location = new System.Drawing.Point(0, 24);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(208, 262);
            this.propertyGrid.TabIndex = 0;
            // 
            // comboBox
            // 
            this.comboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.Items.AddRange(new object[] {
            "propertyGrid"});
            this.comboBox.Location = new System.Drawing.Point(0, 3);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(208, 21);
            this.comboBox.TabIndex = 1;
            // 
            // mainMenu1
            // 
            this.mainMenu1.Items.AddRange(new System.Windows.Forms.ToolStripMenuItem[] {
            this.menuItem1});
            // 
            // menuItem1
            // 
            this.menuItem1.Text = "File";
            // 
            // DummyPropertyWindow
            // 
            this.ClientSize = new System.Drawing.Size(208, 289);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.propertyGrid);
            this.DockAreas = ((WinFormsCoreDockPanelSuite.Docking.DockAreas)(((((WinFormsCoreDockPanelSuite.Docking.DockAreas.Float | WinFormsCoreDockPanelSuite.Docking.DockAreas.DockLeft)
                        | WinFormsCoreDockPanelSuite.Docking.DockAreas.DockRight)
                        | WinFormsCoreDockPanelSuite.Docking.DockAreas.DockTop)
                        | WinFormsCoreDockPanelSuite.Docking.DockAreas.DockBottom)));
            this.HideOnClose = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu1;
            this.Name = "DummyPropertyWindow";
            this.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.ShowHint = WinFormsCoreDockPanelSuite.Docking.DockState.DockRight;
            this.TabText = "Properties";
            this.Text = "Properties";
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.PropertyGrid propertyGrid;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.MenuStrip mainMenu1;
        private System.Windows.Forms.ToolStripMenuItem menuItem1;
    }
}