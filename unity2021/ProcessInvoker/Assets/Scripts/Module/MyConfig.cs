
using System.Xml.Serialization;

namespace XTC.FMP.MOD.ProcessInvoker.LIB.Unity
{
    /// <summary>
    /// 配置类
    /// </summary>
    public class MyConfig : MyConfigBase
    {
        public class Target
        {
            [XmlAttribute("file")]
            public string file { get; set; } = "";
            [XmlAttribute("workdir")]
            public string workdir { get; set; } = "";
            [XmlAttribute("arguments")]
            public string arguments { get; set; } = "";
        }

        public class Style
        {
            [XmlAttribute("name")]
            public string name { get; set; } = "";
            [XmlElement("Target")]
            public Target target { get; set; } = new Target();
        }


        [XmlArray("Styles"), XmlArrayItem("Style")]
        public Style[] styles { get; set; } = new Style[0];
    }
}

