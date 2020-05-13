using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonRotation6 : MonoBehaviour
{
    GameObject PauseMenuHolder;

    public bool pausing11;
    public bool forward11;
    public bool playing11;
    public bool timerewind11;
    public Transform target;
    float x = 0f;
    float y = 0f;
    float z = 0f;
    [Range(0, 5)]
    public float Timescale = 1.0f;

    // Update is called once per frame
    void Update()
    {
        if (playing11 == true)
        {
            Timescale = 1;

            Time.timeScale = Timescale;
            transform.Rotate(100f * Time.timeScale, 20f * Time.timeScale, -.5f * Time.timeScale);
        }
        if (pausing11 == true)
        {
            Timescale =0;

            Time.timeScale = Timescale;
            transform.Rotate(100f * Time.timeScale, 20f * Time.timeScale, -.5f * Time.timeScale);
        }
        if (forward11 == true)
        {
            Timescale = 2;

            Time.timeScale = Timescale;
            transform.Rotate(100f * Time.timeScale, 20f * Time.timeScale, -.5f * Time.timeScale);
        }

    }
}
