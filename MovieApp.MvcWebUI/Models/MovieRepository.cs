using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.MvcWebUI.Models
{
    public static class MovieRepository
    {
        private static List<Movie> movies = null;
        static MovieRepository()
        {
            movies = new List<Movie>()
            {
                new Movie(){Id=1,Name="Joe (2013)", IMDb="https://www.imdb.com/title/tt2382396/",Image="1.jpeg",Description="Texas'ın küçük bir kasabasında geçen hikayede, geçmişini unutmaya çalışan ve gündüzleri koruda çalışıp akşamları içen Joe Ronsom'ın yolu, ailesinin içinde bulunduğu kaos ortamını sonlandırmak için yollara düşen 15 yaşında Gary ile kesişiyor. Gary ailesini geçindirebilmek için iş ararken Joe Ransom ile karşılaşır ve ikisinin de hayatı beklemedikleri şekilde değişir. Joe geçmişte işlediği suçlardan arınmanın ve tüm hatalarını telafi etmenin yolunu ararken, Gary, henüz tanımadığı Joe'yu koşulsuzca önemsemeye ve rol model olarak görmeye başlar. Joe ise hayatında ilk kez birisi için önemli olabileceğini düşünür ve Gary'yi kanatları altına alır. /n/nAmerikan bağımsız sinemasının öne çıkan isimlerinden David Gordon Green'in yönettiği filmin başrollerini Nicolas Cage, Tye Sheridan ve Ronnie Gene Blevins paylaşıyor.", CategoryId=1},
                new Movie(){Id=2,Name="About Schmidt (2002)", IMDb="https://www.imdb.com/title/tt0257360/",Image="2.jpeg",Description="Hayatı, ailesi ve işiyle meşgulken herhangi bir sorun yaşamayan Schmidt, emekliliğinin ardından karısını kaybetmesiyle tepetaklak olur. Üstelik kızı da, uygun olmayan bir adamla evlenme planları yapmaktadır. Geniş bir arazide bir uçan dairenin açtığı kocaman bir boşluğa benzeyen yaşamına bir anlam katmak isteyen orta yaşlı adamımız; hem kendi yaşamını gözden geçirmek, hem de kızının yapmak üzere olduğu hatayı engellemek üzere bir yolculuğa çıkar.Senarist kimliğiyle tanıdığımız yönetmen Alexander Payne’den bol ödüllü bir yapım. Özellikle senaryonun ve oyunculukların bir hayli övgü topladığı filmde, Jack Nicholson eski unutulmaz performanslarını bile aşıyor.", CategoryId=1},
                new Movie(){Id=3,Name="Geleceğe Dönüş (1985)", IMDb="https://www.imdb.com/title/tt0088763/",Image="3.jpeg",Description="Zamana yaptığı bu histerik ve sürprizlerle dolu yolculuğu sırasında Marty'nin geleceğe dönebilmek için garantilemek zorunda olduğu çok önemli bir şey vardır. O da gelecekte bıraktığı anne ve babasını tanıştırıp, bir şekilde birbirlerine aşık olmalarını sağlamaktır.", CategoryId=2},
                new Movie(){Id=4,Name="The Terminator (1984)", IMDb="https://www.imdb.com/title/tt0088247/",Image="4.jpeg",Description="2029 yılının kıyamet sonrası Los Angeles'ında Skynet adlı yapay zeka ürünü bilgisayar sistemi 1990'larda büyük bölümünü yok ettiği insan ırkının kurtulmayı başaran direnişçilerine karşı savaşmaktadır. Direnişçiler Skynet'e karşı başarıya ulaşmadan hemen  önce Skynet savaşçı Terminatör'lerinden birine zamanda yolculuk yaptırarak onu geçmişe göndermeyi başarır. Terminatör'ün görevi direnişçilerin başı olan John Connor'ın annesi Sarah Connor'ı öldürmektir...", CategoryId=2},
                new Movie(){Id=5,Name="Star Trek (2009)", IMDb="https://www.imdb.com/title/tt0796366/",Image="5.jpeg",Description="Galaksinin kaderi birbirinden çok uzaklarda doğmuş iki sıkı rakibin elindedir. Bir tarafta Iowa’daki çiftlikte doğup büyümüş, serseri ruhlu, heyecan ve macera arayan genç James Tiberius Kirk vardır. Diğer tarafta ise Vulcan gezegeninde büyümüş olan ve yarı-insan öz geçmişi nedeniyle kendi toplumunca dışlandığını hisseden, Starfleet Akademi’ye Vulcan ırkından kabul edilen ilk öğrenci olan Spock yer alır.", CategoryId=2},
                new Movie(){Id=6,Name="A Nightmare on Elm Street", IMDb="https://www.imdb.com/title/tt0087800/",Image="6.jpeg",Description="Korku sinemasının en uğursuz antikahramanı Freddy yine ergen gençlere kabuslar yaratmakla meşgul. Tabi sadece bu kabusları görmelerini sağlamıyor, bizzat rüyalarının içine girerek meşhur penceleriyle onlara hadlerini bildiriyor. Çünkü kendisi de 'muhafazakar ailelerin bir kurbanıdır' ve bilinç altında onları suçlamakta, temiz aile çocuklarını katlederek intikamını almaktadır. Freddy Krueger karakterini Watchmen'de Rorshach karakterini oynayan Jackie Earle Haley canlandırıyor. Filmin yönetmen koltuğunda ise Samuel Bayer oturmaktadır.", CategoryId=3},
                new Movie(){Id=7,Name="Red Dragon", IMDb="https://www.imdb.com/title/tt0289765/",Image="7.jpeg",Description="Will Graham işinde oldukça yorulmuş olan bir adamdır. Onca yılın üstüne artık üzerinden bir kamyon geçmiş gibi hissetmektedir ve FBI'dan emekli olmak için hazırlanmaktadır. Ancak şehirde terör estiren bir canavarın varlığı üzerine görevine yeniden çağrılır. Asıl adı Francis Dollarhyde olan bu caninin lakabı Kızıl Ejderha'dır. Sıradaki hedefi ise Reba isimli genç bir kız olacaktır. Will Graham, gerekirse Hannibal Lecter gibi eski bir düşmanın desteğini dahi alarak bu suçluyu yakalamaya kararlıdır.", CategoryId=3},
                new Movie(){Id=8,Name="Casablanca (1942)", IMDb="https://www.imdb.com/title/tt0034583/",Image="8.jpeg",Description="İkinci Dünya Savaşı zamanları, büyük romantizm ve sonsuz nüktelerle dolu bir film. Ayrıca film İkinci Dünya Savaşı'ndan önce vizyona girdi.", CategoryId=4},
                new Movie(){Id=9,Name="Eternal Sunshine Of The Spotless Mind", IMDb="https://www.imdb.com/title/tt0338013/",Image="9.jpeg",Description="Adı efsane çevirilerden biri olan bu filmde, Jim Carrey sizi yanıltmasın. Film bir sürü garipliklerle, insani değerlerle ve aşkla dolu. Ufak bir uyarı, eğer romantik komedi arıyorsanız bunu es geçebilirsiniz.", CategoryId=4}
            };


        }


        public static List<Movie> Movies
        {
            get { return movies; }
        }

        public static void AddMovie(Movie movie)
        {
            movies.Add(movie);
        }

        public static Movie GetById(int id)
        {
            return movies.FirstOrDefault(i => i.Id == id);
        }

    }
}
