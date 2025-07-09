## Estrutura da Aplicação Task

```
task/
├── api/--------------------------------BACKEND
│   ├── Task.API/-----------------------Camada de Apresentação
│   │   ├── Controllers/
│   │   │   └── Orders/
│   │   │       ├── Requests/-----------DTOs de entrada
│   │   │       ├── Responses/----------DTOs de saída
│   │   │       └── OrderController.cs
│   │   ├── Middleware/
│   │   └── Program.cs
│   │
│   ├── Task.Application/---------------Camada de Aplicação
│   │   ├── Features/
│   │   │   └── Orders/
│   │   │       ├── Commands/
│   │   │       ├── Queries/
│   │   │       ├── Services/
│   │   │       └── Mappers/
│   │   └── Core/
│   │
│   ├── Task.Domain/--------------------Camada de Domínio
│   │   ├── Entities/
│   │   │   └── Order.cs
│   │   ├── ValueObjects/
│   │   ├── Events/
│   │   └── Interfaces/
│   │
│   ├── Task.Infrastructure/------------Camada de Infraestrutura
│   │   ├── Persistence/
│   │   │   ├── Repositories/
│   │   │   └── Migrations/
│   │   ├── Messaging/
│   │   │   ├── RabbitMqService.cs
│   │   │   └── RabbitMqConfiguration.cs
│   │   └── Services/
│   │
│   └── Task.Shared/--------------------Recursos Compartilhados
│       ├── Exceptions/
│       └── Utilities/
│
├── ui-web/-----------------------------FRONTEND
│   ├── public/
│   ├── src/
│   │   ├── assets/
│   │   ├── components/
│   │   ├── views/
│   │   │   └── OrderForm.vue
│   │   ├── router/
│   │   ├── store/
│   │   ├── api/
│   │   │   └── order.ts
│   │   └── main.ts
│   ├── vite.config.ts
│   └── package.json
│
├── docker/----------------------------DOCKER
│   ├── backend.dockerfile
│   ├── frontend.dockerfile
│   └── nginx/
│       └── default.conf
│
├── docker-compose.yml-----------------DOCKER COMPOSE
├── .env
└── README.md
```
