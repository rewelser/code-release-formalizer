namespace CodeReleaseFormalizer {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private System.Windows.Forms.TextBox filepath_UAT_tb;
        private System.Windows.Forms.TextBox ppm_tb;
        private System.Windows.Forms.TextBox cai_tb;
        private System.Windows.Forms.Label filepath_UAT_tb_label;
        private System.Windows.Forms.Label ppm_tb_label;
        private System.Windows.Forms.Label cai_tb_label;
        private System.Windows.Forms.Button panaya_UAT_fp_browse_btn;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panaya_UAT_fp_browse_btn = new System.Windows.Forms.Button();
            this.filepath_UAT_tb_label = new System.Windows.Forms.Label();
            this.filepath_UAT_tb = new System.Windows.Forms.TextBox();
            this.ppm_tb = new System.Windows.Forms.TextBox();
            this.ppm_tb_label = new System.Windows.Forms.Label();
            this.cai_tb = new System.Windows.Forms.TextBox();
            this.cai_tb_label = new System.Windows.Forms.Label();
            this.groupbox_impl = new System.Windows.Forms.GroupBox();
            this.gen_btn = new System.Windows.Forms.Button();
            this.moveTest_gb = new System.Windows.Forms.GroupBox();
            this.moveTest_btn = new System.Windows.Forms.Button();
            this.moveTest_combobox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.addTest_btn = new System.Windows.Forms.ToolStripButton();
            this.deleteTest_btn = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addTester_btn = new System.Windows.Forms.ToolStripButton();
            this.deleteTester_btn = new System.Windows.Forms.ToolStripButton();
            this.renameTester_btn = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tests_listbox = new System.Windows.Forms.ListBox();
            this.testers_listbox = new System.Windows.Forms.ListBox();
            this.filepath_SIT_tb = new System.Windows.Forms.TextBox();
            this.filepath_SIT_tb_label = new System.Windows.Forms.Label();
            this.panaya_fp_SIT_browse_btn = new System.Windows.Forms.Button();
            this.pose_dir_tb = new System.Windows.Forms.TextBox();
            this.gen_dir_btn = new System.Windows.Forms.Button();
            this.dept_tb_label = new System.Windows.Forms.Label();
            this.dept_tb = new System.Windows.Forms.TextBox();
            this.groupbox_impl.SuspendLayout();
            this.moveTest_gb.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panaya_UAT_fp_browse_btn
            // 
            this.panaya_UAT_fp_browse_btn.Enabled = false;
            this.panaya_UAT_fp_browse_btn.Location = new System.Drawing.Point(651, 152);
            this.panaya_UAT_fp_browse_btn.Name = "panaya_UAT_fp_browse_btn";
            this.panaya_UAT_fp_browse_btn.Size = new System.Drawing.Size(84, 28);
            this.panaya_UAT_fp_browse_btn.TabIndex = 12;
            this.panaya_UAT_fp_browse_btn.Text = "Browse...";
            this.panaya_UAT_fp_browse_btn.UseVisualStyleBackColor = true;
            this.panaya_UAT_fp_browse_btn.Click += new System.EventHandler(this.Browse_Click_UAT);
            // 
            // filepath_UAT_tb_label
            // 
            this.filepath_UAT_tb_label.AutoSize = true;
            this.filepath_UAT_tb_label.Location = new System.Drawing.Point(30, 158);
            this.filepath_UAT_tb_label.Name = "filepath_UAT_tb_label";
            this.filepath_UAT_tb_label.Size = new System.Drawing.Size(289, 17);
            this.filepath_UAT_tb_label.TabIndex = 10;
            this.filepath_UAT_tb_label.Text = "Select UAT File \'Panaya Exported Steps.xlsx\'";
            // 
            // filepath_UAT_tb
            // 
            this.filepath_UAT_tb.Location = new System.Drawing.Point(325, 155);
            this.filepath_UAT_tb.Name = "filepath_UAT_tb";
            this.filepath_UAT_tb.ReadOnly = true;
            this.filepath_UAT_tb.Size = new System.Drawing.Size(320, 22);
            this.filepath_UAT_tb.TabIndex = 11;
            // 
            // ppm_tb
            // 
            this.ppm_tb.Location = new System.Drawing.Point(325, 71);
            this.ppm_tb.Name = "ppm_tb";
            this.ppm_tb.Size = new System.Drawing.Size(320, 22);
            this.ppm_tb.TabIndex = 4;
            this.ppm_tb.TextChanged += new System.EventHandler(this.EnableBrowseBtn);
            // 
            // ppm_tb_label
            // 
            this.ppm_tb_label.AutoSize = true;
            this.ppm_tb_label.Location = new System.Drawing.Point(163, 74);
            this.ppm_tb_label.Name = "ppm_tb_label";
            this.ppm_tb_label.Size = new System.Drawing.Size(156, 17);
            this.ppm_tb_label.TabIndex = 3;
            this.ppm_tb_label.Text = "Enter HP PPM Number:";
            // 
            // cai_tb
            // 
            this.cai_tb.Location = new System.Drawing.Point(325, 99);
            this.cai_tb.Name = "cai_tb";
            this.cai_tb.Size = new System.Drawing.Size(320, 22);
            this.cai_tb.TabIndex = 6;
            this.cai_tb.TextChanged += new System.EventHandler(this.EnableBrowseBtn);
            // 
            // cai_tb_label
            // 
            this.cai_tb_label.AutoSize = true;
            this.cai_tb_label.Location = new System.Drawing.Point(144, 102);
            this.cai_tb_label.Name = "cai_tb_label";
            this.cai_tb_label.Size = new System.Drawing.Size(175, 17);
            this.cai_tb_label.TabIndex = 5;
            this.cai_tb_label.Text = "Enter CA Incident Number:";
            // 
            // groupbox_impl
            // 
            this.groupbox_impl.CausesValidation = false;
            this.groupbox_impl.Controls.Add(this.gen_btn);
            this.groupbox_impl.Controls.Add(this.moveTest_gb);
            this.groupbox_impl.Controls.Add(this.toolStrip2);
            this.groupbox_impl.Controls.Add(this.toolStrip1);
            this.groupbox_impl.Controls.Add(this.label2);
            this.groupbox_impl.Controls.Add(this.label1);
            this.groupbox_impl.Controls.Add(this.tests_listbox);
            this.groupbox_impl.Controls.Add(this.testers_listbox);
            this.groupbox_impl.Enabled = false;
            this.groupbox_impl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupbox_impl.Location = new System.Drawing.Point(12, 245);
            this.groupbox_impl.Name = "groupbox_impl";
            this.groupbox_impl.Size = new System.Drawing.Size(769, 314);
            this.groupbox_impl.TabIndex = 8;
            this.groupbox_impl.TabStop = false;
            this.groupbox_impl.Text = "Implementation Sign-Off Specs";
            // 
            // gen_btn
            // 
            this.gen_btn.Location = new System.Drawing.Point(528, 196);
            this.gen_btn.Name = "gen_btn";
            this.gen_btn.Size = new System.Drawing.Size(217, 92);
            this.gen_btn.TabIndex = 10;
            this.gen_btn.Text = "Generate";
            this.gen_btn.UseVisualStyleBackColor = true;
            this.gen_btn.Click += new System.EventHandler(this.GenDocs);
            // 
            // moveTest_gb
            // 
            this.moveTest_gb.Controls.Add(this.moveTest_btn);
            this.moveTest_gb.Controls.Add(this.moveTest_combobox);
            this.moveTest_gb.Controls.Add(this.label5);
            this.moveTest_gb.Enabled = false;
            this.moveTest_gb.Location = new System.Drawing.Point(519, 44);
            this.moveTest_gb.Name = "moveTest_gb";
            this.moveTest_gb.Size = new System.Drawing.Size(244, 130);
            this.moveTest_gb.TabIndex = 8;
            this.moveTest_gb.TabStop = false;
            this.moveTest_gb.Text = "Move selected test";
            // 
            // moveTest_btn
            // 
            this.moveTest_btn.Enabled = false;
            this.moveTest_btn.Location = new System.Drawing.Point(74, 87);
            this.moveTest_btn.Name = "moveTest_btn";
            this.moveTest_btn.Size = new System.Drawing.Size(84, 28);
            this.moveTest_btn.TabIndex = 9;
            this.moveTest_btn.Text = "Move";
            this.moveTest_btn.UseVisualStyleBackColor = true;
            this.moveTest_btn.Click += new System.EventHandler(this.MoveTest);
            // 
            // moveTest_combobox
            // 
            this.moveTest_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.moveTest_combobox.FormattingEnabled = true;
            this.moveTest_combobox.Location = new System.Drawing.Point(9, 47);
            this.moveTest_combobox.Name = "moveTest_combobox";
            this.moveTest_combobox.Size = new System.Drawing.Size(217, 24);
            this.moveTest_combobox.TabIndex = 4;
            this.moveTest_combobox.SelectedIndexChanged += new System.EventHandler(this.EnableMoveTestBtn);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tester";
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.SystemColors.Menu;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTest_btn,
            this.deleteTest_btn});
            this.toolStrip2.Location = new System.Drawing.Point(278, 275);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(51, 27);
            this.toolStrip2.TabIndex = 6;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // addTest_btn
            // 
            this.addTest_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addTest_btn.Image = ((System.Drawing.Image)(resources.GetObject("addTest_btn.Image")));
            this.addTest_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addTest_btn.Name = "addTest_btn";
            this.addTest_btn.Size = new System.Drawing.Size(24, 24);
            this.addTest_btn.Text = "Add test";
            this.addTest_btn.Click += new System.EventHandler(this.AddTest);
            // 
            // deleteTest_btn
            // 
            this.deleteTest_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteTest_btn.Enabled = false;
            this.deleteTest_btn.Image = ((System.Drawing.Image)(resources.GetObject("deleteTest_btn.Image")));
            this.deleteTest_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteTest_btn.Name = "deleteTest_btn";
            this.deleteTest_btn.Size = new System.Drawing.Size(24, 24);
            this.deleteTest_btn.Text = "Delete test";
            this.deleteTest_btn.Click += new System.EventHandler(this.DeleteTest);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTester_btn,
            this.deleteTester_btn,
            this.renameTester_btn});
            this.toolStrip1.Location = new System.Drawing.Point(27, 275);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(75, 27);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // addTester_btn
            // 
            this.addTester_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addTester_btn.Image = ((System.Drawing.Image)(resources.GetObject("addTester_btn.Image")));
            this.addTester_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addTester_btn.Name = "addTester_btn";
            this.addTester_btn.Size = new System.Drawing.Size(24, 24);
            this.addTester_btn.Text = "Add tester";
            this.addTester_btn.Click += new System.EventHandler(this.AddTester);
            // 
            // deleteTester_btn
            // 
            this.deleteTester_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteTester_btn.Enabled = false;
            this.deleteTester_btn.Image = ((System.Drawing.Image)(resources.GetObject("deleteTester_btn.Image")));
            this.deleteTester_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteTester_btn.Name = "deleteTester_btn";
            this.deleteTester_btn.Size = new System.Drawing.Size(24, 24);
            this.deleteTester_btn.Text = "Delete tester";
            this.deleteTester_btn.Click += new System.EventHandler(this.DeleteTester);
            // 
            // renameTester_btn
            // 
            this.renameTester_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.renameTester_btn.Enabled = false;
            this.renameTester_btn.Image = ((System.Drawing.Image)(resources.GetObject("renameTester_btn.Image")));
            this.renameTester_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.renameTester_btn.Name = "renameTester_btn";
            this.renameTester_btn.Size = new System.Drawing.Size(24, 24);
            this.renameTester_btn.Text = "Rename tester";
            this.renameTester_btn.Click += new System.EventHandler(this.RenameTester);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tests";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Testers";
            // 
            // tests_listbox
            // 
            this.tests_listbox.FormattingEnabled = true;
            this.tests_listbox.HorizontalScrollbar = true;
            this.tests_listbox.ItemHeight = 16;
            this.tests_listbox.Location = new System.Drawing.Point(278, 44);
            this.tests_listbox.Name = "tests_listbox";
            this.tests_listbox.Size = new System.Drawing.Size(235, 228);
            this.tests_listbox.TabIndex = 1;
            this.tests_listbox.Click += new System.EventHandler(this.SelectTest);
            // 
            // testers_listbox
            // 
            this.testers_listbox.FormattingEnabled = true;
            this.testers_listbox.ItemHeight = 16;
            this.testers_listbox.Location = new System.Drawing.Point(27, 44);
            this.testers_listbox.Name = "testers_listbox";
            this.testers_listbox.Size = new System.Drawing.Size(235, 228);
            this.testers_listbox.TabIndex = 0;
            this.testers_listbox.SelectedIndexChanged += new System.EventHandler(this.SelectTester);
            // 
            // filepath_SIT_tb
            // 
            this.filepath_SIT_tb.Location = new System.Drawing.Point(325, 127);
            this.filepath_SIT_tb.Name = "filepath_SIT_tb";
            this.filepath_SIT_tb.ReadOnly = true;
            this.filepath_SIT_tb.Size = new System.Drawing.Size(320, 22);
            this.filepath_SIT_tb.TabIndex = 8;
            this.filepath_SIT_tb.TextChanged += new System.EventHandler(this.EnableBrowseBtn);
            // 
            // filepath_SIT_tb_label
            // 
            this.filepath_SIT_tb_label.AutoSize = true;
            this.filepath_SIT_tb_label.Location = new System.Drawing.Point(37, 130);
            this.filepath_SIT_tb_label.Name = "filepath_SIT_tb_label";
            this.filepath_SIT_tb_label.Size = new System.Drawing.Size(282, 17);
            this.filepath_SIT_tb_label.TabIndex = 7;
            this.filepath_SIT_tb_label.Text = "Select SIT File \'Panaya Exported Steps.xlsx\'";
            // 
            // panaya_fp_SIT_browse_btn
            // 
            this.panaya_fp_SIT_browse_btn.Location = new System.Drawing.Point(651, 124);
            this.panaya_fp_SIT_browse_btn.Name = "panaya_fp_SIT_browse_btn";
            this.panaya_fp_SIT_browse_btn.Size = new System.Drawing.Size(84, 28);
            this.panaya_fp_SIT_browse_btn.TabIndex = 9;
            this.panaya_fp_SIT_browse_btn.Text = "Browse...";
            this.panaya_fp_SIT_browse_btn.UseVisualStyleBackColor = true;
            this.panaya_fp_SIT_browse_btn.Click += new System.EventHandler(this.Browse_Click_SIT);
            // 
            // pose_dir_tb
            // 
            this.pose_dir_tb.Enabled = false;
            this.pose_dir_tb.Location = new System.Drawing.Point(161, 204);
            this.pose_dir_tb.Name = "pose_dir_tb";
            this.pose_dir_tb.Size = new System.Drawing.Size(320, 22);
            this.pose_dir_tb.TabIndex = 13;
            // 
            // gen_dir_btn
            // 
            this.gen_dir_btn.Enabled = false;
            this.gen_dir_btn.Location = new System.Drawing.Point(487, 201);
            this.gen_dir_btn.Name = "gen_dir_btn";
            this.gen_dir_btn.Size = new System.Drawing.Size(158, 28);
            this.gen_dir_btn.TabIndex = 14;
            this.gen_dir_btn.Text = "Create Directory";
            this.gen_dir_btn.UseVisualStyleBackColor = true;
            this.gen_dir_btn.Click += new System.EventHandler(this.Create_UAT_dir);
            // 
            // dept_tb_label
            // 
            this.dept_tb_label.AutoSize = true;
            this.dept_tb_label.Location = new System.Drawing.Point(233, 46);
            this.dept_tb_label.Name = "dept_tb_label";
            this.dept_tb_label.Size = new System.Drawing.Size(86, 17);
            this.dept_tb_label.TabIndex = 1;
            this.dept_tb_label.Text = "Department:";
            // 
            // dept_tb
            // 
            this.dept_tb.Location = new System.Drawing.Point(325, 43);
            this.dept_tb.Name = "dept_tb";
            this.dept_tb.Size = new System.Drawing.Size(320, 22);
            this.dept_tb.TabIndex = 2;
            this.dept_tb.TextChanged += new System.EventHandler(this.EnableBrowseBtn);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 571);
            this.Controls.Add(this.dept_tb_label);
            this.Controls.Add(this.dept_tb);
            this.Controls.Add(this.gen_dir_btn);
            this.Controls.Add(this.pose_dir_tb);
            this.Controls.Add(this.panaya_fp_SIT_browse_btn);
            this.Controls.Add(this.filepath_SIT_tb);
            this.Controls.Add(this.filepath_SIT_tb_label);
            this.Controls.Add(this.groupbox_impl);
            this.Controls.Add(this.cai_tb);
            this.Controls.Add(this.cai_tb_label);
            this.Controls.Add(this.ppm_tb);
            this.Controls.Add(this.ppm_tb_label);
            this.Controls.Add(this.filepath_UAT_tb);
            this.Controls.Add(this.filepath_UAT_tb_label);
            this.Controls.Add(this.panaya_UAT_fp_browse_btn);
            this.Name = "Form1";
            this.Text = "Code Release Formalizer";
            this.groupbox_impl.ResumeLayout(false);
            this.groupbox_impl.PerformLayout();
            this.moveTest_gb.ResumeLayout(false);
            this.moveTest_gb.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }




        #endregion
        private System.Windows.Forms.GroupBox groupbox_impl;
        private System.Windows.Forms.ListBox testers_listbox;
        private System.Windows.Forms.ListBox tests_listbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton addTester_btn;
        private System.Windows.Forms.ToolStripButton deleteTester_btn;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton addTest_btn;
        private System.Windows.Forms.ToolStripButton deleteTest_btn;
        private System.Windows.Forms.GroupBox moveTest_gb;
        private System.Windows.Forms.ComboBox moveTest_combobox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button moveTest_btn;
        private System.Windows.Forms.Button gen_btn;
        private System.Windows.Forms.TextBox filepath_SIT_tb;
        private System.Windows.Forms.Label filepath_SIT_tb_label;
        private System.Windows.Forms.Button panaya_fp_SIT_browse_btn;
        private System.Windows.Forms.ToolStripButton renameTester_btn;
        private System.Windows.Forms.TextBox pose_dir_tb;
        private System.Windows.Forms.Button gen_dir_btn;
        private System.Windows.Forms.Label dept_tb_label;
        private System.Windows.Forms.TextBox dept_tb;
    }
}

