using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;
using UnityEditor;


namespace JSONExporter
{

public class JEObject
{
    public string name;

    public object ToJSON()
    {
        throw new NotImplementedException("Attempting to call JEObject ToJSON (override method)");        
    }

}

}