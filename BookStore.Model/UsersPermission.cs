using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Model
{
    public class UsersPermission
    {
        private int _Id;
        private int _RolesId;
        private int _SystemMentId;

        public int Id { get => _Id; set => _Id = value; }
        public int RolesId { get => _RolesId; set => _RolesId = value; }
        public int SystemMentId { get => _SystemMentId; set => _SystemMentId = value; }
    }
}
