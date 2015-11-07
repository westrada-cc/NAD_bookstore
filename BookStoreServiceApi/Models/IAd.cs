using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreServiceApi.Models
{
    public interface IAd
    {
        /// <summary>
        /// Unique ID of an Ad in DB.
        /// </summary>
        int Id { get; }

        /// <summary>
        /// Title of an Ad.
        /// </summary>
        string Title { get; set; }

        /// <summary>
        /// Description of an Ad.
        /// </summary>
        string Description { get; set; }

        /// <summary>
        /// Book being sold.
        /// </summary>
        IBook Book { get; set; }

        /// <summary>
        /// Asking Price for a Book being sold in this Ad.
        /// </summary>
        decimal Price { get; set; }

        /// <summary>
        /// User that posted Ad.
        /// </summary>
        IUser UserPosted { get; set; }

        /// <summary>
        /// Date and time that Ad has been posted on.
        /// </summary>
        DateTime PostTimestamp { get; set; }

        /// <summary>
        /// Tags for this Ad.
        /// </summary>
        IList<string> Tags { get; set; }
    }
}
