using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotation: MonoBehaviour
{
    GameObject PauseMenuHolder;
  public bool pausing;
    public bool forward;
    public bool playing;
    public bool timerewind;
    [Range(0, 5)]
    public float Timescale;
    public Transform target;
    float x = 0f;
    float y = 0f;
    float z = 0f;
    void Start()
    {
        playing = true;

    }


    // Update is called once per frame
    void Update()
    {


        if (playing ==true)
        {
            Timescale =1;
            Time.timeScale = Timescale;
            transform.Rotate(.80f*Time.time*Timescale, .20f * Time.time*Timescale, .50f * Time.time*Timescale);
        }

        if (pausing== true)
        {
            Timescale = 0;
            Time.timeScale = Timescale;
            transform.Rotate(.80f*Time.time *Timescale, .20f * Time.time*Timescale, .50f * Time.time*Timescale);
        }
        if (forward== true)
        {
            Timescale = 2;
            Time.timeScale = Timescale;
            transform.Rotate(.80f * Time.time * Timescale, .20f * Time.time * Timescale, .50f * Time.time * Timescale);
        }

     
    }
}
