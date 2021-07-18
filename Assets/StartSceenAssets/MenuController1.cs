using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuController1 : MonoBehaviour
{
    //public GameObject optionPanel;
    public GameObject topPanel,middlePanel,bottomPanel;
    //public GameObject helpPanel;
    public void OptionsMenu()
    {
       // optionPanel.SetActive(true);
        topPanel.SetActive(false);
        middlePanel.SetActive(false);
        bottomPanel.SetActive(false);
    }
    public void HelpMenu()
    {
       // helpPanel.SetActive(true);
        //optionPanel.SetActive(false);
        topPanel.SetActive(false);
        middlePanel.SetActive(false);
        bottomPanel.SetActive(false);
    }
    public void Back()
    {
       // optionPanel.SetActive(false);
        topPanel.SetActive(true);
        middlePanel.SetActive(true);
        bottomPanel.SetActive(true);
    }
    public void Back1()
    {
       // helpPanel.SetActive(false);
       // optionPanel.SetActive(false);
        topPanel.SetActive(true);
        middlePanel.SetActive(true);
        bottomPanel.SetActive(true);
    }
    
}