using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonRotation4 : MonoBehaviour
{
    GameObject PauseMenuHolder;
    public bool pausing9;
    public bool forward9;
    public bool playing9;
    public bool timerewind9;
    public Transform target;
    float x = 0f;
    float y = 0f;
    float z = 0f;
    [Range(0, 5)]
    public float Timescale = 1.0f;

    // Update is called once per frame
    void Update()
    {
        if (playing9 == true)
        {
            Timescale = 1;

            Time.timeScale = Timescale;
            transform.Rotate(-.4f * Time.timeScale, 0.5f * Time.timeScale, .4f * Time.timeScale);

        }

        if (pausing9 == true)
        {
            Timescale = 0;

            Time.timeScale = Timescale;
            transform.Rotate(-.4f * Time.timeScale, 0.5f * Time.timeScale, .4f * Time.timeScale);

        }

        if (forward9 == true)
        {
            Timescale = 2;

            Time.timeScale = Timescale;
            transform.Rotate(-.4f * Time.timeScale, 0.5f * Time.timeScale, .4f * Time.timeScale);

        }
    }
}
