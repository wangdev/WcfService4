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
                SqlParameter parameterId = new SqlParameter {
                    ParameterName = "@Id",
                    Value = emp.Id
                };
                cmd.Parameters.Add(parameterId);
                SqlParameter parameterName = new SqlParameter {
                    ParameterName = "@Name",
                    Value = emp.Name
                };
                cmd.Parameters.Add(parameterName);
                SqlParameter parameterGender = new SqlParameter {
                    ParameterName = "@Gender",
                    Value = emp.Gender
                };
                cmd.Parameters.Add(parameterGender);
                SqlParameter parameterDateOfBirth = new SqlParameter {
                    ParameterName = "@DateOfBirth",
                    Value = emp.DateOfBirth
                };
                cmd.Parameters.Add(parameterDateOfBirth);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}

