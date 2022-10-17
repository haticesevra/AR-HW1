using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene2 : MonoBehaviour
{
    [SerializeField] private string cubes = "Cubes";
    public void NewGameButton()
    {
        SceneManager.LoadScene(cubes);
    }
}
