using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonRotation: MonoBehaviour
{
    GameObject PauseMenuHolder;
    public bool pausing6;
    public bool forward6;
    public bool playing6;
    public bool timerewind6;
    public Transform target;
    float x = 0f;
    float y = 0f;
    float z = 0f;
    [Range(0, 5)]
    public float Timescale = 1.0f;
    
    // Update is called once per frame
    void Update()
    {
        if (playing6 == true)
        {
            Timescale = 1;

            Time.timeScale = Timescale;


            transform.Rotate(-.01f * Timescale, 10 * Timescale, .3f * Timescale);

        }

        if (pausing6 == true)
        {
            Timescale = 0;

            Time.timeScale = Timescale;


            transform.Rotate(-.01f * Timescale, 10 * Timescale, .3f * Timescale);

        }

        if (forward6 == true)
        {
            Timescale = 2;

            Time.timeScale = Timescale;


            transform.Rotate(-.01f * Timescale, 10 * Timescale, .3f * Timescale);

        }
    }
}
