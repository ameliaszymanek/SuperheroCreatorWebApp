using SuperheroCreatorWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperheroCreatorWebApp.Controllers
{
    public class SuperheroController : Controller
    {
        ApplicationDbContext context;
        public SuperheroController()
        {
            context = new ApplicationDbContext();
        }
        // GET: Superhero
        public ActionResult Index()
        {
            //TO DO: print a table only of the superheros names
            var listOfSuperheroes = context.Superheroes.ToList();
            return View(listOfSuperheroes);
        }

        // GET: Superhero/Details/5
        public ActionResult Details(int id)
        {
            return View(context.Superheroes.Where(i => i.Id == id).FirstOrDefault());
        }

        // GET: Superhero/Create
        public ActionResult Create()
        {
            Superhero superhero = new Superhero();
            return View(superhero);
        }

        // POST: Superhero/Create
        [HttpPost]
        public ActionResult Create(Superhero superhero)
        {
            try
            {
                // TODO: Add insert logic here
                context.Superheroes.Add(superhero);
                context.SaveChanges();
                return RedirectToAction("Index", "Superhero");
            }
            catch
            {
                return View();
            }
        }

        // GET: Superhero/Edit/5
        public ActionResult Edit(int id)
        {
            Superhero superhero = context.Superheroes.Where(i => i.Id == id).FirstOrDefault();
            return View(id);
        }

        // POST: Superhero/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Superhero superhero)
        {
            try
            {
                // TODO: Add update logic here
                Superhero superheroFromDb = context.Superheroes.Where(i => i.Id == id).FirstOrDefault();
                if (superhero.name != null)
                {
                    superheroFromDb.name = superhero.name;
                }
                else 
                {
                    superheroFromDb.name = superheroFromDb.name;
                }

                if (superhero.alterEgo != null)
                {
                    superheroFromDb.alterEgo = superhero.alterEgo;
                }
                else
                {
                    superheroFromDb.alterEgo = superheroFromDb.alterEgo;
                }

                if(superhero.primarySuperheroAbility != null)
                {
                    superheroFromDb.primarySuperheroAbility = superhero.primarySuperheroAbility;
                }
                else 
                {
                    superheroFromDb.primarySuperheroAbility = superheroFromDb.primarySuperheroAbility;
                }

                if(superhero.secondarySuperheroAbility != null)
                {
                    superheroFromDb.secondarySuperheroAbility = superhero.secondarySuperheroAbility;
                }
                else 
                {
                    superheroFromDb.secondarySuperheroAbility = superheroFromDb.secondarySuperheroAbility;
                }

                if(superheroFromDb.catchphrase != null)
                {
                    superheroFromDb.catchphrase = superhero.catchphrase;
                }
                else
                {
                    superheroFromDb.catchphrase = superheroFromDb.catchphrase;
                }

                return RedirectToAction("Index", "Superhero");
            }
            catch
            {
                return View();
            }
        }

        // GET: Superhero/Delete/5
        public ActionResult Delete(int id)
        {
            Superhero superhero = context.Superheroes.Where(i => i.Id == id).FirstOrDefault();
            return View(id);
        }

        // POST: Superhero/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Superhero superhero)
        {
            try
            {
                // TODO: Add delete logic here
                superhero = context.Superheroes.Where(i => i.Id == id).FirstOrDefault();
                context.Superheroes.Remove(superhero);
                context.SaveChanges();


                return RedirectToAction("Index", "Superhero");
            }
            catch
            {
                return View();
            }
        }
    }
}
