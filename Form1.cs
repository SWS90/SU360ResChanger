using System;
using System.Windows.Forms;
using System.IO;
using HedgeLib.IO;

namespace SU360ResChanger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private byte[] Xex_File { get; set; }
        private int RenderingRes_X { get; set; }
        private int RenderingRes_Y { get; set; }
        private string Xex_Path { get; set; }
        private string Xex_Name { get; set; }
        private void Load_Xex(string filename)
        {
            Xex_Name = Path.GetFileName(filename);
            Xex_Path = filename;
            Xex_File = File.ReadAllBytes(filename);
            RenderingRes_X_TextBox.Enabled = true;
            RenderingRes_Y_TextBox.Enabled = true;

            SaveXex.Enabled = true;
            RestoreOriginalResBtn.Enabled = true;

            using (MemoryStream file = new MemoryStream(Xex_File))
            using (ExtendedBinaryReader read = new ExtendedBinaryReader(file, true))
            {
                // Get Rendering Res -- In Order Of Xex File
                file.Seek(0xBA5026, SeekOrigin.Begin);
                RenderingRes_Y = read.ReadInt16();

                file.Seek(0xBA502A, SeekOrigin.Begin);
                RenderingRes_X = read.ReadInt16();
            }
            LoadedXexTextBox.Text = filename;
            LoadedXexTextBox.Enabled = false;
            RenderingRes_X_TextBox.Text = RenderingRes_X.ToString();
            RenderingRes_Y_TextBox.Text = RenderingRes_Y.ToString();
        }

        private void Save_Xex(string filename)
        {
            using (FileStream file = new FileStream(filename, FileMode.Create, FileAccess.Write))
            using (ExtendedBinaryWriter writer = new ExtendedBinaryWriter(file, true))
            {
                writer.Write(Xex_File);
                // RenderingRes_Y -- vertical 
                file.Seek(0xBA5026, SeekOrigin.Begin);
                writer.Write(Int16.Parse(RenderingRes_Y_TextBox.Text));
                // RenderingRes_X -- horizontal
                file.Seek(0xBA502A, SeekOrigin.Begin);
                writer.Write(Int16.Parse(RenderingRes_X_TextBox.Text));
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadedXexTextBox.Enabled = false;
            SaveXex.Enabled = false;
            RestoreOriginalResBtn.Enabled = false;
            RenderingRes_X_TextBox.Enabled = false;
            RenderingRes_Y_TextBox.Enabled = false;
        }
       
        private void RestoreOriginalResBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Restore Original Rendering Res?" ,"",MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                RenderingRes_X_TextBox.Text = "880";
                RenderingRes_Y_TextBox.Text = "720";
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
        }
        private void OpenXex_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog()
            {
                Title = "Please select the xex file...",
                FileName = "default.xex",
                DefaultExt = "xex",
                Filter = "XEX Files|*.xex"
            };

            if (open.ShowDialog() == DialogResult.OK)
                Load_Xex(open.FileName);
        }

        private void SaveXex_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog()
            {
                Title = "Please select the path to save the xex file...",
                FileName = Xex_Name,
                DefaultExt = "xex",
                Filter = "XEX Files|*.xex"
            };

            if (save.ShowDialog() == DialogResult.OK)
            {
                Save_Xex(save.FileName);
                Xex_Name = Path.GetFileName(save.FileName);
            }
        }

        private void RenderingRes_X_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == 8)
            {
                return;
            }

            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
        private void RenderingRes_Y_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == 8)
            {
                return;
            }

            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
    }
}

