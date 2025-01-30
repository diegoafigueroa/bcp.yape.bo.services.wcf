using System.Runtime.Serialization;

namespace bcp.yape.bo.services.wcf.DataContracts.People
{
    /// <summary>
    /// Data contract representing a request for person information based on phone number.
    /// </summary>
    [DataContract]
    public class PersonRequest
    {
        /// <summary>
        /// Gets or sets the cell phone number used to request person information.
        /// </summary>
        [DataMember]
        public string CellPhoneNumber { get; set; }
    }
}
