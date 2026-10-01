using System.Linq;
​
public static class Kata {
    public static int TotalPoints(string[] games) {
   
      
      int somax = 0 ;
      int somay = 0 ; 
      
      foreach(string correr in games)
        {
        string[] partes = correr.Split(':');
        int timex = int.Parse(partes[0]);
         int timey = int.Parse(partes[1]);
      if (timex > timey)
        {
        somax += 3;
      }
      else if (timex < timey)
        {
        somay += 3;
      }
      else if (timex == timey)
        {
        somay += 1;
        somax += 1;
      }
        }
      return somax;
    }
}