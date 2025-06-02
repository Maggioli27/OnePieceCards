namespace OnePieceCards.Models
{
    public class Card
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Extension { get; set; } = "";
        public string Rarity { get; set; } = "";
        public string SpecialRarity { get; set; } = "";
        public string ImagePath { get; set; } = "";
        public bool Owned { get; set; }
    }
}
