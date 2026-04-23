using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Threading.Tasks;


namespace StudentManagementSystem
{

    public partial class Form1 : Form
    {
        public class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
        }
        List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();
            RefreshGrid();
        }
        private void RefreshGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = students;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            Student s = new Student()
            {
                Id = int.Parse(txtId.Text),
                Name = txtName.Text,
                Age = int.Parse(txtAge.Text)
            };

            students.Add(s);
            RefreshGrid();

            txtId.Clear();
            txtName.Clear();
            txtAge.Clear();
        
    }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);

            var student = students.FirstOrDefault(s => s.Id == id);

            if (student != null)
            {
                students.Remove(student);
                MessageBox.Show("Deleted");
            }
            else
            {
                MessageBox.Show("Not Found");
            }

            RefreshGrid();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);

            var student = students.FirstOrDefault(s => s.Id == id);

            if (student != null)
            {
                MessageBox.Show($"Name: {student.Name}, Age: {student.Age}");
            }
            else
            {
                MessageBox.Show("Not Found");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
