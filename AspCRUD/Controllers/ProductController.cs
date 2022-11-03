using AspCRUD.Data;
using AspCRUD.Models;
using AspCRUD.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AspCRUD.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductContext _context;
        public ProductController()
        {
            _context = new ProductContext();
        }
        // GET: Product
        public ActionResult Index()
        {
            var products = _context.Products.Include("Category").ToList();
            return View(products);
        }
        [HttpGet]
        public ActionResult Create()
        {
            var categories = _context.Categories.ToList();
            return View(categories);
        }
        [HttpPost]
        public async Task<ActionResult> Create(Product product)
        {
            if (product == null)
            {
                return HttpNotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Products.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(product);
        }
        public ActionResult Details(int? productId)
        {
            if (productId == 0 || productId == null)
            {
                return HttpNotFound();
            }

            var productFromDb = _context.Products.Include("Category").FirstOrDefault(c => c.Id == productId);

            if (productFromDb == null)
            {
                return HttpNotFound();
            }

            return View(productFromDb);
        }
        [HttpGet]
        public ActionResult Edit(int? productId)
        {
            if (productId == 0 || productId == null)
            {
                return HttpNotFound();
            }

            var productFromDb = _context.Products.Include("Category").FirstOrDefault(c => c.Id == productId);

            if (productFromDb == null)
            {
                return HttpNotFound();
            }

            VmProductEdit vm = new VmProductEdit
            {
                Categories = _context.Categories.ToList(),
                Product = productFromDb
            };

            return View(vm);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(Product product)
        {
            if (product == null)
            {
                return HttpNotFound();
            }

            if (ModelState.IsValid)
            {
                //var productFromDb = _context.Products.Include("Category").FirstOrDefault(c => c.Id == product.Id);
                //productFromDb.Name = product.Name;
                //productFromDb.Quantity = product.Quantity;

                _context.Entry(product).State = System.Data.Entity.EntityState.Modified;
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(product);
        }
        [HttpGet]
        public async Task<ActionResult> Delete(int? productId)
        {
            if (productId == 0 || productId == null)
            {
                return HttpNotFound();
            }

            var productFromDb = await _context.Products.FindAsync(productId);

            if (productFromDb == null)
            {
                return HttpNotFound();
            }

            _context.Products.Remove(productFromDb);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}