using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Data.SqlClient;
using System.Data;
namespace BatchMithilesh11AMWE.Models
{
    public class FileUpload
    {
        private readonly IConfiguration _config;
        public string EmpName { get; set; }

        public string EmpImg { get; set; }

        [NotMapped]
        public IFormFile EmpimgFile { get; set; }

        public FileUpload()
        {
            
        }
        public FileUpload(IConfiguration config)
        {
            _config = config;
        }
        public List<FileUpload> GetEmployeesWithImage()
        {
            List<FileUpload> empList = new List<FileUpload>();
            string dbConn = _config.GetConnectionString("DBCS").ToString();
            SqlConnection con = new SqlConnection(dbConn);
            if(con.State==ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "select * from tbl_upload";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                FileUpload fp = new FileUpload();
                fp.EmpName = dr["empname"].ToString();
                fp.EmpImg = dr["empimg"].ToString();
                empList.Add(fp);
            }
            con.Close();
            return empList;
        }
        public bool addEmployee(FileUpload file)
        {
           string filename=UploadedFile(file);
           string dbConn = _config.GetConnectionString("DBCS").ToString();
           SqlConnection con = new SqlConnection(dbConn);
            string sql = "insert into tbl_upload(empname,empimg)values(@name,@img)";
            SqlCommand cmd = new SqlCommand(sql, con);
            if(con.State==ConnectionState.Closed)
            {
                con.Open();
            }

            cmd.Parameters.AddWithValue("@name", file.EmpName);
            cmd.Parameters.AddWithValue("@img", filename);
            int n=cmd.ExecuteNonQuery();
            con.Close();
            if (n!=0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private string UploadedFile(FileUpload fileup)
        {
            //save image file into folder
            string uniqueFileName = null;
            if (fileup.EmpimgFile != null)
            {
                string uploadsFolder = Path.GetFullPath("wwwroot") + "\\emp_image";
                uniqueFileName = Guid.NewGuid().ToString() + "_" + fileup.EmpimgFile.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var FileStream = new FileStream(filePath, FileMode.Create))
                {
                    fileup.EmpimgFile.CopyTo(FileStream);
                }
            }
            return uniqueFileName;
        }
    }
}
