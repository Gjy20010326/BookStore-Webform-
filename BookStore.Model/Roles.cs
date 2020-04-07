using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Model
{
    public class Roles
    {
        private int _Id;
        private string _Title;

        public int Id { get => _Id; set => _Id = value; }
        public string Title { get => _Title; set => _Title = value; }
    }
}
