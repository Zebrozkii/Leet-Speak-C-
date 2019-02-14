using System;
using System.Collections.Generic;

namespace Leetspeak
{
  public class Translate
  {
    public string translateString(string word){
      char[] array = word.ToCharArray();

      string result = "";
      for (int i = 0; i < array.Length; i++){
        if (array[i] == 'e') {
          array[i] = '3';
        } else if (array[i] == 'o'){
          array[i] = '0';
        } else if (array[i] == 'I'){
          array[i] = '1';
        } else if (array[i] == 't'){
          array[i] = '7';
        } else if (array[i] == 's'){
          array[i] = 'z';
        }
      }
      result = string.Join("",array);
      return result;
    }
  }
}
