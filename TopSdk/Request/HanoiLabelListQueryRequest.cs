using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.hanoi.label.list.query
    /// </summary>
    public class HanoiLabelListQueryRequest : ITopRequest<HanoiLabelListQueryResponse>
    {
        /// <summary>
        /// 认证信息
        /// </summary>
        public string AppName { get; set; }

        /// <summary>
        /// 模板业务状态 1 审核 0 创建
        /// </summary>
        public Nullable<long> BizStatus { get; set; }

        /// <summary>
        /// 模板的编码
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 当前页、默认为1
        /// </summary>
        public Nullable<long> CurrentPage { get; set; }

        /// <summary>
        /// 根据时间查询 创建时间结束点
        /// </summary>
        public Nullable<DateTime> GmtCreateEnd { get; set; }

        /// <summary>
        /// 根据时间查询 创建时间截止点
        /// </summary>
        public Nullable<DateTime> GmtCreateStart { get; set; }

        /// <summary>
        /// 根据时间查询，最近修改时间截止
        /// </summary>
        public Nullable<DateTime> GmtModifiedEnd { get; set; }

        /// <summary>
        /// 根据时间查询，最近修改时间起点
        /// </summary>
        public Nullable<DateTime> GmtModifiedStart { get; set; }

        /// <summary>
        /// 模板id
        /// </summary>
        public Nullable<long> Id { get; set; }

        /// <summary>
        /// 是否查询总数，默认false
        /// </summary>
        public Nullable<bool> IsTotal { get; set; }

        /// <summary>
        /// 模板名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 开放策略 true 开放
        /// </summary>
        public Nullable<bool> Open { get; set; }

        /// <summary>
        /// 分页查询，默认20
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 添加使用场景字段
        /// </summary>
        public Nullable<long> Scene { get; set; }

        /// <summary>
        /// 标签的源模板id
        /// </summary>
        public Nullable<long> TemplateId { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.hanoi.label.list.query";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("app_name", this.AppName);
            parameters.Add("biz_status", this.BizStatus);
            parameters.Add("code", this.Code);
            parameters.Add("current_page", this.CurrentPage);
            parameters.Add("gmt_create_end", this.GmtCreateEnd);
            parameters.Add("gmt_create_start", this.GmtCreateStart);
            parameters.Add("gmt_modified_end", this.GmtModifiedEnd);
            parameters.Add("gmt_modified_start", this.GmtModifiedStart);
            parameters.Add("id", this.Id);
            parameters.Add("is_total", this.IsTotal);
            parameters.Add("name", this.Name);
            parameters.Add("open", this.Open);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("scene", this.Scene);
            parameters.Add("template_id", this.TemplateId);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("app_name", this.AppName);
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
