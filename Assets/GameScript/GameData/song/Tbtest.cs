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



namespace cfg.song
{ 

public sealed partial class Tbtest
{
    private readonly Dictionary<int, song.test> _dataMap;
    private readonly List<song.test> _dataList;
    
    public Tbtest(JSONNode _json)
    {
        _dataMap = new Dictionary<int, song.test>();
        _dataList = new List<song.test>();
        
        foreach(JSONNode _row in _json.Children)
        {
            var _v = song.test.Deserializetest(_row);
            _dataList.Add(_v);
            _dataMap.Add(_v.ID, _v);
        }
        PostInit();
    }

    public Dictionary<int, song.test> DataMap => _dataMap;
    public List<song.test> DataList => _dataList;

    public song.test GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public song.test Get(int key) => _dataMap[key];
    public song.test this[int key] => _dataMap[key];

    public void Resolve(Dictionary<string, object> _tables)
    {
        foreach(var v in _dataList)
        {
            v.Resolve(_tables);
        }
        PostResolve();
    }

    public void TranslateText(System.Func<string, string, string> translator)
    {
        foreach(var v in _dataList)
        {
            v.TranslateText(translator);
        }
    }
    
    
    partial void PostInit();
    partial void PostResolve();
}

}