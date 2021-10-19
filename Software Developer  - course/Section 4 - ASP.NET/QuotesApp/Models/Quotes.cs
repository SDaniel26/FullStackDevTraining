using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuotesApp.Models
{
    public class Quotes
    {
        public int Id { get; set; }
        public string QuoteAuthor { get; set; }
        public string QuoteText { get; set; }


        public Quotes()
        {

        }
    }
}