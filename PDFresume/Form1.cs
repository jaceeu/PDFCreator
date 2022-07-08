using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }
    }
}
