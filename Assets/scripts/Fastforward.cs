using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fastforward : MonoBehaviour
{

    GameObject PauseMenuHolder;
    public bool forward;
    PlanetRotation timeforward;
    PlanetRotation2 timeforward2;
    PlanetRotation3 timeforward3;
    PlanetRotation4 timeforward4;
    PlanetRotation5 timeforward5;
    MoonRotation timeforward6;
    MoonRotation2 timeforward7;
    MoonRotation3 timeforward8;
    MoonRotation4 timeforward9;
    MoonRotation5 timeforward10;
    MoonRotation6 timeforward11;
    MoonRotation7 timeforward12;
    MoonRotation8 timeforward13;
    void Start()
    {
        GameObject h = GameObject.FindGameObjectWithTag("Planet");
        GameObject g = GameObject.FindGameObjectWithTag("Planet2");

        timeforward = h.GetComponent<PlanetRotation>();
        timeforward2 = g.GetComponent<PlanetRotation2>();

        GameObject l = GameObject.FindGameObjectWithTag("Planet3");
        GameObject k = GameObject.FindGameObjectWithTag("Planet4");

        timeforward4 = k.GetComponent<PlanetRotation4>();
        timeforward3 = l.GetComponent<PlanetRotation3>();
       GameObject a = GameObject.FindGameObjectWithTag("Planet5");
        GameObject b = GameObject.FindGameObjectWithTag("Moon1");
        GameObject c = GameObject.FindGameObjectWithTag("Moon2");
        GameObject d = GameObject.FindGameObjectWithTag("Moon3");
        GameObject e = GameObject.FindGameObjectWithTag("Moon4");
        GameObject f = GameObject.FindGameObjectWithTag("Moon5");
        GameObject i = GameObject.FindGameObjectWithTag("Moon6");
        GameObject j = GameObject.FindGameObjectWithTag("Moon7");
        GameObject m = GameObject.FindGameObjectWithTag("Moon8");
       

        timeforward5 = a.GetComponent<PlanetRotation5>();

        timeforward6 = b.GetComponent<MoonRotation>();
        timeforward7 = c.GetComponent<MoonRotation2>();
        timeforward8 = d.GetComponent<MoonRotation3>();
        timeforward9 = e.GetComponent<MoonRotation4>();
        timeforward10 = f.GetComponent<MoonRotation5>();
        timeforward11 = i.GetComponent<MoonRotation6>();
        timeforward12 = j.GetComponent<MoonRotation7>();
        timeforward13 = m.GetComponent<MoonRotation8>();

    }

    // Update is called once per frame
    public void OnMouseDown()

    {
        timeforward.pausing = false;
        timeforward.playing = false;
        timeforward.forward = true;
        timeforward.timerewind = false;
        timeforward2.pausing2 = false;
        timeforward2.playing2 = false;
        timeforward2.forward2 = true;
        timeforward2.timerewind2 = false;
        timeforward3.pausing3 = false;
        timeforward3.playing3 = false;
        timeforward3.forward3 = true;
        timeforward3.timerewind3 = false;
        timeforward4.pausing4 = false;
        timeforward4.playing4 = false;
        timeforward4.forward4 = true;
        timeforward4.timerewind4 = false;
        timeforward5.pausing5 = false;
        timeforward5.playing5 = false;
        timeforward5.forward5 = true;
        timeforward5.timerewind5 = false;
        timeforward6.pausing6 = false;
        timeforward6.playing6 = false;
        timeforward6.forward6 = true;
        timeforward6.timerewind6 = false;
        timeforward7.pausing7 = false;
        timeforward7.playing7 = false;
        timeforward7.forward7 = true;
        timeforward7.timerewind7 = false;
        timeforward8.pausing8 = false;
        timeforward8.playing8 = false;
        timeforward8.forward8 = true;
        timeforward8.timerewind8 = false;
        timeforward9.pausing9 = false;
        timeforward9.playing9 = false;
        timeforward9.forward9 = true;
        timeforward9.timerewind9 = false;
        timeforward10.pausing10 = false;
        timeforward10.playing10 = false;
        timeforward10.forward10 = true;
        timeforward10.timerewind10 = false;
        timeforward11.pausing11 = false;
        timeforward11.playing11 = false;
        timeforward11.forward11 = true;
        timeforward11.timerewind11 = false;
        timeforward12.pausing12 = false;
        timeforward12.playing12 = false;
        timeforward12.forward12 = true;
        timeforward12.timerewind12 = false;
        timeforward13.pausing13 = false;
        timeforward13.playing13 = false;
        timeforward13.forward13 = true;
        timeforward13.timerewind13 = false;
        forward = true;
    }


    private void Update()
    {
    }



}