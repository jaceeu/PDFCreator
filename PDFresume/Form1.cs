using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace PDFresume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            Personal personal = new Personal()
            {
                ID = 101496372181,
                Name = "Jhan Carlo M. Vasquez",
                DateofBirth = DateTime.Now,
                Address = "Rodriguez Rizal"
            };

            string JsonOutput = JsonConvert.SerializeObject(personal);
            txtBox1.Text = JsonOutput;
        }
    }
}
