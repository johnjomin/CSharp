using CSharpOpenAPI_UserMachineApplication.Models;
using CSharpOpenAPI_UserMachineApplication.Models.BodyModels;
using CSharpOpenAPI_UserMachineApplication.Models.Modeller;
using CSharpOpenAPI_UserMachineApplication.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpOpenAPI_UserMachineApplication.Services
{
    public interface IManagementService
    {
        /// <summary>
        /// Get user by user id.
        /// </summary>
        /// <returns></returns>
        Task<List<User>> GetUserByUserId(string userId);

        /// <summary>
        /// Get user by user id.
        /// </summary>
        /// <returns></returns>
        Task<List<Machine>> GetMachineByMachineId(string machineId);

        /// <summary>
        /// Get user by user id.
        /// </summary>
        /// <returns></returns>
        Task<List<Application>> GetApplicationByApplicationId(string applicationId);

        /// <summary>
        /// Get user by user id.
        /// </summary>
        /// <returns></returns>
        Task<CouchDbCreateDocumentResult> PostServiceUser(UserBody body);

        /// <summary>
        /// Get user by user id.
        /// </summary>
        /// <returns></returns>
        Task<CouchDbCreateDocumentResult> PostServiceMachine(MachineBody machine);

        /// <summary>
        /// Get user by user id.
        /// </summary>
        /// <returns></returns>
        Task<CouchDbCreateDocumentResult> PostServiceApplication(ApplicationBody body);

        /// <summary>
        /// Get user by user id.
        /// </summary>
        /// <returns></returns>
        Task<bool> DeleteServiceUser(string userId);

        /// <summary>
        /// Get user by user id.
        /// </summary>
        /// <returns></returns>
        Task<bool> DeleteServiceMachine(string machineId);

        /// <summary>
        /// Get user by user id.
        /// </summary>
        /// <returns></returns>
        Task<bool> DeleteServiceApplication(string applicationId);
    }
}
