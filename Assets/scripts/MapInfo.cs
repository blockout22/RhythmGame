using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapInfo
{
    public string name;
    public string song;
    public Data[] songData;
}

[System.Serializable]
public class Data
{
    public int time;
    public int spawnTime = 4000;
    public Distance distance;
    public int spawnAngle = 0;
    //this value is only used during play time and is used to prevent duplicate spawns
    public bool dealthWith = false;
}

[System.Serializable]
public enum Distance
{
    CLOSE, FAR
}
