using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsAvgPoints
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            using (var context = new DataBase())
            {

                List<Group> groups = context.Groups.ToList();
                foreach (Group g in groups) { comboBox1.Items.Add(g.Number); };
               

            }
            comboBox1.SelectedItem = comboBox1.Items[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            using (var context = new DataBase())
            {
                List<Group> groups = context.Groups.ToList();
                foreach (Group g in groups)
                {
                    if (g.Number == Convert.ToInt32(comboBox1.SelectedItem))
                    {
                        foreach (Student s in g.Students)
                        {
                            dataGridView1.Rows.Add(s.Name,s.Surname,s.Average());
                        }
                    };

                };

            }

        }
    }
}
