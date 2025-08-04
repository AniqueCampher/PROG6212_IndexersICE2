using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjIndexersICE2
{
    public class Books
    {
        int price, ISBN;
        string title, author;

        public Books(int price, int ISBN, string title, string author)
        {
            this.price = price;
            this.ISBN = ISBN;
            this.title = title;
            this.author = author;
        }

        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return this.price;
                else if (index == 1)
                    return this.ISBN;
                else if (index == 2)
                    return this.title;
                else if (index == 3)
                    return this.author;
                return null;
            }
            set
            {
                if (index == 0)
                    this.price = (int)value;
                else if (index == 1)
                    this.ISBN = (int)value;
                else if (index == 2)
                    this.title = (string)value;
                else if (index == 3)
                    this.author = (string)value;
            }
        }
        public object this[string attrName]
        {
            get
            {
                if (attrName == "price")
                    return this.price;
                else if (attrName == "ISBN")
                    return this.ISBN;
                else if (attrName == "title")
                    return this.title;
                else if (attrName == "author")
                    return this.author;
                return null;
            }
            set
            {
                if (attrName.ToLower().Equals("price"))
                    this.price = (int)value;
                else if (attrName.ToLower().Equals("ISBN"))
                    this.ISBN = (int)value;
                else if (attrName.ToLower().Equals("title"))
                    this.title = (string)value;
                else if (attrName.ToLower().Equals("author"))
                    this.author = (string)value;
            }
        }
    }
}
