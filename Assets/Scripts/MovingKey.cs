using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.SocialPlatforms.Impl;

public class MovingKey : MonoBehaviour
{
    public GameObject Target;
    private bool _isMoving = true;
    public float _speed = 3.0f;
    private static int _score = 5;
    private Vector2 targetLocation ;
    

    
    private float _timer = 3.0f;
    [SerializeField]
    private ScoreCounter _scoreCounter;

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
        
        // Too specific condition
        if (transform.position.x.Equals(targetLocation.x) && transform.position.y.Equals(targetLocation.y))
        {
            _isMoving = false;
            _timer -= Time.deltaTime;
        }

        if (_timer <= 0)
        {
            FailAnswer();
        }
    }

    public void DestroyByPlayer(string playerInput)
    {
        if (playerInput.Equals(keyToPressed))
        {
            _scoreCounter.Score += _score;
            Destroy(gameObject);
        }
        else
        {
            FailAnswer();
        }
        
        
    }

    private void FailAnswer()
    {
        _scoreCounter.Score -= _score;
        Destroy(gameObject);
    }
    
    
}
