# VillaMon_API

VillaMon_API is a RESTful API service for managing users, devices, and monitoring data in the VillaMon system.

## API Endpoints

| Method | Endpoint              | Description                    |
|--------|-----------------------|--------------------------------|
| GET    | `/api/users`          | Get all users                  |
| POST   | `/api/users`          | Create a new user              |
| GET    | `/api/users/{id}`     | Get a user by ID               |
| PUT    | `/api/users/{id}`     | Update a user by ID            |
| DELETE | `/api/users/{id}`     | Delete a user by ID            |
| GET    | `/api/devices`        | Get all devices                |
| POST   | `/api/devices`        | Create a new device            |
| GET    | `/api/devices/{id}`   | Get a device by ID             |
| PUT    | `/api/devices/{id}`   | Update a device by ID          |
| DELETE | `/api/devices/{id}`   | Delete a device by ID          |
| GET    | `/api/monitoring`     | Get monitoring data            |
| POST   | `/api/monitoring`     | Add new monitoring data        |
| GET    | `/api/monitoring/{id}`| Get monitoring data by ID      |
| PUT    | `/api/monitoring/{id}`| Update monitoring data by ID   |
| DELETE | `/api/monitoring/{id}`| Delete monitoring data by ID   |
