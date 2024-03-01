using System;
namespace rekursive{
    class Program{
        public static void Main(String[] args){
            int result = 1;
            for(int i = 1;i<5;i++){
                result *= 3;
            }
            Console.WriteLine(result);
            Islemler isl =  new Islemler();
            int son = isl.Expo(2,4);
            Console.WriteLine(son);

            string ifade = "Hello World";
            bool sonuc = ifade.CheckSpace();
            Console.WriteLine(sonuc);

            if(sonuc){
                Console.WriteLine(ifade.RemoveWhiteSpaces());
            }
            Console.WriteLine(ifade.MakeUpperCase());       
            Console.WriteLine(ifade.MakeLowerCase());     

            int[] dizi = {9,2,1,5,0};     
            dizi.SortArray();
            dizi.EkranaYazdir();
            int sayi2 = 2;
            bool sonuclar = sayi2.IsEvenNumber();
            Console.WriteLine(sonuclar);
            Console.WriteLine(ifade.GetFirstCharecter());
        } 
    }
    public class Islemler{
        public int Expo(int sayi,int us){
            if(us <=0)
                return 1;
            return sayi*Expo(sayi,us-1);
        }
    }

    public static class Extension{
        public static bool CheckSpace(this string str){
            return str.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string str){
            string[] dizi = str.Split(" "); 
            return string.Join("", dizi);
        }
        public static string MakeUpperCase(this string param){
            return param.ToUpper();
        }
        public static string MakeLowerCase(this string param){
            return param.ToLower();
        }
        public static int[] SortArray(this int[] param){
            Array.Sort(param);
            return param; 
        }
        public static void EkranaYazdir(this int[] param){
            foreach(var item in param){
                Console.WriteLine(item);
            }
        } 
        public static bool IsEvenNumber(this int param){

            return param%2 == 0;
        }
        public static string GetFirstCharecter(this string param){

        return param.Substring(0,1);
        }
        
    }
}