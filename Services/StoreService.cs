using AppShoppingCenter.Models;
using AppShoppingCenter.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AppShoppingCenter.Services;
    public class StoreService
    {
        public List<Establishment> GetStores()
        {
            return MockStoreService.GetStore();
        }
    }

public class MockStoreService
{
    public static List<Establishment> GetStore()
    {
        return new List<Establishment>
        {
            new Establishment
            {
                Id = 1,
                Name = "Youcom",
                Description = "Marca brasileira de moda focada no público jovem, conhecida pelo seu estilo urbano e descontraído.",
                Localization = "1º Piso, Loja 12 - Setor Norte",
                Phone = "(84) 99999-9999",
                Type = EstablishmentType.Store,

                Logo = "https://elephant-file-storage.nyc3.digitaloceanspaces.com/public/images/mos/700672___y0JTROy5yR7QhUNHOuF8u.png",
                Cover = "https://shoppingestacao.com.br/wp-content/uploads/2024/03/Youcom-560x396.png"
            },

            new Establishment
            {
                Id = 2,
                Name = "Any Any",
                Description = "Há 27 anos, a Any Any inspira-se nos momentos simples e significativos, que se transformam nas memórias mais deliciosas da vida. Nossa inspiração vem de um acordar mais leve, de um sorriso bobo ao ver os primeiros raios do dia nascer, de uma noite vibrante e de muitas risadas até o amanhecer.",
                Localization = "1 Piso, Loja 02 - Setor Norte",
                Phone = "(61) 3154-1234",
                Type = EstablishmentType.Store,

                Logo = "https://gsobmidia.com.br/uploads/lojas/1587/any-any_1607606261.png",
                Cover = "https://th.bing.com/th/id/R.3e7fcd5a62c507e0fe520211dc4da74e?rik=EVnAQuH8VECIyQ&riu=http%3a%2f%2f3.bp.blogspot.com%2f-OINRmqrcATk%2fVSepgubwKfI%2fAAAAAAAAL8Q%2fg_kjz4q1Owc%2fs1600%2fany_any_franquia.jpg&ehk=4BVqFRPzznt5pjxTpqgmiaXrWVjyv7uHZqsHG8OeMZk%3d&risl=&pid=ImgRaw&r=0"
            },

            new Establishment
            {
                Id = 3,
                Name = "BadBoy",
                Description = "Bad Boy é uma marca alternativa americana de esportes e estilo de vida. É notável por sua presença tanto na moda como em equipamentos esportivos.",
                Localization = "1 Piso, Loja 03 - Setor Norte",
                Phone = "(61) 3154-1563",
                Type = EstablishmentType.Store,

                Logo = "https://w7.pngwing.com/pngs/1022/751/png-transparent-badboy-hd-logo.png",
                Cover = "https://badboybrasilia.com.br/imagens/produtos/lojas/taguatinga_maior.JPG"
            },

            new Establishment
            {
                Id = 4,
                Name = "BioMundo",
                Description = "Fundada por Edmar Mothé, que possui mais de 40 anos de experiência no varejo, a Rede de lojas Bio Mundo opera no segmento de produtos naturais e está presente em 17 estados brasileiros. A empresa promove saúde e bem estar oferecendo o mix de produtos mais completo do Brasil, incluindo produtos diet, light, integrais, veganos, funcionais, sem glúten, sem lactose e suplementos vitamínicos e esportivos.",
                Localization = "1 Piso, Loja 04 - Setor Norte",
                Phone = "(61) 3154-5594",
                Type = EstablishmentType.Store,

                Logo = "https://biomundo.com.br/wp-content/uploads/2022/07/Bio1.png",
                Cover = "https://viventeandante.com/wp-content/uploads/2023/03/biomundo-em-macae.jpg"
            },

            new Establishment
            {
                Id = 5,
                Name = "Brossman",
                Description = "Luxo e sofisticação são encontrados na loja Brossman, que tem como carro chefe a marca Dudalina. Contamos com diversas opções em roupas sociais para homens.",
                Localization = "1 Piso, Loja 05 - Setor Norte",
                Phone = "(61) 3154-4153",
                Type = EstablishmentType.Store,

                Logo = "https://brossman.com.br/wp-content/uploads/2021/10/cropped-dg-coin-brossman-1.png",
                Cover = "https://photos.wikimapia.org/p/00/02/58/51/10_big.jpg"
            },

            new Establishment
            {
                Id = 6,
                Name = "C&A",
                Description = "C&A é uma cadeia internacional de lojas de vestuário, fundada nos Países Baixos em 1841 pelos irmãos Clemens e August como uma empresa têxtil. No Brasil, é uma das maiores redes de lojas de departamento do país e a décima segunda maior empresa varejista, segundo ranking do Ibevar de 2012.",
                Localization = "1 Piso, Loja 06,07,08 - Setor Norte",
                Phone = "(61) 3154-1355",
                Type = EstablishmentType.Store,

                Logo = "https://img.offers-cdn.net/assets/uploads/stores/br/logos/200x72/c-a-61597689b7d5d.png",
                Cover = "https://ecommercedesucesso.com.br/wp-content/uploads/2021/08/ca-1-1024x683.png"
            },

            new Establishment
            {
                Id = 7,
                Name = "Camicado",
                Description = "Na Camicado você encontra diversas opções itens de decoração, eletro, cozinha, cama, mesa e banho, churrasco. E também pode criar a sua lista de presentes.",
                Localization = "1 Piso, Loja 11, 12- Setor Norte",
                Phone = "(61) 3679-2395",
                Type = EstablishmentType.Store,

                Logo = "https://4.bp.blogspot.com/-mXqmy1EuwsY/VydkyZu1wJI/AAAAAAAAKhM/ejPQD8J1DeIMqXFM3vcN3Zs5N5dKVLc9ACLcB/w1200-h630-p-k-no-nu/cami.jpg",
                Cover = "https://catracalivre.com.br/wp-content/uploads/2020/06/camicado-loja.jpg"
            },

            new Establishment
            {
                Id = 8,
                Name = "Casas Bahia",
                Description = "Casas Bahia é uma popular rede de varejo de móveis e eletrodomésticos do Brasil. Foi fundada em 1952, em São Caetano do Sul, São Paulo, onde se localiza a matriz, pelo imigrante polonês Samuel Klein.",
                Localization = "2 Piso, Loja 10 - 16- Setor Norte",
                Phone = "(61) 3679-153",
                Type = EstablishmentType.Store,

                Logo = "https://cuponomia-a.akamaihd.net/img/stores/original/casas-bahia-637628912275644345.png",
                Cover = "https://s2.glbimg.com/XO8XarHm4uZKPbyxNFpyE8JZlW0=/0x89:2048x1357/984x0/smart/filters:strip_icc()/i.s3.glbimg.com/v1/AUTH_63b422c2caee4269b8b34177e8876b93/internal_photos/bs/2019/9/U/vyuTqHROC6j9Q6k7wRbg/19158185353-556b98ef7e-k.jpg"
            },

            new Establishment()
            {
                Id = 9,
                Name = "Renner",
                Description = "A Lojas Renner S.A. é uma rede de lojas de departamento brasileira.",
                Localization = "2 Andar - Loja 10/11/12/13/14 - Entrada Norte",
                Phone = "(61) 3333-3333",
                Type = EstablishmentType.Store,

                Logo = "https://d1yjjnpx0p53s8.cloudfront.net/styles/logo-thumbnail/s3/122012/renner_0.png?itok=VvGKSsDe",
                Cover = "https://th.bing.com/th/id/OIP.Xge9v8IC43h0iborL-k5rwHaEM?pid=ImgDet&rs=1",
            },

            new Establishment()
            {
                Id = 10,
                Name = "Samsung",
                Description = "Agora, você tem mais uma opção para experimentar e conhecer os produtos Samsung, antes de tomar a sua decisão de compra. Isso porque, nas Lojas Samsung, você pode manusear celulares, tablets, câmeras, smartphones e notebooks livremente, e ainda conta com consultoria e atendimento de vendedores especializados. A experiência de compra de equipamentos tecnológicos deixa de ser impessoal e ganha um caráter mais assertivo e direcionado ao seu verdadeiro desejo.",
                Localization = "2 Andar - Loja 01/02 - Entrada Norte",
                Phone = "(61) 3475-2650",
                Type = EstablishmentType.Store,

                Logo = "https://d1yjjnpx0p53s8.cloudfront.net/styles/logo-thumbnail/s3/052012/samsung.png?itok=Mq0egkoi",
                Cover = "https://th.bing.com/th/id/OIP.kC06IAxn8ES8p7nzooX6tgHaFj?pid=ImgDet&rs=1",
            },

            new Establishment()
            {
                Id = 11,
                Name = "Chilli Beans",
                Description = "A maior rede brasileira de óculos escuros e acessórios”. Essa definição resume a Chilli Beans: provocativa, ardente e envolvente. É a marca da pimenta. Uma marca que, toda semana, lança novos óculos, novos relógios e novas possibilidades. Ou seja, novas formas de compor seu visual. Com mais de 580 pontos de venda exclusivos no Brasil, Estados Unidos, Portugal, Peru, Colômbia e Kuwait, a Chilli Beans é uma marca diversificada, com uma linha de produtos que inclui, além dos óculos escuros e relógios, armações de óculos de grau e lentes em pontos de vendas exclusivos. Além disso, a marca está por trás de um mundo de ações de patrocínio de festas, shows, esportes e ações sociais",
                Localization = "2 Andar - Loja 03 - Entrada Norte",
                Phone = "(61) 3475-2744",
                Type = EstablishmentType.Store,

                Logo = "https://d1yjjnpx0p53s8.cloudfront.net/styles/logo-thumbnail/s3/052016/logo_chilli_beans_1c.png?itok=w_B1Ywks",
                Cover = "https://mercadoeconsumo.com.br/wp-content/uploads/2020/10/C5D_9838.jpg"
            }
        };
    }
}

