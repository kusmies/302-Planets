using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class planet2 : MonoBehaviour
{

    public Transform target2;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;
   public bool button2 = false;
    // Update is called once per frame

    public void Button_click()
    {

        if (button2 == true)
        {
            Vector3 desiredPosition = target2.position + offset;

            Vector3 smoothedPosition = Vector3.Lerp(Camera.main.transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
            Camera.main.transform.position = smoothedPosition;

            Camera.main.transform.LookAt(target2);

        }
    }
    public void OnMouseDown()
    {
        GetComponent<planet5>().button5 = false;
        GetComponent<SolarSystem>().button6 = false;

        GetComponent<Planet>().button1 = false;
        GetComponent<planet3>().button3 = false;
        GetComponent<planet4>().button4 = false;


        button2 = true;
        print("hello");

    }
    void FixedUpdate()


    {

        Button_click();

    }
}
