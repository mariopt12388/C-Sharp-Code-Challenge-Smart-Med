using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SmartMedCodeChallenge1.Controllers
{
    public class ValuesController : ApiController
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-5UQPQ9O; database=medications; Integrated Security=true;");
        // GET api/values
        public string Get()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM medications.medication", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                return JsonConvert.SerializeObject(dt);
            }
            else
            {
                return "No data found";
            }
        }

        // GET api/values/5
        public string Get(int id)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM medications.medication WHERE id = '" + id + "' ", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return JsonConvert.SerializeObject(dt);
            }
            else
            {
                return "No data found";
            }
        }

        // POST api/values
        public string Post([FromBody] string name, [FromBody] int quantity, [FromBody] string creationDate)
        {
            SqlCommand cmd = new SqlCommand("Insert into medications.medication(Name, Quantity, CreationDate) VALUES('" + name + "', '" + quantity + "', '" + creationDate + "'");
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if(i == 1)
            {
                return "Record inserted with the name as " + name + ", the quantity as " + quantity + " and the creation date as " + creationDate;

            }
            else
            {
                return "Try again. No data inserted";
            }
        }

        // PUT api/values/5
        public string Put(int id, [FromBody] string name, [FromBody] int quantity, [FromBody] string creationDate)
        {
            SqlCommand cmd = new SqlCommand("UPDATE medications.medication SET name = '" + name + "', quantity = '" + quantity + "', creationDate = '" + creationDate + "' WHERE id = '" + id + "' ");
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i == 1)
            {
                return "Record updated with the name as " + name + ", the quantity as " + quantity + " and the creation date as " + creationDate + " and the id as " + id;

            }
            else
            {
                return "Try again. No data updated";
            }
        }

        // DELETE api/values/5
        public string Delete(int id)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM medications.medication WHERE id = '" + id + "' ");
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i == 1)
            {
                return "Record deleted with the  id as " + id;

            }
            else
            {
                return "Try again. No data deleted";
            }
        }
    }
}
