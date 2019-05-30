namespace WindowsFormsApp12
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
            this.components = new System.ComponentModel.Container();
            this.mainTextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cutExtraPanel = new System.Windows.Forms.ToolStripMenuItem();
            this.copyExtraPanel = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllExtraPanel = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteExtraPanel = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.parametrsPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vievToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VievPanel = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripPanel = new System.Windows.Forms.ToolStrip();
            this.cutPanel = new System.Windows.Forms.ToolStripButton();
            this.panelCopy = new System.Windows.Forms.ToolStripButton();
            this.panelPaste = new System.Windows.Forms.ToolStripButton();
            this.selectAllPanel = new System.Windows.Forms.ToolStripButton();
            this.findPanel = new System.Windows.Forms.ToolStripButton();
            this.fontPanel = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.nameDeveloper = new System.Windows.Forms.ToolStripStatusLabel();
            this.countSymbol = new System.Windows.Forms.ToolStripStatusLabel();
            this.countWords = new System.Windows.Forms.ToolStripStatusLabel();
            this.countSelect = new System.Windows.Forms.ToolStripStatusLabel();
            this.countSelectSymbol = new System.Windows.Forms.ToolStripStatusLabel();
            this.vievStatusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.menuStripMenu.SuspendLayout();
            this.toolStripPanel.SuspendLayout();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTextBox
            // 
            this.mainTextBox.ContextMenuStrip = this.contextMenuStrip;
            this.mainTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTextBox.HideSelection = false;
            this.mainTextBox.Location = new System.Drawing.Point(0, 0);
            this.mainTextBox.Multiline = true;
            this.mainTextBox.Name = "mainTextBox";
            this.mainTextBox.Size = new System.Drawing.Size(658, 203);
            this.mainTextBox.TabIndex = 0;
            this.mainTextBox.TextChanged += new System.EventHandler(this.MainTextBox_TextChanged);
            this.mainTextBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainTextBox_MouseUp);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutExtraPanel,
            this.copyExtraPanel,
            this.selectAllExtraPanel,
            this.pasteExtraPanel,
            this.findToolStripMenuItem1});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(123, 114);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStrip_Opening_1);
            // 
            // cutExtraPanel
            // 
            this.cutExtraPanel.Image = global::WindowsFormsApp12.Properties.Resources.Cut_16x;
            this.cutExtraPanel.Name = "cutExtraPanel";
            this.cutExtraPanel.Size = new System.Drawing.Size(180, 22);
            this.cutExtraPanel.Text = "Cut";
            this.cutExtraPanel.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
            // 
            // copyExtraPanel
            // 
            this.copyExtraPanel.Image = global::WindowsFormsApp12.Properties.Resources.Copy_16x;
            this.copyExtraPanel.Name = "copyExtraPanel";
            this.copyExtraPanel.Size = new System.Drawing.Size(180, 22);
            this.copyExtraPanel.Text = "Copy";
            this.copyExtraPanel.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // selectAllExtraPanel
            // 
            this.selectAllExtraPanel.Image = global::WindowsFormsApp12.Properties.Resources.SelectAll_16x;
            this.selectAllExtraPanel.Name = "selectAllExtraPanel";
            this.selectAllExtraPanel.Size = new System.Drawing.Size(180, 22);
            this.selectAllExtraPanel.Text = "Select All";
            this.selectAllExtraPanel.Click += new System.EventHandler(this.SelectAllToolStripMenuItem_Click);
            // 
            // pasteExtraPanel
            // 
            this.pasteExtraPanel.Image = global::WindowsFormsApp12.Properties.Resources.Paste_16x;
            this.pasteExtraPanel.Name = "pasteExtraPanel";
            this.pasteExtraPanel.Size = new System.Drawing.Size(180, 22);
            this.pasteExtraPanel.Text = "Paste";
            this.pasteExtraPanel.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // findToolStripMenuItem1
            // 
            this.findToolStripMenuItem1.Image = global::WindowsFormsApp12.Properties.Resources.FindSymbol_16x;
            this.findToolStripMenuItem1.Name = "findToolStripMenuItem1";
            this.findToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.findToolStripMenuItem1.Text = "Find";
            this.findToolStripMenuItem1.Click += new System.EventHandler(this.FindToolStripMenuItem_Click);
            // 
            // menuStripMenu
            // 
            this.menuStripMenu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menuStripMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.formatToolStripMenuItem1,
            this.vievToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripMenu.Location = new System.Drawing.Point(0, 0);
            this.menuStripMenu.Name = "menuStripMenu";
            this.menuStripMenu.Size = new System.Drawing.Size(658, 24);
            this.menuStripMenu.TabIndex = 1;
            this.menuStripMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator2,
            this.parametrsPageToolStripMenuItem,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.FileToolStripMenuItem_Click);
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Image = global::WindowsFormsApp12.Properties.Resources.Create_16x;
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.createToolStripMenuItem.Text = "Create";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.CreateToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::WindowsFormsApp12.Properties.Resources.folder_Open_16xLG;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(185, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::WindowsFormsApp12.Properties.Resources.Save_16x;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Image = global::WindowsFormsApp12.Properties.Resources.SaveAs_16x;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(185, 6);
            // 
            // parametrsPageToolStripMenuItem
            // 
            this.parametrsPageToolStripMenuItem.Name = "parametrsPageToolStripMenuItem";
            this.parametrsPageToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.parametrsPageToolStripMenuItem.Text = "Parametrs page";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(185, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::WindowsFormsApp12.Properties.Resources.Exit_16x;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.findToolStripMenuItem,
            this.selectAllToolStripMenuItem,
            this.dateTimeToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.formatToolStripMenuItem.Text = "Edit";
            this.formatToolStripMenuItem.Click += new System.EventHandler(this.FormatToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = global::WindowsFormsApp12.Properties.Resources.Cut_16x;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = global::WindowsFormsApp12.Properties.Resources.Copy_16x;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = global::WindowsFormsApp12.Properties.Resources.Paste_16x;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(159, 6);
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Image = global::WindowsFormsApp12.Properties.Resources.FindSymbol_16x;
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.findToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.findToolStripMenuItem.Text = "Find";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.FindToolStripMenuItem_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Enabled = false;
            this.selectAllToolStripMenuItem.Image = global::WindowsFormsApp12.Properties.Resources.SelectAll_16x;
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.selectAllToolStripMenuItem.Text = "Select all";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.SelectAllToolStripMenuItem_Click);
            // 
            // dateTimeToolStripMenuItem
            // 
            this.dateTimeToolStripMenuItem.Image = global::WindowsFormsApp12.Properties.Resources.Time_16x;
            this.dateTimeToolStripMenuItem.Name = "dateTimeToolStripMenuItem";
            this.dateTimeToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.dateTimeToolStripMenuItem.Text = "Date time";
            this.dateTimeToolStripMenuItem.Click += new System.EventHandler(this.DateTimeToolStripMenuItem_Click);
            // 
            // formatToolStripMenuItem1
            // 
            this.formatToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem});
            this.formatToolStripMenuItem1.Name = "formatToolStripMenuItem1";
            this.formatToolStripMenuItem1.Size = new System.Drawing.Size(57, 20);
            this.formatToolStripMenuItem1.Text = "Format";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Image = global::WindowsFormsApp12.Properties.Resources.Font_16x;
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.FontToolStripMenuItem_Click);
            // 
            // vievToolStripMenuItem
            // 
            this.vievToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VievPanel,
            this.vievStatusBarToolStripMenuItem});
            this.vievToolStripMenuItem.Name = "vievToolStripMenuItem";
            this.vievToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.vievToolStripMenuItem.Text = "Viev";
            // 
            // VievPanel
            // 
            this.VievPanel.Checked = true;
            this.VievPanel.CheckOnClick = true;
            this.VievPanel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.VievPanel.Name = "VievPanel";
            this.VievPanel.Size = new System.Drawing.Size(128, 22);
            this.VievPanel.Text = "Viev panel";
            this.VievPanel.Click += new System.EventHandler(this.VievPanelToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::WindowsFormsApp12.Properties.Resources.HelpApplication_16x;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // toolStripPanel
            // 
            this.toolStripPanel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.toolStripPanel.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripPanel.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutPanel,
            this.panelCopy,
            this.panelPaste,
            this.selectAllPanel,
            this.findPanel,
            this.fontPanel});
            this.toolStripPanel.Location = new System.Drawing.Point(9, 24);
            this.toolStripPanel.Name = "toolStripPanel";
            this.toolStripPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripPanel.Size = new System.Drawing.Size(141, 25);
            this.toolStripPanel.TabIndex = 2;
            // 
            // cutPanel
            // 
            this.cutPanel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutPanel.Enabled = false;
            this.cutPanel.Image = global::WindowsFormsApp12.Properties.Resources.Cut_16x;
            this.cutPanel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutPanel.Name = "cutPanel";
            this.cutPanel.Size = new System.Drawing.Size(23, 22);
            this.cutPanel.Text = "Cut";
            this.cutPanel.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
            // 
            // panelCopy
            // 
            this.panelCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.panelCopy.Enabled = false;
            this.panelCopy.Image = global::WindowsFormsApp12.Properties.Resources.Copy_16x;
            this.panelCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.panelCopy.Name = "panelCopy";
            this.panelCopy.Size = new System.Drawing.Size(23, 22);
            this.panelCopy.Text = "Copy";
            this.panelCopy.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // panelPaste
            // 
            this.panelPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.panelPaste.Image = global::WindowsFormsApp12.Properties.Resources.Paste_16x;
            this.panelPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.panelPaste.Name = "panelPaste";
            this.panelPaste.Size = new System.Drawing.Size(23, 22);
            this.panelPaste.Text = "Paste";
            this.panelPaste.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // selectAllPanel
            // 
            this.selectAllPanel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.selectAllPanel.Enabled = false;
            this.selectAllPanel.Image = global::WindowsFormsApp12.Properties.Resources.SelectAll_16x;
            this.selectAllPanel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.selectAllPanel.Name = "selectAllPanel";
            this.selectAllPanel.Size = new System.Drawing.Size(23, 22);
            this.selectAllPanel.Text = "Select All";
            this.selectAllPanel.Click += new System.EventHandler(this.SelectAllToolStripMenuItem_Click);
            // 
            // findPanel
            // 
            this.findPanel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.findPanel.Image = global::WindowsFormsApp12.Properties.Resources.FindSymbol_16x;
            this.findPanel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.findPanel.Name = "findPanel";
            this.findPanel.Size = new System.Drawing.Size(23, 22);
            this.findPanel.Text = "Find";
            this.findPanel.Click += new System.EventHandler(this.FindToolStripMenuItem_Click);
            // 
            // fontPanel
            // 
            this.fontPanel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fontPanel.Image = global::WindowsFormsApp12.Properties.Resources.Font_16x;
            this.fontPanel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fontPanel.Name = "fontPanel";
            this.fontPanel.Size = new System.Drawing.Size(23, 22);
            this.fontPanel.Text = "Change font";
            this.fontPanel.Click += new System.EventHandler(this.FontToolStripMenuItem_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip1);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.mainTextBox);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(658, 203);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(658, 274);
            this.toolStripContainer1.TabIndex = 3;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStripMenu);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStripPanel);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameDeveloper,
            this.countSymbol,
            this.countWords,
            this.countSelect,
            this.countSelectSymbol});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(658, 22);
            this.statusStrip1.TabIndex = 0;
            // 
            // nameDeveloper
            // 
            this.nameDeveloper.Name = "nameDeveloper";
            this.nameDeveloper.Size = new System.Drawing.Size(156, 17);
            this.nameDeveloper.Text = "Melnychuk Vasyl(roadstobe)";
            // 
            // countSymbol
            // 
            this.countSymbol.Name = "countSymbol";
            this.countSymbol.Size = new System.Drawing.Size(46, 17);
            this.countSymbol.Text = "Count: ";
            // 
            // countWords
            // 
            this.countWords.Name = "countWords";
            this.countWords.Size = new System.Drawing.Size(13, 17);
            this.countWords.Text = "0";
            // 
            // countSelect
            // 
            this.countSelect.Name = "countSelect";
            this.countSelect.Size = new System.Drawing.Size(82, 17);
            this.countSelect.Text = " Count select: ";
            this.countSelect.Visible = false;
            // 
            // countSelectSymbol
            // 
            this.countSelectSymbol.Name = "countSelectSymbol";
            this.countSelectSymbol.Size = new System.Drawing.Size(13, 17);
            this.countSelectSymbol.Text = "0";
            this.countSelectSymbol.Visible = false;
            // 
            // vievStatusBarToolStripMenuItem
            // 
            this.vievStatusBarToolStripMenuItem.Checked = true;
            this.vievStatusBarToolStripMenuItem.CheckOnClick = true;
            this.vievStatusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.vievStatusBarToolStripMenuItem.Name = "vievStatusBarToolStripMenuItem";
            this.vievStatusBarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vievStatusBarToolStripMenuItem.Text = "Viev status bar";
            this.vievStatusBarToolStripMenuItem.Click += new System.EventHandler(this.VievStatusBarToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 274);
            this.Controls.Add(this.toolStripContainer1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStripMenu;
            this.Name = "MainForm";
            this.Text = "MyTextBox";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.contextMenuStrip.ResumeLayout(false);
            this.menuStripMenu.ResumeLayout(false);
            this.menuStripMenu.PerformLayout();
            this.toolStripPanel.ResumeLayout(false);
            this.toolStripPanel.PerformLayout();
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TextBox mainTextBox;
        private System.Windows.Forms.MenuStrip menuStripMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem parametrsPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vievToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VievPanel;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripPanel;
        private System.Windows.Forms.ToolStripButton cutPanel;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton panelCopy;
        private System.Windows.Forms.ToolStripButton panelPaste;
        private System.Windows.Forms.ToolStripButton selectAllPanel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem cutExtraPanel;
        private System.Windows.Forms.ToolStripButton findPanel;
        private System.Windows.Forms.ToolStripMenuItem copyExtraPanel;
        private System.Windows.Forms.ToolStripMenuItem selectAllExtraPanel;
        private System.Windows.Forms.ToolStripMenuItem pasteExtraPanel;
        private System.Windows.Forms.ToolStripMenuItem dateTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem1;
        private System.Windows.Forms.ToolStripButton fontPanel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel nameDeveloper;
        private System.Windows.Forms.ToolStripStatusLabel countWords;
        private System.Windows.Forms.ToolStripStatusLabel countSymbol;
        private System.Windows.Forms.ToolStripStatusLabel countSelect;
        private System.Windows.Forms.ToolStripStatusLabel countSelectSymbol;
        private System.Windows.Forms.ToolStripMenuItem vievStatusBarToolStripMenuItem;
    }
}

