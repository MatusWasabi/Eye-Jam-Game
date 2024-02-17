using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingKey : MonoBehaviour
{
    public GameObject Target;
    private bool _isMoving = true;
    private float _speed = 3.0f;


    private void FixedUpdate()
    {
        if (_isMoving)
        {
            Vector2 targetLocation = Target.transform.position;
            transform.position = Vector2.MoveTowards(transform.position, targetLocation, _speed);
        }
    }


    private void MoveToLocation()
    {
        
    }
}
