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
        SoundManager.instance.SetVolume(0.25f);
        UIManager.instance.isCorrectVolume = true;
        SceneManager.LoadScene(0);
    }
    public void Exit()
    {
        Application.OpenURL(url);
    }
}
