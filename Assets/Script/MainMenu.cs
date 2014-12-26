using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour
    {
    public GUISkin skin;

    void OnGUI()
        {
        GUI.skin = skin;
        GUI.Label(new Rect(200, 10, 400, 85), "Go Home");
        if (GUI.Button(new Rect(300, 120, 100, 45), "Play"))
            Application.LoadLevel(1);
        //if (GUI.Button(new Rect(300, 160, 100, 45), "Quit"))
            //Application.Quit();
        }
    }
