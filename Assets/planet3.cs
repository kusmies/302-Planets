using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planet3 : MonoBehaviour
{
    // Start is called before the first frame update

    
        public Transform target3;

        public float smoothSpeed = 0.125f;
        public Vector3 offset;

    // Update is called once per frame
    public bool button3;
        public void Button_click()
        {
        if (button3 == true)
        {
            Vector3 desiredPosition = target3.position + offset;

            Vector3 smoothedPosition = Vector3.Lerp(Camera.main.transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
            Camera.main.transform.position = smoothedPosition;

            Camera.main.transform.LookAt(target3);
        }

        }
         public void OnMouseDown()
        {
            button3 = true;
            GetComponent<Planet>().button1 = false;
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