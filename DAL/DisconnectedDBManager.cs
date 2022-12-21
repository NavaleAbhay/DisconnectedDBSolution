using HR;
using MySql.Data.MySqlClient;
using System.Data;
namespace DAL;
public class DisconnectedDBManager
{
    private static string connectionString = string.Empty;
    static DisconnectedDBManager()
    {
        connectionString = "server=localhost;port=3306;user=root;password=password;database=transflower";
    }

    public static List<Department> GetAllDepartments()
    {
        List<Department> departments = new List<Department>();
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = connectionString;
        MySqlCommand command = new MySqlCommand();
        command.CommandText = "SELECT * FROM departments";
        command.Connection = con;
        MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
        DataSet dataSet = new DataSet();
        try
        {
            dataAdapter.Fill(dataSet);
            DataTable dataTable = dataSet.Tables[0];
            foreach (DataRow dataRow in dataTable.Rows)
            {
                int id = int.Parse(dataRow["id"].ToString());
                string name = dataRow["name"].ToString();
                string location = dataRow["location"].ToString();

                Department dept = new Department()
                {
                    Id = id,
                    Name = name,
                    Location = location,
                };
                departments.Add(dept);
            }

        }
        catch (Exception e)
        {
            throw e;
        }
        return departments;
    }


    public static Department GetDepartmentById(int id)
    {
        Department department = null;

        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = connectionString;

        MySqlCommand command = new MySqlCommand();
        command.CommandText = "select * from departments where id=" + id;
        command.Connection = con;

        MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
        DataSet dataSet = new DataSet();

        try
        {

            dataAdapter.Fill(dataSet);
            DataTable table = dataSet.Tables[0];

            DataColumn[] keyColumns = new DataColumn[1];
            keyColumns[0] = table.Columns["id"];
            table.PrimaryKey = keyColumns;


            //  DataRow dataRow = dataSet.Tables[0].Rows.Find(id);
            DataRow dataRow = table.Rows.Find(id);


            id = int.Parse(dataRow["id"].ToString());
            string name = dataRow["name"].ToString();
            string location = dataRow["location"].ToString();

            department = new Department
            {
                Id = id,
                Name = name,
                Location = location
            };
        }
        catch (Exception e)
        {
           throw e;
        }

        return department;
    }

    public static bool InsertDepartment(Department dept)
    {
        bool status = false;

        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = connectionString;

        MySqlCommand command = new MySqlCommand();
        command.CommandText = "SELECT * FROM departments";
        command.Connection = con;

        MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
        DataSet dataSet = new DataSet();
        try
        {
            dataAdapter.Fill(dataSet);
            DataTable dataTable = dataSet.Tables[0];
            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(dataAdapter);
            Console.WriteLine(commandBuilder.GetDeleteCommand().ToString());

            // MySqlCommand deletecommand =commandBuilder.GetDeleteCommand();
            // string strDeleteCommand =deletecommand.CommandText;

            DataRow row = dataTable.NewRow();
            row["id"] = dept.Id;
            row["name"] = dept.Name;
            row["location"] = dept.Location;
            dataTable.Rows.Add(row);
            dataAdapter.Update(dataSet);
            status = true;
        }
        catch (Exception e)
        {
            throw e;
        }
        return status;
    }


    public static bool UpdateDepartment(Department dept)
    {
        bool status = false;
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = connectionString;
        MySqlCommand command = new MySqlCommand();
        command.CommandText = "SELECT * FROM departments";
        command.Connection = con;
        MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
        DataSet dataSet = new DataSet();
        try
        {
            MySqlCommandBuilder commandBuilder=new MySqlCommandBuilder(dataAdapter);
            dataAdapter.Fill(dataSet);
            DataTable table = dataSet.Tables[0];
            DataColumn[] keyColumn = new DataColumn[1];
            keyColumn[0] = table.Columns["id"];
            table.PrimaryKey = keyColumn;
            DataRow row=table.Rows.Find(dept.Id);
            row["name"]=dept.Name;
            row["location"]=dept.Location;

        dataAdapter.Update(dataSet);
        status=true;
            
        }
        catch (Exception e)
        {
            throw e;
        }
        return status;

    }


   public static bool  DeleteDepartment(int id)
   {
    bool status=true;
    MySqlConnection con=new MySqlConnection();
    con.ConnectionString=connectionString;

    MySqlCommand command= new MySqlCommand();
    command.CommandText="select * from departments";
    command.Connection=con;

    MySqlDataAdapter dataAdapter =new MySqlDataAdapter(command);
    DataSet dataSet=new DataSet();

    try{
        MySqlCommandBuilder commandBuilder=new MySqlCommandBuilder(dataAdapter);

        dataAdapter.Fill(dataSet);
        DataTable table=dataSet.Tables[0];
        DataColumn[] keycolumn= new DataColumn[1];
        keycolumn[0]=table.Columns["id"];
        table.PrimaryKey=keycolumn;

        DataRow row=table.Rows.Find(id);
        row.Delete();

        dataAdapter.Update(dataSet);
        status=true;


    }catch(Exception e)
    {
        throw e;
    }


    return status;
   }


}







