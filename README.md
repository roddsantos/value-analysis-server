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
