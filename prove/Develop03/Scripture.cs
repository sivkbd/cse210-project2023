 namespace ScriptureMemory
 {
 
    class Scripture
    {
        public Reference Reference { get; private set; }

        public List<Word> Words { get; private set; }

        public Scripture(Reference reference, string text)
        {
            Reference = reference;
            Words = new List<Word>();
            foreach (string word in text.Split(' ', ',', '.', ';', ':', '?', '!'))
            {
                if (word != "") 
                {
                    Words.Add(new Word(word));
                }
            }
        }

        public override string ToString()
        {
            string result = "";
            foreach (Word word in Words) 
            {
                result += word + " ";
            }
            result += "\n"; 
            result += "(" + Reference + ")"; 
            return result;
        }

        
        public void HideRandomWord()
        {
            Random random = new Random();
            int index = random.Next(Words.Count); 
            while (Words[index].IsHidden) 
            {
                index = random.Next(Words.Count);
            }
            Words[index].IsHidden = true; 
        }

        public bool AreAllWordsHidden()
        {
            foreach (Word word in Words) 
            {
                if (!word.IsHidden) 
                {
                    return false;
                }
            }
            return true; 
        }
    }
 }