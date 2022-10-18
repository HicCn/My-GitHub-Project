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
        { if(!_json["storyChapter"].IsString) { throw new SerializationException(); }  StoryChapter = _json["storyChapter"]; }
        PostInit();
    }

    public textual(int ID, string storyChapter ) 
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
    public string StoryChapter { get; private set; }

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
        + "StoryChapter:" + StoryChapter + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}
}
