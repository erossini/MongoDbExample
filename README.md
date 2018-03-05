# MongoDb example
Simple example for `MongoDB`. Save and retrieve data from `Azure Cosmos DB`.

## Create an Azure Cosmos Db as MongoDb
For creating a new `MongoDb` on `Azure`, search from the list of resources, `Azure Cosmos Db`. Then `Add` a new database and you see the following screen.

![New MongoDb on Azure](https://github.com/erossini/MongoDbExample/blob/master/Screenshots/NewCosmosDB.PNG)

## MongoDb Overview
When you created a new `MongoDb`, you see an `Overview` where there are general information about how many queries the database did (split on insert, update, cancel, query, count, others).

![Azure Overview](https://github.com/erossini/MongoDbExample/blob/master/Screenshots/Overview.png)

Under `Connection String` you have the connection to use in your application. In this project you insert in `Program.cs` the connection string in the variable called `connectionString`.

## MongoDb DataExplorer
You can explorer all data in your `Mongo` database. Click on `Data Explorer` and you can see everything. Also, you can execute same queries.

![Azure DataExplorer](https://github.com/erossini/MongoDbExample/blob/master/Screenshots/DataExplorer.PNG)
