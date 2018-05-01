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
    public partial class Form_addTest : Form {

        Form1 form1;
        GenResults gen;
        List<Tester> testers;

        public Form_addTest() {
            InitializeComponent();
        }

        public void SetGen_SetForm1Ref_PopComboBox(Form1 form1, GenResults gen, string selectedtester) {
            this.form1 = form1;
            this.gen = gen;
            testers = gen.GetTesters();
            for (int i = 0; i < testers.Count; i++) {
                testers_combobox.Items.Add(testers[i].GetTester());
                if (selectedtester == testers[i].GetTester()) {
                    testers_combobox.SelectedIndex = testers_combobox.FindStringExact(selectedtester);
                }
            }
        }

        private void CloseForm(object sender, EventArgs e) {
            Close();
        }

        private void EnableAddBtn(object sender, EventArgs e) {
            addtest_btn.Enabled = (newtest_tb.Text != "" && testers_combobox.SelectedIndex > -1);
        }

        private void AddTest(object sender, EventArgs e) {
            for (int i = 0; i < testers.Count; i++) {
                if (testers[i].GetTester() == testers_combobox.SelectedItem.ToString()) {
                    testers[i].AddTestID(newtest_tb.Text);
                }
            }
            gen.SetTesters(testers);
            form1.UpdateFromExtModal();
            Close();
        }

    }
}
