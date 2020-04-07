using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Model
{
    public class FriendLink
    {
        private int _Id;
        private string _Title;
        private string _Link;
        private int _IsShow;

        public int Id { get => _Id; set => _Id = value; }
        public string Title { get => _Title; set => _Title = value; }
        public string Link { get => _Link; set => _Link = value; }
        public int IsShow { get => _IsShow; set => _IsShow = value; }
    }
}
