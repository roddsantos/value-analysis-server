# value-analysis-server

Value Analysis Server is an application using ASP .NET

You'll need to have the docker installed in your device
First, create a .env file in the main project level, with the following data:

```bash
MYSQL_HOST=<database host>
MYSQL_PORT=<database port>
MYSQL_DATABASE=<database name>
MYSQL_USER=<database username>
MYSQL_PASSWORD=<database password (if used)>
```

After this, you can use the follow docker command to create the containers

```bash
$ docker-compose up
```

If the connection with the database container cannot be established, try the following:

1 - Stop the ´value-analysis-server´ container, keeping only the ´value-analysis-database´ running
2 - change the variable ´MYSQL_HOST´in the .env file with "127.0.0.1"
3 - Open a terminal in the root project and do the command:

```bash
$ dotnet run
```

After this, you should be able to connect to the database
