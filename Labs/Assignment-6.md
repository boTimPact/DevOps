## Assignment 6 - Docker-Compose

### Approach

1. As I have worked with `Postgres` in the past, I chose this as my DB.
2. Due to the quick and easy integration of `EntityFrameworkCore` (EfCore), I decided to use this ORM for my data access.
3. Since EfCore also offers database `migrations`, I thought that this would not be a problem. Unfortunately, I couldn't access the `dotnet cli-tools`, so I had to solve this in the code so that it now checks every time the application is started whether the database is up to date.
4.  Starting my containers via `docker-compose` was fairly simple, but there were problems connecting the web service to the database. After long research, I was able to find the solution, which consisted of naming the Postgres container and specifying the server in the `connection string` instead of a host.
5.  In the end I did some minor changes to provide data persistence even when destroying the container and cleaning my startup conditions.

### Outcome

Apart from the major headache caused by the failed connection to the database, everything worked fine and my containers are now working as intended.
<hr>
