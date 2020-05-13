using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonRotation5 : MonoBehaviour
{
    GameObject PauseMenuHolder;
    public bool pausing10;
    public bool forward10;
    public bool playing10;
    public bool timerewind10;
    public Transform target;
    float x = 0f;
    float y = 0f;
    float z = 0f;
    [Range(0, 5)]
    public float Timescale = 1.0f;

    // Update is called once per frame
    void Update()
    {
        if (playing10 == true)
        {
            Timescale = 1;

            Time.timeScale = Timescale;
            transform.Rotate(-1.20f * Time.timeScale, -.24f * Time.timeScale, -.90f * Time.timeScale);

        }
        if (pausing10 == true)
        {
            Timescale = 0;

            Time.timeScale = Timescale;
            transform.Rotate(-1.20f * Time.timeScale, -.24f * Time.timeScale, -.90f * Time.timeScale);

        }
        if (forward10 == true)
        {
            Timescale = 2;

            Time.timeScale = Timescale;
            transform.Rotate(-1.20f * Time.timeScale, -.24f * Time.timeScale, -.90f * Time.timeScale);

        }

    }
}
