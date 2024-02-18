using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.Serialization;
using UnityEngine.SocialPlatforms.Impl;

public class MovingKey : MonoBehaviour
{
    public GameObject Target;
    private bool _isMoving = true;
    public float _speed = 3.0f;
    private static int _score = 5;
    private Vector2 targetLocation ;

    [SerializeField] private AudioClip correctAudio;
    [SerializeField] private AudioClip failAudio;

    [SerializeField] private AudioSource _audioSource;
    

    [FormerlySerializedAs("_scoreCounter")] public ScoreCounter ScoreCounter;

    [SerializeField] private string keyToPressed;
    [SerializeField] private TextMeshProUGUI _textDisplay;

    private void Awake()
    {
        targetLocation = Target.transform.position;
        _textDisplay.text = keyToPressed.ToString();
    }
    

    private void FixedUpdate()
    {
        // Performance-wise, quite poor 
        if (_isMoving)
        {
            transform.position = Vector2.MoveTowards(transform.position, targetLocation, _speed);
        }
        
    }

    public void DestroyByPlayer(string playerInput)
    {
        if (playerInput.Equals(keyToPressed))
        {
            ScoreCounter.Score += _score;
            _audioSource.PlayOneShot(correctAudio);
            Destroy(gameObject);
        }
        else
        {
            FailAnswer();
        }
        
        
    }

    public void FailAnswer()
    {
        ScoreCounter.Score -= _score;
        _audioSource.PlayOneShot(failAudio);
        Destroy(gameObject);
    }
    
    
}
