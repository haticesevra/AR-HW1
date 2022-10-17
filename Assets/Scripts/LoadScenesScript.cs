using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenesScript : MonoBehaviour
{
    [SerializeField] private string balloon = "Balloon";

    /*
    public void LoadScene(string sceneName) {
        SceneManager.LoadScene(sceneName);
    }*/   
    public void NewGameButton() {
        SceneManager.LoadScene(balloon);
    }
}
