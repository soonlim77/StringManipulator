using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToolAssembly;
using ToolAssembly.Files;
using ToolAssembly.ConverterClass;
using ToolAssembly.Facade;
using ToolAssembly.Command;
namespace StringManipulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnToUpper_Click(object sender, EventArgs e)
        {
            var uppercase = new UpperConverter();
            var d = new ConverterMaker(uppercase);

            var outcome = d.FireConverter(txtStringInput.Text);

          
    
            MessageBox.Show(outcome);


        }

        private void btnAlternate_Click(object sender, EventArgs e)
        {
            var alternate = new AlternateConverter();
            var d = new ConverterMaker(alternate);

            var outcome = d.FireConverter(txtStringInput.Text);



            MessageBox.Show(outcome);


        }

        private char[] StringToCharArray()
        {
            string input = this.txtStringInput.Text.ToString();
            char[] inputchar = input.ToCharArray();

            return inputchar;
        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            ICommand obj = new CreateCommand(new CsvFile());
            bool result= obj.Execute(txtStringInput.Text.ToString());
            if (result)
                MessageBox.Show("CSV Created", "Notification");


        }
    }
}
