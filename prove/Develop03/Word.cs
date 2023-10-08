// A class to represent a word in the scripture text
    class Word
    {
        // The text of the word, such as "God" or "love"
        public string Text { get; private set; }

        // A boolean flag to indicate if the word is hidden or not
        public bool IsHidden { get; set; }

        // A constructor for a word
        public Word(string text)
        {
            Text = text;
            IsHidden = false; // Initially not hidden
        }

        // A method to return the string representation of the word
        public override string ToString()
        {
            if (IsHidden) // Return an underscore for hidden words
            {
                return "_";
            }
            else // Return the text of the word
            {
                return Text;
            }
        }
    }
