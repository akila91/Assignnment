using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace WindowsFormsApplication1
{
    public partial class Student_Registration : Form
    {
        public static string stname = "";
        public static string Dob = "";
        public static string grap = "";
        public static string val = "";
        private Student_Details form1;
        private static string connStr = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.StudentDBConnectionString"].ConnectionString;
        public Student_Registration(Student_Details form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stname = textBox1.Text;
            Dob = dateTimePicker1.Text;
            grap = textBox2.Text;
            val = "";
            if (!checkBox1.Checked)
            {
                val = "false";
            }

          
            SqlConnection con = new SqlConnection(connStr);
            String str = "NextProcedure";
            SqlCommand com = new SqlCommand(str, con);
            com.CommandType = CommandType.StoredProcedure;
            con.Open();
            int count = Convert.ToInt16(com.ExecuteScalar());
            object[] row = new object[] {count,stname,Dob,grap, val };
     
           DataTable table = new DataTable();
           DataRow newRow = form1.tablegrid.NewRow();
         
           newRow.ItemArray = row;
          
           form1.tablegrid.Rows.Add(newRow);

           if (table != null)
           {
               form1.dataGridView1.DataSource = form1.tablegrid.DefaultView;
           }
          
     
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
