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
        /// Gets a list of all Books.
        /// </summary>
        /// <param name="void">It takes no parameters.</param>
        /// <returns>List of Books.</returns>
        /// 
        [OperationContract]
        [WebGet(UriTemplate = "")]
        List<Book> GetBooks();

        /// <summary>
        /// Gets a list of Books that match the search argument.
        /// </summary>
        /// <param name="isbn">ISBN to search books by.</param>
        /// <returns>List of Books.</returns>
        /// 
        [OperationContract]
        [WebGet(UriTemplate = "/GetBooks?isbn={isbn}")]
        List<Book> GetBooksByIsbn(string isbn);

        /// <summary>
        /// Gets a list of Books that match the search argument.
        /// </summary>
        /// <param name="title">Title to search books by.</param>
        /// <returns>List of Books.</returns>
        ///  
        [OperationContract]
        [WebGet(UriTemplate = "/GetBooks/{title}")]
        List<Book> GetBooksByTitle(string title);

        /// <summary>
        /// Gets Ads based on argument title. 
        /// </summary>
        /// <param name="title">Title to search for ads by.</param>
        /// <returns>List of Book ads.</returns>
        /// 
        [OperationContract]
        [WebGet(UriTemplate = "/GetAds?title={title}")]
        List<BookAd> GetAds(string title);

        /// <summary>
        /// Posts an Ad. 
        /// </summary>
        /// <remarks>
        /// To successfully post an Ad, ad argument must contain a valid User that posted the ad, and userPassword argument must match that User's password in DB.
        /// </remarks>
        /// <param name="ad">Ad to post.</param>
        /// <returns>The Book ad that was posted.</returns>
        /// 
        [OperationContract]
        [WebInvoke(UriTemplate = "/PostAd", Method = "POST")]
        BookAd PostAd(BookAd ad);

        /// <summary>
        /// Posts a book. 
        /// </summary>
        /// <remarks>
        /// To successfully post an book, ad argument must contain a valid User that posted the ad, and userPassword argument must match that User's password in DB.
        /// </remarks>
        /// <param name="ad">Book to post.</param>
        /// <returns>The Book that was posted.</returns>
        /// 
        [OperationContract]
        [WebInvoke(UriTemplate = "/PostBook", Method = "POST")]
        Book PostBook(Book book);
    }
}