using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotation5 : MonoBehaviour
{
    GameObject PauseMenuHolder;

    [Range(0, 5)]
    public float Timescale = 1.0f;
    public bool pausing5;
    public bool forward5;
    public bool playing5;
    public bool timerewind5;
    public Transform target;
    float x = 0f;
    float y = 0f;
    float z = 0f;
    // Update is called once per frame
    void Update()
    {
        if (playing5 == true)
        {
            Timescale = 1;

            Time.timeScale = Timescale;

            transform.Rotate(-2f * Timescale, .4f * Timescale, -.5f * Timescale);

        }


        if (pausing5 == true)
        {
            Timescale = 0;

            Time.timeScale = Timescale;

            transform.Rotate(-2f * Timescale, .4f * Timescale, -.5f * Timescale);

        }

        if (forward5 == true)
        {
            Timescale = 2;

            Time.timeScale = Timescale;

            transform.Rotate(-2f * Timescale, .4f * Timescale, -.5f * Timescale);

        }
    }
}
