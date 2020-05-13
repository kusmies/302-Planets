﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Planet : MonoBehaviour
{

    public Transform target;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;
    public bool button1 =false;
    // Update is called once per frame

    public void Button_click()
    {

        if (button1 == true)
        {





            Vector3 desiredPosition = target.position + offset;

            Vector3 smoothedPosition = Vector3.Lerp(Camera.main.transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
            Camera.main.transform.position = smoothedPosition;

            Camera.main.transform.LookAt(target);

        }
    }


    public void OnMouseDown()
    {
        button1 = true;
        GetComponent<planet3>().button3 = false;
        GetComponent<planet4>().button4 = false;
        GetComponent<planet5>().button5 = false;
        GetComponent<SolarSystem>().button6 = false;

        GetComponent<planet2>().button2 = false;

    }

    void FixedUpdate()


    {

        Button_click();

    }


}
