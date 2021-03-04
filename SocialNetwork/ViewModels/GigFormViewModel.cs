using SocialNetwork.Models;
using System.Collections.Generic;

namespace SocialNetwork.ViewModels
{
    public class GigFormViewModel
    {
        public string venue { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public int  Genre { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
    }
}