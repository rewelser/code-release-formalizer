namespace CodeReleaseFormalizer {
    partial class Form_addTester {
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
            this.label2 = new System.Windows.Forms.Label();
            this.fn_tb = new System.Windows.Forms.TextBox();
            this.ln_tb = new System.Windows.Forms.TextBox();
            this.addTester_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "First name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last name:";
            // 
            // fn_tb
            // 
            this.fn_tb.Location = new System.Drawing.Point(96, 19);
            this.fn_tb.Name = "fn_tb";
            this.fn_tb.Size = new System.Drawing.Size(132, 22);
            this.fn_tb.TabIndex = 2;
            this.fn_tb.TextChanged += new System.EventHandler(this.EnableAddBtn);
            // 
            // ln_tb
            // 
            this.ln_tb.Location = new System.Drawing.Point(96, 55);
            this.ln_tb.Name = "ln_tb";
            this.ln_tb.Size = new System.Drawing.Size(132, 22);
            this.ln_tb.TabIndex = 3;
            this.ln_tb.TextChanged += new System.EventHandler(this.EnableAddBtn);
            // 
            // addTester_btn
            // 
            this.addTester_btn.Enabled = false;
            this.addTester_btn.Location = new System.Drawing.Point(40, 103);
            this.addTester_btn.Name = "addTester_btn";
            this.addTester_btn.Size = new System.Drawing.Size(91, 29);
            this.addTester_btn.TabIndex = 4;
            this.addTester_btn.Text = "Add";
            this.addTester_btn.UseVisualStyleBackColor = true;
            this.addTester_btn.Click += new System.EventHandler(this.AddTester);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(137, 103);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(91, 29);
            this.cancel_btn.TabIndex = 5;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.CloseForm);
            // 
            // Form_addTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 160);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.addTester_btn);
            this.Controls.Add(this.ln_tb);
            this.Controls.Add(this.fn_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_addTester";
            this.Text = "Form_addTester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fn_tb;
        private System.Windows.Forms.TextBox ln_tb;
        private System.Windows.Forms.Button addTester_btn;
        private System.Windows.Forms.Button cancel_btn;
    }
}