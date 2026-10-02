public class Kata
{
  public static string PeopleWithAgeDrink(int old)
  {
  string resultado = "";
  if (old < 14){
    resultado = "drink toddy";
  }
    else if (old <18)
      {
      resultado = "drink coke";
    }
    else if (old < 21)
      {
      resultado = "drink beer";
    }
     else 
      {
      resultado = "drink whisky";
    }
    return resultado;
  }
}