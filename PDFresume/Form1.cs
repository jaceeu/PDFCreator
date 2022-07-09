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
using System.IO;
using SautinSoft.Document;

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
                Contact = txtBox1.Text,
                Email = txtBox2.Text,
                Primary = txtBox3.Text,
                Secondary = txtBox6.Text,
                Tertiary = txtBox5.Text,
                Skills = txtBox4.Text,
                Name = txtBox7.Text,
            };

            string JsonOutput = JsonConvert.SerializeObject(personal);
            File.WriteAllText(@"C:\Users\Carlo\source\PDF.json",JsonOutput);
            JsonOutput = String.Empty;
            JsonOutput = File.ReadAllText(@"C:\Users\Carlo\source\PDF.json");
            Personal Personal = JsonConvert.DeserializeObject<Personal>(JsonOutput);
            

            string docPath = @"C:\Users\Carlo\source.pdf";

            // Create a new document and DocumentBuilder.
            DocumentCore dc = new DocumentCore();
            DocumentBuilder db = new DocumentBuilder(dc);

            // Set page size A4.
            Section section = db.Document.Sections[0];
            section.PageSetup.PaperType = PaperType.A4;

            db.CharacterFormat.FontName = "Verdana";
            db.CharacterFormat.Size = 16;
            db.Writeln(Personal.Contact.ToString());
            db.InsertSpecialCharacter(SpecialCharacterType.LineBreak);

            db.CharacterFormat.FontName = "Verdana";
            db.CharacterFormat.Size = 16;
            db.Writeln(Personal.Email.ToString());
            db.InsertSpecialCharacter(SpecialCharacterType.LineBreak);

            db.CharacterFormat.FontName = "Verdana";
            db.CharacterFormat.Size = 16;
            db.Writeln(Personal.Primary.ToString());
            db.InsertSpecialCharacter(SpecialCharacterType.LineBreak);

            db.CharacterFormat.FontName = "Verdana";
            db.CharacterFormat.Size = 16;
            db.Writeln(Personal.Secondary.ToString());
            db.InsertSpecialCharacter(SpecialCharacterType.LineBreak);

            db.CharacterFormat.FontName = "Verdana";
            db.CharacterFormat.Size = 16;
            db.Writeln(Personal.Tertiary.ToString());
            db.InsertSpecialCharacter(SpecialCharacterType.LineBreak);

            db.CharacterFormat.FontName = "Verdana";
            db.CharacterFormat.Size = 16;
            db.Writeln(Personal.Skills.ToString());
            db.InsertSpecialCharacter(SpecialCharacterType.LineBreak);
            dc.Save(docPath, new PdfSaveOptions());
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(docPath) { UseShellExecute = true });
        }
    }
}
