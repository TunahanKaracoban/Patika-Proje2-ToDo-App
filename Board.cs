using System.Collections.Generic;

namespace ToDo_App
{
    public class Board
    {
        public List<Card> TODO = new List<Card>();
        public List<Card> IN_PROGRESS = new List<Card>();
        public List<Card> DONE = new List<Card>();

        public Board()
        {
            TODO.Add(new Card("Proje2", "Patika'daki C#101 modülünün ödevini yap", 1, 1));
            IN_PROGRESS.Add(new Card("OOP", "Nesne Tabanlı Programlama da projeleri bitir", 2, 3));
            DONE.Add(new Card("Listening", "Her gün 15 dk ingilizce podcast dinle", 3, 4));
        }

        public List<Card> GetProperty(string str)
        {
            if (str == "TODO")
                return this.TODO;
            else if (str == "IN_PROGRESS")
                return this.IN_PROGRESS;
            else
                return this.DONE;
        }

    }
}