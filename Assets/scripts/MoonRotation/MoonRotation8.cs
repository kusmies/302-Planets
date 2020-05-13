using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonRotation8 : MonoBehaviour
{
    GameObject PauseMenuHolder;
    public bool pausing13;
    public bool forward13;
    public bool playing13;
    public bool timerewind13;
    public Transform target;
    float x = 0f;
    float y = 0f;
    float z = 0f;
    [Range(0, 5)]
    public float Timescale = 1.0f;

    // Update is called once per frame
    void Update()
    {
        if (playing13 == true)
        {
            Timescale = 1;

            Time.timeScale = Timescale;
            transform.Rotate(.1f * Time.timeScale, .4f * Time.timeScale, 2f * Time.timeScale);

        }
        if (pausing13 == true)
        {
            Timescale = 0;

            Time.timeScale = Timescale;
            transform.Rotate(.1f * Time.timeScale, .4f * Time.timeScale, 2f * Time.timeScale);

        }
        if (forward13 == true)
        {
            Timescale = 2;

            Time.timeScale = Timescale;
            transform.Rotate(.1f * Time.timeScale, .4f * Time.timeScale, 2f * Time.timeScale);

        }

    }
}
