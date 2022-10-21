

using System;
using System.ComponentModel.DataAnnotations;

namespace Beta2
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string FirstName { set; get; } = string.Empty;
        public string SecondName { set; get; } = string.Empty;
        public int JobTitleId { set; get; }
        public JobTitle JobTitle { set; get; }
        public int DescId { set; get; }
        public Desc Desc { get; set; }

        public User()
        {

        }
        public User(string username, string usersurname, int tableId)
        {
            FirstName = username;
            SecondName = usersurname;
            DescId = tableId;
        }

        /// <summary>
        /// Метод выводи информацию о пользователе
        /// </summary>
        /// <returns></returns>
        public string GetUserData()
        {
            return String.Format("#############\nid: {0}\nname: {1}\nsurname: {2}\njob_title: {3}", UserId, FirstName, SecondName, JobTitle.Title);
        }
    }
}