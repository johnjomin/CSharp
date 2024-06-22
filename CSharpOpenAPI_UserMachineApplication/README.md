# CSharpOpenAPI_UserMachineApplication
 C# Exercise on User - Machine - Application

 Created this project to sharpen and learn by creating Swagger OPEN API Project and communicate these API methods with MongoDB functions.
This is real interesting as I wasn’t aware of many Mongo operations being available and it works way differently than Python.
Also had to write bunch of classes stored under the Models directory. This is due to Models for Users, Applications, and Machines being used for reading, write and delete operations within the database. Along with models for an exception, response models, and document response models (mongo documents).
-	Note to self: Is there way minimise all these models?


Note to self: For some reason, Swagger API is not running properly. It is displaying correctly but when opening each method or “Trying it Out”, it gets stuck.
Refer to Google Search: “swagger stuck on loading image”
https://github.com/swagger-api/swagger-ui/issues/4466

These are the models:-
User Model:
string name; // <Test User>
string email; // <user@example.com>
string password; // <example-password>

Machine Model:
User[] owners;
Application[] applications;
string address; // <127.0.0.1>
short port; // <2222>

Application Model:
string container; // <nginx|busybox|alpine>
string status; // <stopped|running|starting>

Note to self: Also ran this Open API Project via Docker and it worked but try more advanced docker operation using docker-compose and YAML files.
-	Learn a tool system and create a K8s deployment files? And how to deploy successfully?
