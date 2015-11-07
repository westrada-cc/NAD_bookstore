using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreServiceApi.Models
{
    public interface IBook
    {
        /// <summary>
        /// Unique ID of the book in the Database.
        /// </summary>
        int Id { get; }

        /// <summary>
        /// Title of the book.
        /// </summary>
        string Title { get; set; }

        /// <summary>
        /// ISBN of the book.
        /// </summary>
        string Isbn { get; set; }

        /// <summary>
        /// Book authors.
        /// </summary>
        IList<IAuthor> Authors { get; set; }

        /// <summary>
        /// Book publishers.
        /// </summary>
        IList<IPublisher> Publishers { get; set; }

        /// <summary>
        /// Number of pages that book has.
        /// </summary>
        int NumberOfPages { get; set; }

        /// <summary>
        /// Book's Edition.
        /// </summary>
        string Edition { get; set; }

        /// <summary>
        /// If a book is a hardcover. If true, it is, if not, it is assumed that is a copy.
        /// </summary>
        bool IsHardCover { get; set; }

        /// <summary>
        /// User that created this book.
        /// </summary>
        IUser UserCreated { get; set; }
    }
}
