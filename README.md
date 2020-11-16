# InvilliaEmprestimoDeJogos
Este projeto tem por objetivo permitir o controle de jogos emprestados a amigos. As principais tecnologias utilizadas são .NET Core, Webapi, EntityFrameworkCore, e etc. O modelo de desenvolvimento utilizado é o DDD, incluindo alguns padrões de projetos para auxiliar a modelagem DDD.

# Notas 
- Inclusão de JWT
- testando campos https://jwt.io/
- Estender o padrao repository para lidar com JWT (e.g. por email)
- Adicionar no projeto Domain - <PackageReference Include="System.IdentityModel.Tokens.Jwt" Version="6.8.0" />

- test Postman Header e no "Authorize" do swagger.
- Efetuar login, depois utilizar o token gerado
Key: Authorization 
Value: Bearer <token gerado no login>

-- Melhorando a estrutura do projeto (também a fim de realizar uma personalização na apresentação da troca de objetos), com relação ao retorno de objetos, includindo Dto com AutoMapper


-- Camadas de teste de unidades implementada. Ainda falta a camada de teste de integração.  Caso dê tempo até o prazo, eu tento incluir uma camada de teste de integração.


-- Falta implementar 2 GetBy para modelo EmprestimoJogo
