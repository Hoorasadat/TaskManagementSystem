﻿using Microsoft.AspNetCore.Mvc;
using TaskManagementSystem.BLL.Interfaces;
using TaskManagementSystem.Lib.Models;

namespace TaskManagementSystem.WEB.Controllers
{
    public class PersonController : Controller
    {
        private readonly IPersonRepository _personRepository;

        public PersonController(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }



        // GET: /person/index
        public async Task<ViewResult> Index()
        {
            IList<Person> persons = await _personRepository.GetAllPersons();

            return View(persons);
        }



        // Get: /person/edit/id
        [HttpGet]
        public async Task<ViewResult> Edit(int id)
        {
            Person person = await _personRepository.GetPerson(id);

            return View(person);
        }



        // POST: /person/edit/person
        [HttpPost]
        public async Task<ViewResult> Edit(Person person)
        {
            Person updatedPerson = await _personRepository.UpdatePerson(person);

            return View(updatedPerson);
        }



        // Get: /person/detials/id
        public async Task<ViewResult> Details(int id)
        {
            Person person = await _personRepository.GetPerson(id);

            return View(person);
        }
    }
}

