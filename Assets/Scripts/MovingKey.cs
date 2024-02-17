using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingKey : MonoBehaviour
{
    public GameObject Target;
    private bool _isMoving = true;
    public float _speed = 3.0f;
    private static int _score = 5;
    private Vector2 targetLocation ;



    private void Awake()
    {
        targetLocation = Target.transform.position;
    }

    private void FixedUpdate()
    {
        // Performance-wise, quite poor 
        if (_isMoving)
        {
            transform.position = Vector2.MoveTowards(transform.position, targetLocation, _speed);
        }

        if (transform.position.x.Equals(targetLocation.x) && transform.position.y.Equals(targetLocation.y))
        {
            _isMoving = false;
        }
    }

    public void DestroyByPlayer()
    {
        Debug.Log($"+{_score} score");
    }

    private void DestroyByTime()
    {
        Debug.Log($"-{_score} score");
    }
    
    
    
}
