using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.subuser.department.update
    /// </summary>
    public class SubuserDepartmentUpdateRequest : ITopRequest<SubuserDepartmentUpdateResponse>
    {
        /// <summary>
        /// 部门ID
        /// </summary>
        public Nullable<long> DepartmentId { get; set; }

        /// <summary>
        /// 部门名称
        /// </summary>
        public string DepartmentName { get; set; }

        /// <summary>
        /// 父部门ID 如果是最高部门则传入0
        /// </summary>
        public Nullable<long> ParentId { get; set; }

        /// <summary>
        /// 主账号用户名
        /// </summary>
        public string UserNick { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.subuser.department.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("department_id", this.DepartmentId);
            parameters.Add("department_name", this.DepartmentName);
            parameters.Add("parent_id", this.ParentId);
            parameters.Add("user_nick", this.UserNick);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("department_id", this.DepartmentId);
            RequestValidator.ValidateRequired("user_nick", this.UserNick);
        }

        #endregion

        public void AddOtherParameter(string key, string value)
        {
            if (this.otherParameters == null)
            {
                this.otherParameters = new TopDictionary();
            }
            this.otherParameters.Add(key, value);
        }
    }
}
