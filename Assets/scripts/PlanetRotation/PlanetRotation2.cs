using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotation2 : MonoBehaviour
{
    GameObject PauseMenuHolder;
    [Range(0, 5)]
    public float Timescale = 1.0f;
    public bool pausing2;
    public bool forward2;
    public bool playing2;
    public bool timerewind2;
    public Transform target;
    float x = 0f;
    float y = 0f;
    float z = 0f;
    // Update is called once per frame
    void Update()
    {
        if (playing2 == true)
        {
            Timescale = 1;

            Time.timeScale = Timescale;

            transform.Rotate(0 * Time.time * Timescale, 0 * Time.time * Timescale, .50f * Time.time * Timescale);
        }
        if (pausing2 == true)
        {
            Timescale = 0;
            Time.timeScale = Timescale;
            transform.Rotate(0 * Time.time * Timescale, 0 * Time.time * Timescale, .50f * Time.time * Timescale);


        }

        if (forward2 == true)
        {
            Timescale = 2;
            Time.timeScale = Timescale;
            transform.Rotate(0 * Time.time * Timescale, 0 * Time.time * Timescale, .50f * Time.time * Timescale);


        }

    }
}
