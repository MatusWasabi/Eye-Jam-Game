using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class BeatManager : MonoBehaviour
{
    [SerializeField] private float bpm;
    [FormerlySerializedAs("source")] [SerializeField] private AudioSource audioSource;
    [SerializeField] private Intervals[] intervals;

    private void Update()
    {
        foreach (Intervals interval in intervals)
        {
            float sampledTime = (audioSource.timeSamples / (audioSource.clip.frequency * interval.GetIntervalLength(bpm)));
            interval.CheckForNewInterval(sampledTime);
        }
    }
    
}

[System.Serializable]
public class Intervals
{
    [SerializeField] private float steps;
    [SerializeField] private UnityEvent trigger;
    private int _lastInterval;

    public float GetIntervalLength(float bpm)
    {
        return 60f / (bpm * steps);
    }

    public void CheckForNewInterval(float interval)
    {
        if (Mathf.FloorToInt(interval) != _lastInterval)
        {
            _lastInterval = Mathf.FloorToInt(interval);
            trigger.Invoke();
        }
    }
}