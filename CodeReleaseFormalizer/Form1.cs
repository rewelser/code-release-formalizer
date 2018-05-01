using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ExcelDataReader;
using OfficeOpenXml;
using System.Text.RegularExpressions;
using System.Diagnostics;
using Xceed.Words.NET;

namespace CodeReleaseFormalizer {
    public partial class Form1 : Form {

        GenResults gen_SIT;
        GenResults gen;
        List<Tester> testers;
        bool currentlyMoving = false;
        // Will not be "" if someone re-clicks to create a directory
        string prevCreatedDir = "";
        string datetime = DateTime.Now.ToString("dd.MM.yy__HH.mm.ss");

        public Form1() {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            dept_tb.Select();
        }

        public void UpdateTesters() {
            testers = gen.GetTesters();
            testers_listbox.Items.Clear();
            tests_listbox.Items.Clear();
            PopulateLists(testers);
        }

        public void UpdateFromExtModal() {
            SelectTester(null, null);
        }

        private void Browse_Click_SIT(object sender, EventArgs e) {
            // Displays an OpenFileDialog so the user can select a Cursor.  
            OpenFileDialog ofd = new OpenFileDialog {
                //openFileDialog1.Filter = "Excel Files|*.xlsx";
                Filter = "Excel Files|Panaya Exported Steps*.xlsx",
                Title = "(SIT) Select 'Panaya Exported Steps.xlsx'"
            };
            //ofd.StartPosition = FormStartPosition.CenterScreen;
            if (ofd.ShowDialog() == DialogResult.OK) {
                groupbox_impl.Enabled = false;
                // Assign the cursor in the Stream to the Form's Cursor property.
                var filename = ofd.FileName;
                filepath_SIT_tb.Text = filename;
                gen_SIT = new GenResults(filepath_SIT_tb.Text, dept_tb.Text, ppm_tb.Text, cai_tb.Text, datetime, this);
                gen_SIT.Populate(false);
            }
        }

        private void Browse_Click_UAT(object sender, EventArgs e) {
            // Displays an OpenFileDialog so the user can select a Cursor.  
            OpenFileDialog ofd = new OpenFileDialog {
                //ofd.Filter = "Excel Files|*.xlsx";
                Filter = "Excel Files|Panaya Exported Steps*.xlsx",
                Title = "(UAT) Select 'Panaya Exported Steps.xlsx'"
            };
            //ofd.StartPosition = FormStartPosition.CenterScreen;
            if (ofd.ShowDialog() == DialogResult.OK) {
                groupbox_impl.Enabled = false;
                // Assign the cursor in the Stream to the Form's Cursor property.
                filepath_UAT_tb.Text = ofd.FileName;

                gen = new GenResults(filepath_UAT_tb.Text, dept_tb.Text, ppm_tb.Text, cai_tb.Text, datetime, this);
                gen.Populate(true);
            }
        }

        // Pose new directory to user to create
        public void Pose_UAT_dir(string filepath) {
            pose_dir_tb.Enabled = true; // welsertest: these all should be disabled once the directory is created
            gen_dir_btn.Enabled = true;
            pose_dir_tb.Text = filepath;
        }

        // Create directory from pose_dir_tb.Text
        private void Create_UAT_dir(object sender, EventArgs e) {

            // If prev created directory exists, delete it
            if (prevCreatedDir != "") {
                (new FileInfo(prevCreatedDir)).Directory.Delete();
            }

            (new FileInfo(pose_dir_tb.Text)).Directory.Create();
            tests_listbox.Items.Clear();
            testers_listbox.Items.Clear();
            testers = gen.GetTesters();
            PopulateLists(testers);
            gen.SetFilePath(pose_dir_tb.Text);
            groupbox_impl.Enabled = true;
            prevCreatedDir = pose_dir_tb.Text;
        }

        private void EnableBrowseBtn(object sender, EventArgs e) {
            if (!groupbox_impl.Enabled) {
                panaya_UAT_fp_browse_btn.Enabled = (ppm_tb.Text.Trim() != "" && cai_tb.Text.Trim() != "" && filepath_SIT_tb.Text.Trim() != "" && dept_tb.Text.Trim() != "");
                pose_dir_tb.Enabled = panaya_UAT_fp_browse_btn.Enabled;
                gen_dir_btn.Enabled = panaya_UAT_fp_browse_btn.Enabled;
            } else {
                gen_btn.Enabled = (ppm_tb.Text.Trim() != "" && cai_tb.Text.Trim() != "" && filepath_SIT_tb.Text.Trim() != "" && dept_tb.Text.Trim() != "");
            }
        }

        private void PopulateLists(List<Tester> testers) {
            for (int i = 0; i < testers.Count; i++) {
                testers_listbox.Items.Add(testers[i].GetTester());
            }
        }

        private void SelectTester(object sender, EventArgs e) {
            if (testers_listbox.SelectedItem != null) {
                deleteTester_btn.Enabled = true;
                renameTester_btn.Enabled = true;
                tests_listbox.Items.Clear();
                for (int i = 0; i < testers.Count; i++) {
                    if (testers[i].GetTester() == testers_listbox.SelectedItem.ToString()) {
                        List<string> tests = testers[i].GetTests();
                        for (int j = 0; j < tests.Count; j++) {
                            tests_listbox.Items.Add(tests[j]);
                        }
                    }
                }
            }
        }

        private void DeleteTester(object sender, EventArgs e) {
            int temp = -1;
            for (int i = 0; i < testers.Count; i++) {
                if (testers[i].GetTester() == testers_listbox.SelectedItem.ToString()) {
                    temp = i;
                }
            }
            if (temp != -1) {
                testers.Remove(testers[temp]);
            }
            testers_listbox.Items.Remove(testers_listbox.SelectedItem);
            tests_listbox.Items.Clear();
            gen.SetTesters(testers);
            deleteTester_btn.Enabled = false;
            renameTester_btn.Enabled = false;
        }

        private void AddTester(object sender, EventArgs e) {
            var form = new Form_addTester {
                StartPosition = FormStartPosition.CenterScreen
            };
            form.SetGen(this, gen);
            form.ShowDialog();
        }

        private void RenameTester(object sender, EventArgs e) {
            var form = new Form_renameTester {
                StartPosition = FormStartPosition.CenterScreen
            };
            form.SetGen(this, gen, testers_listbox.SelectedItem.ToString());
            form.ShowDialog();
        }

        private void SelectTest(object sender, EventArgs e) {
            if (tests_listbox.SelectedItem != null) {
                deleteTest_btn.Enabled = true;
                moveTest_gb.Enabled = true;
                MoveTest_pre();
            }
        }

        private void DeleteTest(object sender, EventArgs e) {
            int temp = -1;
            int temp2 = -1;
            for (int i = 0; i < testers.Count; i++) {
                if (testers[i].GetTester() == testers_listbox.SelectedItem.ToString()) {
                    temp = i;
                    for (int j = 0; j < testers[i].GetTests().Count; j++) {
                        if (testers[i].GetTests()[j] == tests_listbox.SelectedItem.ToString()) {
                            temp2 = j;
                        }
                    }
                }
            }
            if (temp != -1 && temp2 != -1) {
                testers[temp].RemoveTestID(testers[temp].GetTests()[temp2]);
            }
            if (!currentlyMoving) {
                RemoveTestAndUpdate();
            }
        }

        private void AddTest(object sender, EventArgs e) {
            var form = new Form_addTest();
            form.StartPosition = FormStartPosition.CenterScreen;
            if (testers_listbox.SelectedIndex > -1) {
                form.SetGen_SetForm1Ref_PopComboBox(this, gen, testers_listbox.SelectedItem.ToString());
            } else {
                form.SetGen_SetForm1Ref_PopComboBox(this, gen, "");
            }
            form.ShowDialog();
        }

        private void MoveTest_pre() {
            moveTest_combobox.Items.Clear();
            for (int i = 0; i < testers.Count; i++) {
                moveTest_combobox.Items.Add(testers[i].GetTester());
            }
        }

        private void EnableMoveTestBtn(object sender, EventArgs e) {
            moveTest_btn.Enabled = moveTest_combobox.SelectedIndex > -1;
        }

        private void MoveTest(object sender, EventArgs e) {
            currentlyMoving = true;
            DeleteTest(sender, e);
            
            // Add it back to new tester
            for (int i = 0; i < testers.Count; i++) {
                if (testers[i].GetTester() == moveTest_combobox.SelectedItem.ToString()) {
                    testers[i].AddTestID(tests_listbox.SelectedItem.ToString());
                }
            }
            currentlyMoving = false;
            RemoveTestAndUpdate();
        }

        private void RemoveTestAndUpdate() {
            tests_listbox.Items.Remove(tests_listbox.SelectedItem);
            gen.SetTesters(testers);
            moveTest_combobox.Items.Clear();
            deleteTest_btn.Enabled = false;
            moveTest_gb.Enabled = false;
        }

        private void GenDocs(object sender, EventArgs e) {
            gen.CreateApprovalDocXs();
            gen_SIT.SetFilePath(gen.GetFilePath());
            gen_SIT.SetRelease(gen.GetRelease());
            gen_SIT.CreateXLSX();
            Close();
        }

    }

    public class GenResults {

        // Indistinct, used for initial table
        List<string> test_ids = new List<string>();
        List<string> test_names = new List<string>();
        List<string> test_statuses = new List<string>();
        List<string> test_descriptions = new List<string>();
        List<string> step_testers = new List<string>();

        // Distinct, used for approver docs
        List<Tester> testers = new List<Tester>();

        string filepath;
        string dept;
        string ppm_num;
        string cai_num;
        string release;
        string datetime;
        Form1 context;

        public GenResults(string filepath, string dept, string ppm_num, string cai_num, string datetime, Form1 context) {
            this.filepath = @filepath;
            this.dept = dept;
            this.ppm_num = ppm_num;
            this.cai_num = cai_num;
            this.datetime = datetime;
            this.context = context;
        }

        public List<Tester> GetTesters() {
            return testers;
        }

        public List<Tester> SetTesters(List<Tester> testers) {
            this.testers = testers;
            return testers;
        }

        public string GetFilePath() {
            return filepath;
        }

        public string SetFilePath(string filepath) {
            this.filepath = @filepath;
            return this.filepath;
        }

        public string GetRelease() {
            return release;
        }

        public string SetRelease(string release) {
            this.release = release;
            return this.release;
        }

        public void Populate(bool isUAT) {
            using (var stream = File.Open(filepath, FileMode.Open, FileAccess.Read)) {
                // Auto-detect format, supports:
                //  - Binary Excel files (2.0-2003 format; *.xls)
                //  - OpenXml Excel files (2007 format; *.xlsx)
                using (var reader = ExcelReaderFactory.CreateReader(stream)) {

                    // 2. Use the AsDataSet extension method
                    var result = reader.AsDataSet();

                    // The result of each spreadsheet is in result.Tables
                    DataTable dt = result.Tables[0];

                    for (int i = 0; i < result.Tables[0].Rows.Count; i++) {
                        if (!test_ids.Contains(dt.Rows[i][0].ToString())) {
                            test_ids.Add(dt.Rows[i][0].ToString());
                            test_names.Add(dt.Rows[i][2].ToString());
                            test_statuses.Add(dt.Rows[i][3].ToString());
                            test_descriptions.Add(dt.Rows[i][5].ToString());
                            step_testers.Add(dt.Rows[i][53].ToString());

                            var tester = new Tester(dt.Rows[i][53].ToString());

                            if (tester.GetTester().Trim() == "") {
                                tester.RenameTester("[name missing]");
                            }

                            if (i > 0) {
                                if (i == 1) {
                                    tester.AddTestID(dt.Rows[i][0].ToString(), dt.Rows[i][2].ToString());
                                    testers.Add(tester);
                                    
                                }
                                else if (!testers.Contains(tester)) {
                                    tester.AddTestID(dt.Rows[i][0].ToString(), dt.Rows[i][2].ToString());
                                    testers.Add(tester);
                                }
                                else {
                                    for (var j = 0; j < testers.Count; j++) {
                                        if (testers[j].Equals(tester)) {
                                            testers[j].AddTestID(dt.Rows[i][0].ToString(), dt.Rows[i][2].ToString());
                                        }
                                    }
                                }
                            }
                        }
                    }

                    if (isUAT) {
                            release = Regex.Replace(dt.Rows[1][4].ToString(), dept, "", RegexOptions.IgnoreCase);
                        if (release.Contains(" >") || release.Contains(" -")) {
                            Regex r = new Regex(@"(.*?)((?=\s>)|(?=\s-))");
                            Match match = r.Match(release);
                            if (release.ToCharArray()[0] == ' ') {
                                release = dept + match.Value;
                            }
                            else {
                                release = dept + " " + match.Value;
                            }
                        }
                        else {
                            if (release.ToCharArray()[0] == ' ') {
                                release = dept + release;
                            }
                            else {
                                release = dept + " " + release;
                            }
                        }

                        Regex expr = new Regex(@"(C:.*)(?=Panaya Exported Steps.*\.xlsx)", RegexOptions.IgnoreCase);
                        Match expr_match = expr.Match(filepath);
                        filepath = expr_match.Value;
                        filepath += "[" + datetime + "] " + @release + @"\";

                        context.Pose_UAT_dir(filepath);
                    }
                }
            }
        }


        public void CreateApprovalDocXs() {

            for (int i = 0; i < testers.Count; i++) {
                string fp1 = filepath;
                fp1 += release + " (" + testers[i].GetTester() + " – Implementation Sign Off).docx";
                Debug.WriteLine(release);
                using (DocX document = DocX.Create(@fp1)) {

                    // Add document info
                    string title = release + " – Implementation Sign Off";
                    document.InsertParagraph(title).FontSize(15d).Bold().SpacingAfter(50d).Alignment = Alignment.center;

                    var p1 = document.InsertParagraph("Approval Request");
                    p1.SpacingAfter(10d);
                    p1.IndentationFirstLine = 1.0f;

                    // Add a Table into the document and sets its values
                    var t = document.AddTable(2, 4);
                    t.Design = TableDesign.TableGrid;
                    t.Alignment = Alignment.center;
                    t.Rows[0].Cells[0].Paragraphs[0].Append("Description of Approval").FontSize(8d);
                    t.Rows[0].Cells[1].Paragraphs[0].Append("HP PPM #").FontSize(8d);
                    t.Rows[0].Cells[2].Paragraphs[0].Append("CA Ticket #").FontSize(8d);
                    t.Rows[0].Cells[3].Paragraphs[0].Append("Approver's Name").FontSize(8d);

                    t.Rows[1].Cells[0].Paragraphs[0].Append(testers[i].PrintTests()).FontSize(8d);
                    t.Rows[1].Cells[1].Paragraphs[0].Append(ppm_num).FontSize(8d);
                    t.Rows[1].Cells[2].Paragraphs[0].Append(cai_num).FontSize(8d);
                    t.Rows[1].Cells[3].Paragraphs[0].Append(testers[i].GetTester()).FontSize(8d);
                    t.AutoFit = AutoFit.Contents;

                    // Insert the Table after the Paragraph.
                    p1.InsertTableAfterSelf(t);
                    var p2 = document.InsertParagraph("Returning this email to sender indicates your approval that the implemented changes are satisfactory. Upon receipt of your approval the incident will be closed.");
                    p2.SpacingBefore(10d);
                    p2.IndentationBefore = 1.0f;
                    document.Save();
                }

                string fp2 = filepath;
                fp2 += release + " (" + testers[i].GetTester() + " – Business Approval).docx";
                using (DocX document = DocX.Create(@fp2)) {

                    // Add document info
                    string title = release + " – Business Approval";
                    document.InsertParagraph(title).FontSize(15d).Bold().SpacingAfter(50d).Alignment = Alignment.center;

                    var p1 = document.InsertParagraph("Approval Request");
                    p1.SpacingAfter(10d);
                    p1.IndentationFirstLine = 1.0f;

                    // Add a Table into the document and sets its values
                    var t = document.AddTable(2, 4);
                    t.Design = TableDesign.TableGrid;
                    t.Alignment = Alignment.center;
                    t.Rows[0].Cells[0].Paragraphs[0].Append("Description of Approval").FontSize(8d);
                    t.Rows[0].Cells[1].Paragraphs[0].Append("HP PPM #").FontSize(8d);
                    t.Rows[0].Cells[2].Paragraphs[0].Append("CA Ticket #").FontSize(8d);
                    t.Rows[0].Cells[3].Paragraphs[0].Append("Approver's Name").FontSize(8d);

                    t.Rows[1].Cells[0].Paragraphs[0].Append(testers[i].PrintTests()).FontSize(8d);
                    t.Rows[1].Cells[1].Paragraphs[0].Append(ppm_num).FontSize(8d);
                    t.Rows[1].Cells[2].Paragraphs[0].Append(cai_num).FontSize(8d);
                    t.Rows[1].Cells[3].Paragraphs[0].Append(testers[i].GetTester()).FontSize(8d);
                    t.AutoFit = AutoFit.Contents;

                    // Insert the Table after the Paragraph.
                    p1.InsertTableAfterSelf(t);
                    var p2 = document.InsertParagraph("Returning this email to sender indicates your approval for UAT.");
                    p2.SpacingBefore(10d);
                    p2.IndentationBefore = 1.0f;
                    document.Save();
                }
            }
        }

        // Create Issue Description doc for Evidence (SIT)
        public void CreateXLSX() {
            
            string fp = filepath;
            fp += release + " – Evidence.docx";
            Debug.WriteLine(release);
            using (DocX document = DocX.Create(@fp)) {

                // Add document info
                string title = release + " – Evidence";
                document.InsertParagraph(title).FontSize(15d).Bold().SpacingAfter(50d).Alignment = Alignment.center;

                // Add a Table into the document and sets its values
                var t1 = document.AddTable(test_names.Count, 2);
                t1.Design = TableDesign.TableGrid;
                t1.Alignment = Alignment.center;
                t1.Rows[0].Cells[0].FillColor = Color.LightGray;
                t1.Rows[0].Cells[1].FillColor = Color.LightGray;

                for (int i = 0; i < test_names.Count; i++) {
                    if (i == 0) {
                        t1.Rows[i].Cells[0].Paragraphs[0].Append(test_names[i]).FontSize(10d).Bold().SpacingBefore(5d).SpacingAfter(5d).Alignment = Alignment.center;
                        t1.Rows[i].Cells[1].Paragraphs[0].Append(test_descriptions[i]).FontSize(10d).Bold().SpacingBefore(5d).SpacingAfter(5d).Alignment = Alignment.center;
                    } else {
                        t1.Rows[i].Cells[0].Paragraphs[0].Append(test_names[i]).FontSize(8d).KeepLinesTogether(true);
                        t1.Rows[i].Cells[1].Paragraphs[0].Append(test_descriptions[i]).FontSize(8d).KeepLinesTogether(true);
                    }
                }

                t1.AutoFit = AutoFit.Contents;
                document.InsertTable(t1);
                Paragraph p = document.InsertParagraph("\n");

                // Create new table where .zip is embedded
                var t2 = document.AddTable(2, 1);
                t2.Design = TableDesign.TableGrid;
                t2.Alignment = Alignment.center;
                t2.Rows[0].Cells[0].FillColor = Color.LightGray;
                t2.Rows[0].Cells[0].Paragraphs[0].Append("Before/After Evidence").FontSize(10d).Bold().SpacingBefore(5d).SpacingAfter(5d).Alignment = Alignment.center;
                t2.Rows[1].Cells[0].Paragraphs[0].FontSize(8d).Alignment = Alignment.center;
                document.InsertTable(t2);

                document.Save();
            }
        }
    }


    public class Tester : IEquatable<Tester> {

        string tester;
        public List<string> tests = new List<string>();

        public Tester(string tester) {
            this.tester = tester;
        }

        public void RenameTester(string tester) {
            this.tester = tester;
        }

        public void AddTestID(string id, string name) {
            string test = id + " | " + name;
            tests.Add(test);
        }

        public void AddTestID(string id_name) {
            string test = id_name;
            tests.Add(test);
        }

        public void RemoveTestID(string id_name) {
            tests.Remove(id_name);
        }

        public bool Equals(Tester other) {
            if (tester == other.tester) {
                return true;
            }
            else {
                return false;
            }
        }

        public string GetTester() {
            return tester;
        }

        public string PrintTests() {
            string str = "";
            for (int i = 0; i < tests.Count; i++) {
                str += tests[i] + "\n";
            }
            return str;
        }

        public List<string> GetTests() {
            return tests;
        }
    }

}
