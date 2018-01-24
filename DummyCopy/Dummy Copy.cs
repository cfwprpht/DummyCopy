using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DummyCopy {
    public partial class CopyDummy : Form {
        public CopyDummy() {
            InitializeComponent();
        }

        private bool IsInt(string value) {
            int _out = 0;
            return int.TryParse(value, out _out);
        }

        private void ButtonSourceDummy_Click(object sender, EventArgs e) {
            if (openFileDialog.ShowDialog() == DialogResult.OK) textBoxSourceDummy.Text = openFileDialog.FileName;
        }

        private void ButtonDestFolder_Click(object sender, EventArgs e) {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK) textBoxDestinationFolder.Text = folderBrowserDialog.SelectedPath;
        }

        private void ButtonCreateDummys_Click(object sender, EventArgs e) {
            if (textBoxStartValue.Text != string.Empty) {
                if (textBoxEndValue.Text != string.Empty) {
                    if (textBoxDummyName.Text != string.Empty) {
                        if (textBoxExtension.Text != string.Empty) {
                            if (IsInt(textBoxStartValue.Text)) {
                                if (IsInt(textBoxEndValue.Text)) {
                                    if (File.Exists(textBoxSourceDummy.Text)) {
                                        if (Directory.Exists(textBoxDestinationFolder.Text)) {
                                            int start, end;
                                            start = int.Parse(textBoxStartValue.Text);
                                            end = int.Parse(textBoxEndValue.Text);

                                            try {
                                                for (int i = start; i < end + 1; i++) {
                                                    string dummy = textBoxDestinationFolder.Text + @"\" + textBoxDummyName.Text + i.ToString() + "." + textBoxExtension.Text;
                                                    if (!File.Exists(dummy)) File.Copy(textBoxSourceDummy.Text, dummy);
                                                }
                                            } catch (Exception exc) { MessageBox.Show(exc.ToString()); } 
                                            finally { MessageBox.Show("Done !"); }
                                        } else MessageBox.Show("Error no destination folder choosen.");
                                    } else MessageBox.Show("Error no dummy choosen.");
                                } else MessageBox.Show("Error end value is no integer.");
                            } else MessageBox.Show("Error start value is no integer.");
                        } else MessageBox.Show("Error Extension empty.");
                    } else MessageBox.Show("Error dummy name empty.");
                } else MessageBox.Show("Error end value is not defined.");
            } else MessageBox.Show("Error start value is not defined.");
        }
    }
}
