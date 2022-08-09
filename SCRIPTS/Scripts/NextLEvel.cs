using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLEvel : MonoBehaviour
{
    public GameObject nextButton;

    public CorrectPosition correctPosition;
    public SC2CorrectPos SC2CorrectPos;
    public SC3CorrectPos SC3CorrectPos;
    public SC4CorrectPos SC4CorrectPos;
    // Start is called before the first frame update
    void Start()
    {
        nextButton.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if(correctPosition.correct==true&& SC2CorrectPos.correct==true && SC3CorrectPos.correct == true && SC4CorrectPos.correct == true)
        {
            Debug.Log("Complete");
            nextButton.SetActive(true);
        }
    }
}
