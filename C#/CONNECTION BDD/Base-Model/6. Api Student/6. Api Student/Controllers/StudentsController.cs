using _6._Api_Student.Data.Dtos;
using _6._Api_Student.Data.Models;
using _6._Api_Student.Data.Services;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _6._Api_Student.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : Controller
    {

        private readonly StudentsServices _service;
        private readonly IMapper _mapper;

        public StudentsController(StudentsServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/Students
        [HttpGet]
        public ActionResult<IEnumerable<StudentsDTOOut>> GetAllStudents()
        {
            IEnumerable<Student> listeStudents = _service.GetAllStudents();
            return Ok(_mapper.Map<IEnumerable<StudentsDTOOut>>(listeStudents));
        }

        //GET api/Students/{i}
        [HttpGet("{id}", Name = "GetStudentById")]
        public ActionResult<StudentsDTOOut> GetStudentById(int id)
        {
            Student commandItem = _service.GetStudentById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<StudentsDTOOut>(commandItem));
            }
            return NotFound();
        }

        //POST api/Students
        [HttpPost]
        public ActionResult<StudentsDTOIn> CreateStudent(StudentsDTOIn objIn)
        {
            Student obj = _mapper.Map<Student>(objIn);
            _service.AddStudent(obj);
            return CreatedAtRoute(nameof(GetStudentById), new { Id = obj.IdStudent }, obj);
        }

        //POST api/Students/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateStudent(int id, StudentsDTOIn obj)
        {
            Student objFromRepo = _service.GetStudentById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateStudent(objFromRepo);
            return NoContent();
        }

        // Exemple d'appel
        // [{
        // "op":"replace",
        // "path":"",
        // "value":""
        // }]
        //PATCH api/Students/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialStudentUpdate(int id, JsonPatchDocument<Student> patchDoc)
        {
            Student objFromRepo = _service.GetStudentById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            Student objToPatch = _mapper.Map<Student>(objFromRepo);
            patchDoc.ApplyTo(objToPatch, ModelState);
            if (!TryValidateModel(objToPatch))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(objToPatch, objFromRepo);
            _service.UpdateStudent(objFromRepo);
            return NoContent();
        }

        //DELETE api/Students/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteStudent(int id)
        {
            Student obj = _service.GetStudentById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteStudent(obj);
            return NoContent();
        }


    }
}
