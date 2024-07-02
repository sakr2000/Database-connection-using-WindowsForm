using Microsoft.Data.SqlClient;
using System.Data;

namespace DB_with_WF
{
    public partial class Form1 : Form
    {

        SqlConnection con;
        List<int> courseIds;
        public Form1()
        {
            InitializeComponent();

            string ConnectionString = "Server=DESKTOP-CSVHKNO;Database=ITI;Trusted_Connection=True;TrustServerCertificate=True;";
            con = new SqlConnection(ConnectionString);

            courseIds = new List<int>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          courseIds =  DisplayData();
            GetTopics();
        }


        private List<int> DisplayData()
        {
            List<Course> courses = new List<Course>();
            List<int> courseIds = new List<int>();

            SqlCommand cmd = new SqlCommand("SELECT[Crs_Id],[Crs_Name],[Crs_Duration],c.[Top_Id],t.[Top_Name] FROM Course c , Topic t where c.Top_Id = t.Top_Id", con);

            try
            {
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    courses.Add(new Course((int)sdr["Crs_Id"], (string)sdr["Crs_Name"], (int)sdr["Crs_Duration"], (int)sdr["Top_Id"], (string)sdr["Top_Name"]));
                    courseIds.Add((int)sdr["Crs_Id"]);
                }

            }
            catch (Exception ex) { Console.WriteLine(ex); }
            finally
            {
                con.Close();
            }

            dgv_courses.DataSource = courses;

            dgv_courses.Columns[0].HeaderText = "ID";
            dgv_courses.Columns[1].HeaderText = "Name";
            dgv_courses.Columns[2].HeaderText = "Duration";
            dgv_courses.Columns[3].HeaderText = "Topic ID";
            dgv_courses.Columns[4].HeaderText = "Topic Name";
            dgv_courses.Columns["Top_Id"].Visible = false;

            return courseIds;

        }

        private bool ValidInputs()
        {
            if (txt_Crs_Id.Value == 0)
            {
                MessageBox.Show("Crs_Id can't be zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txt_Crs_Name.Text == "")
            {
                MessageBox.Show("Crs_Name can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txt_Crs_Duration.Value == 0)
            {
                MessageBox.Show("Crs_Duration can't be zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (cb_Top_Id.SelectedIndex == -1)
            {
                MessageBox.Show("Topic can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;

        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == "Delete" )
            {
                ExecuteQuery($"DELETE FROM Course WHERE Crs_Id = {txt_Crs_Id.Value}");
            }
            if (button.Text != "Delete" && ValidInputs())
            {
                if (button.Text == "Add")
                {
                    ExecuteQuery($"INSERT INTO Course (Crs_Id,Crs_Name,Crs_Duration,Top_Id) VALUES({txt_Crs_Id.Value},'{txt_Crs_Name.Text}', {txt_Crs_Duration.Value},{cb_Top_Id.SelectedValue})");
                }
                else if (button.Text == "Update")
                {
                    ExecuteQuery($"UPDATE Course SET Crs_Name = '{txt_Crs_Name.Text}',Crs_Duration = {txt_Crs_Duration.Value},Top_Id = {cb_Top_Id.SelectedValue} WHERE Crs_Id = {txt_Crs_Id.Value}");

                }
            }
        }

        private void GetTopics()
        {
            SqlCommand sql = new SqlCommand("SELECT [Top_Id],[Top_Name] FROM Topic", con);
            DataTable DT = new DataTable();
            try
            {
                con.Open();
                SqlDataReader sdr = sql.ExecuteReader();

                DT.Load(sdr);
            }
            catch (Exception ex) { Console.WriteLine(ex); }
            finally
            {
                con.Close();
            }

            cb_Top_Id.DataSource = DT;
            cb_Top_Id.DisplayMember = "Top_Name";
            cb_Top_Id.ValueMember = "Top_Id";


        }
        private void ExecuteQuery(string Query)
        {

            SqlCommand cmd = new SqlCommand(Query, con);
            try
            {
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Successful Operation", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Unsuccessful Operation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex) { Console.WriteLine(ex); }
            finally
            {
                con.Close();
            }

            courseIds = DisplayData();
            clearInputs();

        }

        private void txt_Crs_Id_KeyUp(object sender, KeyEventArgs e)
        {
            if (courseIds.Contains((int)txt_Crs_Id.Value))
            {
                btn_add.Enabled = false;
                btn_update.Enabled = true;
                btn_delete.Enabled = true;
                ShowData((int)txt_Crs_Id.Value);
            }
            else
            {
                btn_add.Enabled = true;
                btn_update.Enabled = false;
                btn_delete.Enabled = false;
                
                txt_Crs_Duration.Value = 0;
                txt_Crs_Name.Text = "";
                cb_Top_Id.SelectedIndex = -1;
            }
        }

        private void ShowData(int id)
        {
            SqlCommand cmd = new SqlCommand($"SELECT * FROM Course WHERE Crs_Id = {id}", con);
            try
            {
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    txt_Crs_Id.Value = (int)sdr["Crs_Id"];
                    txt_Crs_Name.Text = (string)sdr["Crs_Name"];
                    txt_Crs_Duration.Value = (int)sdr["Crs_Duration"];
                    cb_Top_Id.SelectedValue = (int)sdr["Top_Id"];
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
            finally
            {
                con.Close();
            }
        }
        private void clearInputs()
        {
            txt_Crs_Id.Value = 0;
            txt_Crs_Name.Text = "";
            txt_Crs_Duration.Value = 0;
            cb_Top_Id.SelectedIndex = -1;

            btn_add.Enabled = true;
            btn_update.Enabled = false;
            btn_delete.Enabled = false;
        }
        private void dgv_courses_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_Crs_Id.Value = (int)dgv_courses.SelectedRows[0].Cells[0].Value;
            txt_Crs_Name.Text = (string)dgv_courses.SelectedRows[0].Cells[1].Value;
            txt_Crs_Duration.Value = (int)dgv_courses.SelectedRows[0].Cells[2].Value;
            cb_Top_Id.SelectedValue = (int)dgv_courses.SelectedRows[0].Cells[3].Value;

            btn_add.Enabled = false;
            btn_update.Enabled = true;
            btn_delete.Enabled = true;
        }
    }
}
