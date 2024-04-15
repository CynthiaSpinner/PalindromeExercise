using System;
using System.Linq;


namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalinedrome(string palin) 
        {
            //var reversed = "";

            //for (int i = palin.Length - 1; i >= 0; i--) 
            //{
            //  reversed += palin.ToLower()[i];
            //}
            //if(reversed == palin.ToLower())
            //{
            //  return true;
            //}
            //else { return  false; }
            return palin.ToLower().SequenceEqual(palin.ToLower().Reverse());

        }
    }
}
