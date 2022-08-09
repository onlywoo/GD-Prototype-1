using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectPosition : MonoBehaviour
{
    public GameObject point1;
    public GameObject point2;
    public bool correct = false;
    public GameObject heart;
    public CheckIfEmpty checkIfEmpty;

    


    // Start is called before the first frame update
    void Start()
    {
        heart.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(point1.transform.position, Vector2.up, 0f);


        RaycastHit2D hit1 = Physics2D.Raycast(point2.transform.position, Vector2.up, 0f);


        if(hit.transform.gameObject.name== "ROmeo(Clone)" && hit1.transform.gameObject.name == "juLIET(Clone)"|| hit1.transform.gameObject.name == "ROmeo(Clone)" && hit.transform.gameObject.name == "juLIET(Clone)")
        {
            correct = true;
            heart.SetActive(true);

           // hit.transform.gameObject.GetComponent<BoxCollider2D>().enabled = false;
            //hit1.transform.gameObject.GetComponent<BoxCollider2D>().enabled = false;
        }
        else
        {
            Debug.Log("S");
        }
   
       

            
      


        

        if (checkIfEmpty.empty == true)
        {
            correct = false;
            heart.SetActive(false);
        }



    }
}
