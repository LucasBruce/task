## Estrutura da Aplicação Task

```
task/
├── apps/
│   ├── api/                           
│   │   ├── Task.API/             
│   │   └── Task.API.sln          
│   │
│   └── ui-web/                        
│       ├── public/
│       ├── src/
│       │   ├── assets/
│       │   ├── components/
│       │   ├── views/
│       │   ├── router/
│       │   ├── store/
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
│   │
│   └── shared/                        
│       ├── Task.Shared/          
│
├── docker/
│   ├── backend/                       
│   │   └── Dockerfile
│   ├── frontend/                      
│   │   └── Dockerfile
│   └── nginx/
│       ├── default.conf               
│       └── Dockerfile
│
├── docker-compose.yml                
├── README.md
└── .env
```