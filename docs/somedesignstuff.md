

GET /agents/1

```json

{
    "id": 1,
    "firstName": "John",
    "lastName": "Cassavetes",
    "phone": "555-3323",
    "email": "john@nyfile.com",
    "state": "OH",
    "contactMechanisms" {
        "phone":[
            "555-555-5557",
            "800-222-2222",
        ]
    },
    "address": {
        "home": {
            "street": "19 Bluebird Ct",
            "city": "Hudson",
            "state":"OH"
        },
        "work": {
            "street":"19 Snell Ct",
            "city": "Canton",
            "state": "OH"
        }
    }
}

PUT /agents/1/contactmechanism/phones

[
            "555-555-5552",
            "800-222-2223"
]

PUT /agents/1/address/home

{
    "street": "19 Bluebird Ct",
    "city": "Miami",
    "state": "FL"
}

"Upsert" - update it if exists, if not, add it.
```
Questions:
    - If I add this, does everyone that has access to
    the previous information also have access to the 
    new information?

    - What are the performance implications of this?

GET /agents/1/endorsements

```json
{
    "endorsements": [
        "home-owner",
        "rv",
        "commercial"
    ]
}

```