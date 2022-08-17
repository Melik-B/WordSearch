//word search

//ALGORITHM

//1.1 Start.
//1.2 User can login again and again until they press the letter 'q', when they press the letter 'q' they exit the application.
//1.3 The user is prompted to enter a sentence.
//1.4 The user is asked to enter a word she wants to search in the sentence she entered.
//1.5 If the word entered by the user is in the sentence, 'word' found in 'sentence' is written on the screen.
//1.6 If the word entered by the user is not in the sentence, 'word' not found in 'sentence' is displayed on the screen.


//kelime arama

//ALGORİTMA

//1.1 Başla.
//1.2 Kullanıcı 'q' harfine basana kadar tekrar tekrar giriş yapabilir, 'q' harfine bastığında uygulamadan çıkılır.
//1.3 Kullanıcıdan bir cümle girmesi istenir.
//1.4 Kullanıcıdan girdiği cümlede aramak istediği bir kelimeyi girmesi istenir..
//1.5 Eğer kullanıcının girdiği kelime cümlede varsa ekrana 'kelime' 'cümlede' bulundu yazılır.
//1.6 Eğer kullanıcının girdiği kelime cümlede yoksa ekrana 'kelime' 'cümlede' bulunamadı yazılır.



Console.Write("Sentence (Quit: q): ");
string sentence = Console.ReadLine();

while (sentence != "q")
{
    Console.Write("Word: ");
    string word = Console.ReadLine();
    string result;

    //if (sentence.IndexOf(word) == -1)
    //    result = "\"" + word + "\" not found in \"" + sentence + "\".";
    //else
    //    result = "\"" + word + "\" found in \"" + sentence + "\".";

    //if (sentence.Contains(word))
    //    result = "\"" + word + "\" found in \"" + sentence + "\".";
    //else
    //    result = "\"" + word + "\" not found in \"" + sentence + "\".";

    string[] sentenceWords = sentence.Split(' ');
    bool found = false; // flag
    foreach (string sentenceWord in sentenceWords)
    {
        if (sentenceWord.Trim() == word.Trim())
        {
            found = true;
            break;
        }
    }
    if (found == true)
        result = "\"" + word + "\" found in \"" + sentence + "\".";
    else
        result = "\"" + word + "\" not found in \"" + sentence + "\".";
    Console.WriteLine(result);

    Console.Write("\nSentence (Quit: q): ");
    sentence = Console.ReadLine();
}
