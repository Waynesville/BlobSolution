using Blog.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.DatabaseServices
{
    public class BlogCategoryService
    {
        public List<BlogCategory> GetAll()
        {
            List<BlogCategory> blogCategories = new List<BlogCategory>();

            //string connectionString = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(@"Data Source=SQ-WPM-KHV\SQLEXPRESS;Initial Catalog=Blog;persist security info=True;Integrated Security=SSPI;"))
            {
                using (SqlCommand cmd = new SqlCommand("spBlogCategory_GetAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            blogCategories.Add(new BlogCategory
                            {
                                id = Convert.ToInt32(sdr["Id"]),
                                name = sdr["Name"].ToString()
                            });
                        }
                    }
                    conn.Close();
                    return blogCategories;
                }
            }
        }

    }
}
