using System.Text.RegularExpressions;

#region Create and set a Dictionary of conversion

  IDictionary<char, string> braileCode = new Dictionary<char, string>();

  braileCode.Add('a', ".-"); braileCode.Add('b', "-...");
  braileCode.Add('c', "-.-."); braileCode.Add('d', "-..");
  braileCode.Add('e', "."); braileCode.Add('f', "..-.");
  braileCode.Add('g', "--."); braileCode.Add('h', "....");
  braileCode.Add('i', ".."); braileCode.Add('j', ".---");
  braileCode.Add('k', "-.-"); braileCode.Add('l', ".-..");
  braileCode.Add('m', "--"); braileCode.Add('n', "-.");
  braileCode.Add('o', "---"); braileCode.Add('p', ".--.");
  braileCode.Add('q', "--.-"); braileCode.Add('r', ".-.");
  braileCode.Add('s', "..."); braileCode.Add('t', "-");
  braileCode.Add('u', "..-"); braileCode.Add('v', "...-");
  braileCode.Add('w', ".--"); braileCode.Add('x', "-..-");
  braileCode.Add('y', "-.--"); braileCode.Add('z', "--..");
  braileCode.Add('1', ".----"); braileCode.Add('2', "..---");
  braileCode.Add('3', "...--"); braileCode.Add('4', "....-");
  braileCode.Add('5', "....."); braileCode.Add('6', "-....");
  braileCode.Add('7', "--..."); braileCode.Add('8', "---..");
  braileCode.Add('9', "----."); braileCode.Add('0', "-----");
#endregion

Regex comparativeRegexAlf = new Regex("[a-zA-Z0-9]");
Regex comparativeRegexBraile = new Regex(@"\.?\-?");

Console.WriteLine("Ingresa la frase a convertir");

string? paragraphToConvert = Console.ReadLine();

if(comparativeRegexAlf.IsMatch(paragraphToConvert))
  Console.WriteLine(ConvertToMorse(paragraphToConvert));
else if(comparativeRegexBraile.IsMatch(paragraphToConvert))
  Console.WriteLine(ConvertFromMorse(paragraphToConvert));
else
  Console.WriteLine("Hubo un problema con la conversión. Revise el texto ingresado");

string ConvertToMorse(string words) {
  string morse = "";

  int pos = 0;
  char letter;
  try
  {
    while(pos < words.Length) {
      letter = char.Parse(words[pos].ToString().ToLower());
      if(letter == ' ') morse = morse + "  ";
      else morse = morse + braileCode[letter] + " ";
      pos++;
    }
  }
  catch (System.Exception)
  {
    Console.WriteLine("Hubo un error al convertir de alfabético a Braile");
    return "";
  }
  Console.WriteLine("El resultado es el siguiente");
  return morse;
}

string ConvertFromMorse(string code) {
  string paragraph = "";

  string[] toConvert = code.Split(" ");

  int pos = 0;
  try
  {
    while(pos < toConvert.Length) {
      if(toConvert[pos] == "") paragraph = paragraph + " ";
      else paragraph = paragraph + braileCode.FirstOrDefault(x => x.Value == toConvert[pos]).Key;
      pos++;
    }
  }
  catch (System.Exception)
  {
    Console.WriteLine("Hubo un error al convertir de Braile a alfabético");
    return "";
  }
  
  Console.WriteLine("El resultado es el siguiente");
  return paragraph;
}