using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonRotation3 : MonoBehaviour
{
    GameObject PauseMenuHolder;
    public bool pausing8;
    public bool forward8;
    public bool playing8;
    public bool timerewind8;

    public Transform target;
    float x = 0f;
    float y = 0f;
    float z = 0f;
    [Range(0, 5)]
    public float Timescale = 1.0f;
  
    // Update is called once per frame
    void Update()
    {
        if (playing8 == true)
        {
            Timescale = 1;

            Time.timeScale = Timescale;

            transform.Rotate(-.4f * Timescale, -.09f * Timescale, 1f * Timescale);
        }
        if (pausing8 == true)
        {
            Timescale = 0;

            Time.timeScale = Timescale;

            transform.Rotate(-.4f * Timescale, -.09f * Timescale, 1f * Timescale);
        }
        if (forward8 == true)
        {
            Timescale = 2;

            Time.timeScale = Timescale;

            transform.Rotate(-.4f * Timescale, -.09f * Timescale, 1f * Timescale);
        }


    }
}
