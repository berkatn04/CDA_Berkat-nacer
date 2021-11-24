using AutoMapper;
using GestionEmploye.Data.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionEmploye.Controllers
{
    [Route("api/Employe")]
    [ApiController]

    public class ControllerEmploye : ControllerBase
    {
        private readonly ServiceEmploye _service;
        private readonly IMapper _mapper;
    }
}
