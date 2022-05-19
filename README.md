# JogoDaForca

![Animation](https://user-images.githubusercontent.com/86261289/169260648-b0929473-fd6f-4110-a09e-4101bc331236.gif)

Objetivo: usando uma aplicação do tipo consola, criar um jogo da forca que irá ler uma lista de nomes de filmes, nomes de jogos e o países. Com essa aplicação poderá melhorar os seus conhecimentos sobre manipulação de strings e leitura e escrita de ficheiro.

Novos conceitos ou funcionalidades desse exercício
Gravação e leitura de ficheiros para armazenar os nomes de filmes, carros e países.

Requisitos da aplicação
Ao abrir a aplicação o sistema deverá sortear aleatoriamente uma das 3 categorias: filmes, jogos ou países e, após isso, sortear um dos nomes da categoria selecionada.

Após a seleção feita pelo sistema, exiba no ecrã a quantidade de tentativas disponíveis e quantas tentativas já foram realizadas. Mostre também uma lista com as letras e números já utilizados pelo jogador.

Mostre na consola também, a categoria sorteada e a quantidade de letras da palavra. Além da quantidade de letras, inicialmente todas as letras da palavra devem ser substituídas por underline (_). Exemplo:

Se a palavra for o filme Matrix, deverá ser exibido 6 underline no lugar da palavra.
Ao acertar a letra A, deverá ser exibido apenas a letra a na posição correta.
As palavras devem ficar armazenadas num arquivo de texto do tipo CSV que terá a palavra seguido pela categoria, onde Filme = 0, Jogo = 1, e Pais = 2. Segue um exemplo de como cada tipo deve ficar no arquivo:

Matrix;0;
Batman;1;
Brasil;2;
A cada tentativa mostre as pontuações.

Caso o jogador chegue a 0 número de tentativas exiba a mensagem "Fim de jogo, perdeu!".

Caso o jogador acerte todas as letras, exiba a mensagem "Fim de jogo, ganhou!".

Utilize Enumeradores para a categoria
Desafios
Crie mais uma categoria para o jogo
Adicione o sistema de controlo de versões git ao projeto e submeta o seu projeto no github

Antes de iniciar o jogo dê a opção de o utilizador escolher a dificuldade do jogo: fácil, normal ou difícil:
Fácil: 7 tentativas
Normal: 6 tentativas
Difícil: 5 tentativas
