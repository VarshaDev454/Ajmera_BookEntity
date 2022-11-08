//using Assessment.Logging.Interface;
//using Assessment.ViewModel;
//using AutoMapper;
//using BusinessAccessLayer.Interface;
//using DataAccessLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Assessment.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        public BookController()
        {
            
        }

        [HttpGet("GetBooks")]
        public ActionResult<string> GetBooks()
        {
            return "Book";
        }        
    }
}
