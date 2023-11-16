Aplicação de Consulta de Músicas

Este é um projeto em C# que utiliza a biblioteca HttpClient para consultar uma API de músicas e realizar algumas operações.

No código temos algumas funções como:

1. **Exibir detalhes de todas as músicas:**
   - Faz uma requisição à API de músicas e exibe os detalhes de cada música.

2. **Exibir gêneros musicais distintos:**
   - Utiliza LINQ para identificar os gêneros musicais únicos na lista de músicas.

3. **Exibir artistas distintos:**
   - Utiliza LINQ para identificar os artistas únicos na lista de músicas.

4. **Exibir artistas ordenados:**
   - Utiliza LINQ para ordenar os artistas alfabeticamente e os exibe.

5. **Filtrar músicas por estilo musical:**
   - Filtra as músicas de acordo com um estilo musical específico.

6. **Adiciona uma música à lista de músicas favoritas.**
7. **Exibe no console as músicas favoritas, incluindo o nome do usuário.**
8. **Gera um arquivo JSON com o nome do usuário e a lista de músicas favoritas. O arquivo é salvo localmente, e o caminho é exibido no console.**
9. **Utiliza LINQ para filtrar de acordo com a tonalidade.**
   
Ponto interessante: O arquivo Json poderá ser selecionado no site: https://screen-sound.vercel.app/#content e ele irá exibir a sua lista de músicas favoritas

![image](https://github.com/LLucasLira/API_Musicas/assets/84140628/dbb929bf-8381-4ae1-9ca6-cfdba2d3d3b2)

![image](https://github.com/LLucasLira/API_Musicas/assets/84140628/f8cbd5af-c4e2-4e7a-bb88-bc652ae2bda2)

Além disso, o código faz uso da anotação "JsonPropertyName" para mapear os nomes das propriedades nos objetos JSON para os nomes das propriedades no código C#. Isso é especialmente útil quando os nomes das propriedades no JSON diferem dos nomes que você gostaria de usar em seu código.

No geral, o uso do LINQ no C# oferece uma sintaxe elegante e eficaz para consultas e manipulação de dados, tornando o código mais legível, conciso e fácil de manter.
