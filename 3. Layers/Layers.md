## Layers
### Application
- Orquestra implementações.
- Responsável por fluxos do sistema, coordenando regras de negócio, permissões e comunicação. 

### Domain
- Interfaces e Modelos.
- Estrutura e a regra de negócio, onde é definido escopo do projeto. 

### Infrastructure
- Mexe com o banco. 
- Implementações em si.

### Presentation
- Interfaces e interação com usuário.

## Services
Serviços sobre a lógica do funcionamento são "Serviços de Infraestrutura".
- Interfaces ficam na Aplicattion e implementação na Infrastructure.


## Reference
```dotnet add reference ..\Infrastructure\Infrastructure.csproj```