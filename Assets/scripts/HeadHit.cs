using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadHit : MonoBehaviour
{
    public void hit(MessageArgs args)
    {
        args.set("head");
    }
}
