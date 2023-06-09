﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using SQLite;
using System.ComponentModel.DataAnnotations.Schema;

namespace MauiApp1.Entities
{
    [SQLite.Table("Books")]
    public class Book
    {
        [PrimaryKey, AutoIncrement, Indexed]
        [SQLite.Column("Id")]
        public int BookId { get; set; }
        public string Title { get; set; }
        public string YearOfPublication { get; set; }
        public int Price { get; set; }
        [Indexed]
        public int AuthorId { get; set; }

        public Book() { }

        public Book(string title, string yearOfPublication, int price, int authorId)
        {

            Title = title;
            YearOfPublication = yearOfPublication;
            Price = price;
            AuthorId = authorId;

        }

    }
}
