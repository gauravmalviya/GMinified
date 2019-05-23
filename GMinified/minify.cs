using System;
using System.IO;
using System.Windows.Forms;
using Yahoo.Yui.Compressor;

namespace GMinified
{
    public partial class frmMinify : Form
    {
        public frmMinify()
        {
            InitializeComponent();
        }



        private void btnInput_Click(object sender, EventArgs e)
        {
            DialogResult result = this.fbdInput.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtInput.Text = this.fbdInput.SelectedPath;
                //foreach (string f in Directory.GetFiles(foldername))
                //{
                //    this.listBox1.Items.Add(f);
                //}
            }
        }

        private void btnMinify_Click(object sender, EventArgs e)
        {
            foreach (string f in Directory.GetFiles(txtInput.Text))
            {
                string filename = f.Split('\\')[f.Split('\\').Length - 1];

                string filetype = filename.Split('.')[filename.Split('.').Length - 1];

                try
                {
                    string listBox1 = string.Empty;
                    if (filetype.ToLower() == "js")
                    {
                        listBox1 = JavaScriptCompressor.Compress(File.ReadAllText(f));
                    }
                    else if (filetype.ToLower() == "css")
                    {
                        listBox1 = CssCompressor.Compress(File.ReadAllText(f));
                    }
                    string path = txtOutput.Text + "\\" + filename;
                    File.AppendAllLines(path, new[] { listBox1 });
                }
                catch (Exception)
                {
                    string listBox1 = File.ReadAllText(f);
                    string path = txtOutput.Text + "\\" + filename;
                    File.AppendAllLines(path, new[] { listBox1 });
                }
            }
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            DialogResult result = this.fbdInput.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtOutput.Text = this.fbdInput.SelectedPath;
                //foreach (string f in Directory.GetFiles(foldername))
                //{
                //    this.listBox1.Items.Add(f);
                //}
            }
        }
    }
}