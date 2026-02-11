using AppShoppingCenter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppShoppingCenter.Services
{
    public class CinemaService
    {
        public List<Movie> GetMovies()
        {
            return MockCinemaService.GetMovies();
        }
    }

    public class MockCinemaService
    {
        public static List<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie
                {
                    Id = 1,
                    Name = "Paris, Texas",
                    Description = "Paris, Texas conta a história de Travis, um homem que, depois de estar desaparecido por mais de quatro anos, é reencontrado pelo irmão Walt num hospital na região desértica do Texas, próximo à fronteira com o México. Maltrapilho e com amnésia, é levado por Walt para a sua casa em Los Angeles, onde reencontra Hunter, seu filho de sete anos que foi abandonado pela mãe, Jane. Inicialmente estranhos, Travis e Hunter iniciam uma reaproximação que culmina numa grande amizade e também no desejo secreto de reencontrar Jane e reconstruir sua verdadeira família.",
                    Duration = new TimeOnly(2, 25, 0),

                    Cover = "https://m.media-amazon.com/images/I/81TmZEWKJ4L.jpg",
                    Trailer = "https://youtu.be/Lye-WhiwhVA?si=kGEYiF41XmXvpYtc"

                },
                new Movie
                {
                    Id = 2,
                    Name = "Monster",
                    Description = "Monster é um filme japonês de drama e suspense dirigido por Kore-eda Hirokazu (Assuntos de Família, Ninguém Pode Saber). A história mostra o drama de Saori (Sakura Ando), uma mãe desconfiada dos comportamentos estranhos que seu filho começou a apresentar recentemente e, ao que tudo indica, sem nenhuma explicação. Porém, logo Saori descobre que a situação é culpa de um professor que dá aulas na escola de seu filho, e ela decide ir até o local para saber o que está acontecendo. Enquanto acompanhamos o desenrolar desse mistério partindo do ponto de vista da mãe, do filho e do professor, a verdade vai, pouco a pouco, começando a surgir.",
                    Duration = new TimeOnly(2, 06, 0),

                    Cover = "https://image.tmdb.org/t/p/original/h32DXMRq3dy7EQHqkCtKPJoQ604.jpg",
                    Trailer = "https://youtu.be/cOpWDxxiwoE?si=hK3Z08_MOMDtdQIG"
                },
                new Movie
                {
                    Id = 3,
                    Name = "Central do Brasil",
                    Description = "Dora escreve cartas para analfabetos na famosa estação de trem no Rio de Janeiro e decide ajudar um menino de nove anos a encontrar o pai.",
                    Duration = new TimeOnly(1, 50, 0),

                    Cover = "https://m.media-amazon.com/images/M/MV5BMWI3YTg2YmItY2QzYi00NTc2LWExNTQtYWE4ZmIzNjE3ZjMyXkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg",
                    Trailer = "https://youtu.be/JSWgOhRjJmo?si=a5ik_zQ9zH0ZOt_k"
                },

                new Movie
                {
                    Id = 4,
                    Name = "O Labirinto do Fauno",
                    Description = "O Labirinto do Fauno é uma fábula sombria de Guillermo del Toro ambientada na Espanha de 1944, onde a jovem Ofélia, cercada pela brutalidade da guerra, descobre um mundo mágico repleto de desafios para reivindicar um destino perdido. O filme se destaca pela união de fantasia e drama histórico, visual exuberante, trilha envolvente e interpretações marcantes, sendo amplamente aclamado e recomendado a quem aprecia obras poéticas e impactantes.",
                    Duration = new TimeOnly(2, 00, 0),

                    Cover = "https://leiturafilmica.com.br/wp-content/uploads/2024/12/o-labirinto-do-fauno-poster.jpg",
                    Trailer = "https://youtu.be/jVZRnnVSQ8k?si=niFpfo6WwKdrrEXd"
                }
            };
        }
    }
}
 