using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    string name = "Multiplayer";
    public void StartMultiplayer()
    {
        SceneManager.LoadScene("Multiplayer");
    }
}
