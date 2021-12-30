using protonApp.Logic;
using protonApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace protonApp.GUI
{
    public partial class RankingForm : Form
    {
        DatabaseDownloader dw = new DatabaseDownloader();
        public RankingForm()
        {
            InitializeComponent();
            RefreshLists();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshLists();
        }
        private void RefreshLists()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            CreateRank();
        }

        private void CreateRank()
        {
            List <Log> logs =dw.GetLogs();
            List <PointedStudent> students = new List<PointedStudent>();
            List <PointedClass> classes = new List<PointedClass>();
            foreach (Student student in dw.GetStudents())
            {
                if ((string)comboBox1.SelectedItem == "Chłopcy")
                {
                    PointedStudent pstudent = new PointedStudent(student.id, student.name, student.surname, student.class_id, student.sex, 0);
                    if(pstudent.sex ==1)students.Add(pstudent);
                }
                else if ((string)comboBox1.SelectedItem == "Dziewczyny")
                {
                    PointedStudent pstudent = new PointedStudent(student.id, student.name, student.surname, student.class_id, student.sex, 0);
                    if (pstudent.sex == 0) students.Add(pstudent);
                }
                else
                {
                    PointedStudent pstudent = new PointedStudent(student.id, student.name, student.surname, student.class_id, student.sex, 0);
                    students.Add(pstudent);
                }

            }
            foreach(Class klasa in dw.GetClasses())
            {
                PointedClass pclass = new PointedClass(klasa.id, klasa.name, 0);
                classes.Add(pclass);
            }
            foreach(Log log in logs)
            {
                foreach (PointedStudent ps in students)
                    if (ps.id == log.student_id)
                    {
                        ps.points += log.points;
                        if (log.transitive_points == 1)
                        {
                            foreach (PointedClass pc in classes)
                            {
                                if (pc.id == ps.class_id) pc.points += log.points;
                            }
                        }
                    }
            }
            List<PointedStudent> sortedStudents = students.OrderBy(o => -(o.points)).ToList();
            List<PointedClass> sortedClasses = classes.OrderBy(o => -(o.points)).ToList();
            for(int i=0; i<numericUpDown1.Value;i++)
            {
                if(i<sortedStudents.Count())listBox1.Items.Add((i+1)+". "+sortedStudents[i].name+" "+ sortedStudents[i].surname+" "+dw.GetClassById(sortedStudents[i].class_id).name+" "+ sortedStudents[i].points + "pkt");
            }
            for(int i=0; i<classes.Count();i++)
            {
                listBox2.Items.Add((i+1) + "." + sortedClasses[i].name + " " + sortedClasses[i].points+"pkt");
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "pdf files (*.pdf)|*.pdf";
            sfd.RestoreDirectory = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                PdfSharp.Pdf.PdfDocument doc = new PdfSharp.Pdf.PdfDocument();
                comboBox1.SelectedItem = "Obie";
                RefreshLists();
                generatePdf("Ranking Ogólny", doc, toList(listBox1),sfd,160);
                comboBox1.SelectedItem = "Chłopcy";
                RefreshLists();
                generatePdf("Ranking Męski", doc, toList(listBox1),sfd,170);
                comboBox1.SelectedItem = "Dziewczyny";
                RefreshLists();
                generatePdf("Ranking Żeński", doc, toList(listBox1),sfd,160);
                comboBox1.SelectedItem = "Obie";
                RefreshLists();
                generatePdf("Ranking Klas", doc, toList(listBox2),sfd,180);
                
            }
        }
        private List<string> toList(ListBox lb)
        {

            List<string> lista = new List<string>();
            foreach(var item in lb.Items)
            {
                lista.Add(item.ToString());
            }
            return lista;
        }
        private void generatePdf(string text, PdfSharp.Pdf.PdfDocument doc,List<string> list,SaveFileDialog sfd,int x)
        {
            string filePath = null;

                filePath = sfd.FileName;
                PdfSharp.Pdf.PdfPage pg = doc.AddPage();
                PdfSharp.Drawing.XGraphics gfx = PdfSharp.Drawing.XGraphics.FromPdfPage(pg);
                gfx.DrawString(text, new PdfSharp.Drawing.XFont("Arial", 35, PdfSharp.Drawing.XFontStyle.Bold), PdfSharp.Drawing.XBrushes.Red, new PdfSharp.Drawing.XPoint(x, 70));
                gfx.DrawLine(new PdfSharp.Drawing.XPen(PdfSharp.Drawing.XColor.FromArgb(94, 0, 0)), new PdfSharp.Drawing.XPoint(100, 100), new PdfSharp.Drawing.XPoint(500, 100));
                int n = 0;
                foreach(string student in list)
                {
                    n++;
                    gfx.DrawString(student, new PdfSharp.Drawing.XFont("Arial", 15), PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XPoint(100, 150+n*30));
                }
                doc.Save(filePath);
            

        }
    }
}
