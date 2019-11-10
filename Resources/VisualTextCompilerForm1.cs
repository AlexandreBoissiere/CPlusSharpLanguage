using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CompilerLibrary;
using System.IO;
using System.Threading;

namespace VisualTextCompiler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PrecompileButton_click(object sender, EventArgs e)
        {
            TemporaryFiles temp = new TemporaryFiles("./temp.cps");
            TemporaryFiles temp_out = new TemporaryFiles("./output.tcs");
            const string Path = "./output.cs";
            StreamWriter @out = new StreamWriter(Path);
            string inText = InputCodeText.Text;

            try
            {
                File.WriteAllText(temp.path, inText);
            }
            catch (IOException exc)
            {
                MessageBox.Show(exc.Message + "\n Fermeture du programme", "Fermeture du programme", MessageBoxButtons.OK);
                Application.Exit();
            }

            CSharp.Compiler.precompile(temp, temp_out);

            @out.Write(File.ReadAllText(temp_out.path));

            @out.Close();

            PreCompiledText.Text = File.ReadAllText(Path);

            temp.Close();
            temp_out.Close();
        }

        private void CompileButton_Click(object sender, EventArgs e)
        {
            TemporaryFiles tempIn = new TemporaryFiles("./temp.cps");
            File.WriteAllText(tempIn.path, File.ReadAllText("output.cs"));
            List<string> errors = CSharp.Compiler.compile(tempIn.path, "output.exe");

            if (errors.Count > 0)
            {
                foreach (string sub in errors)
                {
                    Status.Text += Environment.NewLine + sub;
                }
            }
            else
                Status.Text += Environment.NewLine + "Compilation : OK";

        }

        private void CompileAllButton_Click(object sender, EventArgs e)
        {
            PrecompileButton.PerformClick();
            CompileButton.PerformClick();
        }

        private void SavingButton_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter("./save.cps");
            file.Write(InputCodeText.Text);
            file.Close();
            Status.Text += Environment.NewLine + "Saving : OK";
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            var savedContent = File.ReadAllText("./save.cps");
            InputCodeText.Text = savedContent;
            Status.Text += Environment.NewLine + "Opening : OK";
        }
    }
}
