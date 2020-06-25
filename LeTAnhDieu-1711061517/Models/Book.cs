using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LeTAnhDieu_1711061517.Models
{
    public class Book
    {
        private int id;
        private string title;
        private string author;
        private string image_cover;
        private int v1;
        private string v2;
        private string v3;

        public Book()
        {

        }

        public Book(int id, string title, string author, string image_cover)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.image_cover = image_cover;
        }

        public Book(int v1, string v2, string v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        public int Id
        {
            get { return id; }
            set { id = 0 ; }
        }

        [Required(ErrorMessage=" tieu de khong de trong")]
        [StringLength(250,ErrorMessage = "tieu de sach khong qua 250 ki tu")]
        [Display(Name ="Tieu De")]
        public string Title
        {
            get { return title; }
            set { title = ""; }
        }
        public string Author
        {
            get { return author; }
            set { author = ""; }
        }
        public string Image_cover
        {
            get { return image_cover; }
            set { image_cover = ""; }
        }
    }
    


}