using System;
using System.Collections.Generic;
using System.Text;

namespace sec2_Assignment
{
    internal class book
    {
       public string title;
       public int pages;
        public override string ToString()
        {
            return $"Title: {title}, Pages: {pages}";
        }
    }
    
}
