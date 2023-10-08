// A class to represent a scripture reference, such as "John 3:16" or "Proverbs 3:5-6"
    class Reference
    {
        // The book name, such as "John" or "Proverbs"
        public string Book { get; private set; }

        // The chapter number, such as 3
        public int Chapter { get; private set; }

        // The starting verse number, such as 16 or 5
        public int StartVerse { get; private set; }

        // The ending verse number, such as 6 or -1 if there is no range
        public int EndVerse { get; private set; }

        // A constructor for a single verse reference, such as "John 3:16"
        public Reference(string book, int chapter, int verse)
        {
            Book = book;
            Chapter = chapter;
            StartVerse = verse;
            EndVerse = -1; // Indicates no range
        }

        // A constructor for a verse range reference, such as "Proverbs 3:5-6"
        public Reference(string book, int chapter, int startVerse, int endVerse)
        {
            Book = book;
            Chapter = chapter;
            StartVerse = startVerse;
            EndVerse = endVerse;
        }

        // A method to return the string representation of the reference
        public override string ToString()
        {
            if (EndVerse == -1) // Single verse
            {
                return $"{Book} {Chapter}:{StartVerse}";
            }
            else // Verse range
            {
                return $"{Book} {Chapter}:{StartVerse}-{EndVerse}";
            }
        }
    }
