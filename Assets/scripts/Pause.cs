using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Pause: MonoBehaviour
{
    
    GameObject PauseMenuHolder;
    public bool paused;
    PlanetRotation timepause;
    PlanetRotation2 timepause2;
    PlanetRotation3 timepause3;
    PlanetRotation4 timepause4;
    PlanetRotation5 timepause5;
    MoonRotation timepause6;
    MoonRotation2 timepause7;
    MoonRotation3 timepause8;
    MoonRotation4 timepause9;
    MoonRotation5 timepause10;
    MoonRotation6 timepause11;
    MoonRotation7 timepause12;
    MoonRotation8 timepause13;
    void Start()
    {
        GameObject g = GameObject.FindGameObjectWithTag("Planet");
        GameObject h = GameObject.FindGameObjectWithTag("Planet2");
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
        timepause2 = h.GetComponent<PlanetRotation2>();

        timepause = g.GetComponent<PlanetRotation>();
        timepause3 = l.GetComponent<PlanetRotation3>();

        timepause4 = k.GetComponent<PlanetRotation4>();
        timepause5 = a.GetComponent<PlanetRotation5>();

        timepause6 = b.GetComponent<MoonRotation>();
        timepause7 = c.GetComponent<MoonRotation2>();
        timepause8 = d.GetComponent<MoonRotation3>();
        timepause9 = e.GetComponent<MoonRotation4>();
        timepause10 = f.GetComponent<MoonRotation5>();
        timepause11 = i.GetComponent<MoonRotation6>();
        timepause12 = j.GetComponent<MoonRotation7>();
        timepause13 = m.GetComponent<MoonRotation8>();
        
    }

    // Update is called once per frame
    public void OnMouseDown()

    {
        timepause.pausing = true;
        timepause.playing = false;
        paused = true;
        timepause.forward = false;
        timepause.timerewind = false;
        timepause2.pausing2 = true;
        timepause2.playing2 = false;
        timepause2.forward2 = false;
        timepause2.timerewind2 = false;
        timepause3.pausing3 = true;
        timepause3.playing3 = false;
        timepause3.forward3 = false;
        timepause3.timerewind3 = false;
        timepause4.pausing4 = true;
        timepause4.playing4 = false;
        timepause4.forward4 = false;
        timepause4.timerewind4 = false;
        timepause5.pausing5 = true;
        timepause5.playing5 = false;
        timepause5.forward5 = false;
        timepause5.timerewind5 = false;
        timepause6.pausing6 = true;
        timepause6.playing6 = false;
        timepause6.forward6 = false;
        timepause6.timerewind6 = false;
        timepause7.pausing7 = true;
        timepause7.playing7 = false;
        timepause7.forward7 = false;
        timepause7.timerewind7 = false;
        timepause8.pausing8 = true;
        timepause8.playing8 = false;
        timepause8.forward8 = false;
        timepause8.timerewind8 = false;
        timepause9.pausing9 = true;
        timepause9.playing9 = false;
        timepause9.forward9 = false;
        timepause9.timerewind9 = false;
        timepause10.pausing10 = true;
        timepause10.playing10 = false;
        timepause10.forward10 = false;
        timepause10.timerewind10 = false;
        timepause11.pausing11 = true;
        timepause11.playing11 = false;
        timepause11.forward11 = false;
        timepause11.timerewind11 = false;
        timepause12.pausing12 = true;
        timepause12.playing12 = false;
        timepause12.forward12 = false;
        timepause12.timerewind12 = false;
        timepause13.pausing13 = true;
        timepause13.playing13 = false;
        timepause13.forward13 = false;
        timepause13.timerewind13 = false;
    }


    private void Update()
    {
    }



}