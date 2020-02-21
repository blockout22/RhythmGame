using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Map : MonoBehaviour
{
    private Ray ray;
    private Vector3 origin;
    private Vector3 direction;
    private Vector3 arrowHeading;
    private float arrowAngle;

    public float startTime = 0f;
    public float curTime = 0f;

    public Text debugDisplayTime;
    public AudioSource musicSource;
    public AudioClip musicClip, bangClip;

    //this is the reference object which will be used to spawn the objects to hit
    public GameObject mob;

    public RawImage arrowImage;

    //have array storing mob(which store hitbox info) & models(which is the visual aspects);
    MapInfo mapInfo;
    //private GameObject[] list = new GameObject[10];

    void Start()
    {
        ray = new Ray();
        musicSource.clip = musicClip;
        arrowHeading = new Vector3(0, 0, 0);
        arrowAngle = 0f;

        //Vector3 spawnPos = new Vector3(4, 0, -3);
        //Instantiate(mob, spawnPos, Quaternion.identity);

        //createTempMap();
        mapInfo = TestMap.load();

        curTime = 0f;

        string json = UnityEngine.JsonUtility.ToJson(mapInfo, true);
        Debug.Log(json);
    }

    void createTempMap()
    {
        Data d1 = new Data();
        d1.time = 1735;
        d1.spawnTime = 1000;
        d1.distance = Distance.CLOSE;
        d1.spawnAngle = 0;

        Data d2 = new Data();
        d2.time = 2983;
        d2.spawnTime = 1000;
        d2.distance = Distance.FAR;
        d2.spawnAngle = 90;

        Data d3 = new Data();
        d3.time = 3403;
        d3.spawnTime = 1000;
        d3.distance = Distance.CLOSE;
        d3.spawnAngle = 180;

        Data d4 = new Data();
        d4.time = 4223;
        d4.spawnTime = 1000;
        d4.distance = Distance.CLOSE;
        d4.spawnAngle = 270;

        Data d5 = new Data();
        d5.time = 5044;
        d5.spawnTime = 1000;
        d5.distance = Distance.CLOSE;
        d5.spawnAngle = 0;

        Data d6 = new Data();
        d6.time = 6729;
        d6.spawnTime = 1000;
        d6.distance = Distance.CLOSE;
        d6.spawnAngle = -45;

        Data d7 = new Data();
        d7.time = 8353;
        d7.spawnTime = 1000;
        d7.distance = Distance.CLOSE;
        d7.spawnAngle = -38;

        Data d8 = new Data();
        d8.time = 10047;
        d8.spawnTime = 1000;
        d8.distance = Distance.CLOSE;
        d8.spawnAngle = -20;

        Data d9 = new Data();
        d9.time = 11680;
        d9.spawnTime = 1000;
        d9.distance = Distance.CLOSE;
        d9.spawnAngle = 15;

        Data d10 = new Data();
        d10.time = 12776;
        d10.spawnTime = 1000;
        d10.distance = Distance.CLOSE;
        d10.spawnAngle = 5;

        mapInfo = new MapInfo();
        mapInfo.name = "Lost Sky";
        mapInfo.song = "Lost Sky - Dreams pt.II (feat. Sara Skinner).mp3";
        mapInfo.songData = new Data[] { d1, d2, d3, d4, d5, d6, d7, d8, d9, d10 };

        curTime = 0f;

        string json = UnityEngine.JsonUtility.ToJson(mapInfo, true);
        Debug.Log(json);
    }


    // Update is called once per frame
    void Update()
    {
        if(!musicSource.isPlaying)
        {
            musicSource.Play();
        }
        displayCurrentTime();

        input();

        updateGamePlay();
    }

    void displayCurrentTime()
    {
        curTime += Time.deltaTime * 1000;
        double trackTime = (musicSource.timeSamples / musicSource.clip.samples) * musicSource.clip.length;
        debugDisplayTime.text = "Time: " + curTime;
    }

    void input()
    {
        if (Input.GetMouseButtonDown(0))
        {
            musicSource.PlayOneShot(bangClip, Settings.EFFECTS_VOLUME);
            //check for hits
            //change this to on click
            origin = this.transform.position;
            direction = this.transform.TransformDirection(Vector3.forward);

            GameObject obj = castRayTo(origin, direction, 100f);
            if (obj != null)
            {
                MessageArgs args = new MessageArgs();
                obj.SendMessage("hit", args, SendMessageOptions.DontRequireReceiver);
                bool hit = false;
                if (args.get().Equals("head"))
                {
                    Debug.Log("HEAD SHOT!!!!!!!!");
                    hit = true;
                }
                else if (args.get().Equals("body"))
                {
                    Debug.Log("This was aBody Shot");
                    hit = true;
                }
                if (hit)
                {
                    //remove after hit;
                    Destroy(obj.transform.parent.gameObject, .2f);
                }
            }
        }
    }

    void updateGamePlay()
    {
        for(int i = 0; i < mapInfo.songData.Length; i++)
        {
            Data d = mapInfo.songData[i];
            if(d == null)
            {
                continue;
            }
            if(curTime >= d.time - d.spawnTime && !d.dealthWith)
            {
                float dist = 0f;
                if(d.distance == Distance.CLOSE)
                {
                    dist = 5f;
                }else if(d.distance == Distance.FAR)
                {
                    dist = 15f;
                }

                float x = dist * Mathf.Cos(d.spawnAngle * Mathf.Deg2Rad);
                float z = dist * Mathf.Sin(d.spawnAngle * Mathf.Deg2Rad);

                //Vector3 pos = new Vector3(dist * Mathf.Sin(d.spawnAngle * Mathf.Deg2Rad), 0, dist * Mathf.Cos(d.spawnAngle * Mathf.Deg2Rad));
                Vector3 pos = new Vector3(x, 0, z);
                arrowHeading = pos - transform.position;
                //arrowLookLocation.x = x;
                //arrowLookLocation.y = z;
                Quaternion rot = Quaternion.LookRotation(this.transform.position, Vector3.up);
                GameObject obj = Instantiate(mob, pos, Quaternion.identity);
                Debug.Log("Spawn at: " + pos + " @ " + curTime);
                Destroy(obj, 0.5f + (d.spawnTime / 1000));


                //StartCoroutine(new SpawnDelay().ExecuteAfterTime(d.spawnTime, () => {
                    
                //}));

                
                d.dealthWith = true;
            }
        }

        //arrowRotation = Quaternion.FromToRotation(transform.position, arrowLookLocation);
        //arrowRotation = Quaternion.LookRotation(transform.position, arrowLookLocation);
        //arrowImage.transform.rotation = Quaternion.AngleAxis(0, Vector3.forward);
        arrowAngle = Vector3.Angle(arrowHeading, transform.forward);
        Quaternion rotation = Quaternion.LookRotation(arrowHeading);
        float rots = Quaternion.Angle(rotation, transform.localRotation);
        if(Vector3.Dot(transform.right, arrowHeading) > 0f)
        {
            rots = -rots;
        }
        arrowImage.transform.localRotation = Quaternion.Euler(0, 0, rots);
    }

    private LineRenderer line;

    public GameObject castRayTo(Vector3 loc, Vector3 dir, float length)
    {
        if(line == null)
        {
            GameObject obj = new GameObject("Line");
            line = obj.AddComponent<LineRenderer>();
            line.startWidth = 0.01f;
            line.endWidth = 0.01f;
        }

        ray.origin = loc;
        ray.direction = dir;
        RaycastHit rayHit;
        Vector3 endPos = loc + (length * dir);
        GameObject hitObject = null;

        if(Physics.Raycast(ray, out rayHit, length))
        {
            endPos = rayHit.point;
            hitObject = rayHit.collider.gameObject;
        }

        line.SetPosition(0, loc);
        line.SetPosition(1, endPos);

        if(hitObject != null)
        {
            return hitObject;
        }

        return null;

    }
}

public class SpawnDelay
{
    bool isCoroutineExecuting = false;
    public IEnumerator ExecuteAfterTime(float time, Action task)
    {
        if (isCoroutineExecuting)
            yield break;
        isCoroutineExecuting = true;
        yield return new WaitForSeconds(time);
        task();
        isCoroutineExecuting = false;
    }
}
