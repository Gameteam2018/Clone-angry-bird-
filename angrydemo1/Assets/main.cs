using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main : MonoBehaviour
{

    // Use this for initialization
    public void PlayGame()
    {
        Application.LoadLevel("choose_level");
    }
    public void backmenu()
    {
        Application.LoadLevel("main");
    }
}
