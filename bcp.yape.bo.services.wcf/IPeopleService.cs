using bcp.yape.bo.services.wcf.DataContracts.People;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;

namespace bcp.yape.bo.services.wcf
{
    /// <summary>
    /// Service contract for operations related to retrieving people information.
    /// </summary>
    [ServiceContract]
    public interface IPeopleService
    {
        /// <summary>
        /// Asynchronously retrieves a list of people based on their phone number.
        /// </summary>
        /// <param name="request">The request containing the phone number used to search for people.</param>
        /// <returns>List of <see cref="PersonResponse"/> objects.</returns>
        [OperationContract]
        Task<List<PersonResponse>> GetPeopleByPhoneNumber(PersonRequest request);
    }
}
