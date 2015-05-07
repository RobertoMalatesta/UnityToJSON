
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;
using UnityEditor;


namespace JSONExporter
{

public class JETimeOfDay : JEComponent
{

    override public void Preprocess()
    {
        unityTimeOfDay = unityComponent as TimeOfDay;        
    }

    override public void QueryResources()
    {
    }    

    new public static void Reset()
    {
        
    }

    public override JSONComponent ToJSON()
    {
        var json = new JSONTimeOfDay();

        json.type = "TimeOfDay";
        json.timeOn = unityTimeOfDay.TimeOn;
        json.timeOff = unityTimeOfDay.TimeOff;

        return json;
    }

    TimeOfDay unityTimeOfDay;    
}

}