using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class planet5 : MonoBehaviour
{
    // Start is called before the first frame update
    
    public Transform target5;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;
    public bool button5;
    // Update is called once per frame

    public void Button_click()
    {
        if (button5 == true)
        {
            Vector3 desiredPosition = target5.position + offset;

            Vector3 smoothedPosition = Vector3.Lerp(Camera.main.transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
            Camera.main.transform.position = smoothedPosition;

            Camera.main.transform.LookAt(target5);
        }

    }
    public void OnMouseDown()
    {
        button5 = true;
        GetComponent<Planet>().button1 = false;
        GetComponent<SolarSystem>().button6 = false;

        GetComponent<planet3>().button3 = false;
        GetComponent<planet4>().button4 = false;

        GetComponent<planet2>().button2 = false;

    }
    void FixedUpdate()


    {

        Button_click();

    }
    
}