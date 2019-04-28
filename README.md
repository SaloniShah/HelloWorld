# HelloWorld
A simple hello world .NET Core application that reads the message from an API

### To build and run, follow these steps:

1. Clone from the `Master` branch.
2. Build and run the `HelloWorldAPI.sln` solution.
3. To check if it is working, navigate to `https://localhost:44355/api/HelloWorld`. You should see _Hello World_ in the browser.
4. Build and run the 'HelloWorldConsoleApp.sln' solution.
5. You should see a console open up with the message _Hello World_.

### Technical details:

#### The API:
* This solution uses a simple Web API to return the _Hello World_ message. 
* The API can be extended to get the message from different sources.
* The `Manager` layer can be extended to include further logic, go to the database layer etc.
* The API uses dependency injection (`StructureMap`) to build the dependencies.

#### The console app:
* The console app is a simple app that reads configuration from a config file.
* The config file currently has two configurations:
	* Where to write the message to (console in this case)
	* The url to the API
* The console app also has a Writer project which can contain different implementations for the writers.
* Currently, only the console writer is implemented.