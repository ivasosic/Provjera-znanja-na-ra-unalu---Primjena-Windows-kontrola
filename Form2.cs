using System;
using System.Windows.Forms;

namespace FormaProgram
{
    public partial class Form2 : Form
    {
        public string ProgramName { get; private set; }
        public string ProgramDescription { get; private set; }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
          
            ProgramName = textBoxProgramName.Text; 
            ProgramDescription = textBoxProgramDescription.Text; 
            this.DialogResult = DialogResult.OK; 
            this.Close();
        }
    }
}