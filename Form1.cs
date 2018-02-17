using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syroot.NintenTools.Byaml.Dynamic;
using Syroot.BinaryData;
using Syroot.Maths;
using Syroot.NintenTools.Yaz0;
using OpenTK;

namespace ByamlEditor
{
    public partial class ByamlTool : Form
    {

        public ByamlTool()
        {
            InitializeComponent();
        }
        Dictionary<string, dynamic> byaml = null;

        //Settings
       public dynamic byteOrderLE = ByteOrder.LittleEndian;
       public dynamic byteOrder = ByteOrder.BigEndian;
       public dynamic SupportPaths = true;


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog d = new OpenFileDialog())
            {
                d.Title = "Open File";
                d.Filter = "Binary yaml|*.byaml;*.bprm;*.szs;|All files (*.*)|*.*";

                if (d.ShowDialog() == DialogResult.OK)
                {
                    const string message = "Not implemented yet!";
                    const string caption = "Error";
                    var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (byaml == null) return;

            dynamic SupportPaths = true;

            using (SaveFileDialog s = new SaveFileDialog())
            {
                s.Title = "Save File";
                s.CheckFileExists = true;
                s.CheckPathExists = true;
                s.DefaultExt = "byaml";
                s.Filter = "Binary yaml|*.byaml;*.bprm;*.szs;|All files (*.*)|*.*";

             //   ByamlFile.Save("3", byaml);


                if (s.ShowDialog() == DialogResult.OK)
                {
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void convertToBigEndianToolStripMenuItem_Click(object sender, EventArgs e)
        {



            using (OpenFileDialog d = new OpenFileDialog())
            {
                d.Title = "Open File";
                d.Filter = "Binary yaml|*.byaml;*.bprm;*.szs;|All files (*.*)|*.*";

                if (d.ShowDialog() == DialogResult.OK)
                {
                    dynamic byaml = ByamlFile.Load(d.FileName, SupportPaths, byteOrderLE);

                    ByamlFile.Save(d.FileName + ".new.byaml", byaml, SupportPaths, byteOrder);

                    const string message = "Successfully converted byaml to big endian!";
                    const string caption = "Success";
                    var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void convertToLittleEndianToolStripMenuItem_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog d = new OpenFileDialog())
            {
                if (d.ShowDialog() == DialogResult.OK)
                {
                    dynamic byaml = ByamlFile.Load(d.FileName, SupportPaths, byteOrder);

                    ByamlFile.Save(d.FileName + ".new.byaml", byaml, SupportPaths, byteOrderLE);

                    const string message = "Successfully converted byaml to little endian!";
                    const string caption = "Success";
                    var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
