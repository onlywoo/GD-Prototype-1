using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{

    //This is a drag and drop script that will also check if there is an object already on the snapping point before an object can be snapped on it.

    public GameObject[] snapingPoints;
    GameObject currentGameObject = null;
   public float snappingtrigger = 6.0f;
    public int testInt = 0;
  

    //public GameObject checkMe;
    public bool empty = true;

    public GameObject romeo;
    public GameObject juliete;
    public GameObject grave;
    public GameObject bloodyGrave;

    bool romeoMade = false;
   

   

    // Start is called before the first frame update
    void Start()
    {
        //checkMe = this.gameObject;
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            PickUpObject();
        }

        if (Input.GetMouseButton(0) && currentGameObject !=null)
        {
            DragTheObject();
        }

        if (Input.GetMouseButtonUp(0) && currentGameObject != null)
        {
            DropTheObject();
        }



    }

     void PickUpObject()
    {
        RaycastHit2D hit2D = Physics2D.GetRayIntersection(Camera.main.ScreenPointToRay(Input.mousePosition));

        if(hit2D.collider != null)
        {
            currentGameObject= hit2D.transform.gameObject;

            if (hit2D.transform.gameObject.name == "Rome")
            {                
                currentGameObject = Instantiate(romeo, new Vector3(Input.mousePosition.x, Input.mousePosition.x, Input.mousePosition.x), Quaternion.identity);
                
            }

            if (hit2D.transform.gameObject.name == "Juli")
            {
                currentGameObject = Instantiate(juliete, new Vector3(Input.mousePosition.x, Input.mousePosition.x, Input.mousePosition.x), Quaternion.identity);

            }
            if (hit2D.transform.gameObject.name == "Grave")
            {
                currentGameObject = Instantiate(grave, new Vector3(Input.mousePosition.x, Input.mousePosition.x, Input.mousePosition.x), Quaternion.identity);

            }
            if (hit2D.transform.gameObject.name == "BloodyGrave")
            {
                currentGameObject = Instantiate(bloodyGrave, new Vector3(Input.mousePosition.x, Input.mousePosition.x, Input.mousePosition.x), Quaternion.identity);

            }







        }




    }

    void DragTheObject()
    {
        currentGameObject.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane+10.0f));

    }

    void DropTheObject()
    {



       
        ObjectInsertedCheck objectInsertedCheck = currentGameObject.GetComponent<ObjectInsertedCheck>();

        if (objectInsertedCheck == null)
        {
            for (int i = 0; i < snapingPoints.Length; i++)
            {

                if (Vector3.Distance(snapingPoints[i].transform.position, currentGameObject.transform.position) < snappingtrigger)
                {
                    if (snapingPoints[i].GetComponent<CheckIfEmpty>().empty == true)
                    {

                        currentGameObject.transform.position = new Vector3(snapingPoints[i].transform.position.x, snapingPoints[i].transform.position.y, snapingPoints[i].transform.position.z - 0f);
                        
                        if (currentGameObject.transform.position== snapingPoints[i].transform.position)
                        {
                            Debug.Log(currentGameObject.gameObject.name);
                          
                            Debug.Log("HEllO WORLD");

                        } 

                    } else if(snapingPoints[i].GetComponent<CheckIfEmpty>().empty == false)
                    {
                        Debug.Log("Fail");
                        currentGameObject.GetComponent<NoDupes>().MakeNoDuplicates();
                    }


                }
            }
        }
        else
        {
            objectInsertedCheck.SnapInPlace();
        }


        currentGameObject = null;
    }


}
