## Estrutura da Aplicação Task

```
task/
├── apps/
│   ├── api/                           
│   │   ├── Task.API/             
│   │   │   ├── Controllers/
│   │   │   │   └── OrderController.cs
│   │   │   ├── Program.cs
│   │   │   └── appsettings.json
│   │   └── Task.API.sln
│   │
│   └── ui-web/                        
│       ├── public/
│       ├── src/
│       │   ├── assets/
│       │   ├── components/
│       │   ├── views/
│       │   │   └── OrderForm.vue
│       │   ├── router/
│       │   ├── store/
│       │   ├── api/
│       │   │   └── order.ts
│       │   └── main.ts
│       ├── vite.config.ts
│       └── package.json
│
├── libs/
│   ├── core/
│   │   ├── Task.Domain/          
│   │   └── Task.Application/     
│   │
│   ├── infrastructure/
│   │   └── Task.Infrastructure/  
│   │       └── Messaging/
│   │           ├── RabbitMqService.cs
│   │           └── RabbitMqConfiguration.cs
│   │
│   └── shared/
│       └── Task.Shared/          
│
├── docker/
│   ├── backend/
│   │   └── Dockerfile
│   ├── frontend/
│   │   └── Dockerfile
│   ├── nginx/
│   │   └── default.conf
│   └── rabbitmq/
│       └── definitions.json
│
├── docker-compose.yml
├── .env
└── README.md
```