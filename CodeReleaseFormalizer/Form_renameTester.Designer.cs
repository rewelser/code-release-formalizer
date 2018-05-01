namespace CodeReleaseFormalizer {
    partial class Form_renameTester {
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
            this.label1 = new System.Windows.Forms.Label();
            this.renameTester_btn = new System.Windows.Forms.Button();
            this.close_btn = new System.Windows.Forms.Button();
            this.fln_tb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Name:";
            // 
            // renameTester_btn
            // 
            this.renameTester_btn.Enabled = false;
            this.renameTester_btn.Location = new System.Drawing.Point(74, 68);
            this.renameTester_btn.Name = "renameTester_btn";
            this.renameTester_btn.Size = new System.Drawing.Size(91, 29);
            this.renameTester_btn.TabIndex = 1;
            this.renameTester_btn.Text = "Rename";
            this.renameTester_btn.UseVisualStyleBackColor = true;
            this.renameTester_btn.Click += new System.EventHandler(this.RenameTester);
            // 
            // close_btn
            // 
            this.close_btn.Location = new System.Drawing.Point(196, 68);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(91, 29);
            this.close_btn.TabIndex = 2;
            this.close_btn.Text = "Cancel";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.CloseForm);
            // 
            // fln_tb
            // 
            this.fln_tb.Location = new System.Drawing.Point(141, 21);
            this.fln_tb.Name = "fln_tb";
            this.fln_tb.Size = new System.Drawing.Size(146, 22);
            this.fln_tb.TabIndex = 3;
            this.fln_tb.TextChanged += new System.EventHandler(this.EnableAddBtn);
            // 
            // Form_renameTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 122);
            this.Controls.Add(this.fln_tb);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.renameTester_btn);
            this.Controls.Add(this.label1);
            this.Name = "Form_renameTester";
            this.Text = "Rename Tester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button renameTester_btn;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.TextBox fln_tb;
    }
}