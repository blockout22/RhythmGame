using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugInfo : MonoBehaviour
{
    public bool isEnabled;
    public GameObject canvas;
    public Text fps;

    private float lastTime = 0;
    private int frames = 0;
    private int lastFrames = 0;

    void Start()
    {
        if (isEnabled)
        {
            canvas.SetActive(true);
        }

        lastTime = Time.time;
    }

    private void Update()
    {
        if (isEnabled)
        {
            if (Time.time * 1 - lastTime >= 1)
            {
                lastTime += 1;
                if (lastFrames != frames)
                {
                    fps.text = "FPS: " + frames;
                    lastFrames = frames;
                }
                frames = 0;
            }
            frames++;
        }
    }
}
