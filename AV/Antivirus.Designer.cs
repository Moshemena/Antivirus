namespace AV
{
    partial class Antivirus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Antivirus));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MonitorFiles = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.dataGridUser = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScanFolderText = new System.Windows.Forms.TextBox();
            this.ScanFolder = new System.Windows.Forms.Button();
            this.btn_browse = new System.Windows.Forms.Button();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.dataGridFiles = new System.Windows.Forms.DataGridView();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.New_Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab3 = new System.Windows.Forms.TabPage();
            this.dataGridRegistry = new System.Windows.Forms.DataGridView();
            this.Machine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Directory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab5 = new System.Windows.Forms.TabPage();
            this.dataGridPorts = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridProcess = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridSystem = new System.Windows.Forms.DataGridView();
            this.Scanned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Protocol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Port = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PEC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MonitorFiles.SuspendLayout();
            this.tab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUser)).BeginInit();
            this.tab2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFiles)).BeginInit();
            this.tab3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRegistry)).BeginInit();
            this.tab5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPorts)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProcess)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSystem)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1875, 206);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1875, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MonitorFiles
            // 
            this.MonitorFiles.Controls.Add(this.tab1);
            this.MonitorFiles.Controls.Add(this.tab2);
            this.MonitorFiles.Controls.Add(this.tab3);
            this.MonitorFiles.Controls.Add(this.tab5);
            this.MonitorFiles.Controls.Add(this.tabPage1);
            this.MonitorFiles.Controls.Add(this.tabPage2);
            this.MonitorFiles.Location = new System.Drawing.Point(18, 215);
            this.MonitorFiles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MonitorFiles.Name = "MonitorFiles";
            this.MonitorFiles.SelectedIndex = 0;
            this.MonitorFiles.Size = new System.Drawing.Size(1842, 640);
            this.MonitorFiles.TabIndex = 1;
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.dataGridUser);
            this.tab1.Controls.Add(this.ScanFolderText);
            this.tab1.Controls.Add(this.ScanFolder);
            this.tab1.Controls.Add(this.btn_browse);
            this.tab1.Location = new System.Drawing.Point(4, 29);
            this.tab1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tab1.Size = new System.Drawing.Size(1834, 607);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "User Scan";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // dataGridUser
            // 
            this.dataGridUser.AllowUserToAddRows = false;
            this.dataGridUser.AllowUserToDeleteRows = false;
            this.dataGridUser.AllowUserToResizeColumns = false;
            this.dataGridUser.AllowUserToResizeRows = false;
            this.dataGridUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn10});
            this.dataGridUser.Location = new System.Drawing.Point(0, 144);
            this.dataGridUser.Name = "dataGridUser";
            this.dataGridUser.ReadOnly = true;
            this.dataGridUser.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridUser.RowTemplate.Height = 28;
            this.dataGridUser.Size = new System.Drawing.Size(1831, 460);
            this.dataGridUser.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn6.FillWeight = 228.4264F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Status";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn6.Width = 250;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn10.FillWeight = 29.20402F;
            this.dataGridViewTextBoxColumn10.HeaderText = "Path";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ScanFolderText
            // 
            this.ScanFolderText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ScanFolderText.Location = new System.Drawing.Point(0, 88);
            this.ScanFolderText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ScanFolderText.Multiline = true;
            this.ScanFolderText.Name = "ScanFolderText";
            this.ScanFolderText.ReadOnly = true;
            this.ScanFolderText.Size = new System.Drawing.Size(1834, 48);
            this.ScanFolderText.TabIndex = 4;
            // 
            // ScanFolder
            // 
            this.ScanFolder.BackColor = System.Drawing.Color.DarkGray;
            this.ScanFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ScanFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ScanFolder.Location = new System.Drawing.Point(378, 10);
            this.ScanFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ScanFolder.Name = "ScanFolder";
            this.ScanFolder.Size = new System.Drawing.Size(358, 68);
            this.ScanFolder.TabIndex = 3;
            this.ScanFolder.Text = "Scan Folder";
            this.ScanFolder.UseVisualStyleBackColor = false;
            this.ScanFolder.Click += new System.EventHandler(this.ScanFolder_Click);
            // 
            // btn_browse
            // 
            this.btn_browse.BackColor = System.Drawing.Color.DarkGray;
            this.btn_browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_browse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_browse.Location = new System.Drawing.Point(8, 10);
            this.btn_browse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(362, 68);
            this.btn_browse.TabIndex = 0;
            this.btn_browse.Text = "Scan File";
            this.btn_browse.UseVisualStyleBackColor = false;
            this.btn_browse.Click += new System.EventHandler(this.button1_Click);
            // 
            // tab2
            // 
            this.tab2.Controls.Add(this.dataGridFiles);
            this.tab2.Location = new System.Drawing.Point(4, 29);
            this.tab2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tab2.Size = new System.Drawing.Size(1834, 607);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "Monitor Files";
            this.tab2.UseVisualStyleBackColor = true;
            // 
            // dataGridFiles
            // 
            this.dataGridFiles.AllowUserToAddRows = false;
            this.dataGridFiles.AllowUserToDeleteRows = false;
            this.dataGridFiles.AllowUserToResizeColumns = false;
            this.dataGridFiles.AllowUserToResizeRows = false;
            this.dataGridFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.Path,
            this.New_Value});
            this.dataGridFiles.Location = new System.Drawing.Point(3, 0);
            this.dataGridFiles.Name = "dataGridFiles";
            this.dataGridFiles.ReadOnly = true;
            this.dataGridFiles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridFiles.RowTemplate.Height = 28;
            this.dataGridFiles.Size = new System.Drawing.Size(1822, 605);
            this.dataGridFiles.TabIndex = 1;
            // 
            // Type
            // 
            this.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Type.FillWeight = 228.4264F;
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 8;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Type.Width = 150;
            // 
            // Path
            // 
            this.Path.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Path.FillWeight = 35.7868F;
            this.Path.HeaderText = "Path";
            this.Path.MinimumWidth = 8;
            this.Path.Name = "Path";
            this.Path.ReadOnly = true;
            this.Path.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // New_Value
            // 
            this.New_Value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.New_Value.FillWeight = 35.7868F;
            this.New_Value.HeaderText = "New Value";
            this.New_Value.MinimumWidth = 8;
            this.New_Value.Name = "New_Value";
            this.New_Value.ReadOnly = true;
            this.New_Value.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // tab3
            // 
            this.tab3.Controls.Add(this.dataGridRegistry);
            this.tab3.Location = new System.Drawing.Point(4, 29);
            this.tab3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tab3.Name = "tab3";
            this.tab3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tab3.Size = new System.Drawing.Size(1834, 607);
            this.tab3.TabIndex = 2;
            this.tab3.Text = "Monitor Registry key";
            this.tab3.UseVisualStyleBackColor = true;
            // 
            // dataGridRegistry
            // 
            this.dataGridRegistry.AllowUserToAddRows = false;
            this.dataGridRegistry.AllowUserToDeleteRows = false;
            this.dataGridRegistry.AllowUserToResizeColumns = false;
            this.dataGridRegistry.AllowUserToResizeRows = false;
            this.dataGridRegistry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRegistry.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Machine,
            this.Directory,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridRegistry.Location = new System.Drawing.Point(3, 0);
            this.dataGridRegistry.Name = "dataGridRegistry";
            this.dataGridRegistry.ReadOnly = true;
            this.dataGridRegistry.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridRegistry.RowTemplate.Height = 28;
            this.dataGridRegistry.Size = new System.Drawing.Size(1827, 605);
            this.dataGridRegistry.TabIndex = 2;
            // 
            // Machine
            // 
            this.Machine.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Machine.HeaderText = "Machine";
            this.Machine.Name = "Machine";
            this.Machine.ReadOnly = true;
            this.Machine.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Machine.Width = 120;
            // 
            // Directory
            // 
            this.Directory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Directory.HeaderText = "Directory";
            this.Directory.Name = "Directory";
            this.Directory.ReadOnly = true;
            this.Directory.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.FillWeight = 228.4264F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Key";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.FillWeight = 29.20402F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Executable Path";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // tab5
            // 
            this.tab5.Controls.Add(this.dataGridPorts);
            this.tab5.Location = new System.Drawing.Point(4, 29);
            this.tab5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tab5.Name = "tab5";
            this.tab5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tab5.Size = new System.Drawing.Size(1834, 607);
            this.tab5.TabIndex = 4;
            this.tab5.Text = "Monitor Ports";
            this.tab5.UseVisualStyleBackColor = true;
            // 
            // dataGridPorts
            // 
            this.dataGridPorts.AllowUserToAddRows = false;
            this.dataGridPorts.AllowUserToDeleteRows = false;
            this.dataGridPorts.AllowUserToResizeColumns = false;
            this.dataGridPorts.AllowUserToResizeRows = false;
            this.dataGridPorts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPorts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Protocol,
            this.FA,
            this.Port,
            this.State,
            this.Pid,
            this.pname,
            this.PEC});
            this.dataGridPorts.Location = new System.Drawing.Point(3, 3);
            this.dataGridPorts.Name = "dataGridPorts";
            this.dataGridPorts.ReadOnly = true;
            this.dataGridPorts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridPorts.RowTemplate.Height = 28;
            this.dataGridPorts.Size = new System.Drawing.Size(1824, 602);
            this.dataGridPorts.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridProcess);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1834, 607);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "Monitor Process";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridProcess
            // 
            this.dataGridProcess.AllowUserToAddRows = false;
            this.dataGridProcess.AllowUserToDeleteRows = false;
            this.dataGridProcess.AllowUserToResizeColumns = false;
            this.dataGridProcess.AllowUserToResizeRows = false;
            this.dataGridProcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProcess.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn7});
            this.dataGridProcess.Location = new System.Drawing.Point(0, 0);
            this.dataGridProcess.Name = "dataGridProcess";
            this.dataGridProcess.ReadOnly = true;
            this.dataGridProcess.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridProcess.RowTemplate.Height = 28;
            this.dataGridProcess.Size = new System.Drawing.Size(1834, 602);
            this.dataGridProcess.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn4.FillWeight = 228.4264F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Process Name";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn5.FillWeight = 35.7868F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Process ID";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.FillWeight = 35.7868F;
            this.dataGridViewTextBoxColumn7.HeaderText = "Executable Path";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridSystem);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1834, 607);
            this.tabPage2.TabIndex = 6;
            this.tabPage2.Text = "Expert Mode";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridSystem
            // 
            this.dataGridSystem.AllowUserToAddRows = false;
            this.dataGridSystem.AllowUserToDeleteRows = false;
            this.dataGridSystem.AllowUserToResizeColumns = false;
            this.dataGridSystem.AllowUserToResizeRows = false;
            this.dataGridSystem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSystem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Scanned,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dataGridSystem.Location = new System.Drawing.Point(0, 0);
            this.dataGridSystem.Name = "dataGridSystem";
            this.dataGridSystem.ReadOnly = true;
            this.dataGridSystem.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridSystem.RowTemplate.Height = 28;
            this.dataGridSystem.Size = new System.Drawing.Size(1834, 602);
            this.dataGridSystem.TabIndex = 5;
            // 
            // Scanned
            // 
            this.Scanned.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Scanned.HeaderText = "Scanned by";
            this.Scanned.Name = "Scanned";
            this.Scanned.ReadOnly = true;
            this.Scanned.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn8.FillWeight = 228.4264F;
            this.dataGridViewTextBoxColumn8.HeaderText = "Status";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn8.Width = 250;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.FillWeight = 29.20402F;
            this.dataGridViewTextBoxColumn9.HeaderText = "Path";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Protocol
            // 
            this.Protocol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Protocol.HeaderText = "Protocol";
            this.Protocol.MinimumWidth = 8;
            this.Protocol.Name = "Protocol";
            this.Protocol.ReadOnly = true;
            // 
            // FA
            // 
            this.FA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FA.HeaderText = "LocalAddress";
            this.FA.MinimumWidth = 8;
            this.FA.Name = "FA";
            this.FA.ReadOnly = true;
            this.FA.Width = 180;
            // 
            // Port
            // 
            this.Port.HeaderText = "Port";
            this.Port.Name = "Port";
            this.Port.ReadOnly = true;
            // 
            // State
            // 
            this.State.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.State.HeaderText = "State";
            this.State.MinimumWidth = 8;
            this.State.Name = "State";
            this.State.ReadOnly = true;
            this.State.Width = 120;
            // 
            // Pid
            // 
            this.Pid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Pid.HeaderText = "PID";
            this.Pid.MinimumWidth = 8;
            this.Pid.Name = "Pid";
            this.Pid.ReadOnly = true;
            // 
            // pname
            // 
            this.pname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.pname.HeaderText = "Process Name";
            this.pname.MinimumWidth = 8;
            this.pname.Name = "pname";
            this.pname.ReadOnly = true;
            this.pname.Width = 140;
            // 
            // PEC
            // 
            this.PEC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PEC.HeaderText = "Process Executable Path";
            this.PEC.MinimumWidth = 8;
            this.PEC.Name = "PEC";
            this.PEC.ReadOnly = true;
            // 
            // Antivirus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1875, 872);
            this.Controls.Add(this.MonitorFiles);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Antivirus";
            this.Text = "Antivirus";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MonitorFiles.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUser)).EndInit();
            this.tab2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFiles)).EndInit();
            this.tab3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRegistry)).EndInit();
            this.tab5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPorts)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProcess)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSystem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl MonitorFiles;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.TabPage tab3;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.TabPage tab5;
        private System.Windows.Forms.DataGridView dataGridFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path;
        private System.Windows.Forms.DataGridViewTextBoxColumn New_Value;
        private System.Windows.Forms.DataGridView dataGridRegistry;
        private System.Windows.Forms.DataGridView dataGridPorts;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Machine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Directory;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridProcess;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridView dataGridSystem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Scanned;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Button ScanFolder;
        private System.Windows.Forms.TextBox ScanFolderText;
        private System.Windows.Forms.DataGridView dataGridUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Protocol;
        private System.Windows.Forms.DataGridViewTextBoxColumn FA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Port;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pid;
        private System.Windows.Forms.DataGridViewTextBoxColumn pname;
        private System.Windows.Forms.DataGridViewTextBoxColumn PEC;
    }
}

