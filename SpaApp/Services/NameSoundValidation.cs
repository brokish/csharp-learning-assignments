namespace FitnessApp.Services;

public static class NameSoundValidation
{
    private static char[] xmovnebi = "aeiouაეიოუ".ToCharArray();
    
    public static int CountVowels(this string name)
    {
        int xmovenbi = 0; 
        
      foreach (char c in name.ToLower() )
      {
          if (xmovnebi.Contains(c))
          {
              xmovenbi++;
          }
      
         
      }
      
      return xmovenbi;
    }
    
}