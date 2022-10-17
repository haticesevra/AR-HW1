using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene3 : MonoBehaviour
{
    [SerializeField] private string spiderGame = "SpiderGame";

    /*
    public void LoadScene(string sceneName) {
        SceneManager.LoadScene(sceneName);
    }*/
    public void NewGameButton()
    {
        SceneManager.LoadScene(spiderGame);
    }
}
