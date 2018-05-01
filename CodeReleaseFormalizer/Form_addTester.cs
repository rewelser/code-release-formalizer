using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeReleaseFormalizer {
    public partial class Form_addTester : Form {

        Form1 form1;
        GenResults gen;

        public Form_addTester() {
            InitializeComponent();
        }

        public void SetGen(Form1 form1, GenResults gen) {
            this.form1 = form1;
            this.gen = gen;
        }

        private void EnableAddBtn(object sender, EventArgs e) {
            addTester_btn.Enabled = (fn_tb.Text != "" && ln_tb.Text != "");
        }

        private void CloseForm(object sender, EventArgs e) {
            Close();
        }

        private void AddTester(object sender, EventArgs e) {

            List<Tester> testers = gen.GetTesters();
            bool dupe_name = false;
            string newName = (fn_tb.Text + " " + ln_tb.Text).Trim();
            for (int i = 0; i < testers.Count; i++) {
                if (testers[i].GetTester() == newName) {
                    dupe_name = true;
                }
            }

            if (!dupe_name && newName.Trim() != "") {
                testers.Add(new Tester(newName));
                gen.SetTesters(testers);
                form1.UpdateTesters();
                Close();
            } else if (dupe_name) {
                fn_tb.Text = "";
                ln_tb.Text = "";
                MessageBox.Show("There is already a tester with this name.");
            } else if (newName.Trim() == "") {
                fn_tb.Text = "";
                ln_tb.Text = "";
                MessageBox.Show("This name is invalid");
            }

        }

    }
}
