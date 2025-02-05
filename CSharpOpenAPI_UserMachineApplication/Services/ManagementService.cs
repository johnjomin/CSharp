﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Linq;
using MongoDB.Driver;
using MongoDB.Bson;
using Newtonsoft.Json;
using System.Web;
using System.Text.RegularExpressions;
using CSharpOpenAPI_UserMachineApplication.Clients;
using CSharpOpenAPI_UserMachineApplication.Models.Response;
using CSharpOpenAPI_UserMachineApplication.Models;
using CSharpOpenAPI_UserMachineApplication.Models.Modeller;
using AutoMapper;
using System.Net.Http;
using CSharpOpenAPI_UserMachineApplication.Models.BodyModels;
using CSharpOpenAPI_UserMachineApplication.Services;

namespace CSharpOpenAPI_UserMachineApplication.Services
{
    public class ManagementService : IManagementService
    {
        private IMongoDbClient _couchDbClient = new MongoDbClient();
        private readonly IMapper _mapper;

        /// <inheritdoc/>
        public async Task<List<User>> GetUserByUserId(string userId)
        {
            CouchDbGetDocumentsResult results;
            string collectionName = "users";

            results = await _couchDbClient.GetDocumentsAsync(collectionName, $" {{_id: '{userId}' }}");

            List<User> users = new List<User>();
            foreach (CouchDbRow row in results.Rows)
            {
                var result = await _couchDbClient.GetDocumentAsync(collectionName, row.Id);
                try
                {
                    users.Add(JObject.FromObject(result).ToObject<User>());
                }
                catch (Exception e)
                {
                    Console.WriteLine($"error {e.Message}");
                }
            }

            return users;
        }

        public async Task<List<Machine>> GetMachineByMachineId(string machineId)
        {
            CouchDbGetDocumentsResult results;
            string collectionName = "machines";

            results = await _couchDbClient.GetDocumentsAsync(collectionName, $" {{_id: '{machineId}' }}");

            List<Machine> machines = new List<Machine>();
            foreach (CouchDbRow row in results.Rows)
            {
                var result = await _couchDbClient.GetDocumentAsync(collectionName, row.Id);
                try
                {
                    machines.Add(JObject.FromObject(result).ToObject<Machine>());
                }
                catch (Exception e)
                {
                    Console.WriteLine($"error {e.Message}");
                }
            }

            return machines;
        }

        public async Task<List<Application>> GetApplicationByApplicationId(string applicationId)
        {
            CouchDbGetDocumentsResult results;
            string collectionName = "applications";

            results = await _couchDbClient.GetDocumentsAsync(collectionName, $" {{_id: '{applicationId}' }}");

            List<Application> machines = new List<Application>();
            foreach (CouchDbRow row in results.Rows)
            {
                var result = await _couchDbClient.GetDocumentAsync(collectionName, row.Id);
                try
                {
                    machines.Add(JObject.FromObject(result).ToObject<Application>());
                }
                catch (Exception e)
                {
                    Console.WriteLine($"error {e.Message}");
                }
            }

            return machines;
        }

        public async Task<CouchDbCreateDocumentResult> PostServiceUser(UserBody userBody)
        {
            string database = "users";
            string id = "";
            
            if (!string.IsNullOrEmpty(userBody.id))
            {
                id = userBody.id;
            }
            else
            {
                id = Guid.NewGuid().ToString("N");
            }

            CouchDbCreateDocumentResult createResponse = await _couchDbClient.CreateDocumentAsync(database, id, userBody);

            return createResponse;
        }

        public async Task<CouchDbCreateDocumentResult> PostServiceMachine(MachineBody machineBody)
        {
            string database = "machines";
            string id = "";
            if (!string.IsNullOrEmpty(machineBody.id))
            {
                id = machineBody.id;
            }
            else
            {
                id = Guid.NewGuid().ToString("N");
            }

            foreach (var macUsers in machineBody.owners)
            {
                macUsers.id = Guid.NewGuid().ToString("N");
            }

            foreach(var macApp in machineBody.applications)
            {
                macApp.id = Guid.NewGuid().ToString("N");
            }

            CouchDbCreateDocumentResult createResponse = await _couchDbClient.CreateDocumentAsync(database, id, machineBody);

            return createResponse;
        }

        public async Task<CouchDbCreateDocumentResult> PostServiceApplication(ApplicationBody applicationBody)
        {
            string database = $"applications";
            string id = "";
            if (!string.IsNullOrEmpty(applicationBody.id))
            {
                id = applicationBody.id;
            }
            else
            {
                id = Guid.NewGuid().ToString("N");
            }

            CouchDbCreateDocumentResult createResponse = await _couchDbClient.CreateDocumentAsync(database, id, applicationBody);

            return createResponse;
        }

        public async Task<bool> DeleteServiceUser(string userId)
        {
            CouchDbGetDocumentResult getResult = new CouchDbGetDocumentResult();
            string requestDatabase = $"users";

            try
            {
                getResult = await _couchDbClient.GetDocumentAsync(requestDatabase, userId);
            }
            catch (Exception e)
            {
                Console.WriteLine($"error {e.Message}");
            }

            CouchDbDeleteDocumentResult deleteResult = await _couchDbClient.DeleteDocumentAsync(requestDatabase, getResult.DocumentId, getResult.RevisionId);

            return deleteResult.IsSuccessful;
        }

        public async Task<bool> DeleteServiceMachine(string machineId)
        {
            CouchDbGetDocumentResult getResult = new CouchDbGetDocumentResult();
            string requestDatabase = $"machines";

            try
            {
                getResult = await _couchDbClient.GetDocumentAsync(requestDatabase, machineId);
            }
            catch (Exception e)
            {
                Console.WriteLine($"error {e.Message}");
            }

            CouchDbDeleteDocumentResult deleteResult = await _couchDbClient.DeleteDocumentAsync(requestDatabase, getResult.DocumentId, getResult.RevisionId);

            return deleteResult.IsSuccessful;
        }

        public async Task<bool> DeleteServiceApplication(string applicationId)
        {
            CouchDbGetDocumentResult getResult = new CouchDbGetDocumentResult();
            string requestDatabase = $"applications";

            try
            {
                getResult = await _couchDbClient.GetDocumentAsync(requestDatabase, applicationId);
            }
            catch (Exception e)
            {
                Console.WriteLine($"error {e.Message}");
            }

            CouchDbDeleteDocumentResult deleteResult = await _couchDbClient.DeleteDocumentAsync(requestDatabase, getResult.DocumentId, getResult.RevisionId);

            return deleteResult.IsSuccessful;
        }
    }
}
