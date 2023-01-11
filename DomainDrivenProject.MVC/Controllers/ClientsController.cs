using AutoMapper;
using DomainDrivenProject.Application.Interface;
using DomainDrivenProject.Domain.Entities;
using DomainDrivenProject.MVC.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace DomainDrivenProject.MVC.Controllers
{
    public class ClientsController : Controller
    {
        private readonly IClientAppService _clientApp;

        public ClientsController(IClientAppService clientService)
        {
            _clientApp = clientService;
        }

        // GET: Clients
        public ActionResult Index()
        {
            var clientViewModel = Mapper.Map<IEnumerable<Client>, IEnumerable<ClientViewModel>>(_clientApp.GetAll());
            return View(clientViewModel);
        }

        public ActionResult Specials()
        {
            var clientViewModel = Mapper.Map<IEnumerable<Client>, IEnumerable<ClientViewModel>>(_clientApp.GetSpecialClients());
            return View(clientViewModel);
        }

        // GET: Clients/Details/5
        public ActionResult Details(int id)
        {
            var clientViewModel = Mapper.Map<Client, ClientViewModel>(_clientApp.GetById(id));
            return View(clientViewModel);
        }

        // GET: Clients/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clients/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClientViewModel clientViewModel)
        {
            if (ModelState.IsValid)
            {
                var client = Mapper.Map<ClientViewModel, Client>(clientViewModel);
                _clientApp.Add(client);

                return RedirectToAction("Index");
            }

            return View(clientViewModel);
        }

        // GET: Clients/Edit/5
        public ActionResult Edit(int id)
        {
            var client = _clientApp.GetById(id);
            var clientViewModel = Mapper.Map<Client, ClientViewModel>(client);

            return View(clientViewModel);
        }

        // POST: Clients/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ClientViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var client = Mapper.Map<ClientViewModel, Client>(viewModel);
                _clientApp.Update(client);

                return RedirectToAction("Index");
            }

            return View(viewModel);
        }

        // GET: Clients/Delete/5
        public ActionResult Delete(int id)
        {
            var client = _clientApp.GetById(id);
            var clientViewModel = Mapper.Map<Client, ClientViewModel>(client);

            return View(clientViewModel);
        }

        // POST: Clients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var client = _clientApp.GetById(id);
            _clientApp.Delete(client);

            return RedirectToAction("Index");
        }
    }
}
