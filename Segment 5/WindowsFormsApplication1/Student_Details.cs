using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Windows;
using System.Data.SqlClient;


namespace WindowsFormsApplication1
{
    public partial class Student_Details : Form
    {
        private static string connStr = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.StudentDBConnectionString"].ConnectionString;
        public DataTable tablegrid;
        public Student_Details()
        {
            InitializeComponent();
            loadtable();

        }

        public void loadtable()
        {
            Dbconnection dbconnect = new Dbconnection();
            tablegrid = dbconnect.getAllStudents();
            if (tablegrid != null)
            {
                dataGridView1.DataSource = tablegrid.DefaultView;
            }

        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Student_Details_Load(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student_Registration reg = new Student_Registration(this);
            reg.Show();


        }


    

        private void button2_Click(object sender, EventArgs e)
        {
         
            SqlConnection conn = null;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                try
                {
                    string Name = row.Cells[1].Value.ToString();
                    string DOB = row.Cells[2].Value.ToString();
                    string GradePointAvg = row.Cells[3].Value.ToString();
                    string Active = row.Cells[4].Value.ToString();

                    if (Active.Equals("false"))
                    {
                        Dbconnection dbconnect = new Dbconnection();
                        dbconnect.Registration(Name, DOB, GradePointAvg, Active);
                        MessageBox.Show("inserted sussfully");
                      

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }
    }
}
