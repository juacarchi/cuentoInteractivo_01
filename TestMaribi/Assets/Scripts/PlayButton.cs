using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayButton : MonoBehaviour
{
    private void Start()
    {
        Button btnPlay = GetComponent<Button>();
        btnPlay.interactable = true;
    }
    public void Play (int sceneToLoad)
    {
        Button btnPlay = GetComponent<Button>();
        btnPlay.interactable = false;
        UIManager.instance.StartFadeImageToBlack(sceneToLoad);
    }
}
