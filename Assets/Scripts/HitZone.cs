
using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class HitZone : MonoBehaviour
{
    
    public InputAction button1;
    private MovingKey _key;
    private string buttonPress;

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
        if (_key)
        {
            Debug.Log(button1.GetBindingDisplayString());
            _key.DestroyByPlayer(button1.GetBindingDisplayString());
        }
    }

    private void OnDisable()
    {
        button1.started -= OnButton1;
        button1.Disable();
    }
}
