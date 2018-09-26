using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace KPZ
{
    public partial class Form1 : Form
    {
        static List<Person> person = new List<Person>();
        static List<Project> project = new List<Project>();
        public Form1()
        {

            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = t5.Text;
            string task = t6.Text;
            string state = t7.Text;
            TextBox[] textBoxes = { t5, t6, t7 };
            Label[] labels = { label9, label10, label11 };
            if (checker(textBoxes, labels))
            {
                project.Insert(0, new Project(name, task, state));
                dataGridView3.Rows.Add();
                for (int i = 0; i < project.Count; i++)
                {
                    dataGridView3[0, i].Value = project[i].name;
                    dataGridView3[1, i].Value = project[i].task;
                    dataGridView3[2, i].Value = project[i].state;
                }
                fillCombo();
            }

        }
        public void fillCombo()
        {
            comboBox1.Items.Clear();
            for (int i = 0; i < project.Count; i++)
            {
                comboBox1.Items.Add(project[i].name + "(" + project[i].task + ")");
            }
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string surname = textBox2.Text;
            string email = textBox3.Text;
            TextBox[] textBoxes = { textBox1, textBox2, textBox3 };
            Label[] labels = { l1, l2, l3 };
            if (checker(textBoxes, labels))
            {
                dataGridView2.Rows.Add();
                string project_selected = comboBox1.Text;
                person.Insert(0, new Person(name, surname, email));

                for (int i = 0; i < person.Count; i++)
                {
                    dataGridView2[0, i].Value = person[i].name;
                    dataGridView2[1, i].Value = person[i].surname;
                    dataGridView2[2, i].Value = person[i].email;
                }

                for (int i = 0; i < project.Count; i++)
                {
                    if (project[i].name + "(" + project[i].task + ")" == project_selected)
                    {
                        project[i].person.Add(person[0]);
                    }
                }
            }

        }


        private void tabPage3_Enter(object sender, EventArgs e)
        {
            int iter = 0;
            if (person.Count != 0) dataGridView1.RowCount = person.Count;

            for (int j = 0; j < project.Count; j++)
            {
                for (int i = 0; i < project[j].person.Count; i++)
                {
                    if (iter >= person.Count) return;
                    dataGridView1[0, iter].Value = project[j].name;
                    dataGridView1[1, iter].Value = project[j].task;
                    dataGridView1[2, iter].Value = project[j].state;
                    dataGridView1[3, iter].Value = project[j].person[i].email;

                    iter++;
                }
            }
        }

        public Boolean checker(TextBox[] tmas, Label[] lmas)
        {
            int _iter = 0;
            List<bool> empty = new List<bool>();
            foreach (TextBox i in tmas)
            {
                if (i.Text == "" || i.Text == String.Empty)
                {
                    lmas[_iter].Visible = true;
                    empty.Add(true);
                }
                else
                {
                    lmas[_iter].ForeColor = Color.Green;
                    lmas[_iter].Visible = true;
                    empty.Add(false);
                }
                _iter++;
            }
            if (empty.Contains(true))
            {
                return false;
            }
            else { return true; }
        }

        public void designDataGrid(DataGridView obj)
        {
            obj.BorderStyle = BorderStyle.None;
            //obj.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(130,255,50);
            obj.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            obj.DefaultCellStyle.ForeColor = Color.Black;
            obj.DefaultCellStyle.SelectionBackColor = Color.White;
            obj.DefaultCellStyle.SelectionForeColor = Color.Red;
            obj.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            obj.RowTemplate.Height = 30;

            obj.EnableHeadersVisualStyles = false;
            obj.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            obj.ColumnHeadersDefaultCellStyle.BackColor = Color.Green;
            obj.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            designDataGrid(dataGridView1);
            designDataGrid(dataGridView2);
            designDataGrid(dataGridView3);
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (person.Count != 0 && project.Count != 0)
            {
                XmlSerializer writer = new XmlSerializer(typeof(List<Project>));
                using (FileStream fs = new FileStream("project.xml", FileMode.OpenOrCreate))
                {
                    writer.Serialize(fs, project);
                }
                XmlSerializer personW = new XmlSerializer(typeof(List<Person>));
                using (FileStream fs = new FileStream("person.xml", FileMode.OpenOrCreate))
                {
                    personW.Serialize(fs, person);
                }
            }
        }

        private void открыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlSerializer reader = new XmlSerializer(typeof(List<Project>));
            using (FileStream fs = new FileStream("project.xml", FileMode.OpenOrCreate))
            {
                project = (List<Project>)reader.Deserialize(fs);
            }
            XmlSerializer personW = new XmlSerializer(typeof(List<Person>));
            using (FileStream fs = new FileStream("person.xml", FileMode.OpenOrCreate))
            {
                person = (List<Person>)personW.Deserialize(fs);
            }
            dataGridView3.RowCount = 0;
            dataGridView2.RowCount = 0;
            foreach (Project i in project)
            {
                dataGridView3.Rows.Add();
                int pos = dataGridView3.RowCount-1;
                dataGridView3[0, pos].Value = i.name;
                dataGridView3[1, pos].Value = i.task;
                dataGridView3[2, pos].Value = i.state;
            }

            foreach (Person i in person)
            {
                dataGridView2.Rows.Add();
                int pos = dataGridView2.RowCount - 1;
                dataGridView2[0, pos].Value = i.name;
                dataGridView2[1, pos].Value = i.surname;
                dataGridView2[2, pos].Value = i.email;
            }
            fillCombo();
        }
    }
}
