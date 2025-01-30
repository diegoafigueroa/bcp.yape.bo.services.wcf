using System.Runtime.Serialization;
using System;
using bcp.yape.bo.services.rules.Entities;

namespace bcp.yape.bo.services.wcf.DataContracts.People
{
    /// <summary>
    /// Data contract representing the response containing person information.
    /// </summary>
    [DataContract]
    public class PersonResponse
    {
        /// <summary>
        /// Gets or sets the cell phone number of the person.
        /// </summary>
        [DataMember]
        public string CellPhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the first name of the person.
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the last name of the person.
        /// </summary>
        [DataMember]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the type of identity document the person holds.
        /// </summary>
        [DataMember]
        public DocumentTypeEnum DocumentType { get; set; }

        /// <summary>
        /// Gets or sets the document number of the person
        /// </summary>
        [DataMember]
        public string DocumentNumber { get; set; }

        /// <summary>
        /// Converts a <see cref="Person"/> object to a <see cref="PersonResponse"/> object.
        /// </summary>
        /// <param name="person">The person object to convert.</param>
        /// <returns>A new <see cref="PersonResponse"/> object populated with the person's data.</returns>
        public static PersonResponse ToPersonResponse(Person person)
        {
            return new PersonResponse
            {
                CellPhoneNumber = person.CellPhoneNumber,
                Name = person.Name,
                LastName = person.LastName,
                DocumentType = person.DocumentType,
                DocumentNumber = person.DocumentNumber
            };
        }
    }
}
