using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization; //[DataContract], [DataMember]

namespace BookStoreWebServices
{
    [DataContract]
    public class Author
    {
        /// <summary>
        /// Unique ID of Author in DB.
        /// </summary>
        /// 
        [DataMember]
        public int Id;

        /// <summary>
        /// Author's full name. 
        /// </summary>
        /// 
        [DataMember]
        public string FullName;
    }
}