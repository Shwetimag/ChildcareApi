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
    public class ParticipantController : ApiController
    {
        ChildCareContext context;
        IParticipantRepository repository;
        
        public ParticipantController()
        {
            context = new ChildCareContext();
            this.repository = new ParticipantRepository(new ChildCareContext());
        }

        public ParticipantController(IParticipantRepository repository)
        {
            this.repository = repository;
        }


       // GET api/Participant

        public IHttpActionResult Get()
        {
            var data = repository.GetAll();
            if (data == null)
            {
                return NotFound();
            }
            return Ok(data);
        }



        // GET api/Participant/5

        public IHttpActionResult Get(int id)
        {
            Participant data = repository.Get(id);
            if (data == null)
            {
                return NotFound();
            }
            return Ok(data);

        }
        // POST api/Participant
        // [Authorize]
        public IHttpActionResult PostParticipant(Participant item/*, HttpPostedFileBase file*/)
        {
            //Dictionary<string, object> dict = new Dictionary<string, object>();
            //  string str = files(file);
            //  item.Img = str;
            try
            {
                var httpRequest = HttpContext.Current.Request;
                item = repository.Add(item);
                repository.Save();
                var response = Request.CreateResponse<Participant>(HttpStatusCode.Created, item);
                string uri = Url.Link("DefaultApi", new { id = item.PId });
                response.Headers.Location = new Uri(uri);
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

        // PUT api/Participant/5
        public IHttpActionResult PutParticipant(Participant p)
        {

            // emp.Id = id;
            if (!repository.Update(p))
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return Ok("Successful");
        }

        [HttpPatch]
        public IHttpActionResult PatchEmployee(int id, Participant p)
        {
            p.PId = id;
            if (!repository.Update(p))
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return Ok("Successful");


        }
        public void DeleteParticipant(int id)
        {
            Participant item = repository.Get(id);
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            repository.Remove(id);
            repository.Save();
        }

        //[HttpGet]
        //public IEnumerable<Participant> GetAllProducts([FromUri]PagingParameterModel pagingparametermodel)
        //{

        //    // Return List of Participants  
        //    var source = (from p in context.ParticipantData.
        //                    OrderBy(a => a.PId)
        //                  select p).AsQueryable();

        //    if (!string.IsNullOrEmpty(pagingparametermodel.QuerySearch))
        //    {
        //        source = source.Where(a => a.FirstName.Contains(pagingparametermodel.QuerySearch));
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
