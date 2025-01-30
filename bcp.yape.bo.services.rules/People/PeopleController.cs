using bcp.yape.bo.services.rules.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace bcp.yape.bo.services.rules.People
{
    /// <summary>
    /// Controller class responsible for handling requests related to people.
    /// </summary>
    public class PeopleController
    {
        /// <summary>
        /// Retrieves a list of people based on their phone number.
        /// </summary>
        /// <param name="cellPhoneNumber">The cell phone number to search for.</param>
        /// <returns>List of people.</returns>
        public async Task<IEnumerable<Person>> GetPeopleByPhoneNumber(string cellPhoneNumber)
        {
            var broker = new PeopleBroker();
            var peopleByPhoneNumber = await broker.GetPeopleByPhoneNumberAsync(cellPhoneNumber);
            return peopleByPhoneNumber;
        }
    }
}
