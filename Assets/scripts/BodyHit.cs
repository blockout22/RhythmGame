using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyHit : MonoBehaviour
{
    public void hit(MessageArgs args)
    {
        args.set("body");
    }
}
