using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{

    string url = "https://iquick.es";

    public void Play()
    {
        SceneManager.LoadScene(1);
    }
    public void ReturnMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void Exit()
    {
        Application.OpenURL(url);
    }
}
