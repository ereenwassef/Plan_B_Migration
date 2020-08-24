
using NewDBModels.Models;
using OldDatabaseModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace migration.Controllers
{
    [RoutePrefix("api/migrate")]
    public class ValuesController : ApiController
    {
        Plan_BEntities OldDB = new Plan_BEntities();
        NewDBModel NewDB = new NewDBModel();
        // GET api/values

        [HttpGet]
        [Route("ActionTypes")]
        public IEnumerable<string> ActionTypes()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet]
        [Route()] public IEnumerable<string> ActivityLogTypes() { return new string[] { "value1", "value2" }; }
        [HttpGet]
        [Route()] public IEnumerable<string> Balance_Action_History() { return new string[] { "value1", "value2" }; }
        [HttpGet]
        [Route()] public IEnumerable<string> ActivityLogs() { return new string[] { "value1", "value2" }; }
        [HttpGet]
        [Route()] public IEnumerable<string> Categories() { return new string[] { "value1", "value2" }; }
        [HttpGet]
        [Route()] public IEnumerable<string> Cities() { return new string[] { "value1", "value2" }; }
        [HttpGet]
        [Route()] public IEnumerable<string> Courses() { return new string[] { "value1", "value2" }; }
        [HttpGet]
        [Route()] public IEnumerable<string> Course_Category_Mapping() { return new string[] { "value1", "value2" }; }
        [HttpGet]
        [Route()] public IEnumerable<string> Course_Customer_Mapping() { return new string[] { "value1", "value2" }; }
        [HttpGet]
        [Route()] public IEnumerable<string> Course_Instructor_Mapping() { return new string[] { "value1", "value2" }; }
        [HttpGet]
        [Route()] public IEnumerable<string> Course_Package_Mapping() { return new string[] { "value1", "value2" }; }
        [HttpGet]
        [Route()] public IEnumerable<string> CourseDetails() { return new string[] { "value1", "value2" }; }
        [HttpGet]
        [Route()] public IEnumerable<string> CourseLevels() { return new string[] { "value1", "value2" }; }
        [HttpGet]
        [Route()] public IEnumerable<string> CourseTags() { return new string[] { "value1", "value2" }; }
        [HttpGet]
        [Route()] public IEnumerable<string> CourseTypes() { return new string[] { "value1", "value2" }; }
        [HttpGet]
        [Route()] public IEnumerable<string> Customer_CustomerRole_Mapping() { return new string[] { "value1", "value2" }; }
        [HttpGet]
        [Route()] public IEnumerable<string> Customer_Point_Mapping() { return new string[] { "value1", "value2" }; }
        [HttpGet]
        [Route("CustomerAttributes")]
        public IEnumerable<string> CustomerAttributes()
        {var Cinfo= NewDB.CustomerInfoes.GroupBy(g => g.NationalId).ToList();
            //     var CInfoList = Cinfo.Select(s => s.First()).ToList();
            int min = 0, gC=0;

            foreach (var item in Cinfo)
            {
                gC++;
                if (item.Count() > 1)
                { min = item.First().Id;

                    NewDB.CustomerInfoes.RemoveRange(item.Where(c => c.Id != min).ToList());
                    NewDB.SaveChanges();
}
               // var Dcusts=NewDB.CustomerInfoes.Where(c=>c.)

            }
            var customerInf = NewDB.CustomerInfoes.ToDictionary(d=>d.NationalId,d=>d.Id);
            CustomerAttribute custAtt;
            var Distributors = OldDB.Distributors.Where(c => c.ProductID != null & c.Is_Active != null && c.Renewal != null).ToList();
            gC = 0;
            foreach (Distributor row in Distributors)
            {
                gC++;
                custAtt = new CustomerAttribute();
                custAtt.Active = (bool)row.Is_Active;
                custAtt.ChildAvalible = 0;
                custAtt.CreatedOnUtc = (DateTime)DateTime.Now;
                try
                {
                    custAtt.CustomerInfoId = customerInf[row.National_ID];
                }
                catch (Exception ex)
                {

                }
                custAtt.Deleted = false;
                custAtt.Id = row.ID;
                custAtt.LastLoginDateUtc = null;
                custAtt.NumberChild = 0;
                custAtt.ReferId = row.Referrer_ID;
                custAtt.RenewalDateUtc = OldDB.Distributors_Annual_renewal.Where(c=>c.Distributor_ID==row.ID ).OrderByDescending(o=>o.Activation_Date).Select(s=>s.Renewal_Date).FirstOrDefault();

                NewDB.CustomerAttributes.Add(custAtt);

            }
            NewDB.SaveChanges();

            return new string[] { "value1", "value2" };
        }
        [HttpGet]
        [Route("CustomerInfo")]
        public IEnumerable<string> CustomerInfoes()
        {
            CustomerInfo cut;
            List<CustomerInfo> cuts = new List<CustomerInfo>();
            var Distributors = OldDB.Distributors.Where(c => c.ProductID != null & c.Is_Active != null && c.Renewal != null).ToList();
            var GroupsDistributor = Distributors.GroupBy(g => g.Guide_ID).ToList();
            var dd = GroupsDistributor.Select(s => s.First()).ToList();
            int count = 0;
            List<int> ids;
            foreach (var s in dd)
            {
                count++;
                try
                    {
                  //  var s = row.First();
                    cut = new CustomerInfo()
                    {
                        address = s.Address ,
                        CityId = s.City_ID,
                        CreatedOnUtc = (DateTime)s.Activation_Date,
                        Email = s.Email,
                        Gendar = s.Gender,
                        Mobile = s.Mobile,
                        NameEN = s.Name,
                        NameAR = s.Name_AR,
                        NationalId = s.National_ID,
                        UpdatedOnUtc = (DateTime)s.Activation_Date,
                       



                    };
                   ids = Distributors.Where(c => c.Guide_ID == s.Guide_ID).Select(s1 => s1.ID).ToList();
                    cut.balance = (decimal)OldDB.Profits.Where(cb => cb.Is_Paid == false & ids.Any(a => a == cb.Distributor_ID)).Sum(m => m.Profit1).GetValueOrDefault();
                   // cut.balance = balance;
                   // cut.balance = (decimal)OldDB.Profits.Where(cb => cb.Is_Paid == false & Distributors.Where(c => c.Guide_ID == row.First().Guide_ID).Select(s1 => s1.ID).ToList().Any(a => a == cb.Distributor_ID)).Sum(m => m.Profit1);

                        NewDB.CustomerInfoes.Add(cut);
                    }
                    catch (Exception ex)
                    {
                       
                    }
                

            }
            NewDB.SaveChanges();
            return new string[] { "value1", "value2" };
        }
        [HttpGet]
        [Route()] public IEnumerable<string> CustomerNetworks() { return new string[] { "value1", "value2" }; }
        [HttpGet]
        [Route()] public IEnumerable<string> CustomerPasswords() { return new string[] { "value1", "value2" }; }
        [HttpGet]
        [Route()] public IEnumerable<string> CustomerTransactions() { return new string[] { "value1", "value2" }; }
        [HttpGet]
        [Route()] public IEnumerable<string> Governorates() { return new string[] { "value1", "value2" }; }
        [HttpGet]
        [Route()] public IEnumerable<string> Instructors() { return new string[] { "value1", "value2" }; }
        [HttpGet]
        [Route()] public IEnumerable<string> Languages() { return new string[] { "value1", "value2" }; }
        [HttpGet]
        [Route()] public IEnumerable<string> Logs() { return new string[] { "value1", "value2" }; }
        [HttpGet]
        [Route()] public IEnumerable<string> OfflineAttendances() { return new string[] { "value1", "value2" }; }
        [HttpGet]
        [Route()] public IEnumerable<string> OnlineAttendances() { return new string[] { "value1", "value2" }; }
        [HttpGet]
        [Route()] public IEnumerable<string> Open_Course_history() { return new string[] { "value1", "value2" }; }
        [HttpGet]
        [Route()] public IEnumerable<string> Packages() { return new string[] { "value1", "value2" }; }
        [HttpGet]
        [Route()] public IEnumerable<string> Payments() { return new string[] { "value1", "value2" }; }
        [HttpGet]
        [Route()] public IEnumerable<string> PointProcesses() { return new string[] { "value1", "value2" }; }
        [HttpGet]
        [Route()] public IEnumerable<string> RequestCashes() { return new string[] { "value1", "value2" }; }
        [HttpGet]
        [Route()] public IEnumerable<string> RequestTypes() { return new string[] { "value1", "value2" }; }
        [HttpGet]
        [Route()] public IEnumerable<string> sysdiagrams() { return new string[] { "value1", "value2" }; }
        [HttpGet]
        [Route()] public IEnumerable<string> TransactionTypes() { return new string[] { "value1", "value2" }; }

    }
}
