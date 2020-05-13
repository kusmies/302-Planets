using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotation3 : MonoBehaviour
{
    GameObject PauseMenuHolder;

    [Range(0, 5)]
    public float Timescale = 1.0f;
    public bool pausing3;
    public bool forward3;
    public bool playing3;
    public bool timerewind3;
    public Transform target;
    float x = 0f;
    float y = 0f;
    float z = 0f;
    // Update is called once per frame
    void Update()
    {
        if (playing3 == true)
        {
            Timescale = 1;

            Time.timeScale = Timescale;

            transform.Rotate(8 * Time.time * Timescale, 58 * Time.time * Timescale, -50 * Time.time * Timescale);

        }
        if (forward3 == true)
        {
            Timescale = 2;

            Time.timeScale = Timescale;

            transform.Rotate(8 * Time.time * Timescale, 58 * Time.time * Timescale, -50 * Time.time * Timescale);

        }

        if (pausing3 == true)
        {
            Timescale = 0;

            Time.timeScale = Timescale;

            transform.Rotate(8 * Time.time * Timescale, 58 * Time.time * Timescale, -50 * Time.time * Timescale);

        }

    }
}
