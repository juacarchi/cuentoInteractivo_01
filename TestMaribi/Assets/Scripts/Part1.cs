using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Part1 : MonoBehaviour
{
    public VideoPlayer _videoPlayer = null; //your videoplayer component

    private void Start()
    {
        if (_videoPlayer)
        {
            _videoPlayer.url = Application.streamingAssetsPath + "/" + "TextosParte1.mp4";
            _videoPlayer.Prepare();
            _videoPlayer.Play();
        }
    }

}
