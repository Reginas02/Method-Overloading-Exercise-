using System.Runtime.CompilerServices;

namespace MethodOverloading
{
    internal class Methods
    {

        public static int Add(int x, int y)
        {
            return x + y;   
        }

        public static decimal Add(decimal x, decimal y) 
        {
            return (decimal)x + y;  
        }
        public static double Add(double x, double y)
        {
            return ((double)x + y) / (double)y; 
        }

        public static string Add(int x, int y, bool withDollars)
        {
            if (withDollars && (x + y)!= 1)
            {
                return $"{x + y} dollars";
            }
            else if (withDollars && x + y == 1)
            {
                return $" {x + y} dollar";
            }
            else
            {
                return $"{x + y}";
            }
        }  
       
        
          
            
              
            }
            
            
 }






   

        
   
    
        
        
            
       
    

       
    
    
    

    

    

















     
        