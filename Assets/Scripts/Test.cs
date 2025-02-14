using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;

public class Test : MonoBehaviour
{

   int number = 5;

   int number2 = 6;

   List<int> sayilar = new List<int>();
   void Start()

   {
      Debug.Log("Debug logu. açıklama");

      if (number > 6)
      {

         Debug.Log("Number is bigger than 6!");
      }
      else
      {
         Debug.Log("Number is not bigger than 6!");
      }


      testFunction();

      testDongulerFor();

      testDongulerWhile();


      sayilar.Add(10);
      sayilar.Add(20);
      sayilar.Add(30);
      sayilar.Add(40);

      foreach (int item in sayilar)
      {
         Debug.Log("Listedeki sayılardan biri = " + item);
      }

      sayilar.Remove(40);
      sayilar.RemoveAt(2);

      foreach (int item in sayilar)
      {

         Debug.Log("2 elemanı çıkardıktan sonra sayılar = " + item);

      }
   }

   void Update()

   {




   }

   void testFunction()
   {

      if (number < number2)
      {
         Debug.Log("1. sayı, ikinci sayıdan küçük");
      }
      else
      {
         Debug.Log("İkinci sayı, birinci sayıdan küçük");
      }
   }

   void testDongulerFor()
   {

      //ilk başta int i = 0 diyerek değişken tanımladık istersek bu değişkeni yukarıda tanımlayıp buraya doğrudan tanımlanmış olan i değişkenini i=0; diye yazabilirdik
      //İkinci bölümde değişkenin koşulunu sorguladık. i < 5 olduğu sürece döngü sürecek
      //Koşul sürdüğü sürece her döngü sonunda i'yi 1 artırdık.

      for (int i = 0; i < 5; i++)
      {
         Debug.Log(i);
      }


   }

   void testDongulerWhile()
   {

      //Yukarıda tanımlı number değişkeninin koşulunu bildirdik. Döngü her tamamlandığında 1 eksilttik. 


      while (number > 0)
      {
         Debug.Log(number);
         number--;
         //number--; yerine number = number - 1 de yazabiliriz. Burada olaya matematik olarak değil atama olarak bakıyoruz. Number değişkeninin yeni değeri 1 eksiğine eşit olacak şekilde atama yaptık.


      }

   }

   void testArray()
   {
      //Bir dizi(array) tanımladık. İçeriğine 1den 5 e kadar sayıları yazdık
      //Bu dizinin 3. indisi olan 3 değerine ulaşmak için 2 ile log aldık 
      int[] numbers = { 1, 2, 3, 4, 5 };

      Debug.Log(numbers[2]);

   }


}
