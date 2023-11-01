using System.Reflection.Metadata.Ecma335;

namespace Method_s;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Method Tanımlama(Definition)");
        /*Methodları parçalara ayırmak için kullanılır,tek başlarına yazılamazlar bir class içine 
        yazılmış olmalı bir kodu düzeltmek için kolaylaştırıcıdır.*/
        //Erişim_belirteci geri_dönüştipi metot-adı(parametre listesi/argüman)

        int a = 2;
        int b = 3;
        Console.WriteLine(a+b);

        int accept = plus(a,b);
        
        Console.WriteLine(accept);

        themethod home = new themethod();
        home.Printforscreen(Convert.ToString(accept));

        int plus2 = home.plusplus(a,b);
        home.Printforscreen(Convert.ToString(plus2));
        


    }

    static int plus (int value1 , int value2)//Yeni method.
    //Burada değer parametresi yazdık ve a ve b nin parametlerini verdik
    //Methoda 2 parametre verdik
    //Methoda erişmek için static olması gerekli static methoda static method erişebilir
    //value1 ve value 2 a ve b ye değer atamasıdır.
    {
        return (value1 + value2);//Geri dönüş
    }

    class themethod 
    {
       public void Printforscreen(string loop)
       {
        Console.WriteLine(loop);
       }
     
     public int plusplus (int value1,int value2)
     {
        value1+=1;
        value2+=1;
        return value1 + value2;
     }
    }
}
