using System;
using System.Linq;

namespace CaesarCipher
{
    public static class RotationalCipher
    {
        public static string Rotate(string text, int shiftKey)
        {
             char[] Arr = text.ToCharArray();
        for (int i = 0; i < Arr.Length; i++)
        {
           if(!char.IsLetter(Arr[i])){
                Arr[i]=Arr[i];
}            else{                        
            char letter = Arr[i];
            
            letter = (char)(letter + shiftKey);
                if(!char.IsUpper(Arr[i])){
         
            if (letter > 'z')
            {
                letter = (char)(letter - 26);
            }
            else if (letter < 'a')
            {
                letter = (char)(letter + 26);
            }}
     if(char.IsUpper(Arr[i])){
                    
            if (letter > 'Z')
            {
                letter = (char)(letter - 26);
            }
            else if (letter < 'A')
            {
                letter = (char)(letter + 26);
            }
}
     
            Arr[i] = letter;
        }  } 
        return new string(Arr);
        }
        public static void Main(string[] args){
            string text=Console.ReadLine();
            int shiftKey=Convert.ToInt32(Console.ReadLine());
            string Cipher = Rotate(text,shiftKey);
        }
    }
}
