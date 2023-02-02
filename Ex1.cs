using System;

class Ex1
{
   private static List<string> ls = new List<string>();
   private static bool ok = false;
   private static int[] arr = new int[100];
   private static void Swap(ref int a, ref int b)
   {
      int temp = a;
      a = b;
      b = temp;
   }

   private static void permutation(int n)
   {
      int i = n - 1;
      int temp;
      while(i >= 1 && arr[i] > arr[i + 1]) --i;
      if(i == 0) ok = true;
      else
      {
         int j = n;
         while(arr[i] > arr[j]) j--;

         temp = arr[i];
         arr[i] = arr[j];
         arr[j] = temp;
         
         int l = i + 1, r = n;
         while(l < r)
         {
            temp = arr[l];
            arr[l] = arr[r];
            arr[r] = temp;
            l++; r--;
         }
      }
   }
    
   private static void Main(string[] args)
   {
      int n = Convert.ToInt32(Console.ReadLine());
      int k = Convert.ToInt32(Console.ReadLine());
      for(int i = 1; i <= n; i++)
      {
         arr[i] = i;
      }
      while(!ok)
      {
         string tmp = "";
         for(int i = 1; i <= n; i++)
         {
            tmp += arr[i] + " ";
         }
         ls.Add(tmp);
         permutation(n);
      }
      System.Console.WriteLine(ls[k - 1]);
   }
}
