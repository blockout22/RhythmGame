using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsTest : MonoBehaviour
{
    public GameObject cube;
    public int rx = 3;
    public int ry = 3;
    public int rz = 3;
    void Start()
    {
        int amt = 0;
        for(int x = -rx; x < rx; x++)
        {
            for (int y = -ry; y < ry; y++)
            {
                for (int z = -rz; z < rz; z++)
                {
                    Vector3 position = new Vector3(x * 1f, y * 1f, z * 1f);
                    Instantiate(cube, position, Quaternion.identity);
                    amt++;
                }
            }
        }

        Debug.Log("Spawned: " + amt + " Objects");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
