//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;
using SimpleJSON;



namespace cfg
{ 

public sealed partial class textual :  Bright.Config.BeanBase 
{
    public textual(JSONNode _json) 
    {
        { if(!_json["ID"].IsNumber) { throw new SerializationException(); }  ID = _json["ID"]; }
        { var __json0 = _json["storyChapter"]; if(!__json0.IsArray) { throw new SerializationException(); } int _n0 = __json0.Count; StoryChapter = new string[_n0]; int __index0=0; foreach(JSONNode __e0 in __json0.Children) { string __v0;  { if(!__e0.IsString) { throw new SerializationException(); }  __v0 = __e0; }  StoryChapter[__index0++] = __v0; }   }
        PostInit();
    }

    public textual(int ID, string[] storyChapter ) 
    {
        this.ID = ID;
        this.StoryChapter = storyChapter;
        PostInit();
    }

    public static textual Deserializetextual(JSONNode _json)
    {
        return new textual(_json);
    }

    /// <summary>
    /// 故事序号
    /// </summary>
    public int ID { get; private set; }
    /// <summary>
    /// 故事内容
    /// </summary>
    public string[] StoryChapter { get; private set; }

    public const int __ID__ = -1417817325;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "ID:" + ID + ","
        + "StoryChapter:" + Bright.Common.StringUtil.CollectionToString(StoryChapter) + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}
}
