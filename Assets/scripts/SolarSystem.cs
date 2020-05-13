using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SolarSystem : MonoBehaviour
{

    public Transform target6;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;
    public bool button6;



    public void OnMouseDown()
    {
        button6 = true;
        GetComponent<Planet>().button1 = false;
        GetComponent<planet5>().button5 = false;

        GetComponent<planet3>().button3 = false;
        GetComponent<planet4>().button4 = false;

        GetComponent<planet2>().button2 = false;

    }


    public void Button_Click()
    {
        if (button6 == true)
        {

            Vector3 desiredPosition = target6.position+offset;

            Vector3 smoothedPosition = Vector3.Lerp(Camera.main.transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
            Camera.main.transform.position = smoothedPosition;

            Camera.main.transform.LookAt(target6);
        }
   

    }

    private void Update()
    {


        Button_Click();

    }


}


