using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public GameObject instructionsPan;
    public GameObject creditsPan;
    public GameObject startPan;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Mandrakes");
    }
   public void EndGame()
    {
        SceneManager.LoadScene("END");
    }
    public void Level2()
    {
        SceneManager.LoadScene("RomeoAndJuli");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void Instrctions()
    {
        instructionsPan.SetActive(true);
    }
    public void CloseInstrctions()
    {
        instructionsPan.SetActive(false);
    }

    public void Credits()
    {
        creditsPan.SetActive(true);
    }
    public void CloseCredits()
    {
        creditsPan.SetActive(false);
    }
    public void Return()
    {
        startPan.SetActive(true);
        instructionsPan.SetActive(false);
        creditsPan.SetActive(false);
    }
}
