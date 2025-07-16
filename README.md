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

As versões atuais do .NET, até o momento, não lidam bem com o versionamento
centralizado de bibliotecas. Basicamente, existem duas opções:

1. Suprimir os avisos manualmente adicionando esta configuração nos projetos
onde ocorrem os conflitos:

```xml
<PropertyGroup>
  <NoWarn>NU1604;NU1602</NoWarn>
</PropertyGroup>
```

2. Adicionar explicitamente as versões das bibliotecas diretamente
nos respectivos projetos onde são utilizadas, da forma tradicional.
Porém, nesse caso, não haverá um gerenciamento
centralizado de dependências.

Utilizei o padrão Singleton nas injeções de dependencias, pois no
contexto atual do projeto não é necessário multiplas instâncias já
que não terá multiplas requisições em concorrência.
