using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonRotation7 : MonoBehaviour
{
    GameObject PauseMenuHolder;

    public bool pausing12;
    public bool forward12;
    public bool playing12;
    public bool timerewind12;
    public Transform target;
    float x = 0f;
    float y = 0f;
    float z = 0f;
    [Range(0, 5)]
    public float Timescale = 1.0f;

    // Update is called once per frame
    void Update()
    {
        if (playing12 == true)
        {
            Timescale = 1;

            Time.timeScale = Timescale;
            transform.Rotate(-1f * Time.timeScale, .55f * Time.timeScale, -.1f * Time.timeScale);
        }
        if (pausing12 == true)
        {
            Timescale = 0;

            Time.timeScale = Timescale;
            transform.Rotate(-1f * Time.timeScale, .55f * Time.timeScale, -.1f * Time.timeScale);
        }
        if (forward12 == true)
        {
            Timescale = 2;

            Time.timeScale = Timescale;
            transform.Rotate(-1f * Time.timeScale, .55f * Time.timeScale, -.1f * Time.timeScale);
        }
    }
}
