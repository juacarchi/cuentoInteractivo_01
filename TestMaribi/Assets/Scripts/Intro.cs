using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
public class Intro : MonoBehaviour
{
    public VideoPlayer _videoPlayer = null; //your videoplayer component
    private void Start()
    {
        if (_videoPlayer)
        {
            _videoPlayer.url = Application.streamingAssetsPath + "/" + "AnimacionInicial.mp4";
            _videoPlayer.Prepare();
            _videoPlayer.Play();
        }
    }
    public void StartCoroutineUI(int sceneToLoad)
    {
        UIManager.instance.StartFadeImageToBlack(sceneToLoad);
    }
    public void SetCorrectVolume()
    {
        UIManager.instance.isCorrectVolume = false;
    }
}
