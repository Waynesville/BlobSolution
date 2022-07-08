using Blog.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.DatabaseServices
{
    public class BlogPostService
    {
        public BlogPost Get(int id)
        {
            BlogPost blogPost = new BlogPost();

            return new BlogPost();
        }

        public List<BlogPost> GetAll()
        {
            List<BlogPost> blogPosts = new List<BlogPost>();

            //string connectionString = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(@"Data Source=SQ-WPM-KHV\SQLEXPRESS;Initial Catalog=Blog;persist security info=True;Integrated Security=SSPI;"))
            {
                using (SqlCommand cmd = new SqlCommand("spBlogPost_GetAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            blogPosts.Add(new BlogPost
                            {
                                id = Convert.ToInt32(sdr["Id"]),
                                title = sdr["Title"].ToString(),
                                contents = sdr["Contents"].ToString(),
                                timestamp = Convert.ToDateTime(sdr["TimeStamp"].ToString()),
                                categoryId = Convert.ToInt32(sdr["CategoryId"])
                            });
                        }
                    }
                    conn.Close();
                    return blogPosts;
                }
            }

        }
    }
}
