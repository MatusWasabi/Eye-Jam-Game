using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreDisplay;
    
    private int _score = 0;
    
    public int Score
    {
        get { return _score; }
        set
        {
            _score = value;
            if (_score < 0)
            {
                _score = 0;
            }
            UpdateScore();
        }
    }
    
   

    private void Awake()
    {
        UpdateScore();
    }

    private void UpdateScore()
    {
        _scoreDisplay.text = $"Score: {_score}";
    }
    
}
