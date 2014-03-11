﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandrill
{
    public partial class MandrillApi
    {
        public RejectDeleteResult DeleteReject(string email)
        {
            try
            {
                return DeleteRejectAsync(email).Result;
            }
            catch (AggregateException aex)
            {
                //catch and throw the inner exception
                throw aex.Flatten().InnerException;
            }
        }
        public Task<RejectDeleteResult> DeleteRejectAsync(string email)
        {
            var path = "/rejects/delete.json";

            dynamic param = new ExpandoObject();
            param.email = email;
            return PostAsync<RejectDeleteResult>(path, param);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="email">email address to limit the results</param>
        /// <returns></returns>
        public List<RejectInfo> ListRejects(string email="")
        {
            try
            {
                return ListRejectsAsync(email).Result;
            }catch(AggregateException aex)
            {
                //catch and throw the inner exception
                throw aex.Flatten().InnerException;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="email">email address to limit the results</param>
        /// <returns></returns>
        public Task<List<RejectInfo>> ListRejectsAsync(string email="")
        {
            var path = "/rejects/list.json";


            dynamic param = new ExpandoObject();
            param.email = email;
            return PostAsync<List<RejectInfo>>(path, param);
        }

    }
}
