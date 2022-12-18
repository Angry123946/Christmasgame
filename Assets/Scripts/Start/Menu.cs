using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public void Menuu()
    {
        SceneManager.LoadScene(0);
    }
    public void Graj()
    {
        SceneManager.LoadScene(1);
    }
    public void wyjdü()
    {
        Application.Quit();
    }
    public void Credits()
    {
        SceneManager.LoadScene(2);
    }
}
