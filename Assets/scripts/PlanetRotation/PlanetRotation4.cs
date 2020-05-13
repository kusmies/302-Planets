using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotation4 : MonoBehaviour
{
    GameObject PauseMenuHolder;

    [Range(0, 5)]
    public float Timescale = 1.0f;
    public bool pausing4;
    public bool forward4;
    public bool playing4;
    public bool timerewind4;
    public Transform target;
    float x = 0f;
    float y = 0f;
    float z = 0f;
    // Update is called once per frame
    void Update()
    {
        if (playing4 == true)
        {
            Timescale = 1;

            Time.timeScale = Timescale;

            transform.Rotate(-1.79f * Time.time * Timescale, 0 * Time.time * Timescale, .4f * Time.time * Timescale);

        }
        if (pausing4 == true)
        {
            Timescale = 0;

            Time.timeScale = Timescale;

            transform.Rotate(-1.79f * Time.time * Timescale, 0 * Time.time * Timescale, .4f * Time.time * Timescale);

        }
        if (forward4 == true)
        {
            Timescale = 2;

            Time.timeScale = Timescale;

            transform.Rotate(-1.79f * Time.time * Timescale, 0 * Time.time * Timescale, .4f * Time.time * Timescale);

        }
    }
}
