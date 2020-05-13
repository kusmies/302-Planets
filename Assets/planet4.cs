using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class planet4 : MonoBehaviour
{
    
    public Transform target4;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;
    public bool button4;
    // Update is called once per frame

    public void Button_click()
    {
        if (button4 == true)
        {
            Vector3 desiredPosition = target4.position + offset;

            Vector3 smoothedPosition = Vector3.Lerp(Camera.main.transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
            Camera.main.transform.position = smoothedPosition;

            Camera.main.transform.LookAt(target4);
        }

    }


    public void OnMouseDown()
    {
        button4 = true;
        GetComponent<Planet>().button1 = false;
        GetComponent<planet5>().button5 = false;
        GetComponent<SolarSystem>().button6 = false;

        GetComponent<planet3>().button3 = false;

        GetComponent<planet2>().button2 = false;

    }
    void FixedUpdate()


    {

        Button_click();

    }
    
}
