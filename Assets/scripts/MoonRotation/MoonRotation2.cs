using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonRotation2 : MonoBehaviour
{
    GameObject PauseMenuHolder;
    public bool pausing7;
    public bool forward7;
    public bool playing7;
    public bool timerewind7;

    public Transform target;
    float x = 0f;
    float y = 0f;
    float z = 0f;
    [Range(0, 5)]
    public float Timescale = 1.0f;

    // Update is called once per frame
    void Update()
    {
        if (playing7 == true)
        {
            Timescale = 1;

            Time.timeScale = Timescale;

            transform.Rotate(-.20f * Timescale, 50 * Timescale, .10f * Timescale);
        }

        if (pausing7 == true)
        {
            Timescale = 0;

            Time.timeScale = Timescale;

            transform.Rotate(-.20f * Timescale, 50 * Timescale, .10f * Timescale);
        }
        if (forward7 == true)
        {
            Timescale = 2;

            Time.timeScale = Timescale;

            transform.Rotate(-.20f * Timescale, 50 * Timescale, .10f * Timescale);
        }
    }
}
