using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaNonsearchDemographicsGetResponse.
    /// </summary>
    public class SimbaNonsearchDemographicsGetResponse : TopResponse
    {
        /// <summary>
        /// 人群维度设置列表
        /// </summary>
        [XmlArray("demographic_setting_list")]
        [XmlArrayItem("demographic_setting")]
        public List<DemographicSetting> DemographicSettingList { get; set; }
    }
}
