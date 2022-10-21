using LiteDB;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Tables.dll
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
        public ICollection<User> User { set; get; }

        /// <summary>
        /// ����� ���������� ���������� ������������� �� ������
        /// </summary>
        /// <returns></returns>
        public int CountUsers()
        {
            return User.Count();
        }

        /// <summary>
        /// ����� ���������� ��������� �� ����
        /// </summary>
        /// <returns></returns>
        public bool IsTableFull()
        {
            if (User.Count() < MaxUsers)
                return false;
            else 
                return true;

           // return (User.Count() < MaxUsers);
        }
    }
}