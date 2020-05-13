using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Play : MonoBehaviour
{

    GameObject PauseMenuHolder;
    public bool play;
   
    PlanetRotation timeplay;
    PlanetRotation2 timeplay2;
    PlanetRotation3 timeplay3;
    PlanetRotation4 timeplay4;
      PlanetRotation5 timeplay5;
    MoonRotation timeplay6;
    MoonRotation2 timeplay7;
    MoonRotation3 timeplay8;
    MoonRotation4 timeplay9;
    MoonRotation5 timeplay10;
    MoonRotation6 timeplay11;
    MoonRotation7 timeplay12;
    MoonRotation8 timeplay13;
    void Start()
    {
        GameObject h = GameObject.FindGameObjectWithTag("Planet");
        GameObject g = GameObject.FindGameObjectWithTag("Planet2");

        timeplay = h.GetComponent<PlanetRotation>();
        timeplay2 = g.GetComponent<PlanetRotation2>();

        GameObject l = GameObject.FindGameObjectWithTag("Planet3");
        GameObject k = GameObject.FindGameObjectWithTag("Planet4");
        GameObject a = GameObject.FindGameObjectWithTag("Planet5");
        GameObject b = GameObject.FindGameObjectWithTag("Moon1");
        GameObject c = GameObject.FindGameObjectWithTag("Moon2");
        GameObject d = GameObject.FindGameObjectWithTag("Moon3");
        GameObject e = GameObject.FindGameObjectWithTag("Moon4");
        GameObject f = GameObject.FindGameObjectWithTag("Moon5");
        GameObject i = GameObject.FindGameObjectWithTag("Moon6");
        GameObject j = GameObject.FindGameObjectWithTag("Moon7");
        GameObject m = GameObject.FindGameObjectWithTag("Moon8");
        timeplay4 = k.GetComponent<PlanetRotation4>();
        timeplay3 = l.GetComponent<PlanetRotation3>();


        timeplay5 = a.GetComponent<PlanetRotation5>();

        timeplay6 = b.GetComponent<MoonRotation>();
        timeplay7 = c.GetComponent<MoonRotation2>();
        timeplay8 = d.GetComponent<MoonRotation3>();
        timeplay9 = e.GetComponent<MoonRotation4>();
        timeplay10 = f.GetComponent<MoonRotation5>();
        timeplay11 = i.GetComponent<MoonRotation6>();
        timeplay12 = j.GetComponent<MoonRotation7>();
        timeplay13 = m.GetComponent<MoonRotation8>();
    }

    // Update is called once per frame
    public void OnMouseDown()

    {
        timeplay.pausing = false;
        timeplay.playing = true;
        timeplay.forward = false;
        timeplay.timerewind = false;

        timeplay2.pausing2 = false;
        timeplay2.playing2 = true;
        timeplay2.forward2 = false;
        timeplay2.timerewind2 = false;

        timeplay3.pausing3 = false;
        timeplay3.playing3 = true;
        timeplay3.forward3 = false;
        timeplay3.timerewind3 = false;
        timeplay4.pausing4 = false;
        timeplay4.playing4 = true;
        timeplay4.forward4 = false;
        timeplay4.timerewind4 = false;
        timeplay5.pausing5 = false;
        timeplay5.playing5 = true;
        timeplay5.forward5 = false;
        timeplay5.timerewind5 = false;
        timeplay6.pausing6 = false;
        timeplay6.playing6 = true;
        timeplay6.forward6 = false;
        timeplay6.timerewind6 = false;
        timeplay7.pausing7 = false;
        timeplay7.playing7 = true;
        timeplay7.forward7 = false;
        timeplay7.timerewind7 = false;
        timeplay8.pausing8 = false;
        timeplay8.playing8 = true;
        timeplay8.forward8 = false;
        timeplay8.timerewind8 = false;
        timeplay9.pausing9 = false;
        timeplay9.playing9 = true;
        timeplay9.forward9 = false;
        timeplay9.timerewind9 = false;
        timeplay10.pausing10 = false;
        timeplay10.playing10 = true;
        timeplay10.forward10 = false;
        timeplay10.timerewind10 = false;
        timeplay11.pausing11 = false;
        timeplay11.playing11 = true;
        timeplay11.forward11 = false;
        timeplay11.timerewind11 = false;
        timeplay12.pausing12 = false;
        timeplay12.playing12 = true;
        timeplay12.forward12 = false;
        timeplay12.timerewind12 = false;
        timeplay13.pausing13 = false;
        timeplay13.playing13 = true;
        timeplay13.forward13 = false;
        timeplay13.timerewind13 = false;
        play = true;

    }


    private void Update()
    {
    }



}