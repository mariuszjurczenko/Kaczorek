# Kaczorek
C# Seria Programista część 2 - Podstawy Programowanie obiektowego w języku C#

mariuszjurczenko@dev-hobby.pl

Programowanie  obiektowe  to fundamentalna cecha języka C #. Tematem tego kursu będzie programowanie w języku C #, 
a dokładnie wszystko co powinieneś wiedzieć o programowaniu obiektowym. Po podaniu specyfikacji nowej funkcji lub 
nowej aplikacji zacznij od zidentyfikowania klas z wymagań lub specyfikacji. Programowanie obiektowe reprezentuje 
encje i koncepcje aplikacji jako zbioru klas. Następnym krokiem jest przeanalizowanie zidentyfikowanych 
klas i podział obowiązków w zależności od potrzeb. Chodzi o to, że aplikacja powinna zostać rozłożona na części 
z minimalnym nakładaniem się funkcji. Jeśli każda klasa ma jeden cel, łatwiej jest pisać, testować, a później znajdować 
tę klasę, gdy trzeba ją zaktualizować lub rozszerzyć. To sprawia, że kod jest łatwiejszy do modyfikacji i dostosowania 
do nowych wymagań i przyszłych wymagań. Następnym krokiem jest przyjrzenie się związkom. Relacje między klasami definiują 
sposób, w jaki obiekty utworzone z tych klas mogą współpracować w celu wykonywania operacji aplikacji. Ostatnim krokiem 
jest wykorzystanie ponownego użycia. Siła programowania obiektowego leży w obietnicy ponownego użycia. Poprzez wyodrębnienie 
podobieństwa między zestawami klas do oddzielnej klasy, masz więcej kodu wielokrotnego użytku. Rozbudowane ponowne wykorzystanie 
istniejących, sprawdzonych klas nie tylko skraca czas opracowywania, ale także prowadzi do bardziej niezawodnych aplikacji. 
Przykładowa aplikacja została ponownie wykorzystana poprzez klasę bazową z wykorzystaniem dziedziczenia. Następnie zademonstrujemy 
ponowne użycie poprzez bibliotekę komponentów klas ogólnych. I wreszcie, zobaczymy ponowne użycie interfejsów. Interfejsy 
zapewniają czysty sposób interakcji aplikacji z innymi klasami, komponentami, aplikacjami lub systemami. 

Kurs opisał również cztery filary lub cechy programowania obiektowego.  
Abstrakcja, enkapsulacja, dziedziczenie i polimorfizm. 

Abstrakcja opisuje jednostkę w prosty sposób, ignorując nieistotne szczegóły. 
Zmniejsza złożoność, koncentrując się tylko na tym, co jest ważne dla celów konkretnego zastosowania. 

Enkapsulacja polega na enkapsulacji lub ukrywaniu danych implementacji w obrębie klasy. 
Dane są przechowywane w polach w klasie i dostępne dla reszty aplikacji tylko za pomocą metod pobierających 
i ustawiających właściwości. Kod jest również hermetyzowany w klasie i dostępny tylko poprzez interfejs klasy. 
Ukrywanie danych może chronić dane przed nieautoryzowanym dostępem lub nieprawidłowymi danymi. Ukrywanie implementacji 
pomaga zarządzać złożonością i ułatwia konserwację. Implementacja może zostać zmieniona w dowolnym momencie 
bez wpływu na aplikację. 

Dziedziczenie pozwala klasom pochodnym lub klasom potomnym na ponowne użycie całego kodu z klasy podstawowej lub macierzystej. 
W demonstracji stworzyliśmy klasę bazową encji, która zawierała standardowy zestaw właściwości i metodę sprawdzania poprawności. 
Każda klasa encji odziedziczyła po tej klasie bazowej, aby ponownie wykorzystać jej funkcjonalność. Ale w niektórych 
przypadkach nie chcemy ponownie korzystać z całej funkcjonalności klasy podstawowej, więc możemy przesłonić jej części tak, 
jak zrobiliśmy to za pomocą metody sprawdzania poprawności. 

Polimorfizm jest koncepcją, że pojedyncza metoda, taka jak metoda sprawdzania poprawności, może zachowywać się 
inaczej w zależności od typu obiektu, który ją wywołuje. Tak więc sprawdzanie poprawności obiektu zamówienia 
może zachowywać się inaczej niż obiektu klienta, który sprawdza poprawność, a obiekt klienta może zachowywać 
się inaczej od sprawdzania poprawności obiektu produktu i tak dalej. Metoda o podanej nazwie może mieć różne kształty, 
a aplikacja określa, jaki kształt metody należy zastosować w momencie wykonywania. Ideą polimorfizmu opartego 
na dziedziczeniu jest to, że klasa bazowa może definiować metodę, a każda klasa pochodna może przesłonić tę metodę, 
aby zapewnić własną definicję i implementację, zasadniczo zapewniając własny kształt tej metody. Ideą polimorfizmu 
opartego na interfejsie jest to, że interfejs może definiować metodę. Każda klasa może następnie zaimplementować ten 
interfejs i zdefiniować własną implementację dla tej metody, zasadniczo zapewniając własny kształt dla tej metody. 

Link do kursu https://dev-hobby.pl/kursy/c-najlepsze-praktyki-podstawy-jezyka/
