using _5951071057_BuiVanManh.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _5951071057_BuiVanManh.Controllers
{
    public class StudentController : ApiController
    {
        // GET: api/Student
        public IEnumerable<StudentInfo> Get()
        {
            var studeninfo = new StudentInfo
            {
                Tentruong = "Dại học Giao thông vận tải phân hiệu Thành phố Hồ Chí Minh",
                Hoten = "Bùi Văn Mạnh",
                Mssv = "5951071057",
                Lop = "Công nghẹ thông tin k59"
            };
            yield return studeninfo;
        }

        // GET: api/Student/5
        public StudentInfo Get(string id)
        {
            return new StudentInfo
            {
                Tentruong = "Dại học Giao thông vận tải phân hiệu Thành phố Hồ Chí Minh",
                Hoten = "Bùi Văn Mạnh",
                Mssv = id,
                Lop = "Công nghẹ thông tin k59"

            };
        }

        // POST: api/Student
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Student/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Student/5
        public void Delete(int id)
        {
        }
    }
}
