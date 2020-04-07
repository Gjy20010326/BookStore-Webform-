using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Model;
using System.Data.SqlClient;
using System.Data;

namespace BookStore.DAL
{
    public class UsersDAL
    {
        /// <summary>
        /// 判断电子邮件是否存在
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public int SearchUsersEmail(string email)
        {
            string sql = "select * from Users where Email=@Email";
            SqlParameter[] sp = 
            {
                new SqlParameter("@Email",SqlDbType.VarChar,255,email)
            };
            return SqlHelper.Query(sql,sp).Rows.Count;
        }
        /// <summary>
        /// 注册信息
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public int AddUsers(Users u)
        {
            string sql = "insert into Users(Email,Password,NickName,Photo,CreateTime,RolesId)values(@Email,@Password,@NickName,@Photo,getdate(),@RolesId);";
            SqlParameter[] sp = 
            {
                new SqlParameter("@Email",SqlDbType.VarChar,255,u.Email),
                new SqlParameter("@Password",SqlDbType.VarChar,255,u.Password),
                new SqlParameter("@NickName",SqlDbType.VarChar,255,u.NickName),
                new SqlParameter("@Photo",SqlDbType.VarChar,255,u.Photo),
                new SqlParameter("@RolesId",SqlDbType.Int,u.RolesId)
            };
            return SqlHelper.ExecuteNonQuery(sql,sp);
        }
        /// <summary>
        /// 修改信息
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public int Edit(Users u)
        {
            string sql = "update Users set Email=@Email,Password=@Password,NickName=@NickName,Photo=@Photo,CreateTime=getdate(),RolesId=@RolesId where Id=@Id";
            SqlParameter[] sp =
            {
                new SqlParameter("@Email",SqlDbType.VarChar,255,u.Email),
                new SqlParameter("@Password",SqlDbType.VarChar,255,u.Password),
                new SqlParameter("@NickName",SqlDbType.VarChar,255,u.NickName),
                new SqlParameter("@Photo",SqlDbType.VarChar,255,u.Photo),
                new SqlParameter("@RolesId",SqlDbType.Int,u.RolesId)
            };
            return SqlHelper.ExecuteNonQuery(sql,sp);
        }
        public int Del(int id)
        {
            string sql = "delete from Users where Id=@Id";
            SqlParameter[] sp =
            {
                new SqlParameter("@Id",SqlDbType.Int,id)
            };
            return SqlHelper.ExecuteNonQuery(sql,sp);
        }
    }
}
