using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.MyContext.Repositories
{
    public interface IMyRepository
    {

    }

    public class MyRepository :  IMyRepository
    {
        private string _lawyerDbContext;

        public MyRepository(string context) { 
            _lawyerDbContext = context;
        }

        public (long, string) GetAddressIdAndAdressTextBySubjectId(long subjectId)
        {
           
            return (1, "London");
        }

    }
}
