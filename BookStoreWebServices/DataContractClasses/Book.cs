using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization; //[DataContract], [DataMember]

namespace BookStoreWebServices
{
    [DataContract]
    public class Book
    {
        /// <summary>
        /// Unique ID of the book in the Database.
        /// </summary>
        /// 
        [DataMember]
        public int Id;

        /// <summary>
        /// Title of the book.
        /// </summary>
        /// 
        [DataMember]
        public string Title;

        /// <summary>
        /// ISBN of the book.
        /// </summary>
        /// 
        [DataMember]
        public string Isbn;

        /// <summary>
        /// Book authors.
        /// </summary>
        /// 
        [DataMember]
        public List<Author> Authors;

        /// <summary>
        /// Book publishers.
        /// </summary>
        /// 
        [DataMember]
        public List<Publisher> Publishers;

        /// <summary>
        /// Number of pages that book has.
        /// </summary>
        /// 
        [DataMember]
        public int NumberOfPages;

        /// <summary>
        /// Book's Edition.
        /// </summary>
        /// 
        [DataMember]
        public string Edition;

        /// <summary>
        /// If a book is a hardcover. If true, it is, if not, it is assumed that is a copy.
        /// </summary>
        /// 
        [DataMember]
        public bool IsHardCover;

        /// <summary>
        /// User that created this book.
        /// </summary>
        /// 
        [DataMember]
        public User UserCreated;
    }
}