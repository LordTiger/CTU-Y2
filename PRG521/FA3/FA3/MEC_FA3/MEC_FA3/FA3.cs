using System;
using System.Windows.Forms;
using System.Text;
using System.IO;

namespace MEC_FA3
{
    public partial class FA3 : Form
    {
        public FA3()
        {
            InitializeComponent();
        }

        private void b_Calc_Click(object sender, EventArgs e)
        {

            try
            {
                double TotalGas;

                if (Convert.ToDouble(t_GU.Text) != 0)
                {
                    TotalGas = Convert.ToDouble(t_Dr.Text) / Convert.ToDouble(t_GU.Text);

                    FileStream fs = new FileStream("MilesperGallon.txt", FileMode.Append, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.WriteLine("(" + DateTime.Today + ")\n" +
                        "Miles Driven: " + Convert.ToDouble(t_Dr.Text) + "\n" +
                        "Gallons of gas used: " + Convert.ToDouble(t_GU.Text) + "\n" +
                        "Efficiency (Miles/Gallon): " + TotalGas + "\n");
                    sw.Flush();
                    sw.Close();
                    fs.Close();

                    t_Fin.Text = Convert.ToString(TotalGas);

                } else
                {
                    FileStream fs = new FileStream("Exceptionfile.txt", FileMode.Append, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.WriteLine("(" + DateTime.Today + ")" + "Error Code #501 (Enter a value greater than 0)" + "\n");
                    sw.Flush();
                    sw.Close();
                    fs.Close();
                    MessageBox.Show("Error Code #501 (Enter a value greater than 0)");
                    e_prov.SetError(lbl_gused, "Please Enter a value > 0");
                }



            } catch (Exception ex)
            {
                FileStream fs = new FileStream("Exceptionfile.txt", FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine("(" + DateTime.Today + ")" + "Error: " + ex.Message + "\n");
                sw.Flush();
                sw.Close();
                fs.Close();
                MessageBox.Show("Error: " + ex.Message);
                e_prov.SetError(lbl_gused, "Please Enter a value > 0");

            } finally
            {
                MessageBox.Show("Files Saved");
            }
        }
    }
}
