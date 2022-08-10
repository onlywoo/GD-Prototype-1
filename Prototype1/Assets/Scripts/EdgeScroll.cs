using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdgeScroll : MonoBehaviour
{

    void Update()
    {
        if(Camera.main.transform.position.x< 4.73)
        {

            if (Input.GetKey(KeyCode.D))
            {
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x + (3.5f*Time.deltaTime), Camera.main.transform.position.y, Camera.main.transform.position.z);
            }



        }

        if (Camera.main.transform.position.x > 0.38f)
        {

            if (Input.GetKey(KeyCode.A))
            {
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x - (3.5f * Time.deltaTime), Camera.main.transform.position.y, Camera.main.transform.position.z);
            }



        }


    }
}
