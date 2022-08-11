using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketBookingSystem.Training.Services;
using Autofac;
using TicketBookingSystem.Models;
using Microsoft.AspNetCore.Http;

namespace TicketBookingSystem.Areas.Admin.Models
{
    public class CustomerListModel
    {
        private readonly ICustomerService _customerService;
        private IHttpContextAccessor _httpContextAccessor;
        public CustomerListModel()
        {
            _customerService = Startup.AutofacContainer.Resolve<ICustomerService>();
            _httpContextAccessor = Startup.AutofacContainer.Resolve<IHttpContextAccessor>();
        }
        public CustomerListModel(ICustomerService customerService, IHttpContextAccessor httpContextAccessor)
        {
            _customerService = customerService;
            _httpContextAccessor = httpContextAccessor;
        }

        //internal object GetCustomers(DataTablesAjaxRequestModel dataTablesModel)
        //{
        //    var data = _customerService.GetCourses(
        //        dataTablesModel.PageIndex,
        //        dataTablesModel.PageSize,
        //        dataTablesModel.SearchText,
        //        dataTablesModel.GetSortText(new string[] { "Name", "Age", "Address" })
        //        );
        //    return new {
        //        recordsTotal = data.total,
        //        recordsFilter = data.totalDisplay,
        //        data = (from record in data.records
        //                select new string[]
        //                {
        //                    record.Name,
        //                    record.Age.ToString(),
        //                    record.Address
        //                }
        //                ).ToArray()
        //    };
        //}
        internal object GetCustomers(DataTablesAjaxRequestModel dataTablesModel)
        {
            var data = _customerService.GetCustomers(
                dataTablesModel.PageIndex,
                dataTablesModel.PageSize,
                dataTablesModel.SearchText,
                dataTablesModel.GetSortText(new string[] { "Name", "Age", "Address" })
                );
            return new
            {
                recordsTotal = data.total,
                recordsFilter = data.totalDisplay,
                data = (from record in data.records
                        select new string[]
                        {
                            record.Name,
                            record.Age.ToString(),
                            record.Address
                        }
                        ).ToArray()
            };
        }
    }
}
