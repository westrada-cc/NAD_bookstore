using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;
using System.ServiceModel.Activation;

namespace BookStoreWebServices
{
    //Implement the IBookStoreService in this class and complete business requirements.
    [AspNetCompatibilityRequirements
        (RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class BookstoreService : IBookstoreService
    {
        List<BookAd> bookAds = new List<BookAd>(); //List of all available ads
        List<Book> books = new List<Book>(); //List of all available ads
        int bookAdCount = 0;    //Count of available ads
        int bookCount = 0;  //Count of available books

        /// <summary>
        /// Gets a list of all Books.
        /// </summary>
        /// <param name="void">It takes no parameters.</param>
        /// <returns>List of Books.</returns>
        /// 
        public List<Book> GetBooks()
        {
            return books.ToList();
        }

        /// <summary>
        /// Gets a list of Books that match the search argument.
        /// </summary>
        /// <param name="isbn">ISBN to search books by.</param>
        /// <returns>List of Books.</returns>
        /// 
        public List<Book> GetBooksByIsbn(string isbn)
        {
            return books.FindAll(e => e.Isbn.Equals(isbn));
        }

        /// <summary>
        /// Gets a list of Books that match the search argument.
        /// </summary>
        /// <param name="title">Title to search books by.</param>
        /// <returns>List of Books.</returns>
        /// 
        public List<Book> GetBooksByTitle(string title)
        {
            return books.FindAll(e => e.Title.Equals(title));
        }

        /// <summary>
        /// Gets Ads based on argument title. 
        /// </summary>
        /// <param name="title">Title to search for ads by.</param>
        /// <returns>List of Book ads.</returns>
        /// 
        public List<BookAd> GetAds(string title)
        {
            return bookAds.FindAll(e => e.Title.Equals(title));
        }

        /// <summary>
        /// Posts an Ad. 
        /// </summary>
        /// <remarks>
        /// To successfully post an Ad, ad argument must contain a valid User that posted the ad, and userPassword argument must match that User's password in DB.
        /// </remarks>
        /// <param name="ad">Ad to post.</param>
        /// <returns>The Book ad that was posted.</returns>
        /// 
        public BookAd PostAd(BookAd ad)
        {
            ad.Id = ++bookAdCount;
            bookAds.Add(ad);
            return ad;
        }

        /// <summary>
        /// Posts a book. 
        /// </summary>
        /// <remarks>
        /// To successfully post an book, ad argument must contain a valid User that posted the ad, and userPassword argument must match that User's password in DB.
        /// </remarks>
        /// <param name="ad">Book to post.</param>
        /// <returns>The Book that was posted.</returns>
        /// 
        public Book PostBook(Book book)
        {
            book.Id = ++bookCount;
            books.Add(book);
            return book;
        }
    }
}