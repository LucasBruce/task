## Estrutura da Aplicação Task

```
task/
├── src/---------------------------------------BACKEND
│   ├── Task.API/------------------------------Camada de Apresentação/API
│   │   ├── Controllers/
│   │   │   └── OrderController.cs
│   │   ├── Program.cs
│   │   └── appsettings.json
│   │
│   ├── Task.Application/----------------------Camada de Aplicação
│   │   ├── Services/
│   │   ├── Commands/
│   │   ├── Queries/
│   │   └── DTOs/
│   │
│   ├── Task.Domain/---------------------------Camada de Domínio
│   │   ├── Entities/
│   │   ├── ValueObjects/
│   │   ├── Enums/
│   │   ├── Events/
│   │   └── Interfaces/
│   │
│   ├── Task.Infrastructure/-------------------Camada de Infraestrutura
│   │   ├── Persistence/
│   │   ├── Messaging/
│   │   │   ├── RabbitMqService.cs
│   │   │   └── RabbitMqConfiguration.cs
│   │   └── Services/
│   │
│   └── Task.Shared/---------------------------Recursos Compartilhados
│
├── ui-web/------------------------------------FRONTEND
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
├── docker/------------------------------------DOCKER
│   ├── backend/
│   │   └── Dockerfile
│   ├── frontend/
│   │   └── Dockerfile
│   ├── nginx/
│   │   └── default.conf
│   └── rabbitmq/
│       └── definitions.json
│
├── docker-compose.yml-------------------------DOCKER COMPOSE
├── .env
└── README.md
```