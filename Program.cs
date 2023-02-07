using System.Text.RegularExpressions;

#region Create and set a Dictionary of conversion

  IDictionary<char, string> morseCode = new Dictionary<char, string>();

  morseCode.Add('a', ".-"); morseCode.Add('b', "-...");
  morseCode.Add('c', "-.-."); morseCode.Add('d', "-..");
  morseCode.Add('e', "."); morseCode.Add('f', "..-.");
  morseCode.Add('g', "--."); morseCode.Add('h', "....");
  morseCode.Add('i', ".."); morseCode.Add('j', ".---");
  morseCode.Add('k', "-.-"); morseCode.Add('l', ".-..");
  morseCode.Add('m', "--"); morseCode.Add('n', "-.");
  morseCode.Add('o', "---"); morseCode.Add('p', ".--.");
  morseCode.Add('q', "--.-"); morseCode.Add('r', ".-.");
  morseCode.Add('s', "..."); morseCode.Add('t', "-");
  morseCode.Add('u', "..-"); morseCode.Add('v', "...-");
  morseCode.Add('w', ".--"); morseCode.Add('x', "-..-");
  morseCode.Add('y', "-.--"); morseCode.Add('z', "--..");
  morseCode.Add('1', ".----"); morseCode.Add('2', "..---");
  morseCode.Add('3', "...--"); morseCode.Add('4', "....-");
  morseCode.Add('5', "....."); morseCode.Add('6', "-....");
  morseCode.Add('7', "--..."); morseCode.Add('8', "---..");
  morseCode.Add('9', "----."); morseCode.Add('0', "-----");
#endregion

Regex comparativeRegexAlf = new Regex("[a-zA-Z0-9]");
Regex comparativeRegexMorse = new Regex(@"\.?\-?");

Console.WriteLine("Ingresa la frase a convertir");

string? paragraphToConvert = Console.ReadLine();

if(comparativeRegexAlf.IsMatch(paragraphToConvert))
  Console.WriteLine(ConvertToMorse(paragraphToConvert));
else if(comparativeRegexMorse.IsMatch(paragraphToConvert))
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
      else morse = morse + morseCode[letter] + " ";
      pos++;
    }
  }
  catch (System.Exception)
  {
    Console.WriteLine("Hubo un error al convertir de alfabético a Morse");
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
      else paragraph = paragraph + morseCode.FirstOrDefault(x => x.Value == toConvert[pos]).Key;
      pos++;
    }
  }
  catch (System.Exception)
  {
    Console.WriteLine("Hubo un error al convertir de Morse a alfabético");
    return "";
  }
  
  Console.WriteLine("El resultado es el siguiente");
  return paragraph;
}