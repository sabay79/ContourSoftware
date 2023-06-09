﻿namespace OBS.Data.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int ISBN { get; set; }
        public int Price { get; set; }
        public DateTime Year { get; set; }

        public virtual ICollection<AuthorBook> BookAuthors { get; set; }

        public int PublisherID { get; set; }
        public virtual Publisher Publisher { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}