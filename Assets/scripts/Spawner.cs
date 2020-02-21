using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject cube;
    public int numberOfObjects = 100;
    [Range(1.0f, 100.0f)]
    public float radius = 10f;

    public GameObject[] objects;

    public float lastRadius = 0;

    void Start()
    {
        objects = new GameObject[numberOfObjects];
        for (int i = 0; i < numberOfObjects; i++)
        {
            float angle = i * Mathf.PI * 2 / numberOfObjects;
            float x = Mathf.Cos(angle) * radius;
            float z = Mathf.Sin(angle) * radius;
            Vector3 pos = new Vector3(x, 0, z);
            float angleDegrees = -angle * Mathf.Rad2Deg;
            Quaternion rot = Quaternion.Euler(0, angleDegrees, 0);
            objects[i] = Instantiate(cube, pos, rot);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(lastRadius != radius)
        {
            for (int i = 0; i < objects.Length; i++)
            {
                float angle = i * Mathf.PI * 2 / numberOfObjects;
                float x = Mathf.Cos(angle) * radius;
                float z = Mathf.Sin(angle) * radius;
                Vector3 pos = new Vector3(x, 0, z);
                float angleDegrees = -angle * Mathf.Rad2Deg;
                Quaternion rot = Quaternion.Euler(0, angleDegrees, 0);
                objects[i].transform.rotation = rot;
                objects[i].transform.position = pos;
            }
            lastRadius = radius;
        }
    }
}
