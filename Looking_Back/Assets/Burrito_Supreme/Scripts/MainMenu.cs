using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
   
    public void OnButtonPressStart()
    {
        Application.LoadLevel(1);
    }
    public void OnButtonPressQuit()
    {
        Application.Quit();
    }
}
