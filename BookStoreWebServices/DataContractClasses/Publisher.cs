using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization; //[DataContract], [DataMember]

namespace BookStoreWebServices
{
    [DataContract]
    public class Publisher
    {
        /// <summary>
        /// Unique ID of Publisher in DB.
        /// </summary>
        /// 
        [DataMember]
        public int Id;

        /// <summary>
        /// Publisher's name. 
        /// </summary>
        /// 
        [DataMember]
        public string Name;
    }
}