using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckIFCarrotIsClicked : MonoBehaviour
{
    public GameObject attack;
    public GameObject boi;
    public GameObject pulse;
    // Start is called before the first frame update
    void Start()
    {
        attack.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit2D hit2D = Physics2D.GetRayIntersection(Camera.main.ScreenPointToRay(Input.mousePosition));

            if (hit2D.transform.gameObject.name == "SCene2")
            {
                attack.SetActive(true);
                pulse.SetActive(false);
                boi.transform.rotation = new Quaternion(0,0,90,90);
                
            }
            
        }


    }
}
