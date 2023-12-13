using System.Windows.Forms;

namespace SergeyParcesr {
    public partial class FormParser: Form {
        private FileHandling FH;

#pragma warning disable CS8618
        public FormParser() {
            InitializeComponent();
        }
#pragma warning restore CS8618

        private void GetParserFile_Click(object sender, EventArgs e) {
            OpenFileDialog dialog = new OpenFileDialog();
            if(dialog.ShowDialog() == DialogResult.OK) {
                string[] pathToFile = dialog.FileName.Split('\\');
                ParsingFile.Text = pathToFile[^1];
                FH = new(dialog.FileName, RichTextOutput, OutputDataGrid,
                    FilterComBoxSenderName, FilterComBoxReceiverName,
                    FilterComBoxAttributeName, FilterComBoxCodeName);
                ReadParserFile.Enabled = true;
                FilterButton.Enabled = true;
                FilterComBoxSenderName.Enabled = true;
                FilterComBoxReceiverName.Enabled = true;
                FilterComBoxAttributeName.Enabled = true;
                FilterComBoxCodeName.Enabled = true;
            }
        }

        private void ReadParserFile_Click(object sender, EventArgs e) {
            RichTextOutput.Clear();
            FH.ReadFileHandling();
        }

        private void StopButton_Click(object sender, EventArgs e) {
            FH.StopReadFile();
        }

        private void ClearButton_Click(object sender, EventArgs e) {
            OutputDataGrid.Rows.Clear();
            RichTextOutput.Clear();
        }

        private void FilterButton_Click(object sender, EventArgs e) {
            RichTextOutput.Clear();
            FH.FilterDataGrid(
                FilterComBoxSenderName.Text, FilterComBoxReceiverName.Text,
                FilterComBoxAttributeName.Text, FilterComBoxCodeName.Text
            );
        }
    }
}