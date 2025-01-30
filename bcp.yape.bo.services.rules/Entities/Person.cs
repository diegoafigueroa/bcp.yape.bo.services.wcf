using System;

namespace bcp.yape.bo.services.rules.Entities
{
    /// <summary>
    /// Class that represents a person with their personal details.
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Gets or sets the person's first name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the person's last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the person's cell phone number.
        /// </summary>
        public string CellPhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the type of identity document the person holds.
        /// </summary>
        public DocumentTypeEnum DocumentType { get; set; }

        /// <summary>
        /// Gets or sets the document number of the person.
        /// </summary>
        public string DocumentNumber { get; set; }

        /// <summary>
        /// Gets or sets the person's address.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets the person's email address.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the person's date of birth.
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Gets or sets the person's gender.
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// Gets or sets the person's nationality.
        /// </summary>
        public string Nationality { get; set; }

        /// <summary>
        /// Gets or sets the person's occupation.
        /// </summary>
        public string Occupation { get; set; }
    }
}
