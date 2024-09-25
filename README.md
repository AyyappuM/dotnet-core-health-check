# dotnet-core-health-check

Close this repo and run `dotnet run`.

Open a new terminal and run the commands below (the app is running in http://localhost:5004 in this example):

```
$ curl -H "Authorization: Bearer 123" http://localhost:5004
Hello World!

$ curl http://localhost:5004
Unauthorized: Not token provided

$ curl -H "Authorization: Bearer 123456" http://localhost:5004
Unauthorized: Invalid token

$curl http://localhost:5004/health
Healthy

$ curl -H "Authorization: Bearer 123456" http://localhost:5004/health
Healthy

$ curl -H "Authorization: Bearer 123" http://localhost:5004/health
Healthy 
```
