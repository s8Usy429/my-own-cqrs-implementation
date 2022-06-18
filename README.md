# my-own-cqrs-implementation

As to me, a better implementation of the CQRS pattern.
I'm not only segregating Reads from Writes but the all the CRUD operations :
- Requests
  - C
  - R
  - U
  - D
- Handlers
  - C
  - R
  - U
  - D 

I'm also segregating MediatR stuff per entity.
This way, source code is well organized and easy to navigate :
- Requests
  - C
    - Entity1
    - Entity2
    - ...

Entities are internal and made visible to he DAL so only it can map them to Dtos.
I'm using AutoMapper in the DAL to map entites from/to Dtos.
