using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.DAL;
using BookStore.Model;

namespace BookStore.BLL
{
    public class UsersService
    {
        private UsersDAL ud = new UsersDAL();
        /// <summary>
        /// 注册信息
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public bool AddUsers(Users u)
        {
            return ud.AddUsers(u)>0;
        }
        /// <summary>
        /// 查询email是否存在
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool SearchUsersEmail(string email)
        {
            return ud.SearchUsersEmail(email)>0;
        }
        /// <summary>
        /// 修改信息
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public bool Edit(Users u)
        {
            return ud.Edit(u)>0;
        }
        /// <summary>
        /// 按Id删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Del(int id)
        {
            return ud.Del(id)>0;
        }
    }
}
