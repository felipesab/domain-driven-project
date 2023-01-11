using AutoMapper;
using DomainDrivenProject.Application.Interface;
using DomainDrivenProject.Domain.Entities;
using DomainDrivenProject.MVC.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace DomainDrivenProject.MVC.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductAppService _productApp;
        private readonly IClientAppService _clientApp;

        public ProductsController(IProductAppService productApp, IClientAppService clientApp)
        {
            _productApp = productApp;
            _clientApp = clientApp;
        }

        // GET: Products
        public ActionResult Index()
        {
            var productViewModel = Mapper.Map<IEnumerable<Product>, IEnumerable<ProductViewModel>>(_productApp.GetAll());
            return View(productViewModel);
        }

        public ActionResult Details(int id)
        {
            var productViewModel = Mapper.Map<Product, ProductViewModel>(_productApp.GetById(id));
            return View(productViewModel);
        }

        public ActionResult Create()
        {
            ViewBag.ClientId = new SelectList(_clientApp.GetAll(), "Id", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductViewModel productViewModel)
        {
            if (ModelState.IsValid)
            {
                var product = Mapper.Map<ProductViewModel, Product>(productViewModel);
                _productApp.Add(product);

                return RedirectToAction("Index");
            }

            ViewBag.ClientId = new SelectList(_clientApp.GetAll(), "Id", "Nome", productViewModel.ClientId);
            return View(productViewModel);
        }

        public ActionResult Edit(int id)
        {
            var productViewModel = Mapper.Map<Product, ProductViewModel>(_productApp.GetById(id));
            ViewBag.ClientId = new SelectList(_clientApp.GetAll(), "Id", "Nome", productViewModel.ClientId);

            return View(productViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProductViewModel productViewModel)
        {
            if (ModelState.IsValid)
            {
                var product = Mapper.Map<ProductViewModel, Product>(productViewModel);
                _productApp.Update(product);

                return RedirectToAction("Index");
            }

            ViewBag.ClientId = new SelectList(_clientApp.GetAll(), "Id", "Nome", productViewModel.ClientId);
            return View(productViewModel);
        }

        public ActionResult Delete(int id) 
        {
            var clientViewModel = Mapper.Map<Product, ProductViewModel>(_productApp.GetById(id));
            return View(clientViewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            var product = _productApp.GetById(id);
            _productApp.Delete(product);

            return RedirectToAction("Index");
        }
    }
}