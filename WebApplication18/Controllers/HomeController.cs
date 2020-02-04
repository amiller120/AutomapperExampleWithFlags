using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication18.Data;
using WebApplication18.DoesNotFitElseWhere;
using WebApplication18.Models;

namespace WebApplication18.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IMapper _mapper;

        private DataContext _dbContext { get; }

        public HomeController(ILogger<HomeController> logger, IMapper mapper, DataContext dataContext)
        {
            _dbContext = dataContext;
            _logger = logger;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            // Be careful when using any extractor... Safety first            
            var person = NoNamePersonExtractor.CreatePerson();
            
            var persistenceObject = _mapper.Map<Domain.Models.Person, Persistence.Models.Person>(person);
            
            _dbContext.Person.Add(persistenceObject);
            _dbContext.SaveChanges();

            var domainPerson = _mapper.Map<Domain.Models.Person>(persistenceObject);
            return View("Index", domainPerson);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
