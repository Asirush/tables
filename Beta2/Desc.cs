using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Beta2
{
    public class Desc
    {
        public Desc(){}

        public Desc(int maxSize)
        {
            MaxUsers = maxSize;
        }

        [Key]
        public int DescId { set; get; }
        public int MaxUsers { set; get; }
        public ICollection<User> Users { set; get; }

        /// <summary>
        /// —етод возвращает количествл пользователей за столом
        /// </summary>
        /// <returns></returns>
        public int CountUsers()
        {
            return Users.Count();
        }

        /// <summary>
        /// ћетод возвращает сводобный ли стол
        /// </summary>
        /// <returns></returns>
        public bool IsTableFull()
        {
            if (Users.Count() < MaxUsers)
                return false;
            else 
                return true;

           // return (User.Count() < MaxUsers);
        }
    }
}