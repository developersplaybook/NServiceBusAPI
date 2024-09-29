# NServiceBusAPI
Create empty databases NServiceBusDb, CarDb and ASPNETDb in Sql Server. In the connection strings, the Sql Server is called localhost. Change this name to the name of Your actual Sql Server.

You will need a NServiceBus developer license:
 https://particular.net/license/nservicebus
 
 Go to Solution Properties: Right-click the solution in Solution Explorer and choose Properties.
Select Multiple Startup Projects: Under Startup project, select Multiple startup projects.
Configure Startup Action:
Set the Client to Start.
Set the Server to Start (with the launchBrowser set to false in the launchSettings.json of the Server project).
Persist Project Settings: Use version-controlled launchSettings.json for port and environment configuration.

