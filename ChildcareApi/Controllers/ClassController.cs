using ChildcareApi.Models;
using Entities;
using Newtonsoft.Json;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ChildcareApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ClassController : ApiController
    {
        ChildCareContext context;
        IClassRepository repository;

        public ClassController()
        {
            context = new ChildCareContext();
            this.repository = new ClassRepository(new ChildCareContext());
        }

        public ClassController(IClassRepository repository)
        {
            this.repository = repository;
        }
        // GET api/Class

        public IHttpActionResult Get()
        {
            var data = repository.GetAll();
            if (data == null)
            {
                return NotFound();
            }
            return Ok(data);
        }


        // GET api/Class/5

        public IHttpActionResult Get(int id)
        {
            Addclass data = repository.Get(id);
            if (data == null)
            {
                return NotFound();
            }
            return Ok(data);

        }
        // POST api/Class
        public IHttpActionResult PostClass(Addclass item/*, HttpPostedFileBase file*/)
        {
            //Dictionary<string, object> dict = new Dictionary<string, object>();
            //  string str = files(file);
            //  item.Img = str;
            try
            {
                var httpRequest = HttpContext.Current.Request;
                item = repository.Add(item);
                repository.Save();
                //var response = Request.CreateResponse<Addclass>(HttpStatusCode.Created, item);

                //string uri = Url.Link("DefaultApi", new { id = item.CId });
                //response.Headers.Location = new Uri(uri);
               // return Ok();
                var data = repository.GetAll();
                if (data == null)
                {
                    return NotFound();
                }
                return Ok(data);
            }
            catch
            {
                return InternalServerError();
            }
        }

        // PUT api/Class/5
        public IHttpActionResult PutClass(Addclass p)
        {

            // emp.Id = id;
            if (!repository.Update(p))
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            // return Ok("Successful");
            else
            {
                var data = repository.GetAll();
                if (data == null)
                {
                    return NotFound();
                }
                return Ok(data);
            }
        }

        [HttpPatch]
        public IHttpActionResult PatchClass(int id, Addclass p)
        {
            p.CId = id;
            if (!repository.Update(p))
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            //  return Ok("Successful");
            var data = repository.GetAll();
            if (data == null)
            {
                return NotFound();
            }
            return Ok(data);

        }
        public void DeleteClass(int id)
        {
            Addclass item = repository.Get(id);
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            repository.Remove(id);
            repository.Save();
        }

        //[HttpGet]
        //public IEnumerable<Addclass> GetAll(/*[FromUri]PagingParameterModel pagingparametermodel*/)
        //{

        //    // Return List of Class  
        //    var source = (from p in context.ClassData.
        //                    OrderBy(a => a.CId)
        //                  select p).AsQueryable();

            //    if (!string.IsNullOrEmpty(pagingparametermodel.QuerySearch))
            //    {
            //        source = source.Where(a => a.Name.Contains(pagingparametermodel.QuerySearch));
            //    }

            //    // Get's No of Rows Count   
            //    int count = source.Count();

            //    // Parameter is passed from Query string if it is null then it default Value will be pageNumber:1  
            //    int CurrentPage = pagingparametermodel.pageNumber;

            //    // Parameter is passed from Query string if it is null then it default Value will be pageSize:20  
            //    int PageSize = pagingparametermodel.pageSize;

            //    // Display TotalCount to Records to User  
            //    int TotalCount = count;

            //    // Calculating Totalpage by Dividing (No of Records / Pagesize)  
            //    int TotalPages = (int)Math.Ceiling(count / (double)PageSize);

            //    // Returns List of Customer after applying Paging   
            //    var items = source.Skip((CurrentPage - 1) * PageSize).Take(PageSize).ToList();

            //    // if CurrentPage is greater than 1 means it has previousPage  
            //    var previousPage = CurrentPage > 1 ? "Yes" : "No";

            //    // if TotalPages is greater than CurrentPage means it has nextPage  
            //    var nextPage = CurrentPage < TotalPages ? "Yes" : "No";

            //    // Object which we are going to send in header   
            //    var paginationMetadata = new
            //    {
            //        totalCount = TotalCount,
            //        pageSize = PageSize,
            //        currentPage = CurrentPage,
            //        totalPages = TotalPages,
            //        previousPage,
            //        nextPage,
            //        QuerySearch = string.IsNullOrEmpty(pagingparametermodel.QuerySearch) ?
            //              "No Parameter Passed" : pagingparametermodel.QuerySearch
            //    };

            //    // Setting Header  
            //    HttpContext.Current.Response.Headers.Add("Paging-Headers", JsonConvert.SerializeObject(paginationMetadata));
            //    // Returing List of Customers Collections  
            //    return items;

        //}

    }
    }
