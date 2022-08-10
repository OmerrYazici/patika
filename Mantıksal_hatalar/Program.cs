using System;

class program{
    static void Main(string[] args){
        try{
            System.Console.WriteLine("Bir sayi giriniz.");
            int sayi=Convert.ToInt32 (Console.ReadLine());
            System.Console.WriteLine("girmiş oldugunuz sayi:"+sayi);
        }
        catch(Exception ex){
            System.Console.WriteLine("Hata: "+ex.Message.ToString());
        }
        finally{
            System.Console.WriteLine("islemi tamamladınız.");
        }
    }
}