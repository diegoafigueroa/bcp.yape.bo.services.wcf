using bcp.yape.bo.services.rules.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace bcp.yape.bo.services.rules.People
{
    /// <summary>
    /// A broker class responsible for handling people-related operations.
    /// </summary>
    internal class PeopleBroker
    {
        /// <summary>
        /// Retrieves a list of people based on their phone number.
        /// </summary>
        /// <param name="cellPhoneNumber">The phone number to search for.</param>
        /// <returns>List of people.</returns>
        public Task<IEnumerable<Person>> GetPeopleByPhoneNumberAsync(string cellPhoneNumber)
        {
            // SAMPLE DATA REPRESENTING PEOPLE WITH PHONE NUMBERS AND DOCUMENT DETAILS
            var people = new List<Person>
            {
                new Person { Name = "John", LastName = "Doe", CellPhoneNumber = "62345678", DocumentType = DocumentTypeEnum.IdentityCard, DocumentNumber = "123456" },
                new Person { Name = "Jane", LastName = "Smith", CellPhoneNumber = "62345677", DocumentType = DocumentTypeEnum.IdentityCard, DocumentNumber = "654321" }
            };

            return Task.FromResult((IEnumerable<Person>)people);
        }
    }
}