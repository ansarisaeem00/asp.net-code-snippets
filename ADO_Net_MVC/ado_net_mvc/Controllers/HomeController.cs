using ADO_Net_MVC.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ADO_Net_MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(CustomerModel customer)
        {
            string constr = ConfigurationManager.ConnectionStrings["Constring"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                string query = "INSERT INTO Customers(Name, Country) VALUES(@Name, @Country)";
                query += " SELECT SCOPE_IDENTITY()";
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Connection = con;
                    con.Open();
                    cmd.Parameters.AddWithValue("@Name", customer.Name);
                    cmd.Parameters.AddWithValue("@Country", customer.Country);
                    customer.CustomerId = Convert.ToInt32(cmd.ExecuteScalar());
                    con.Close();
                }
            }

            return View(customer);
        }
    }
}