using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization; //[DataContract], [DataMember]

namespace BookStoreWebServices
{
    [DataContract]
    public class BookAd
    {
        /// <summary>
        /// Unique ID of an Ad in DB.
        /// </summary>
        /// 
        [DataMember]
        public int Id;

        /// <summary>
        /// Title of an Ad.
        /// </summary>
        /// 
        [DataMember]
        public string Title;

        /// <summary>
        /// Description of an Ad.
        /// </summary>
        /// 
        [DataMember]
        public string Description;

        /// <summary>
        /// Book being sold.
        /// </summary>
        /// 
        [DataMember]
        public Book Book;

        /// <summary>
        /// Asking Price for a Book being sold in this Ad.
        /// </summary>
        /// 
        [DataMember]
        public decimal Price;

        /// <summary>
        /// User that posted Ad.
        /// </summary>
        /// 
        [DataMember]
        public User UserPosted;

        /// <summary>
        /// Date and time that Ad has been posted on.
        /// </summary>
        /// 
        [DataMember]
        public DateTime PostTimestamp;

        /// <summary>
        /// Tags for this Ad.
        /// </summary>
        /// 
        [DataMember]
        public List<string> Tags;

        [DataMember]
        public List<byte[]> Pictures;
    }
}