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
    public class CoursesController : Controller
    {

        private readonly CoursesServices _service;
        private readonly IMapper _mapper;

        public CoursesController(CoursesServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/Courses
        [HttpGet]
        public ActionResult<IEnumerable<CoursesDTOOut>> GetAllCourses()
        {
            IEnumerable<Course> listeCourses = _service.GetAllCourses();
            return Ok(_mapper.Map<IEnumerable<CoursesDTOOut>>(listeCourses));
        }

        //GET api/Courses/{i}
        [HttpGet("{id}", Name = "GetCourseById")]
        public ActionResult<CoursesDTOOut> GetCourseById(int id)
        {
            Course commandItem = _service.GetCourseById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<CoursesDTOOut>(commandItem));
            }
            return NotFound();
        }

        //POST api/Courses
        [HttpPost]
        public ActionResult<CoursesDTOIn> CreateCourse(CoursesDTOIn objIn)
        {
            Course obj = _mapper.Map<Course>(objIn);
            _service.AddCourse(obj);
            return CreatedAtRoute(nameof(GetCourseById), new { Id = obj.IdCourse }, obj);
        }

        //POST api/Courses/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateCourse(int id, CoursesDTOIn obj)
        {
            Course objFromRepo = _service.GetCourseById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateCourse(objFromRepo);
            return NoContent();
        }

        // Exemple d'appel
        // [{
        // "op":"replace",
        // "path":"",
        // "value":""
        // }]
        //PATCH api/Courses/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialCourseUpdate(int id, JsonPatchDocument<Course> patchDoc)
        {
            Course objFromRepo = _service.GetCourseById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            Course objToPatch = _mapper.Map<Course>(objFromRepo);
            patchDoc.ApplyTo(objToPatch, ModelState);
            if (!TryValidateModel(objToPatch))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(objToPatch, objFromRepo);
            _service.UpdateCourse(objFromRepo);
            return NoContent();
        }

        //DELETE api/Courses/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteCourse(int id)
        {
            Course obj = _service.GetCourseById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteCourse(obj);
            return NoContent();
        }


    }
}
