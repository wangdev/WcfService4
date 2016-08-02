using EmployeeWcfService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeServiceClient {
    public partial class WebForm1 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void btnGetEmployee_Click(object sender, EventArgs e) {
            using (ChannelFactory<IEmployeeService> cf = new ChannelFactory<IEmployeeService>("employeeservice")) {
                IEmployeeService proxy = cf.CreateChannel();
                Employee emp = proxy.GetEmployee(Convert.ToInt32(tbxId.Text));
                
                tbxName.Text = emp.Name;
                tbxGender.Text = emp.Gender;
                tbxDateOfBirth.Text = emp.DateOfBirth.ToString();
                lblStatus.Text = "Retrieved successfully";
            }
        }

        protected void btnSaveEmployee_Click(object sender, EventArgs e) {
            using (ChannelFactory<IEmployeeService> cf = new ChannelFactory<IEmployeeService>("employeeservice")) {
                IEmployeeService proxy = cf.CreateChannel();
                Employee emp = new Employee();
                emp.Id = Convert.ToInt32(tbxId.Text);
                emp.Name = tbxName.Text;
                emp.Gender = tbxGender.Text;
                emp.DateOfBirth = Convert.ToDateTime(tbxDateOfBirth.Text); 
                proxy.SaveEmployee(emp);
                lblStatus.Text = "Saved successfully";
            }
        }
    }
}