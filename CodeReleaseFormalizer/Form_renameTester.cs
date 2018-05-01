using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeReleaseFormalizer {
    public partial class Form_renameTester : Form {

        Form1 form1;
        GenResults gen;
        string newTester;

        public Form_renameTester() {
            InitializeComponent();
            fln_tb.Select();
        }

        public void SetGen(Form1 form1, GenResults gen, string newTester) {
            this.form1 = form1;
            this.gen = gen;
            this.newTester = newTester;
        }

        private void EnableAddBtn(object sender, EventArgs e) {
            renameTester_btn.Enabled = (fln_tb.Text != "");
        }

        private void CloseForm(object sender, EventArgs e) {
            Close();
        }

        private void RenameTester(object sender, EventArgs e) {
            List<Tester> testers = gen.GetTesters();
            bool dupe_name = false;
            string newName = fln_tb.Text.Trim();
            for (int i = 0; i < testers.Count; i++) {
                if (testers[i].GetTester() == newName) {
                    dupe_name = true;
                }
            }

            if (!dupe_name && newName.Trim() != "") {
                for (int i = 0; i < testers.Count; i++) {
                    if (testers[i].GetTester() == newTester) {
                        testers[i].RenameTester(newName);
                    }
                }
                gen.SetTesters(testers);
                form1.UpdateTesters();
                Close();
            } else if (dupe_name) {
                fln_tb.Text = "";
                MessageBox.Show("There is already a tester with this name.");
            } else if (newName.Trim() == "") {
                fln_tb.Text = "";
                MessageBox.Show("This name is invalid");
            }

        }

    }
}
