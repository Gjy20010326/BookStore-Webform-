using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Model
{
    public class Users
    {
        private int _Id;
        private string _Email;
        private string _Password;
        private string _NickName;
        private string _Photo;
        private string _CreateTime;
        private int _RolesId;

        public int Id { get => _Id; set => _Id = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Password { get => _Password; set => _Password = value; }
        public string NickName { get => _NickName; set => _NickName = value; }
        public string Photo { get => _Photo; set => _Photo = value; }
        public string CreateTime { get => _CreateTime; set => _CreateTime = value; }
        public int RolesId { get => _RolesId; set => _RolesId = value; }
    }
}
