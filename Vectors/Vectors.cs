using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;

public class Vectors
{
    public static void Main()
    {
        var menu = new Vectors();
        menu.SearchInOrdered();
    }
    /*public void Menu()
    {
        Console.WriteLine("Escull una opció");
        Console.WriteLine("");
        Console.WriteLine("0 - Exit");
        Console.WriteLine("1 - DayOfWeek");
        Console.WriteLine("2 - PlayerNumbers");
        Console.WriteLine("3 - CandidatesList");
        Console.WriteLine("4 - LetterInWord");
        Console.WriteLine("5 - AddValuesToList");
        Console.WriteLine("6 - PushButtonPadlockSimulator");
        Console.WriteLine("7 - BoxesOpenedCounter");
        Console.WriteLine("8 - MinOf10Values");
        Console.WriteLine("9 - IsThereAMultiple0f7");
        Console.WriteLine("A - SearchInOrdered");
        Console.WriteLine("B - InverseOrder");
        Console.WriteLine("C - Palindrome");
        Console.WriteLine("D - ListSortedValues");
        Console.WriteLine("E - CapICuaValues");
        Console.WriteLine("F - ListSameValues");
        Console.WriteLine("G - ListSumValues");
        Console.WriteLine("H - IvaPrices");
        Console.WriteLine("I - CovidGrowRate");
        Console.WriteLine("J - BicicleDistance");
        Console.WriteLine("K - ValueNearAvg");
        Console.WriteLine("L - Isbn");
        Console.WriteLine("M - Isbn13");

        string x;
        do
        {
            x = Convert.ToString(Console.ReadLine());

            switch (x)
            {
                case "0":
                    Console.WriteLine("Bye");
                    break;
                case "1":
                    DayOfWeek();
                    break;
                case "2":
                    PlayerNumbers();
                    break;
                case "3":
                    CandidatesList();
                    break;
                case "4":
                    LetterInWord();
                    break;
                case "5":
                    AddValuesToList();
                    break;
                case "6":
                    Swap();
                    break;
                case "7":
                    PushButtonPadlockSimulator();
                    break;
                case "8":
                    BoxesOpenedCounter();
                    break;
                case "9":
                    MinOf10Values();
                    break;
                case "A":
                    IsThereAMultipleOf7();
                    break;
                case "B":
                    SearchInOrdered();
                    break;
                case "C":
                    InverseOrder();
                    break;
                case "D":
                    Palindrome();
                    break;
                case "E":
                    ListSortedValues();
                    break;
                case "F":
                    CapICuaValues();
                    break;
                case "G":
                    ListSameValues();
                    break;
                case "H":
                    IvaPrices();
                    break;
                case "I":
                    CovidGrowRate();
                    break;
                case "J":
                    BicicleDistance();
                    break;
                case "K":
                    ValueNearAvg();
                    break;
                case "L":
                    Isbn();
                    break;
                case "M":
                    Isbn13();
                    break;
                default: Console.WriteLine("Prem un valor valid");
                    break;
            }
            
        } while (x != "0");
    }
    */
    //DESCRIPTION:Donat un enter, printa el dia de la setmana amb text (dilluns, dimarts, dimecres…), tenint en compte que dilluns és el 0. Els dies de la setmana es guarden en un vector.
    public void DayOfWeek() {
        
        Console.Clear();
        Console.WriteLine("");

        int x;

        do
        {
            Console.WriteLine("Donam un numero del 0 al 6 i et donare el dia de la setmana equivalent");
            x = Convert.ToInt32(Console.ReadLine());//declaro i demano un int
        }
        while (x < 0 || x > 6);
        

        string[] dies = new string[7] { "Dilluns", "Dimarts", "Dimecres", "Dijous", "Divendres", "Dissabte", "Diumenge" };//declaro e inicialitzo a la array possant el nombre de valors que vull i aquest mateixos
        Console.WriteLine(dies[x]);//printo per pantalla el valor que coincideix amb el numero de l'array

    }

//DESCRIPTION:Volem fer un petit programa per guardar l'alineació inicial de jugadors d'un partit de bàsquet. L'usuari introduirà els 5 números dels jugadors. Imprimeix-los després amb el format indicat.

public void PlayerNumbers() {

     Console.Clear();//Netejo la consola

     int[] players = new int[5];//declaro una array d'int i la incialitzo a 5 

     for(int i=0; i <5; i++)//declaro e inicialitzo i a 0; si es mes petit que 5; em suma 1
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

 }

/*DESCRIPTION:Volem fer un petit programa per un partit polític. Quan hi ha eleccions, el partit presenta una llista de candidats. Cada candidat té una posició a la llista.
El programa primer llegirà la llista de candidats(primer introduirem la quantitat i després un candidat per línia).
Un cop llegida la llista, l'usuari podrà preguntar quin candidat hi ha a cada posició. El programa acaba quan introdueixi -1. Tingues en compte que els polítics no són informàtics, i si indiquen la posició 1, volen dir el primer polític de la llista.
*/

public void CandidatesList() {

    int x = Convert.ToInt32(Console.ReadLine());//declaro x i el demano a l'usuari
    string[] candidats = new string[x];//declaro un array de strings i poso que el nombre de valors que conté es x

    for(int i =0; i < x; i++)//declaro e inicialitzo i a 0; mentres i sigui mes petita que x; suma 1 a i
    {
        candidats[i] = Convert.ToString(Console.ReadLine());//li dono a candidats el valor de la i, la igualo al que em dongui l'usuari
    }

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
}

/*DESCRIPTION:Donada una paraula i una posició  indica quina lletra hi ha a la posició indicada*/
public void LetterInWord() 
{
       string palabra = Console.ReadLine();//declaro i demano una paraula a l'usuari

        int posicio = Convert.ToInt32(Console.ReadLine());//declaro un int i demano la posicio que voldra l'usuari

        Console.WriteLine(palabra[posicio - 1]);//printo la posicio que vol l'usuari

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
        float[] nombres = new float[50]; //declaro un array de float amb nom nombre i dic que te 50 valors

        nombres[0] = 31.0f;//dic que la posicio 0 es 31.0f
        nombres[1] = 50.0f;//dic que la posicio 1 es 56.0f
        nombres[19] = 12.0f;//dic que la posicio 19 es 12.0f
        nombres[49] = 79.0f;//dic que la posicio 49 es 79.0f

        Console.Write("[");
        for(int i =0; i < nombres.Length; i++)//declaro e incialitzo i a 0 que em fara de contador; mentres i sigui mes petit que la amplada de l'array
        {
            Console.Write(nombres[i] + ", ");//printo per pantalla els nombres
        }
        Console.WriteLine("]") ;
}

    /*DESCRIPTION: Donada un vector de 4 números de tipus int,intercanvia el primer per l'últim element.*/
public void Swap()
{
        int[] nums = new int [4];//declaro una array d'int y dic quan valors conté

        for(int i = 0; i < nums.Length; i++)//inicialitzo i a 0; mentres i sigui mes petit que el numero de valor que conte l'array; incremento 1 a i
        {
            nums[i] =Convert.ToInt32(Console.ReadLine());//la posicio de nums i es igual al que indiqui l'usuari
        }

        Console.WriteLine();//espais
        Console.WriteLine();

        for(int i =3; i >= 0; i--)//incialitzo i a 3; mentres i sigui igual o mes gran que 0; decremento 1 a i
        {
            Console.Write(nums[i] + ", ");//printo per pantalla num i
        }
        
        
}

    /*DESCRIPTION: Volem fer un simulador d'un candau com el de la foto:
    La nostra versió, també tindrà 8 botons, però el primer serà el 0. A l'inici tots els botons estaran sense prémer.
    L'usuari introduirà enters indicant quin botó ha de prémer o no.
    Quan introdueix el -1, és que ja ha acabat i hem d'imprimir l'estat del candau.
    */
public void PushButtonPadlockSimulator()
{
        bool[] press = new bool[8];//declaro una array de bools y dic que conte 8 valors

        Console.WriteLine("Quina caixa vols obrir del 1 al 8?");
        int x = Convert.ToInt32(Console.ReadLine())-1;//declaro x i la inicialitzo al que em doni l'usuari -1


        while (x != -2) //mentres x no sigui -1
        {
            press[x] = !press[x];//igualo press x a l'invers de si mateix (converteixo true en false i false en true)
            x = Convert.ToInt32(Console.ReadLine()) - 1;//demano x a l'usuari
        }

        foreach(var print in press)//
        {
            Console.Write(print+", ");//printo el resultat amb un foreach  
        }

}

    /*DESCRIPTION: Un banc té tot de caixes de seguretat, enumerades del 0 al 10.
    Volem registrar quan els usuaris obren una caixa de seguretat, i al final del dia, fer-ne un recompte.
    L'usuari introduirà enters del 0 al 10 quan s'obri la caixa indicada.
    Quan introduiexi l'enter -1, és que s'ha acabat el dia. Printa per pantalla el nombre de cops que s'ha obert.
    */
public void BoxesOpenedCounter()
    {
        int[] caixes = new int[11];//declaro una array d'int i dic que conte 11 valors

        int numCaix = Convert.ToInt32(Console.ReadLine());//declaro un int i la demano a l'usuari

        while (numCaix != -1)//mentres numCaix no sigui -1
        {
            caixes[numCaix] = caixes[numCaix] + 1; // Li sumno +1 al valor que hi hagui en aquesta posicio de memoria

            numCaix = Convert.ToInt32(Console.ReadLine());//demano un numero de caixa a l'usuari

        }
        foreach(int print in caixes)
        {
            Console.WriteLine(print);//printo cuantes vegades s'han obert les caixes
        } 
}
    /*L'usuari entra 10 enters. Crea un vector amb aquest valors. Imprimeix per pantalla el valor més petit introduït.*/
    public void MinOf10Values() 
{
        int[] valors = new int[10];//declaro una array d'int i dic que te 10 valors 
        int min = 0;//declaro e incialitzo a 0 un int min

        for(int i =0; i < 10; i++)// declaro e inicialitzo a 0 l'int i; mentres i sigui mes petit que 10; incremento 1 a i
        {
            valors[i] = Convert.ToInt32(Console.ReadLine());//el valor de la posicio de memoria d'aquest punt de l'array será igual al que em dongui l'usuari
           
            if (valors[i] < min)//si el valor de la posicio de memoria de l'array es mes petit que min
            {
                min = valors[i];//min sera igual al valor esmentat anteriorment
            }
        }

        Console.WriteLine(min);//printo
}

    /*Donat el següent vector, imprimeix true si algun dels números és divisible entre 7 o false en cas contrari.
values = (4, 8, 9, 40, 54, 84, 40, 6, 84, 1, 1, 68, 84, 68, 4, 840, 684, 25, 40, 98, 54, 687, 31, 4894, 468, 46, 84687, 894, 40, 846, 1681, 618, 161, 846, 84687, 6, 848)*/
public void IsThereAMultipleOf7()
    {
        int[] valors = { 4, 8, 9, 40, 54, 84, 40, 6, 84, 1, 1, 68, 84, 68, 4, 840, 684, 25, 40, 98, 54, 687, 31, 4894, 468, 46, 84687, 894, 40, 846, 1681, 618, 161, 846, 84687, 6, 848 };
        //declaro una array d'int i li dic tots els valors que conte
        bool divisible =false;//declaro un bool i l'igualo a false

        for(int i =0; i < valors.Length; i++)//declaro i e l'inicialitzo a 0;mentes i sigui mes petit que la llargada del vector; incremento 1 a i
        {
            if(valors[i]/7 == 0)//si el valor de la posicio de memoria i es divisible per 7
            {
                divisible = true;//igualo el bool a true
            }
        }

        Console.WriteLine(divisible);//printo el true
}

    /*Donat una llista d'enters ordenats de menor a major indica si un cert valor existeix en el bucle.*/

public void SearchInOrdered()
{
        Console.WriteLine("Donam el numero de valors que te l'array");//printo una ordre
        int x = Convert.ToInt32(Console.ReadLine());//declaro x i la demano a l'usuari ( es el nombre de valor de l'array)
        int y = 0;//declaro e inicialitzo a 0 y ( es el comparador)
        int num;//declaro num que utilitzare per demanar el numero si esta a la seri
        int [] valors = new int [x];//l'array d'ints

        bool repetit = false;//un bool inicialitzat a false

        Console.WriteLine("Començem per 0");//print
        
        for (int i =0; i < x; i++)//incialitzo i a 0; mentres i sigui mes petit que els num de valors; incrementa 1
        {
            valors[i] = Convert.ToInt32(Console.ReadLine());//igualo el valor de la posicio de memoria i a el que em dongui el usuari ( un int)

            while (valors[i] <= y)//aquest while per si em dona un numero mes petit que l'anterior ja que han d'estar ordenats
            {
                Console.WriteLine("Donam un numero mes gran que l'anterior"); 
                valors[i] = Convert.ToInt32(Console.ReadLine());
            }

            y=valors[i];//si el nombre es mes gran l'igualo per comparar a la proxima
            
        }

        Console.WriteLine("Donam un numero y veurem si el numero esta a la serie que m'has escrit");//printo

        num = Convert.ToInt32 (Console.ReadLine());//demano el num que busca l'usuari

        for(int i = 0; i < x; i++)//un for que fa com el de dalt
        {
            if(num == valors[i])// si el numero es igual al valor de la posicio de memoria i de vakirs
            {
                repetit = true;//el bool es true
            }
            else//sino
            {
                repetit = false;//el bool es false
            }
        }

        Console.WriteLine(repetit);//printo
        

}
public void SearchInOrderedVersionCarlos() 
{
    Console.WriteLine("Donam el numero de valors de l'array");
    int x = Convert.ToInt32(Console.ReadLine());
    char[] valors = new char[x];

    int contador = 0;
    char min = ':';

    Console.WriteLine("Escriume els valors de l'array del 1 al 9");
    for (var i = 0; i < x*2-1; i++)
    {
        char y = Convert.ToChar(Console.Read());

        if(y == ' ')
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


}
public void InverseOrder() { }
public void Palindrome() { }
public void ListSortedValues() { }
public void CapICuaValues() { }
public void ListSameValues() { }
public void ListSumValues() { }
public void IvaPrices() { }
public void CovidGrowRate() { }
public void BicicleDistance() { }
public void ValueNearAvg() { }
public void Isbn() { }
public void Isbn13() { }


}