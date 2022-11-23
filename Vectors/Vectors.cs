public class Vectors
{
    public static void Main()
    {
        var menu = new Vectors();
        menu.Menu();
    }
    public void Menu()
    {

       
        char x;
        do
        {
            Console.Clear(); ;
            Console.WriteLine();
            Console.WriteLine("Escull una opció");
            Console.WriteLine("");
            Console.WriteLine("0 - Exit");
            Console.WriteLine("1 - DayOfWeek");
            Console.WriteLine("2 - PlayerNumbers");
            Console.WriteLine("3 - CandidatesList");
            Console.WriteLine("4 - LetterInWord");
            Console.WriteLine("5 - AddValuesToList");
            Console.WriteLine("6 - Swap");
            Console.WriteLine("7 - PushButtonPadlockSimulator");
            Console.WriteLine("8 - BoxesOpenedCounter");
            Console.WriteLine("9 - MinOf10Values");
            Console.WriteLine("A - IsThereAMultiple0f7");
            Console.WriteLine("B - SearchInOrdered");
            Console.WriteLine("C - InverseOrder");
            Console.WriteLine("D - Palindrome");
            Console.WriteLine("E - ListSortedValues");
            Console.WriteLine("F - CapICuaValues");
            Console.WriteLine("G - ListSameValues");
            Console.WriteLine("H - ListSumValues");
            Console.WriteLine("I - IvaPrices");
            Console.WriteLine("J - CovidGrowRate");
            Console.WriteLine("K - BicicleDistance");
            Console.WriteLine("L - ValueNearAvg");
            Console.WriteLine("M - Isbn");
            Console.WriteLine("N - Isbn13");

            Console.WriteLine();
            Console.WriteLine("Escogeix una opció: ");
            x = Convert.ToChar(Console.ReadLine());

            switch (x)
            {
                case '0':
                    Console.WriteLine("Bye");
                    break;
                case '1':
                    DayOfWeek();
                    break;
                case '2':
                    PlayerNumbers();
                    break;
                case '3':
                    CandidatesList();
                    break;
                case '4':
                    LetterInWord();
                    break;
                case '5':
                    AddValuesToList();
                    break;
                case '6':
                    Swap();
                    break;
                case '7':
                    PushButtonPadlockSimulator();
                    break;
                case '8':
                    BoxesOpenedCounter();
                    break;
                case '9':
                    MinOf10Values();
                    break;
                case 'A':
                    IsThereAMultipleOf7();
                    break;
                case 'B':
                    SearchInOrdered();
                    break;
                case 'C':
                    InverseOrder();
                    break;
                case 'D':
                    Palindrome();
                    break;
                case 'E':
                    ListSortedValues();
                    break;
                case 'F':
                    CapICuaValues();
                    break;
                case 'G':
                    ListSameValues();
                    break;
                case 'H':
                    ListSumValues();
                    break;
                case 'I':
                    IvaPrices();
                    break;
                case 'J':
                    CovidGrowRate();
                    break;
                case 'K':
                    BicicleDistance();
                    break;
                case 'L':
                    ValueNearAvg();
                    break;
                case 'M':
                    Isbn();
                    break;
                case 'N':
                    Console.Clear();
                    Isbn13();
                    break;
                default: Console.WriteLine("Prem un valor valid");
                    break;
            }
            
        } while (x != '0');
    }
    
    //DESCRIPTION:Donat un enter, printa el dia de la setmana amb text (dilluns, dimarts, dimecres…), tenint en compte que dilluns és el 0. Els dies de la setmana es guarden en un vector.
    public void DayOfWeek()
    {

        Console.Clear();
        Console.WriteLine("1 - DayOfWeek");
        Console.WriteLine();

        int x;

        do
        {
            Console.WriteLine("Donam un numero del 0 al 6 i et donare el dia de la setmana equivalent");
            x = Convert.ToInt32(Console.ReadLine());//declaro i demano un int
        }
        while (x < 0 || x > 6);


        string[] dies = new string[7] { "Dilluns", "Dimarts", "Dimecres", "Dijous", "Divendres", "Dissabte", "Diumenge" };//declaro e inicialitzo a la array possant el nombre de valors que vull i aquest mateixos
        Console.WriteLine(dies[x]);//printo per pantalla el valor que coincideix amb el numero de l'array
        
        Console.WriteLine("Prem enter per tornar al menu");
        Console.ReadLine();
    }

    //DESCRIPTION:Volem fer un petit programa per guardar l'alineació inicial de jugadors d'un partit de bàsquet. L'usuari introduirà els 5 números dels jugadors. Imprimeix-los després amb el format indicat.

    public void PlayerNumbers()
    {

        Console.Clear();
        Console.WriteLine("2 - PlayerNumbers");
        Console.WriteLine();

        int[] players = new int[5];//declaro una array d'int i la incialitzo a 5 

        for (int i = 0; i < 5; i++)//declaro e inicialitzo i a 0; si es mes petit que 5; em suma 1
        {
            Console.WriteLine("Donam el numero d'un dorsal");
            players[i] = Convert.ToInt32(Console.ReadLine());//igual el numero i al int que em dongui l'usuari

        }

        Console.Write("[");//printo 
        int x = 0;//declaro e inicialitzo a 0 x
        foreach (int element in players)//combertire en int cada valor de players cada vegada fins que players s'acabi
        {
            Console.Write(element);
            if (x < 4)//si x es mes petit que 4
            {
                Console.Write(", ");//possam una coma
                x++;//incrementa en 1 x
            }
        }
        Console.Write("]");//fina del print

        Console.WriteLine("Prem enter per tornar al menu");
        Console.ReadLine();

    }

    /*DESCRIPTION:Volem fer un petit programa per un partit polític. Quan hi ha eleccions, el partit presenta una llista de candidats. Cada candidat té una posició a la llista.
    El programa primer llegirà la llista de candidats(primer introduirem la quantitat i després un candidat per línia).
    Un cop llegida la llista, l'usuari podrà preguntar quin candidat hi ha a cada posició. El programa acaba quan introdueixi -1. Tingues en compte que els polítics no són informàtics, i si indiquen la posició 1, volen dir el primer polític de la llista.
    */

    public void CandidatesList()
    {

        Console.Clear();
        Console.WriteLine("3 - CandidatesList");
        Console.WriteLine();


        Console.Write("Qyab ");
        int x = Convert.ToInt32(Console.ReadLine());//declaro x i el demano a l'usuari
        string[] candidats = new string[x];//declaro un array de strings i poso que el nombre de valors que conté es x

        for (int i = 0; i < x; i++)/*declaro e inicialitzo i a 0; mentres i sigui mes petita que x; suma 1 a i */candidats[i] = Convert.ToString(Console.ReadLine());//li dono a candidats el valor de la i, la igualo al que em dongui l'usuari

        Console.WriteLine();
        Console.WriteLine();

        do
        {
            Console.WriteLine("Donam un numero i et diré el nom de la llista corresponent");//printo
            Console.WriteLine();
            x = Convert.ToInt32(Console.ReadLine());//igualo x al numero de la llista que em dongui l'usuari
            x--;//decremento 1 a x
            Console.WriteLine(candidats[x]);//printo el candidat donat per x a la pantalla
        } while (x != -1);//tot aixo mentres x no sigui -1

        Console.WriteLine("Prem enter per tornar al menu");
        Console.ReadLine();
    }

    /*DESCRIPTION:Donada una paraula i una posició  indica quina lletra hi ha a la posició indicada*/
    public void LetterInWord()
    {

        Console.Clear();
        Console.WriteLine("4 - LetterInWord");
        Console.WriteLine();

        string palabra = Console.ReadLine();//declaro i demano una paraula a l'usuari

        int posicio = Convert.ToInt32(Console.ReadLine());//declaro un int i demano la posicio que voldra l'usuari

        Console.WriteLine(palabra[posicio - 1]);//printo la posicio que vol l'usuari

        Console.WriteLine("Prem enter per tornar al menu");
        Console.ReadLine();
    }

    /*DESCRIPTION: Inicialitza un vector de floats de mida 50, amb el valor 0.0f a tots els elements.
    Després assigna els valors següents a les posicions indicades i printa el vector:
    primera: 31.0f
    segona: 56.0f
    vintena: 12.0f
    última: 79.0f
    */
    public void AddValuesToList()
    {

        Console.Clear();
        Console.WriteLine("5 - AddValuesToList");
        Console.WriteLine();

        float[] nombres = new float[50]; //declaro un array de float amb nom nombre i dic que te 50 valors

        nombres[0] = 31.0f;//dic que la posicio 0 es 31.0f
        nombres[1] = 50.0f;//dic que la posicio 1 es 56.0f
        nombres[19] = 12.0f;//dic que la posicio 19 es 12.0f
        nombres[49] = 79.0f;//dic que la posicio 49 es 79.0f

        Console.Write("[");
        for (int i = 0; i < nombres.Length; i++)/*declaro e incialitzo i a 0 que em fara de contador; mentres i sigui mes petit que la amplada de l'array*/ Console.Write(nombres[i] + ", ");//printo per pantalla els nombres
        Console.WriteLine("]");

        Console.WriteLine("Prem enter per tornar al menu");
        Console.ReadLine();
    }

    /*DESCRIPTION: Donada un vector de 4 números de tipus int,intercanvia el primer per l'últim element.*/
    public void Swap()
    {

        Console.Clear();
        Console.WriteLine("6 - Swap");
        Console.WriteLine();

        int[] nums = new int[4];//declaro una array d'int y dic quan valors conté

        for (int i = 0; i < nums.Length; i++)/*inicialitzo i a 0; mentres i sigui mes petit que el numero de valor que conte l'array; incremento 1 a i */nums[i] = Convert.ToInt32(Console.ReadLine());//la posicio de nums i es igual al que indiqui l'usuari


        Console.WriteLine();//espais
        Console.WriteLine();

        for (int i = 3; i >= 0; i--)//incialitzo i a 3; mentres i sigui igual o mes gran que 0; decremento 1 a i
        {
            Console.Write(nums[i] + ", ");//printo per pantalla num i
        }

        Console.WriteLine("Prem enter per tornar al menu");
        Console.ReadLine();
    }

    /*DESCRIPTION: Volem fer un simulador d'un candau com el de la foto:
    La nostra versió, també tindrà 8 botons, però el primer serà el 0. A l'inici tots els botons estaran sense prémer.
    L'usuari introduirà enters indicant quin botó ha de prémer o no.
    Quan introdueix el -1, és que ja ha acabat i hem d'imprimir l'estat del candau.
    */
    public void PushButtonPadlockSimulator()
    {

        Console.Clear();
        Console.WriteLine("7 - PushButtonPadlockSimulator");
        Console.WriteLine();

        bool[] press = new bool[8];//declaro una array de bools y dic que conte 8 valors

        Console.WriteLine("Quina caixa vols obrir del 1 al 8?");
        int x = Convert.ToInt32(Console.ReadLine()) - 1;//declaro x i la inicialitzo al que em doni l'usuari -1


        while (x != -2) //mentres x no sigui -1
        {
            press[x] = !press[x];//igualo press x a l'invers de si mateix (converteixo true en false i false en true)
            x = Convert.ToInt32(Console.ReadLine()) - 1;//demano x a l'usuari
        }

        foreach (var print in press) Console.Write(print + ", ");//printo el resultat amb un foreach  

        Console.WriteLine("Prem enter per tornar al menu");
        Console.ReadLine();
    }

    /*DESCRIPTION: Un banc té tot de caixes de seguretat, enumerades del 0 al 10.
    Volem registrar quan els usuaris obren una caixa de seguretat, i al final del dia, fer-ne un recompte.
    L'usuari introduirà enters del 0 al 10 quan s'obri la caixa indicada.
    Quan introduiexi l'enter -1, és que s'ha acabat el dia. Printa per pantalla el nombre de cops que s'ha obert.
    */
    public void BoxesOpenedCounter()
    {
        Console.Clear();
        Console.WriteLine("8 - BoxesOpenedCounter");
        Console.WriteLine();


        int[] caixes = new int[11];//declaro una array d'int i dic que conte 11 valors

        int numCaix = Convert.ToInt32(Console.ReadLine());//declaro un int i la demano a l'usuari

        while (numCaix != -1)//mentres numCaix no sigui -1
        {
            caixes[numCaix] = caixes[numCaix] + 1; // Li sumno +1 al valor que hi hagui en aquesta posicio de memoria

            numCaix = Convert.ToInt32(Console.ReadLine());//demano un numero de caixa a l'usuari

        }
        foreach (int print in caixes)
        {
            Console.WriteLine(print);//printo cuantes vegades s'han obert les caixes
        }

        Console.WriteLine("Prem enter per tornar al menu");
        Console.ReadLine();
    }
    /*L'usuari entra 10 enters. Crea un vector amb aquest valors. Imprimeix per pantalla el valor més petit introduït.*/
    public void MinOf10Values()
    {
        Console.Clear();
        Console.WriteLine("9 - Min0f10Values");
        Console.WriteLine();

        int[] valors = new int[10];//declaro una array d'int i dic que te 10 valors 
        int min = 0;//declaro e incialitzo a 0 un int min

        for (int i = 0; i < 10; i++)// declaro e inicialitzo a 0 l'int i; mentres i sigui mes petit que 10; incremento 1 a i
        {
            valors[i] = Convert.ToInt32(Console.ReadLine());//el valor de la posicio de memoria d'aquest punt de l'array será igual al que em dongui l'usuari

            if (valors[i] < min)//si el valor de la posicio de memoria de l'array es mes petit que min
            {
                min = valors[i];//min sera igual al valor esmentat anteriorment
            }
        }

        Console.WriteLine(min);//printo

        Console.WriteLine("Prem enter per tornar al menu");
        Console.ReadLine();
    }

    /*Donat el següent vector, imprimeix true si algun dels números és divisible entre 7 o false en cas contrari.
values = (4, 8, 9, 40, 54, 84, 40, 6, 84, 1, 1, 68, 84, 68, 4, 840, 684, 25, 40, 98, 54, 687, 31, 4894, 468, 46, 84687, 894, 40, 846, 1681, 618, 161, 846, 84687, 6, 848)*/
    public void IsThereAMultipleOf7()
    {

        Console.Clear();
        Console.WriteLine("A - IsThereMultipleOf7");
        Console.WriteLine();

        int[] valors = { 4, 8, 9, 40, 54, 84, 40, 6, 84, 1, 1, 68, 84, 68, 4, 840, 684, 25, 40, 98, 54, 687, 31, 4894, 468, 46, 84687, 894, 40, 846, 1681, 618, 161, 846, 84687, 6, 848 };
        //declaro una array d'int i li dic tots els valors que conte
        bool divisible = false;//declaro un bool i l'igualo a false

        for (int i = 0; i < valors.Length; i++)//declaro i e l'inicialitzo a 0;mentes i sigui mes petit que la llargada del vector; incremento 1 a i
        {
            if (valors[i] / 7 == 0)//si el valor de la posicio de memoria i es divisible per 7
            {
                divisible = true;//igualo el bool a true
            }
        }

        Console.WriteLine(divisible);//printo el true

        Console.WriteLine("Prem enter per tornar al menu");
        Console.ReadLine();
    }

    /*Donat una llista d'enters ordenats de menor a major indica si un cert valor existeix en el bucle.*/

    public void SearchInOrdered()
    {
        Console.Clear();
        Console.WriteLine("B - SearchInOrdered");
        Console.WriteLine();

        Console.WriteLine("Donam el numero de valors que te l'array");//printo una ordre
        int x = Convert.ToInt32(Console.ReadLine());//declaro x i la demano a l'usuari ( es el nombre de valor de l'array)
        int y = 0;//declaro e inicialitzo a 0 y ( es el comparador)
        int num;//declaro num que utilitzare per demanar el numero si esta a la seri
        int[] valors = new int[x];//l'array d'ints

        bool repetit = false;//un bool inicialitzat a false

        Console.WriteLine("Començem per 0");//print

        for (int i = 0; i < x; i++)//incialitzo i a 0; mentres i sigui mes petit que els num de valors; incrementa 1
        {
            valors[i] = Convert.ToInt32(Console.ReadLine());//igualo el valor de la posicio de memoria i a el que em dongui el usuari ( un int)

            while (valors[i] <= y)//aquest while per si em dona un numero mes petit que l'anterior ja que han d'estar ordenats
            {
                Console.WriteLine("Donam un numero mes gran que l'anterior");
                valors[i] = Convert.ToInt32(Console.ReadLine());
            }

            y = valors[i];//si el nombre es mes gran l'igualo per comparar a la proxima

        }

        Console.WriteLine("Donam un numero y veurem si el numero esta a la serie que m'has escrit");//printo

        num = Convert.ToInt32(Console.ReadLine());//demano el num que busca l'usuari

        for (int i = 0; i < x; i++)//un for que fa com el de dalt
        {
            if (num == valors[i])// si el numero es igual al valor de la posicio de memoria i de vakirs
            {
                repetit = true;//el bool es true
            }
            else//sino
            {
                repetit = false;//el bool es false
            }
        }

        Console.WriteLine(repetit);//printo

        Console.WriteLine("Prem enter per tornar al menu");
        Console.ReadLine();


    }
    public void SearchInOrderedVersionCarlos()
    {


        Console.WriteLine("Donam el numero de valors de l'array");
        int x = Convert.ToInt32(Console.ReadLine());
        char[] valors = new char[x];

        int contador = 0;
        char min = ':';

        Console.WriteLine("Escriume els valors de l'array del 1 al 9");
        for (var i = 0; i < x * 2 - 1; i++)
        {
            char y = Convert.ToChar(Console.Read());

            if (y == ' ')
            {
                contador++;
            }
            else
            {
                valors[contador] = y;

                if (valors[contador] < min)
                {
                    min = valors[contador];
                }
            }

        }
        Console.WriteLine();

        Console.WriteLine(min + " es el numero mes petit d'aquesta serie");

        Console.WriteLine("Prem enter per tornar al menu");
        Console.ReadLine();


    }
    /*L'usuari entra 10 enters. Imprimeix-los en l'ordre invers al que els ha entrat.*/
    /**/
    public void InverseOrder()
    {
        Console.Clear();
        Console.WriteLine("C - InverseOrder");
        Console.WriteLine();

        int[] valors = new int[10];//declaro una array que tiene 10 valores
        
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Donam el valor numero " + (i+1) + ":");
            valors[i] = Convert.ToInt32(Console.ReadLine());//demano els valors de l'array a l'usuari
        }

        for (int i = valors.Length; i >= 0; i--) Console.WriteLine(valors[i] + " ");//print//un for que fa que començi pel final de l'array

        Console.WriteLine("Prem enter per tornar al menu");
        Console.ReadLine();
    }
    public void Palindrome()
    {

        Console.Clear();
        Console.WriteLine("D - Palindrome");
        Console.WriteLine();

        string paraula = Console.ReadLine();
        int contador = -1;
        char[] comprovador;
        bool palindrom = true;
       

        for(int i = paraula.Length -1; i >= 0; i--) contador++;

        comprovador = new char[contador +1];

        for (int i = 0; i < paraula.Length; i++)
        {
            comprovador[contador - i] = paraula[i];
        }

        for (int i = 0; i < paraula.Length; i++)
        {
            if(comprovador[i] != paraula[i]) palindrom = false;
 
        }

        Console.WriteLine();
        Console.WriteLine(palindrom);
        Console.WriteLine();
        
        Console.WriteLine("Prem enter per tornar al menu");
        Console.ReadLine();
            
    }
    /*Printa per pantalla ordenats si la llista de N valors introduïts per l'usuari estan ordenats.
L'usuari primer entrarà el número d'enters a introduir i després els diferents enters.
*/
    public void ListSortedValues()
    {

        Console.Clear();
        Console.WriteLine("E - ListSortedValues");
        Console.WriteLine();

        int num = Convert.ToInt32(Console.ReadLine());
        int[] valors = new int[num];
        string ordre = "";

        for (int i = 0; i < valors.Length; i++)
        {
            valors[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; valors.Length != i + 1; i++)
        {
            Console.WriteLine();
            Console.WriteLine();

            if (valors[i] < valors[i + 1])
            {
                ordre = "Ordenats";
            }
            else
            {
                ordre = "Desordenats";


            }

        }

        Console.WriteLine(ordre);
        Console.WriteLine("Prem enter per tornar al menu");
        Console.ReadLine();
    }

    /*Printa per pantalla cap i cua si la llista de N valors introduïts per l'usuari són cap i cua (llegits en ordre invers és la mateixa llista).*/
    public void CapICuaValues()
    {

        Console.Clear();
        Console.WriteLine("F - CapICuaValues");
        Console.WriteLine();

        int num = Convert.ToInt32(Console.ReadLine());
        int[] vector = new int[num];
        int[] vectorInv = new int[num];
        bool capicua = true;

        for (int i = 0; i < num; i++)
        {
            int j = vectorInv.Length - i - 1;

            Console.WriteLine("Donam el nombre " + i);

            vector[i] = Convert.ToInt32(Console.ReadLine());

            vectorInv[j] = vector[i];

        }

        for (int i = 0; i < num; i++)
        {
            if (vector[i] != vectorInv[i])
            {
                i = num;
                capicua = false;
            }
        }

        if (capicua)
        {
            Console.WriteLine("Es capicua");
        }
        else
        {
            Console.WriteLine("No es capicua");
        }

        Console.WriteLine("Prem enter per tornar al menu");
        Console.ReadLine();


    }

    /*L'usuari introduirà 2 vectors de valors, primer mida després introdueix elements.
    Printa per pantalla són iguals si ha introduït el mateix vector, o no són iguals si són diferents.*/
    public void ListSameValues()
    {

        Console.Clear();
        Console.WriteLine("G - ListSameValues");
        Console.WriteLine();

        Console.WriteLine("Donam el numero d'elements que te el vector 1");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Donam el numero d'elements que te el vector 2");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int[] vector1 = new int[num1];
        int[] vector2 = new int[num2];

        bool iguals = true;

        if (num1 != num2)
        {
            Console.WriteLine("No són iguals");
        }
        else
        {
            for (int i = 0; i < vector1.Length; i++)
            {
                Console.WriteLine("Donam el de nombre de la posicio " + i + " del vector1");
                vector1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < vector2.Length; i++)
            {
                Console.WriteLine("Donam el de nombre de la posicio " + i + " del vector2");
                vector2[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < vector1.Length; i++)
            {
                if (vector1[i] != vector2[i]) iguals = false;
            }

            if (iguals == true)
            {
                Console.WriteLine("Son iguals");
            }
            else
            {
                Console.WriteLine("No són iguals");
            }
        }

        Console.WriteLine("Prem enter per tornar al menu");
        Console.ReadLine();
    }

    /*L'usuari introdueix una llista de valors.
    Imprimeix per pantalla la suma d'aquests valors.
    */
    public void ListSumValues()
    {

        Console.Clear();
        Console.WriteLine("H - ListSumValues");
        Console.WriteLine();

        Console.WriteLine("Donam el numero de valors que te l'array");
        int num = Convert.ToInt32(Console.ReadLine());
        int[] vector = new int[num];


        for (int i = 0; i < vector.Length; i++)
        {
            vector[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine(vector.Sum());

    }

    /*En una botiga volem convertir tot de preus sense a IVA al preu amb IVA. Per afegir l'IVA a un preu hem de sumar-hi el 21% del seu valor.
    L'usuari introduirà el preu de 10 articles. Imprimeix per pantalla el preu amb l'IVA afegit amb el següent format indicat a continuació. El programa no pot imprimir res fins a que hagi llegit tots els valors.
    */
    public void IvaPrices()
    {
        Console.Clear();
        Console.WriteLine("I - IvaPrices");
        Console.WriteLine();

        double[] articles = new double[10];

        for (int i = 0; i < articles.Length; i++)
        {

            articles[i] = Convert.ToDouble(Console.ReadLine());
        }

        foreach (double item in articles)
        {
            Console.WriteLine(item + " IVA = " + (item + item * 0.21) + " euros");
        }

        Console.WriteLine("Prem enter per tornar al menu");
        Console.ReadLine();
    }

    /*El departament de salut ens ha demanat que calculem la taxa d’infecció que està tenint la Covid en la nostre regió sanitària. Donat un nombre de casos 
    casos1
    casos1 en una setmana, si la següent tenim un nombre de casos 
    casos2
    casos2, podem calcular la taxa d'infecció amb la fórmula
    infecció =  casos2/casos1
    L'usuari introduirà un llistat de casos detectats cada setmana. Imprimeix la taxa d'infecció detectada cada setmana. El programa no pot imprimir res fins a que hagi llegit tots els valors.
    */
    public void CovidGrowRate()
    {
        Console.Clear();
        Console.WriteLine("J - CovidGrowRate");
        Console.WriteLine();

        int num = Convert.ToInt32(Console.ReadLine());

        double[] casos = new double[num];

        for (int i = 0; i < casos.Length; i++)
        {
            casos[i] = Convert.ToDouble(Console.ReadLine());
        }

        for (int i = 0; i < casos.Length - 1; i++)
        {
            Console.WriteLine("Caso " + (i + 1) + ": " + casos[i + 1] / casos[i]);
        }

        Console.WriteLine("Prem enter per tornar al menu");
        Console.ReadLine();

    }

    /*Donada una velocitat d'una bicicleta en metres per segon, indica els metres que haurà recorregut quan hagi passat 1,2,3,4,5,6,7,8,9 i 10 segons.*/
    public void BicicleDistance()
    {
        Console.Clear();
        Console.WriteLine("K - BicicleDistance");
        Console.WriteLine();

        double velocitat = Convert.ToDouble(Console.ReadLine());
        double[] distancia = new double[10];

        for (int i = 1; i < distancia.Length; i++)
        {
            distancia[i] = i;
        }

        foreach (double item in distancia)
        {
            Console.WriteLine(item * velocitat);
        }

        Console.WriteLine("Prem enter per tornar al menu");
        Console.ReadLine();
    }
    /*L'usuari introdueix una llista de valors. Imprimeix per pantalla el valor que està més proper a la mitjana dels valors de la llista (calcula la mitjana dels valors primer i cerca el més proper després).*/
    public void ValueNearAvg()
    {
        Console.Clear();
        Console.WriteLine("L - ValueNearAvg");
        Console.WriteLine();

        int num = Convert.ToInt32(Console.ReadLine());

        int numAprox = 0;
        int mitjana;
        int valorAprox;

        int[] vector = new int[num];

        for (int i = 0; i < vector.Length; i++)
        {
            vector[i] = Convert.ToInt32(Console.ReadLine());//li dono un valor a cada espai de memoria de l'array
        }
        ;
        valorAprox = vector.Sum();//sumo tots els valors de l'array per tener un valor a comparar
        mitjana = vector.Sum() / num;//faig la mitjan

        for (int i = 0; i < vector.Length; i++)
        {
            if (mitjana < vector[i])//si la mitjana es mes petita que el vector
            {
                if (valorAprox > vector[i] - mitjana)//si el valoraprox es mes gran que la resta de la mitja pel vector
                {
                    valorAprox = vector[i] - mitjana;//el valor mes petit es converteix en el nou valor
                    numAprox = vector[i];//em guardo el numero original per printarlo
                }
            }
            else if (mitjana > vector[i])//si la mitjana es mes gran que el vector
            {
                if (valorAprox > mitjana - vector[i])
                {
                    valorAprox = mitjana - vector[i];//el valor mes petit es converteix en el mes petit
                    numAprox = vector[i];//em guardo el numero original per printarlo
                }
            }
        }
        Console.WriteLine(numAprox);

        Console.WriteLine("Prem enter per tornar al menu");
        Console.ReadLine();

    }

    /*Es vol fer un programa per verificar que un codi ISBN (International Standard Book Code) és correcte. El format d’un codi ISBN és: Codi de grup (1 dígit), Codi de l’editor (4 dígits), Codi del llibre (4 dígits), Caràcter/dígit de control (1 caràcter/dígit)
    Així, per exemple, el codi ISBN d’un llibre és 84-7602-561-0. La verificació del codi es fa a partir d’aplicar una sèrie d’operacions sobre els primers 9 dígits del resultat de les quals s'extreu el dígit/caràcter de control. Per obtenir el del control, cal fer els passos següents:
    Es multiplica cadascun dels dígits per la posició que ocupa dins l’ISBN i se sumen totes les multiplicacions. Es divideix el resultat per 11 i el residu és el dígit de control. Si aquest residu és 10 es fa anar la lletra “X” com a control.
    Per exemple el ISBN: 84-7602-561-0 , el caràcter de control és el 0
    (8x1)+(4x2)+(7x3)+(6x4)+(0x5)+(2x6)+(5x7)+(6x8)+(1x9) = 165 165 mod 11 = 0
    El residu és igual al caràcter de control per tant és un ISBN vàlid
    */

    public void Isbn()
    {
        Console.Clear();
        Console.WriteLine("M - ISBN");
        Console.WriteLine();

        Console.Clear();
        Console.WriteLine("ISBN");
        


        int[] ISBN = new int[10];
        int acumulador = 0;
        bool output = false;

        for (int i = 0; i < ISBN.Length; i++)
        {
            Console.WriteLine("Donam un numero");
            ISBN[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < ISBN.Length - 1; i++)
        {
            ISBN[i] = ISBN[i] * (i + 1);//multiplico cada valor de ISBN per i mes 1
            acumulador += ISBN[i];//sumo tots el valors de ISBN menys el ultim
        }

        acumulador = acumulador % 11;//faig el modul de 11

        if (acumulador == 10)//si el modul 11 em dona 10
        {
            output = true;//OUput false
            for (int i = 0; i < ISBN.Length-1; i++)
            {
                Console.Write(ISBN[i]);
            }                                       //Printo tots els nombres de ISBN menys l'ultim i despres printo la X
            Console.Write("X");
        }

        else if(acumulador == ISBN[ISBN.Length - 1])//si el modul de 11 es igual al ultim nombre de ISBN 
        {
            output = true;  
        }

        Console.WriteLine(output);


        Console.WriteLine("Prem enter per tornar al menu");
        Console.ReadLine();

    }

    /*A partir de l'any 2006 els ISBN van passar a tenir 13 dígits i es va adaptar per a què fos compatible amb el sistema de codi de barres EAN-13.
Volem verificar si un codi ISBN és correcte. Mitjançant el dígit de control que és el dígit número 13. Es calcula de la manera següent:
Es multiplica el primer dígit dels 12 digits
per 1, el segon per 3, el tercer per 1, el quart per 3, i així
successivament fins al número 12;
El dígit de control és el valor que s'ha d'afegir a la suma de tots aquests productes per fer-la divisible per 10. Si
el resultat de la suma ja fos múltiple de 10, el dígit de control seria 0.
Aquest ISBN 978-84-92493-70-8 ens el donarien de la manera següent, indica si el dígit de control és correcte.
*/
    public void Isbn13()
    {
        Console.Clear();
        Console.WriteLine("N - ISBN13");
        Console.WriteLine();

        int[]ISBN= new int[13];
        int valors;
        bool output;
        
        for(int i =0; i < ISBN.Length; i++) 
        {
            ISBN[i]= Convert.ToInt32(Console.ReadLine());
        }

        for(int i =1; i < ISBN.Length; i+=2) 
        {
            ISBN[i]*=3;
        }

        valors = ISBN.Sum();
        
        if (valors % 10 == 0) output= true; else output = false;
        
        Console.WriteLine(output);

        Console.WriteLine("Prem enter per tornar al menu");
        Console.ReadLine();

    }
 

}