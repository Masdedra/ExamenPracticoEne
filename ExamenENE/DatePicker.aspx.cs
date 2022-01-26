using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExamenENE
{
    public partial class DatePicker : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }


        public void GetTables()
        {
            DateTime dateStart = Convert.ToDateTime(start.Value);
            DateTime dateEnd = Convert.ToDateTime(end.Value);
            if (dateStart> dateEnd)
            {
                string script = "alert(\"Fechas incorrectas\");";
                ScriptManager.RegisterStartupScript(this, GetType(),
                      "ServerControlScript", script, true);
                return;
            }
            using (SqlConnection cn = new SqlConnection(ExamenENE.Properties.Resources.Connection))
            {
                cn.Open();

                SqlCommand cmd = new SqlCommand("GetDataByDateExam", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@date1", SqlDbType.Date).Value = start.Value;
                cmd.Parameters.Add("@date2", SqlDbType.Date).Value = end.Value;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                table.DataSource = dt;
                table.DataBind();
            }
        }

        public void Btn_Click(Object sender, EventArgs e)
        {

            Button clickedButton = (Button)sender;

            GetTables();
        }
    }
}