using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Beta2
{
    public class JobTitle
    {
        [Key]
        public int JobTitleId { set; get; }
        public string Title { set; get; }

        public void EditJobTitle(string title)
        {
            Title = title;
        }

        public JobTitle()
        {

        }

        public JobTitle(string title)
        {
            Title = title;
        }
    }
}
