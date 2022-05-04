## 2020-08-21
Boa noite Professor Dalton!
Sou Leonardo Rovigo do BCC-Noturno estou tendo a matéria de TCC-1 e gostaria de fazer algum TCC na área de computação gráfica ou realidade virtual, porém ainda não tenho uma ideia, queria saber se o professor tem alguma sugestão de ideia e talvez ser o meu orientador.
Atenciosamente, Leonardo Rovigo.

----------
## 2020-08-25
Assunto: Química / tabela periódica -> http://dsc.inf.furb.br/arquivos/tccs/monografias/2015_2_arthur-henrique-eggert_monografia.pdf
Área:
  Realidade Aumentada: http://dsc.inf.furb.br/arquivos/tccs/monografias/2017_1_evandro-matheus_monografia.pdf
  Ilusões de Ótica: artigo - https://furb-my.sharepoint.com/:w:/g/personal/dalton_furb_br/EQJAVe_bkLpCnk3H5NGzN-4BYFyPDceR5X5jkvB685Vmeg?e=Lfnisx
Jogos SuperLiminal
 
Video juntar marcadores H2O -> turma de DPM
Unity.

----------
## 2021-03-03
### TCC2: importe assistir
Pílares:
- Química
- Realidade Aumentada
- Ilusão Ótica

### Está fazendo:

#### Unity - persistência: SQLite - C# -> serializar .. link
  https://www.codejourney.net/2017/05/sqlite-net-extensions-one-to-one-relationships/<br>
  https://www.codejourney.net/2017/05/sqlite-net-extensions-one-to-many-relationships/

#### Diagramação
  MER (Modelo Entidade Relacionamento)
  Diagrama de Classe

#### Modelagem
Modelo no Blender -> molécula
http://dsc.inf.furb.br/arquivos/tccs/monografias/2015_2_arthur-henrique-eggert_monografia.pdf

### Especialista
- Dalton agendar com alguem da química
- Testes 
----------
## 2021-03-10
Fez testes na implementação com a parte de persistência no Unity.

#### Oculos Quest
O orientando adquiriu o Oculus Quest (valor no Brasil comprado pela impotação da Amazon, 3.400,00).
Assim desidimos em mudar a parte de Realidade Aumentada (RA) do projeto para Realidade Imerssiva. 
O resto se mantén, mas agora em vez de expecionar o mundo RV usando um smatphone em volta do objeto 
virtual para RA, o usuário vai estar imerso no mundo virtual e interagir com os atuadores do Quest.

Decidimos adiar a conversar com o especialista em Química para ter algo a ser mostrado.

----------
## 2021-03-17
Desmarquei a reunião, não estva me sentindo bem...

##### Resposta do orietnando sobre andamento do TCC
Boa noite Professor!
Sem problemas, a reunião pode ser só semana que vem mesmo.
 
O que eu fiz: 
Essa semana eu dei uma olhada em como fazer a construção e o deploy para o Oculus quest 2, criando uma conta e habilitando o modo de desenvolvedor do oculus também achei um asset gratuito do unity chamado "Oculus Integrations" que vem com alguns exemplos, já consegui dar deploy nesses exemplos.
 
O que vou fazer:
Vou começar a criar uma cena no unity com uma daquelas moléculas criadas anteriormente pra ver como funciona a manipulação dos objetos.

----------
## 2021-03-24
Já tem uma cena com molecula usando a mão. Usa os controles do Quest para mover as mãos, e o botão para segurar com o dedo.<br>
Os botões parecem ter um sensor de proximidade, pois antes de pressionar o botão já preve o movimento.<br>
Vídeo:

----------
## 2021-03-31
Tem um ginásio com várias mesas e um quadro, onde aparece a tabela períodica. Clicando no elemento da tabela períodica abre um painel lateral onde deve mostrar algumas moléculas que usam aquele elemento selecionado.<br>
Já mostra um "despejo" de moléculas na mesa....<br>
![2020-03-31 cena](2020-03-31_cena.png "2020-03-31 cena")<br>
Vamos marcar uma reunião com especialista da Química.<br>
Vai gravar um video, ter projeto, video daquele da quimica dos marcadores, e ter um video anamorfose (SuperLiminal).<br>

OBS Studio: software para edição de videos gratuito.

----------
## 2021-04-07
Anamorfose: video, vai postar no GitHub.

Vai fazer mais botões na tabela períodica.<br>
Sugerir tentar sair da "caixa" .. do uso tradicional de interface.<br>
Explorar algo do tipo que foi feito com o LeapMotion Cat Explore: https://www.youtube.com/watch?v=WwHrXwGyMt8<br>

----------
## 2021-03-14
Trabalhou no modelo gráfico da tabela periócadica.<br>
Mudou de vertical para cima da mesa.<br>

Trabalhou no modelo gráfico da tabela periódica.

[Video da aplicação desenvolvida](tcc_LeonardoRovigo_2021-03-25_video.mp4)

----------
## 2021-04-20

Das 17:00~18:00 fizemos uma reunião com a profa. Arlei (química).<br>
Ver: [Vídeo da Reunião](https://furb-my.sharepoint.com/:v:/g/personal/dalton_furb_br/EYeB5upQ6wZHreyna7W0zvMBz4qmSlUc_eb7oYWIXVavYQ)<br>
Em resumo a profa. acho a ideia interessante e gostou de já estarmos tratando que as moléculas devem respeitar um certo ângulo nas conexões. Também frisou a importância de usar um espaço 3D, porque a informação é 3D. Da possíbildade de ir do espaço micro para o macro.<br>
Coletamos algumas ideias e ficamos de marcar uma nova reunião.<br>

As 22:15 fizemos uma reunião só orientador e orientando para definir o que faríamos com o que produzimos na reunião anteior.<br>
Ficou __ O Leonardo vai tentar fazer a "mesa 1 e 2".<br>
Ver: [Video da Reunião](https://furb-my.sharepoint.com/:v:/g/personal/dalton_furb_br/Ebigv6bKO9hEhZbh-4mW-HIB2DsPn1bESobn25fLa-02_g)<br>

__ Resumo __
Cena -> Estações<br>
Estações (fases)<br>
    interações (IT)<br>
        realçar um elemento da tabela<br>
        projetor (largar uma ficha perto projeta maior as informações)<br>
        selecionar uma molécula de um cjto de moléculas<br>

Cada mesa pode ter um nome<br>
    cada mesa pode ter um BBox<br>

H2O Instrucional<br>
1 mesa) apresentar um sub-conjunto da tabela periódica<br>
      tabela mesa 3D<br>
        pegar os elementos da tabela (IT)<br>
           -> Hidrogênio<br>
             colocar mão painel inf.<br>
                O que pode fazer com H<br>
                    Água (ficha) instruções<br>
            
.. sair para o lado da mesa<br>

2 mesa) fazer atividade<br>
   largar a ficha na mesa e seguir instruções<br>
     quando ficha na mesa poderia projetar num banner atrás da mesa as instruções (IT)<br>
        montar molécula: ter na mesa um conjunto de moléculas diferentes (uma certa) que podem ser selecionar qual seria a certa<br>

------
3 mesa) validar a resposta usando anamáforse<br>

------
4 mesa) Transição do espaço microscópico -> macroscópio: produto (água)<br>
 .. um equipamento com uma esteira no meio e de um lado entra o micro e do outro sai o macro
 
----------

## 2021-05-12

- revisão geral
- tentar colocar um Bias na anamoforse (quase no angulo certo ele juntar as partes cortas)
- diminuir espaço da sala de deixar ela mais próximo

[Video da aplicação desenvolvida](tcc_LeonardoRovigo_2021-05-12_video.mp4)

## 2021-05-19

O Leonardo apresentou o que produziu para o profa. Arleide mostrando um video.
[Video da reunião](<https://furb-my.sharepoint.com/:v:/g/personal/dalton_furb_br/EVUrsH-1ia5CoBPyOYNyUHkBxvvaCdCg1HbavY-TIvQSFQ>)

### Anotações Dalton
Placas nomeando as estações
Níveis de compreensão do conhecimento químico: triângulo de Johnstone
  Macroscópio -> evidência que existe a água
  Microscópio ->
  Representacional escrever o H2O

Objeto Educacional

Fundamentar ana seção do capítulo 2
  Se usa para ensinar as etapas de cima
E explicar que uso estes conhecimentos na explicação que definiu as estação

Dúvida: quando ele encontra a molécula na Anamorfose tem algum retorno para o usuário.
Acho que a cada estação deveria ter uma entrada x processo

Terminar o tutorial para usar o CC

### 2021-05-26

Comentei sobre o artigo de forma geral ... passei o artigo do RodrigoWenkePereira  
Agendar testes para terça (08/06)
Vai trocar código com o GabrielSalvador
