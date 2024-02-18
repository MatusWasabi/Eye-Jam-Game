using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyKillZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        MovingKey movingKey = other.GetComponent<MovingKey>();
        if (movingKey)
        {
            movingKey.FailAnswer();
        }
        
    }
}
