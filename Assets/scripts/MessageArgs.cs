using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageArgs
{
    private string args = "";


    public void set(string args)
    {
        this.args = args;
    }
    public string get()
    {
        return args;
    }
}
