using System;

 namespace donguler_for_loop
{
    class program
    {
        static void Main(string[] args)
        { 
            for (int i = 1; i < 10; i++)
            {
              if(i==4)
              break;
              Console.WriteLine(i);
                
            }

            for (int i = 1; i < 10; i++)
            {
              if(i==4)
              continue;
              Console.WriteLine(i);
                
            }
              //ekrandan girilen sayıya kadar olan tek sayılarını ekrana yazdır.
              //  Console.Write("lütfen bir sayı giriniz: ");
              //  int sayac =int.Parse(Console.ReadLine());
              // for (int i = 1; i <= sayac; i++)
            
               // if(i%2 == 1)
                   //  Console.Write(i);
            

              //1 ile 1000 arasındaki tek ve çift sayıların ken içlerinde toplamlarını ekrana yazdır.
              //  int tekToplam =0;
             //  int ciftToplam =0;
             //  for (int i = 1; i <= 1000; i++)
            
              // if(i%2 == 1)
              //    tekToplam += i; // Tektoplam = Tektoplam + i;
             //  else
                  //  ciftToplam += i; //cifttoplam= cifttoplam +i;
                    
            

              //Console.WriteLine("Tek Toplam: " +tekToplam);
              // Console.WriteLine("cift Toplam: " +ciftToplam);

              // break, continue
            
        }
    }    
 }  
