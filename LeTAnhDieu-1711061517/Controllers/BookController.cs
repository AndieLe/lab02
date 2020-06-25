using LeTAnhDieu_1711061517.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeTAnhDieu_1711061517.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public string HelooDear(string hutech)
        {
            return "heloo everyone" + hutech;
        }
        public ActionResult ListBook()
        {
            var books = new List<string>();
            books.Add("HTML5 & CSS3 the complete Manual - Author Name Book 1  ");
            books.Add("HTML5 & CSS Responsive web design cookbook - Author Name Book 2  ");
            books.Add("Professional ASP.NET MVC% - Author Name Book 2  ");
            ViewBag.Books = books;
            return View();
        }

        public ActionResult ListBookModel()
        {
            var books = new List<Book>();
            books.Add(new Book (1,"HTML5 & CSS3 the complete Manual"," Author Name Book 1 ",  "/Content/img/book.jpg"));
            books.Add(new Book (2,"HTML5 & CSS Responsive web design cookbook"," Author Name Book 2", "/Content/img/book2.jpg"));
            books.Add(new Book (3,"Professional ASP.NET MVC"," Author Name Book 3", "/Content/img/book3.jpg"));
            return View(books);
        }
        [HttpPost, ActionName("EditBook")]
        [ValidateAntiForgeryToken]
        public ActionResult EditBook(int id, string Title, string Author, string Imagecover  )
        {
            var books = new List<Book>();
            books.Add(new Book(1, "HTML5 & CSS3 the complete Manual", " Author Name Book 1 ", "/Content/img/book.jpg"));
            books.Add(new Book(2, "HTML5 & CSS Responsive web design cookbook", " Author Name Book 2", "/Content/img/book2.jpg"));
            books.Add(new Book(3, "Professional ASP.NET MVC", " Author Name Book 3", "/Content/img/book3.jpg"));
            if (id ==null)
            {
                return HttpNotFound();
            }
            foreach (Book b in books)
            {
                if (b.Id == id)
                {
                    b.Title = Title;
                    b.Author = Author;
                    b.Image_cover = Imagecover;
                    break;
                }
            }

            return View("ListBookModel",books);
        }
        [HttpPost,ActionName("CreateBook")]
        [ValidateAntiForgeryToken]
        public ActionResult Contact([Bind(Include= "Id, Title,Author,ImageCover")]Book book)
        {
            var books = new List<Book>();
            books.Add(new Book(1, "HTML5 & CSS3 the complete Manual", " Author Name Book 1 ", "/Content/img/book.jpg"));
            books.Add(new Book(2, "HTML5 & CSS Responsive web design cookbook", " Author Name Book 2", "/Content/img/book2.jpg"));
            books.Add(new Book(3, "Professional ASP.NET MVC", " Author Name Book 3", "/Content/img/book3.jpg"));
            try
            {
                if (ModelState.IsValid)
                {
                    books.Add(book);
                }
            }catch (RetryLimitExceedException)
            {
                ModelState.AddModelError("", "error Save Data");
            }
            return View("ListBookModel", books);
        }


        public ActionResult EditBook (int id)
        {
            var books = new List<Book>();
            books.Add(new Book(1, "HTML5 & CSS3 the complete Manual", " Author Name Book 1 ", "/Content/img/book.jpg"));
            books.Add(new Book(2, "HTML5 & CSS Responsive web design cookbook", " Author Name Book 2", "/Content/img/book2.jpg"));
            books.Add(new Book(3, "Professional ASP.NET MVC", " Author Name Book 3", "/Content/img/book3.jpg"));
            Book book = new Book();
            foreach (Book b in books)
            {
                if (b.Id == id)
                {
                    book = b;
                    break;
                }
                if (book == null)
                {
                    return HttpNotFound();
                }
            }

            return View(book);
        }
    }
}