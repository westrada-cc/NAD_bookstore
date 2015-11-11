using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;  //[ServiceContract], [OperationContract]
using System.ServiceModel.Web; //WebGet and WebInvoke

namespace BookStoreWebServices
{
    [ServiceContract]
    public interface IBookstoreService
    {
        /// <summary>
        /// Gets a list of Books that match the search argument.
        /// </summary>
        /// <param name="search">String to search for books by.</param>
        /// <returns>List of Books.</returns>
        /// 
        [OperationContract]
        [WebGet(UriTemplate = "")]
        IList<Book> GetBooks();

        /// <summary>
        /// Gets a list of Books that match the search argument.
        /// </summary>
        /// <param name="isbn">ISBN to search books by.</param>
        /// <returns>List of Books.</returns>
        /// 
        [OperationContract]
        [WebGet(UriTemplate = "")]
        IList<Book> GetBooksByIsbn(string isbn);

        /// <summary>
        /// Gets a list of Books that match the search argument.
        /// </summary>
        /// <param name="title">Title to search books by.</param>
        /// <returns>List of Books.</returns>
        ///  
        [OperationContract]
        [WebGet(UriTemplate = "")]
        IList<Book> GetBooksByTitle(string title);

        /// <summary>
        /// Gets Ads based on arguments search,from, and to. 
        /// </summary>
        /// <param name="search">String to search for ads by. If NULL, argument is ignored.</param>
        /// <param name="from">Minimum Ad PostTimestamp. If NUll argument is ignored.</param>
        /// <param name="to">Maximum Ad PostTimestamp. If NUll argument is ignored.</param>
        /// <returns></returns>
        /// 
        [OperationContract]
        [WebGet(UriTemplate = "")]
        IList<BookAd> GetAds(string title);

        /// <summary>
        /// Posts an Ad. 
        /// </summary>
        /// <remarks>
        /// To successfully post an Ad, ad argument must contain a valid User that posted the ad, and userPassword argument must match that User's password in DB.
        /// </remarks>
        /// <param name="ad">Ad to post.</param>
        /// <exception cref="ArgumentNullException">Thrown when ad argument is NULL.</exception>
        /// <exception cref="ArgumentException">Thrown when ad argument is not valid, userPassword argument is not valid</exception>
        /// <returns>True if Ad was posted.</returns>
        /// 
        [OperationContract]
        [WebInvoke(UriTemplate = "", Method = "POST")]
        BookAd PostAd(BookAd ad);

        /// <summary>
        /// Posts a book. 
        /// </summary>
        /// <remarks>
        /// To successfully post an book, ad argument must contain a valid User that posted the ad, and userPassword argument must match that User's password in DB.
        /// </remarks>
        /// <param name="ad">Ad to post.</param>
        /// <exception cref="ArgumentNullException">Thrown when ad argument is NULL.</exception>
        /// <exception cref="ArgumentException">Thrown when ad argument is not valid, userPassword argument is not valid</exception>
        /// <returns>True if Ad was posted.</returns>
        /// 
        [OperationContract]
        [WebInvoke(UriTemplate = "", Method = "POST")]
        Book PostBook(Book book);
    }
}