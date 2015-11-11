using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization; //[DataContract], [DataMember]

namespace BookStoreWebServices
{
    [DataContract]
    public class User
    {
        /// <summary>
        /// Unique ID of User in db. Read Only.
        /// </summary>
        /// 
        [DataMember]
        public int Id;

        /// <summary>
        /// First name of a User.
        /// </summary>
        /// 
        [DataMember]
        public string FirstName;

        /// <summary>
        /// Last name of a User.
        /// </summary>
        /// 
        [DataMember]
        public string LastName;

        /// <summary>
        /// Nick name of a User.
        /// </summary>
        /// 
        [DataMember]
        public string Nickname;

        /// <summary>
        /// Email address of a User.
        /// </summary>
        /// 
        [DataMember]
        public string Email;

        /// <summary>
        /// Address of a User.
        /// </summary>
        /// 
        [DataMember]
        public string Address;

        /// <summary>
        /// Phone number of a User.
        /// </summary>
        /// 
        [DataMember]
        public string PhoneNumber;

        /// <summary>
        /// If User is an Admin. Read Only.
        /// </summary>
        /// 
        [DataMember]
        public bool IsAdmin;
    }
}