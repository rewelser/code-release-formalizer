namespace CodeReleaseFormalizer {
    partial class Form_addTest {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.newtest_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addtest_btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.testers_combobox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newtest_tb
            // 
            this.newtest_tb.Location = new System.Drawing.Point(105, 30);
            this.newtest_tb.Name = "newtest_tb";
            this.newtest_tb.Size = new System.Drawing.Size(331, 22);
            this.newtest_tb.TabIndex = 0;
            this.newtest_tb.TextChanged += new System.EventHandler(this.EnableAddBtn);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "New Test:";
            // 
            // addtest_btn
            // 
            this.addtest_btn.Enabled = false;
            this.addtest_btn.Location = new System.Drawing.Point(105, 111);
            this.addtest_btn.Name = "addtest_btn";
            this.addtest_btn.Size = new System.Drawing.Size(110, 28);
            this.addtest_btn.TabIndex = 2;
            this.addtest_btn.Text = "Add";
            this.addtest_btn.UseVisualStyleBackColor = true;
            this.addtest_btn.Click += new System.EventHandler(this.AddTest);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(233, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.CloseForm);
            // 
            // testers_combobox
            // 
            this.testers_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.testers_combobox.FormattingEnabled = true;
            this.testers_combobox.Location = new System.Drawing.Point(105, 65);
            this.testers_combobox.Name = "testers_combobox";
            this.testers_combobox.Size = new System.Drawing.Size(121, 24);
            this.testers_combobox.TabIndex = 4;
            this.testers_combobox.TextChanged += new System.EventHandler(this.EnableAddBtn);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tester:";
            // 
            // Form_addTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 154);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.testers_combobox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addtest_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newtest_tb);
            this.Name = "Form_addTest";
            this.Text = "Form_addTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox newtest_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addtest_btn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox testers_combobox;
        private System.Windows.Forms.Label label2;
    }
}