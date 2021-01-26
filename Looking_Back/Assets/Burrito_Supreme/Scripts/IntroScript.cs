using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroScript : MonoBehaviour
{
        public void OnButtonPressStart()
        {
            print("OnButtonPressStart!");
            Application.LoadLevel(2);
        }
    }
