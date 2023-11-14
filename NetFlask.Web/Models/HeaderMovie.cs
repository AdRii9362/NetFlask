namespace NetFlask.Web.Models
{
    public class HeaderMovie
    {
        private string _title;
        private string _description;
        private string _picturePath;
        private DateTime _releaseDate;
        private string _directors;
        private double _rating;
        private string genre;
        private string _categorie;

        //encapsulation: selectionner tous mes private string et faire ctrl + r + e
        public string Title { get => _title; set => _title = value; }
        public string Description { get => _description; set => _description = value; }
        public string PicturePath { get => _picturePath; set => _picturePath = value; }
        public DateTime ReleaseDate { get => _releaseDate; set => _releaseDate = value; }
        public string Directors { get => _directors; set => _directors = value; }
        public double Rating { get => _rating; set => _rating = value; }
        public string Genre { get => genre; set => genre = value; }
        public string Categorie { get => _categorie; set => _categorie = value; }
    }
}
