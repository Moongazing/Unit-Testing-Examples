using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
  public class StringHelper
  {

    public static string DeleteBlanks(string text)
    {//Excess spaces in the entered text should be deleted

      text = text.Trim();

      string newText = string.Empty;

      for (int i = 0; i < text.Length; i++)
      {

        if (text[i] == ' ' && text[i + 1] == ' ')
        {
          continue;
        }

        newText += text[i];

      }
      return newText;
    }
  }
}
