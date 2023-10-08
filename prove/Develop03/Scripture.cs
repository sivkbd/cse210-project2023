 namespace ScriptureMemory
 {
 
 // A class to represent a scripture, including the reference and the text
    class Scripture
    {
        // The reference of the scripture, such as "John 3:16" or "Proverbs 3:5-6"
        public Reference Reference { get; private set; }

        // The list of words in the scripture text, such as ["For", "God", "so", ...]
        public List<Word> Words { get; private set; }

        // A constructor for a scripture
        public Scripture(Reference reference, string text)
        {
            Reference = reference;
            Words = new List<Word>();
            // Split the text by spaces and punctuation marks and add each word to the list
            foreach (string word in text.Split(' ', ',', '.', ';', ':', '?', '!'))
            {
                if (word != "") // Ignore empty strings
                {
                    Words.Add(new Word(word));
                }
            }
        }

        // A method to return the string representation of the scripture
        public override string ToString()
        {
            string result = "";
            foreach (Word word in Words) // Append each word to the result
            {
                result += word + " ";
            }
            result += "\n"; // Add a new line at the end of the text
            result += "(" + Reference + ")"; // Add the reference in parentheses
            return result;
        }

        // A method to hide a random word in the scripture that is not already hidden
        public void HideRandomWord()
        {
            Random random = new Random();
            int index = random.Next(Words.Count); // Pick a random index from 0 to count - 1
            while (Words[index].IsHidden) // If the word at that index is already hidden, pick another one until it is not hidden
            {
                index = random.Next(Words.Count);
            }
            Words[index].IsHidden = true; // Set the flag of the word at that index to true
        }

        // A method to check if all words in the scripture are hidden or not
        public bool AreAllWordsHidden()
        {
            foreach (Word word in Words) // Loop through each word in the list
            {
                if (!word.IsHidden) // If any word is not hidden, return false
                {
                    return false;
                }
            }
            return true; // Otherwise, return true
        }
    }
 }