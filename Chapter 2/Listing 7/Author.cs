using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWPFSample
{
    /// <summary>
    /// The Author Class
    /// </summary>
    public class Author
    {
        /// <summary>
        /// Constructor of Author
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="bookName"></param>
        public Author(string name, short age, string bookName)
        {
            AuthorName = name;
            AuthorAge = age;
            PublishedBook = bookName;
        }

        /// <summary>
        /// The property name
        /// </summary>
        private string _name;
        
        /// <summary>
        /// The property AuthorName
        /// </summary>
        public string AuthorName
        {
            get => _name;
            set => _name = value;
        }

        /// <summary>
        /// The property age
        /// </summary>
        private short _age;
        
        /// <summary>
        /// The property AuthorAge
        /// </summary>
        public short AuthorAge
        {
            get => _age;
            set => _age = value;
        }

        /// <summary>
        /// The property book
        /// </summary>
        private string _book;
        
        /// <summary>
        /// The property PublishedBook
        /// </summary>
        
        public string PublishedBook
        {
            get => _book;
            set => _book = value;
        }
    }
}
