using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWPFSample
{
    /// <summary>
    /// The Author Classs
    /// </summary>
    public class Author
    {
        /// <summary>
        /// Constructor of Author
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="bookName"></param>
        public Author(string name, Int16 age, string bookName)
        {
            this.AuthorName = name;
            this.AuthorAge = age;
            this.PublishedBook = bookName;
        }

        /// <summary>
        /// The property name
        /// </summary>
        private string name;
        /// <summary>
        /// The property AuthorName
        /// </summary>
        public string AuthorName
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// The property age
        /// </summary>
        private Int16 age;
        /// <summary>
        /// The property AuthorAge
        /// </summary>
        /// 
        public Int16 AuthorAge
        {
            get { return age; }
            set { age = value; }
        }

        /// <summary>
        /// The property book
        /// </summary>
        private string book;

        /// <summary>
        /// The property PublishedBook
        /// </summary>
        public string PublishedBook
        {
            get { return book; }
            set { book = value; }
        }
    }
}
