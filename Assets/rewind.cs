using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rewind : MonoBehaviour
{

    GameObject PauseMenuHolder;
    public bool paused;
    PlanetRotation timerewind;
    PlanetRotation2 timerewind2;


    void Start()
    {
        GameObject g = GameObject.FindGameObjectWithTag("Planet");
        GameObject h = GameObject.FindGameObjectWithTag("Planet2");

        timerewind2 = h.GetComponent<PlanetRotation2>();

        timerewind = g.GetComponent<PlanetRotation>();
    }

    // Update is called once per frame
    public void OnMouseDown()

    {
        timerewind.pausing = false;
        timerewind.playing = false;
        timerewind.forward = false;
        timerewind.timerewind = true;
        timerewind2.pausing2 = false;
        timerewind2.playing2 = false;
        timerewind2.forward2 = false;
        timerewind2.timerewind2 = true;
    }


    private void Update()
    {
    }



}