using bcp.yape.bo.services.rules;
using bcp.yape.bo.services.rules.People;
using bcp.yape.bo.services.wcf.DataContracts.People;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace bcp.yape.bo.services.wcf
{
    /// <summary>
    /// Service implementation for handling people-related operations in the WCF service.
    /// </summary>
    public class PeopleService : IPeopleService
    {
        /// <summary>
        /// Asynchronously retrieves a list of people based on the provided phone number from the request.
        /// </summary>
        /// <param name="request">The request containing the cell phone number to search for people.</param>
        /// <returns>A task representing the asynchronous operation, containing a list of <see cref="PersonResponse"/> objects.</returns>
        public async Task<List<PersonResponse>> GetPeopleByPhoneNumber(PersonRequest request)
        {
            // INSTANTIATE THE PeopleController TO HANDLE THE LOGIC OF RETRIEVING PEOPLE BY PHONE NUMBER
            var peopleController = new PeopleController();
            var peopleByPhoneNumber = await peopleController.GetPeopleByPhoneNumber(request.CellPhoneNumber);

            // CONVERT EACH Person OBJECT (BUSINESS MODEL) TO A PersonResponse AND ADD TO THE RESPONSE LIST
            var peopleResponseList = new List<PersonResponse>();
            foreach (var person in peopleByPhoneNumber)
            {
                var personResponse = PersonResponse.ToPersonResponse(person);
                peopleResponseList.Add(personResponse);
            }

            // RETURN THE LIST OF PEOPLE
            return peopleResponseList;
        }
    }
}
