# dotnet-core-health-check

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
