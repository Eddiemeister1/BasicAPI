
## GET all the Agents

## GET a single Agent

### Request
```
GET /agents
Accept: application/json
```

### Response

```
200 Ok
Content-Type: application/json

```

```json
{
    "agents":[
        {"id":939, 
         "firstName": "Bob",
         "lastName": "Smith",
         "phone": "555-1212",
         "email": "Bob@aol.com"
        }
    ]
}