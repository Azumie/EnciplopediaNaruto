using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnciclopediaNaruto.Shared
{
    public class Page
    {
        public List<Personaje> characters { get; set; }
        public int currentPage { get; set; }
        public int pageSize { get; set; }
        public int totalCharacters { get; set; }
    }

    public class Debut
    {
        public string ?novel { get; set; }
        public string ?movie { get; set; }
        public string ?appearsIn { get; set; }
    }

    public class Personal
    {
        public string ?species { get; set; }
    }

    public class Personaje
    {
        public int id { get; set; }
        public string ?name { get; set; }
        public List<string> ?images { get; set; }
        public Debut ?debut { get; set; }
        public List<string> ?jutsu { get; set; }
        public Personal ?personal { get; set; }
        public List<string> ?uniqueTraits { get; set; }
    }
}
