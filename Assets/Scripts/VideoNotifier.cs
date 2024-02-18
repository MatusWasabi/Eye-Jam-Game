using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class VideoNotifier : MonoBehaviour
{
    [SerializeField] private VideoPlayer _videoPlayer;
    [SerializeField] private string thankYouScene;

    private void Start()
    {
        _videoPlayer.loopPointReached += EndGame;
    }


    private void EndGame(VideoPlayer videoPlayer)
    {
        SceneManager.LoadScene(thankYouScene);
    }

    private void OnDisable()
    {
        _videoPlayer.loopPointReached -= EndGame;
    }
}
