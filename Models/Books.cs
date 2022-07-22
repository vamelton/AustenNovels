using AustenNovels.Models;
using System.ComponentModel.DataAnnotations;

namespace AustenNovels.Models
{
    public class Books
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public double PublishedYear { get; set; }
        public string Characters { get; set; }
        public string Summary { get; set; }
        public string Biography { get; set; }

    }



    }

