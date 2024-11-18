using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float _startTime;
    AudioSource source;
    void Start()
    {
        source = GetComponent<AudioSource>();
        source.time = _startTime;
    }

    public void Pause()
    {
        if (source.isPlaying)
        {
            source.Pause();
        }
        else
        {
            source.UnPause();
        }
    }

    public void SetTime(float time)
    {
        source.time = time;
    }

    public void SetVolume(float volume)
    {
        source.volume = volume;
    }
}
