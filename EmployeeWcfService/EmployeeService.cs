using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace EmployeeWcfService {
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployeeService" in both code and config file together.
    public class EmployeeService : IEmployeeService {


        public Employee GetEmployee(int id) {
            Employee emp = new Employee();
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs)) {
                SqlCommand cmd = new SqlCommand("GetEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter parameterId = new SqlParameter();
                parameterId.ParameterName = "@Id";
                parameterId.Value = id;
                cmd.Parameters.Add(parameterId);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    emp.Id = Convert.ToInt32(reader["Id"]);
                    emp.Name = Convert.ToString(reader["Name"]);
                    emp.Gender = Convert.ToString(reader["Gender"]);
                    emp.DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);
                }
                return emp;
            }

        }

        public void SaveEmployee(Employee emp) {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs)) {
                SqlCommand cmd = new SqlCommand("SaveEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter[] sqlParameters = new SqlParameter[4];
                sqlParameters[0].ParameterName = "@Id";
                sqlParameters[1].ParameterName = "@Name";
                sqlParameters[2].ParameterName = "@Gender";
                sqlParameters[3].ParameterName = "@DateOfBirth";
                sqlParameters[0].Value = emp.Id;
                sqlParameters[1].Value = emp.Name;
                sqlParameters[2].Value = emp.Gender;
                sqlParameters[3].Value = emp.DateOfBirth;
                cmd.Parameters.Add(sqlParameters[0]);
                cmd.Parameters.Add(sqlParameters[1]);
                cmd.Parameters.Add(sqlParameters[2]);
                cmd.Parameters.Add(sqlParameters[3]);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}

