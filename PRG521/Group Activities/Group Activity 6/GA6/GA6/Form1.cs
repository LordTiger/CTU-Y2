using System;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;

//Brandon de Bruyn 6954
//Luke de Kiewit 7293
namespace GA6
{
    public partial class Form1 : Form
    {
        public string fileName;
        public Form1()
        {
            InitializeComponent();
        }

        private void b_Browse_Click(object sender, EventArgs e)
        {
            BFiles(); // Calling the BrowseFiles Method
        }

        //Browse Files and save them to t_RBox Method
        public void BFiles()
        {
            OpenFileDialog f_Dialog = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if(f_Dialog.ShowDialog() == DialogResult.OK)
            {
                fileName = f_Dialog.FileName;
                t_RBox.Text = fileName;

            }
        }

        private void b_Search_Click(object sender, EventArgs e)
        {
            try
            {
                if (t_SBox.Text != "")
                {
                    SAF();
                }
            }catch
            {
                MessageBox.Show("Lolz");
            }

            
        }


        // Search and Find i guess, Basically the whole,
        // Thing about searching the word and placing it into the Label
        public void SAF()
        {
            StreamReader oReader;
            if (File.Exists(fileName))
            {
                string cSearforSomething = t_SBox.Text;
                oReader = new StreamReader(fileName);
                string cColl = oReader.ReadToEnd();
                string cCriteria = @"\b" + cSearforSomething + @"\b";
                Regex oRegex = new Regex(cCriteria, RegexOptions.IgnoreCase);

                int count = oRegex.Matches(cColl).Count;
                l_R.Text = count.ToString();
            }
            else
            {
                throw new Exception();
            }
        }
    }
}
