using System.Data.Common;
using UnityEngine;

public class Test : MonoBehaviour
{

   int number = 5;

   int number2 = 6;
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
   }

   void Update()

   {

      testDonguler();


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

   void testDonguler()
   {

      for (int i = 0; i < 5; i++)
      {
         Debug.Log(i);
      }

      foreach (var item in collection)
      {
         
      }
   }


}
