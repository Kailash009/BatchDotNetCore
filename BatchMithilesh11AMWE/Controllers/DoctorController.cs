using BatchMithilesh11AMWE.Dtos;
using BatchMithilesh11AMWE.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BatchMithilesh11AMWE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        [HttpPost]
        public Doctor GetDoctorDetails(DoctorDto doctorDto)
        {
            Doctor doctor = new Doctor
            {
                Id = doctorDto.Id,
                FirstName = doctorDto.FirstName,
                LastName = doctorDto.LastName,
                DepartmentName = doctorDto.DepartmentName
            };
            return doctor;
        }
    }
}
