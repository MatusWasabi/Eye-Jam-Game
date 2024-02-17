
using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class HitZone : MonoBehaviour
{
    
    public InputAction button1;
    public InputAction button2;
    public InputAction button3;
    public InputAction button4;
    
    private MovingKey _key;

    private void OnEnable()
    {
        button1.started += OnButton1;
        button1.Enable();
        
        button2.started += OnButton2;
        button2.Enable();
        
        button3.started += OnButton3;
        button3.Enable();
        
        button4.started += OnButton4;
        button4.Enable();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        _key = other.GetComponent<MovingKey>();
    }

    private void OnButton1(InputAction.CallbackContext context)
    {
        if (_key)
        {
            _key.DestroyByPlayer(button1.GetBindingDisplayString());
        }
    }
    
    private void OnButton2(InputAction.CallbackContext context)
    {
        if (_key)
        {
            _key.DestroyByPlayer(button2.GetBindingDisplayString());
        }
    }
    
    private void OnButton3(InputAction.CallbackContext context)
    {
        if (_key)
        {
            _key.DestroyByPlayer(button3.GetBindingDisplayString());
        }
    }
    
    private void OnButton4(InputAction.CallbackContext context)
    {
        if (_key)
        {
            _key.DestroyByPlayer(button4.GetBindingDisplayString());
        }
    }
    
    
    

    private void OnDisable()
    {
        button1.started -= OnButton1;
        button1.Disable();
    }
}
