using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{

    //This is a drag and drop script that will also check if there is an object already on the snapping point before an object can be snapped on it.

    public GameObject[] snapingPoints;
    GameObject currentGameObject = null;
   public float snappingtrigger = 4.0f;
    public int testInt = 0;
    public CheckIfEmpty checkIfEmpty;

    public GameObject checkMe;
    public bool empty = true;

    // Start is called before the first frame update
    void Start()
    {
        checkMe = this.gameObject;
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
            currentGameObject = hit2D.transform.gameObject;

        }




    }

    void DragTheObject()
    {
        currentGameObject.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane+10.0f));

    }

    void DropTheObject()
    {
        RaycastHit2D hit = Physics2D.Raycast(checkMe.transform.position, Vector2.up, 0f);
        if (hit.collider != null)
        {
            empty = false;
        }
        else if (hit.collider == null)
        {
            empty = true;
        }
        ObjectInsertedCheck objectInsertedCheck = currentGameObject.GetComponent<ObjectInsertedCheck>();

        if (objectInsertedCheck == null)
        {
            for (int i = 0; i < snapingPoints.Length; i++)
            {

                if (Vector3.Distance(snapingPoints[i].transform.position, currentGameObject.transform.position) < snappingtrigger)
                {
                    if (empty == true)
                    {
                        currentGameObject.transform.position = new Vector3(snapingPoints[i].transform.position.x, snapingPoints[i].transform.position.y, snapingPoints[i].transform.position.z - 0f);

                        if (currentGameObject.transform.position.x == snapingPoints[i].transform.position.x)
                        {
                            empty = false;
                            Debug.Log("HEllO WORLD");
                        }
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
