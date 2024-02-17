
using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class HitZone : MonoBehaviour
{
    
    public InputAction button1;
    private MovingKey _key;

    private void OnEnable()
    {
        button1.started += OnButton1;
        button1.Enable();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.gameObject.name);
        _key = other.GetComponent<MovingKey>();
    }

    private void OnButton1(InputAction.CallbackContext context)
    {
        Debug.Log("Button 1 is pressed");
        if (_key)
        {
            Destroy(_key.gameObject);
        }
        else
        {
            Debug.Log("Minus point");
        }
    }

    private void OnDisable()
    {
        button1.started -= OnButton1;
        button1.Disable();
    }
}
