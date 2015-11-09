using BookStoreServiceApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreServiceApi
{
    /// <summary>
    /// This interface represents operations that can be performed by an actual implementation of a BookStoreService.
    /// </summary>
    public interface IBookStoreService
    {
        #region | Properties |

        /// <summary>
        /// IP address of a service to connect to.
        /// </summary>
        string Ip { get; set; }

        /// <summary>
        /// Port number of a service to connect to.
        /// </summary>
        string Port { get; set; } 

        #endregion

        #region | Methods |

        /// <summary>
        /// Gets a list of Books that match the search argument.
        /// </summary>
        /// <param name="search">String to search for books by.</param>
        /// <returns>List of Books.</returns>
        IList<IBook> GetBooks(string search);

        /// <summary>
        /// Gets a list of Books that match the search argument.
        /// </summary>
        /// <param name="isbn">ISBN to search books by.</param>
        /// <returns>List of Books.</returns>
        IList<IBook> GetBooksByIsbn(string isbn); 

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
        bool PostAd(IAd ad, string userPassword);

        /// <summary>
        /// Gets Ads based on arguments search,from, and to. 
        /// </summary>
        /// <param name="search">String to search for ads by. If NULL, argument is ignored.</param>
        /// <param name="from">Minimum Ad PostTimestamp. If NUll argument is ignored.</param>
        /// <param name="to">Maximum Ad PostTimestamp. If NUll argument is ignored.</param>
        /// <returns></returns>
        IList<IAd> GetAds(string search, DateTime? from, DateTime? to);

        #endregion
    }
}
