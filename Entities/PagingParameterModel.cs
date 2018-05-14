//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Entities
//{
//    public class PagingParameterModel
//    {
//        // To define the max page size
//        const int maxPageSize = 20;

//        // It defines the page number
//        public int pageNumber { get; set; } = 1;

//        //it defines the number of records in a page
//        public int _pageSize { get; set; } = 5;

//        public int pageSize
//        {
//            get { return _pageSize; }
//            set
//            {
//                _pageSize = (value > maxPageSize) ? maxPageSize : value;
//            }
//        }
//        public string QuerySearch { get; set; }
//    }
//}
