using System.Linq;
using Microsoft.EntityFrameworkCore;
using shopapp.entity;

namespace shopapp.data.Concrete.EfCore
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            var context = new ShopContext();
            if (context.Database.GetPendingMigrations().Count()==0)
            {
                if (context.Kategoriler.Count()==0)
                {
                    context.Kategoriler.AddRange(Kategoriler);
                }
            

                if (context.Filmler.Count()==0)
                {
                    context.Filmler.AddRange(Filmler);
                    context.AddRange(FilmKategoriler);
                    
                   
                }

                if (context.Stars.Count() == 0)
                {
                    context.Stars.AddRange(Stars);
                }

                if (context.Comments.Count() == 0)
                {
                    context.Comments.AddRange(Comments);
                }

             
            }

            context.SaveChanges();
        }

        private static Kategori[] Kategoriler = {
            new Kategori(){Name = "Macera", Url ="macera"},
            new Kategori(){Name = "Aksiyon", Url ="aksiyon"},
            new Kategori(){Name = "Romantik", Url ="romantik"},
            new Kategori(){Name = "Bilim Kurgu", Url ="bilim-kurgu"},
        };

        private static Film[] Filmler = {
            new Film(){Name = "Harry Potter",Url ="harry",Sene = 2003,Description = "Harry Potter, İngiliz yazar J. K. Rowling tarafından yazılan yedi fantastik romandan oluşan seri. Romanlar, Hogwarts Cadılık ve Büyücülük Okulu'nda eğitim gören genç büyücü Harry Potter ile arkadaşları Hermione Granger ve Ron Weasley'nin yaşamlarını konu alır.", ResimUrl = "harry.jpg",Gosterim =true,AnasayfaGosterim = true},
            new Film(){Name = "96 Saat",Url ="96",Sene = 2008,Description = "96 Saat (İngilizce özgün ad: Taken), 2008 yapımı bir aksiyon filmi. ... Filmin konusu, Paris'te Arnavut bir fuhuş çetesi tarafından kaçırılan bir Amerikalı kız ve onu kurtarmaya çalışan eski ajan babası hakkındadır. Filmin büyük bir kısmı Paris'te çekilmiştir.", ResimUrl = "96saat.jpg",Gosterim =true,AnasayfaGosterim = false},
            new Film(){Name = "Bay & Bayan Smith",Url ="bay",Sene = 2005,Description = "Konusu. Sıradan bir evlilik yaşayan John ve Jane Smith'in hayatları gün geçtikçe daha sıkıcı bir hal almaktadır. Hayatlarındaki monotonluğu bozan tek şey; birbirlerine söyledikleri yalanlardır. Çift, aslında, birbirine rakip iki organizasyona tetikçi olarak çalışmaktadır.", ResimUrl = "bayvebayan.jpg",Gosterim =true,AnasayfaGosterim = false},
            new Film(){Name = "Journey to the Center of the Earth ",Url ="dunyanın",Sene = 2009,Description = "Film, maceraperest bir bilim adamı olan amcası (Fraser) ile, İzlanda'ya giden Sean (Hutcherson), burada onlara rehberlik eden Hannah'nın (Briem), tesadüfen gizli güzellikler ve tehlikelerle dolu bambaşka bir dünya keşfetmelerini konu alıyor.", ResimUrl = "dunyaninmerkezine.jpg",Gosterim =true,AnasayfaGosterim = false},
            new Film(){Name = "The Shawshank Redemption",Url ="esaret",Sene = 1998,Description = "Stephen King'in Rita Hayworth ve Shawshank'in Kefareti adlı novellasından uyarlanan film, masumiyetini iddia etmesine rağmen karısını ve sevgilisini öldürdüğü gerekçesiyle Shawshank Devlet Cezaevi'nde yaklaşık 20 yılını geçiren bankacı Andy Dufresne'in hikâyesini anlatır.", ResimUrl = "esaret.jpg",Gosterim =true,AnasayfaGosterim = true},
            new Film(){Name = "Forrest Gump",Url ="forrest",Sene = 1999,Description = "Forrest Gump, düşük I.Q. sahibi genç bir adamdır. Jenny ile tanıştığında ona aşık olur. Gump aralarında Elvis Presley, Kennedy, Nixon'ın da olduğu tarihsel kişilerle kaza eseri tanışır ve 50'lerden 70'lerin sonuna kadar gelen bir süre zarfında olaylar gelişir.", ResimUrl = "forrest.jpg",Gosterim =true,AnasayfaGosterim = true},
            new Film(){Name = "First Love",Url ="ilk",Sene = 2014,Description = "Bryce ve Julie ikinci sınıfta tanışmıştır. Küçük Juli, Bryce'ın hayatına girmesi ile ilk aşkını da tatmış olur. Ancak durum Bryce için aynı değildir. Kızlardan korkan, utangaç ve sıkılgan Bryce, her ne kadar Juli'yi kaybetmek istemese de, kızın ısrarı ve hayır cevabını kabul etmemesi canını sıkmaktadır.", ResimUrl = "ilkask.jpg",Gosterim =true,AnasayfaGosterim = false},
            new Film(){Name = "Pay It Forward",Url ="iyilik",Sene = 2000,Description = "Sadece hayal kurun. Birisine gerçekten yardımı dokunan bir iyilik yapıyorsunuz ve ondan bunu size bunu ödememesini, fakat ileriye taşımasını ve üç yeni kişiye iyilik yapmasını istiyorsunuz ve bu yeni üç kişi de diğer yeni üç kişiye yardım yapıyor ve bu şekilde evrensel bir iyilik ve nezaket akımı başlıyor.", ResimUrl = "iyilikyap.jpg",Gosterim =true,AnasayfaGosterim = true},
            new Film(){Name = "Pirates of the Caribbean",Url ="karayip",Sene = 2004,Description = "Karayip Korsanları: Siyah İnci'nin Laneti, genç bir kızı kurtarmaya çalışan korsan Jack Sparrow ile demirci Will Turner'ın maceralarını anlatıyor. ... Bu enkazdan kurtulabilen tek kişi küçük Will'dır. Elizabeth küçük çocuğun boynundaki altın madalyondan onun bir korsan olduğunu anlar, bu yüzden madalyonu alarak saklar.", ResimUrl = "karayip.jpg",Gosterim =true,AnasayfaGosterim = true},
            new Film(){Name = "Wonder",Url ="mucize",Sene = 2019,Description = "Yaşıtları çocuklardan biraz farklı olan Auggie Pullman'ın yüzünde bulunan ciddi deformasyon nedeniyle dışlanmasını konu alan yapımda küçük çocuğun diğer çocuklardan bir farklı olmadığını kanıtlama çabasını anlatmaktadır.", ResimUrl = "mucize.jpg",Gosterim =true,AnasayfaGosterim = true},
            new Film(){Name = "İnstant Family",Url ="sipsak",Sene = 2020,Description = "Şipşak Aile, çocuk sahibi olmak isteyen ve evlat edinmeye karar veren bir çiftin hikayesini konu ediyor. ... Amaçları küçük bir çocuğu evlat edinmektir ancak birbirinden tatlı üç kardeş görünce hepsini evlat edinmeye karar verirler. Kardeşlerin en büyüğü, asi bir genç kız olan 15 yaşındaki Lizzy'dir.", ResimUrl = "sipsakaile.jpg",Gosterim =true,AnasayfaGosterim = true},
            new Film(){Name = "Wanted",Url ="wanted",Sene = 2008,Description = "Konu. Rus-Kazak yönetmen Bekmambetov'un son projesi Wanted'ta, McAvoy babasının kiralık katil olduğunu öğrenen ve onun izinden gitmeye karar veren heyecanlı bir genç olan Wes'i, Jolie ve Freeman ise oğlana mesleğin inceliklerini öğretecek olan Fox ve Sloan adlı deneyimli katilleri canlandırıyor.", ResimUrl = "wanted.jpg",Gosterim =true,AnasayfaGosterim = false},
            new Film(){Name = "Wenom",Url ="wenom",Sene = 2016,Description = "Eddie Brock hırslı bir muhabirdir. ... Kötü niyetli ve kendi amaçları doğrultusunda hareket eden bu adamın hikâyesinin peşinde koşarken, Eddie, sadece simbiyoz hâlinde yaşayabilen ve adrenalinle beslenen uzaylı bir organizmanın firma tarafından keşfedildiğini ve insan deneklerle birleştirilmeye çalışıldığını öğrenir.", ResimUrl = "wenom.jpg",Gosterim =true,AnasayfaGosterim = false},
            new Film(){Name = "The Green Mile",Url ="yesil",Sene = 2000,Description = "Yeşil Yol, bir hapishane görevlisi ile bir mahkumun öyküsünü anlatıyor. Paul Edgecomb'un hapishanedeki görevi, idama mahkum edilen mahkumları son yolculuklarına uğurlamaktır. Çalıştığı yıllar içerisinde yüzlerce mahkumu idam etmiştir. Bir gün John Coffey isimli korkutucu görünümlü bir adamla tanışır.", ResimUrl = "yesilyol.jpg",Gosterim =true,AnasayfaGosterim = true},
            new Film(){Name = "Lord Of The Rings",Url ="yuzuklerin",Sene = 2000,Description = "Yüzüklerin Efendisi: Yüzük Kardeşliği, dünyanın kaderini değişterecek olan yüzükten kurtulmak için verilen mücadeleyi konu ediyor. Yıllar önce üretilen ve Orta Dünya topraklarına kandan başka hiçbir şey getirmeyen yüzüklerin sonuncusu, üretiminden yüz yıllar sonra ortaya çıkar.", ResimUrl = "Yuzuk.jpg",Gosterim =true,AnasayfaGosterim = true},
           
        };

        
        private static Star[] Stars = {
            new Star(){FullName = "Jennifer Aniston", Starİmage ="jannifer.jpg",Description ="11 Şubat 1969, Los Angeles), sinema ve dizi oyuncusudur. Los Angeles'ta doğan ve 80'li yıllarda küçük rollerde oynamaya başlayan Jennifer Aniston, çeşitli dizi ve filmlerde rol aldı. En bilinen rolü Friends dizisindeki Rachel Green rolüdür. ... Kendisi gibi babası da bir sinema oyuncusu olup, babası Yunan asıllıdır.",StarringMovies="",Birthyear=1969},
            new Star(){FullName = "Brad Pitt", Starİmage ="brad.jpg",Description ="William Bradley Pitt (d. 18 Aralık 1963; Shawnee, Oklahoma, ABD) ABD'li oyuncu ve film yapımcısı. William Bradley Pitt, 1963 yılında Oklahoma'da dünyaya gelmiştir. ... Mezun olmasına iki hafta kala okulu bırakıp aktör olmak için Los Angeles'a gitmiş burada çeşitli işlerde çalışmış ve oyunculuk dersleri almıştır.",StarringMovies="",Birthyear=1963},
            new Star(){FullName = "Tom Hanks", Starİmage ="tom.jpg",Description ="Thomas Jeffrey Hanks (d. 9 Temmuz 1956), Amerikalı sinema oyuncusudur. İki defa Oscar ödülü almış, zor rollerin üstesinden gelebilmesi ile tanınmış ve özellikle dramatik rollerdeki performansıyla önemli başarı yakalamıştır.",StarringMovies="",Birthyear=1956},
            new Star(){FullName = "Angelina Julie", Starİmage ="angelina.jpg",Description ="Jolie, 1975 yılında Los Angeles'ta Akademi Ödülü kazanmış aktör Jon Voight ile yalnızca iki filmde oynamış oyuncu Marcheline Bertrand'ın kızları olarak doğmuştur. Aynı zamanda Chip Taylor'un yeğeni, James Haven'ın kız kardeşi olan Jolie'nin vaftiz annesi Jacqueline Bisset ve vaftiz babası Maximilian Schell'dir.",StarringMovies="",Birthyear=1975},
            new Star(){FullName = "Helen Hunt", Starİmage ="helen.jpg",Description ="Hunt film yönetmenidir. Çocukken bale eğitimi ve Lurene Tuttle'dan oyunculuk dersleri aldı. ... 1996 yılında NBC'nin haftalık komedi dizisi Mad About You 'daki Jamie Buchman rolü ile tanındı. 1997 yılında çekilen “As Good as It Gets” filmi ile Hollywood'un en çok aranan oyuncularından biri olarak yerini pekiştirdi.",StarringMovies="",Birthyear=1963},
            new Star(){FullName = "Viggo Mortensen", Starİmage ="viggo.jpg",Description ="Viggo Peter Mortensen Jr. (d. 20 Ekim 1958), Altın Küre'ye ve Oscar'a aday gösterilmiş Danimarka asıllı Amerikalı film ve tiyatro sanatçısı, şair, müzisyen, fotoğrafçı ve ressam. 1987 - 1998 yılları arasında Exene Cervenka ile evli kalmıştır. Çiftin Henry isminde bir oğlu vardır.",StarringMovies="",Birthyear=1958},
            new Star(){FullName = "Liam Neeson", Starİmage ="liam.jpg",Description ="7 Haziran 1952 Kuzey İrlanda'da doğan Liam John Neeson aşçı bir annenin ve bekçi bir babanın oğludur. .İlk sahne deneyimini 11 yaşında yaşadı.Üniversite yıllarına kadar okul yapımlarında oyunculuk yaptı ardından Belfast Queen Universitesine fizik ve bilgisayar bilimleri öğrencisi olarak girdi.",StarringMovies="",Birthyear=1952},
            new Star(){FullName = "Emma Watson", Starİmage ="emma.jpg",Description ="Emma Charlotte Duerre Watson (d. 15 Nisan 1990, Paris) İngiliz oyuncu, model ve aktivist. Watson Harry Potter film serisinde canlandırdığı Hermione Granger karakteriyle tanındı. ... Watson Harry Potter serisindeki çalışmalarından çok sayıda ödül ve 10.000.000 sterlinin üzerinde para kazandı.",StarringMovies="",Birthyear=1990},
            new Star(){FullName = "Tom Hardy", Starİmage ="tom2.jpg",Description ="Tom Hardy, 15 Eylül 1977 tarihinde İngiltere, Londra, Hammersmith'da ressam bir anne ve yazar bir babanın çocuğu olarak doğmuştur. ... Londra'da akabinde Richmond Dram Okulu'nda veTower House School'da okudu. Bir yandan da modellik yaptı. 21 yaşında iken 1998 yılında Find Me A Supermodel adlı yarışmayı kazandı.",StarringMovies="",Birthyear=1977},
            new Star(){FullName = "Brendan Fraser", Starİmage ="brendan.jpg",Description ="Brendan Fraser, 3 Aralık 1968 tarihinde ABD, Indiana, Indianapolis'de doğmuştur. Tam adı Brendan James Fraser'dır. Kevin, Regan ve Sean adlarında üç abisi vardır. Aslen Kanadalıdır. Kanada, Toronto'da Upper Canada College Preparatory School'da okudu. ABD. Seattle şehrinde Cornish Sanat Kolejinde Tiyatro Bölümüne eğitimine devam etti, 1990 yılında mezun oldu.",StarringMovies="",Birthyear=1968},
            new Star(){FullName = "Rose Bynre", Starİmage ="rose.jpg",Description ="Byrne, Sidney, Yeni Güney Galler banliyösü Balmain’de doğdu ve İrlanda ve İskoç asıllıdır.  Ebeveynleri, ilkokul yöneticisi Jane ve yarı emekli istatistikçi ve pazar araştırmacısı Robin Byrne’dir .  Dört çocuğunun en küçüğüdür; George adında bir ağabeyi ve Alice ve Lucy adında iki ablası vardır. 2009 yılında yapılan bir röportajda Byrne, annesinin ateist olduğunu ancak hem kendisinin hem de babasının agnostik olduğunu belirtti.",StarringMovies="",Birthyear=1979},
            new Star(){FullName = "Isabela Merced", Starİmage ="isabela.jpg",Description ="Isabela Yolanda Moner, 10 Temmuz 2001'de Cleveland-ABD'de dünyaya geldi. Aktris, ses sanatçısı, şarkıcı, söz yazarı ve dansçıdır aynı zamanda ukulele çalmaktadır. Biri kendinden büyük diğeri küçük olamk üzere iki erkek kardeşi vardır. İlk defa sahneye 10 yaşındayken Broadway'de Evita ile çıkmıştır. 100 Things to Do Before High School adlı Nickelodeon televizyon dizisinde canlandırdığı CJ Martin karakteri ile tanınır.",StarringMovies="",Birthyear=2001},
        };

        private static Comment[] Comments = {
            new Comment(){CommentString = "iyi film",CommentPoint = 8},
            new Comment(){CommentString = "iyi film",CommentPoint = 2},
            new Comment(){CommentString = "iyi film",CommentPoint = 7},
            new Comment(){CommentString = "iyi film",CommentPoint = 9},
            new Comment(){CommentString = "iyi film",CommentPoint = 5}
        };
          private static FilmKategori[] FilmKategoriler = {

            new FilmKategori(){Film = Filmler[0],Kategori = Kategoriler[0]},
            new FilmKategori(){Film = Filmler[0],Kategori = Kategoriler[2]},
            new FilmKategori(){Film = Filmler[1],Kategori = Kategoriler[1]},
            new FilmKategori(){Film = Filmler[1],Kategori = Kategoriler[0]},
            new FilmKategori(){Film = Filmler[2],Kategori = Kategoriler[2]},
            new FilmKategori(){Film = Filmler[2],Kategori = Kategoriler[3]},
            new FilmKategori(){Film = Filmler[3],Kategori = Kategoriler[0]},
            new FilmKategori(){Film = Filmler[3],Kategori = Kategoriler[1]},
            new FilmKategori(){Film = Filmler[4],Kategori = Kategoriler[1]},
            new FilmKategori(){Film = Filmler[4],Kategori = Kategoriler[0]},
            new FilmKategori(){Film = Filmler[5],Kategori = Kategoriler[0]},
            new FilmKategori(){Film = Filmler[5],Kategori = Kategoriler[2]},
            new FilmKategori(){Film = Filmler[6],Kategori = Kategoriler[2]},
            new FilmKategori(){Film = Filmler[6],Kategori = Kategoriler[0]},
            new FilmKategori(){Film = Filmler[7],Kategori = Kategoriler[2]},
            new FilmKategori(){Film = Filmler[7],Kategori = Kategoriler[0]},
           
           


        };

   

    }
}


