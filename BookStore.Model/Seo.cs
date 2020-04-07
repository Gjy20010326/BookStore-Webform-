using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Model
{
    public class Seo
    {
        private int _Id;
        private string _Title;
        private string _Keyword;
        private string _Descriptions;
        private int _WebMenuId;

        public int Id { get => _Id; set => _Id = value; }
        public string Title { get => _Title; set => _Title = value; }
        public string Keyword { get => _Keyword; set => _Keyword = value; }
        public string Descriptions { get => _Descriptions; set => _Descriptions = value; }
        public int WebMenuId { get => _WebMenuId; set => _WebMenuId = value; }
    }
}
