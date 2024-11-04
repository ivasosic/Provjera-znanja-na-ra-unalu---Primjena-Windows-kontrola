using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace FormaProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBoxPrograms.Items.Add("Notepad");
            comboBoxPrograms.Items.Add("Paint");
            groupBoxProgramControl.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonRunProgram_Click(object sender, EventArgs e)
        {
            string selectedProgram = comboBoxPrograms.SelectedItem?.ToString();

            if (selectedProgram == "Notepad")
            {
                
                Process.Start(@"C:\Windows\System32\notepad.exe");
            }
            else if (selectedProgram == "Paint")
            {
                
                Process.Start(@"C:\Windows\System32\mspaint.exe");
            }
            else
            {
                MessageBox.Show("Molimo odaberite program.");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxProgramControl.Visible = checkBoxShowAction.Checked;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
           textBoxProgramName.Clear();
           textBoxProgramDescription.Clear();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Open clicked");
        }

        private void messageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "Da li želite da nastavite?",
               "Informacija",
               MessageBoxButtons.YesNoCancel,
               MessageBoxIcon.Information
           );

            switch (result)
            {
                case DialogResult.Yes:
                    MessageBox.Show("Odabrali ste 'Da'.");
                    break;
                case DialogResult.No:
                    MessageBox.Show("Odabrali ste 'Ne'.");
                    break;
                case DialogResult.Cancel:
                    MessageBox.Show("Odabrali ste 'Odustani'.");
                    break;
            }
        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                textBoxProgramName.Text = form2.ProgramName; 
                textBoxProgramDescription.Text = form2.ProgramDescription;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
           DialogResult result = MessageBox.Show(
            "Da li ste sigurni da želite zatvoriti aplikaciju?",
            "Potvrda",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            );

       
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
