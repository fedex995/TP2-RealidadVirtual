﻿using System;
using UnityEngine;
using System.Collections;

public class FireTrap : MonoBehaviour
{

    [SerializeField] private float activeSeconds;
    [SerializeField] private ParticleSystem[] fireSources;
    [SerializeField] private GameObject[] fireTriggers;

    private bool active = true;

	// Use this for initialization
	void Start ()
    {
        Invoke("ToggleFire", activeSeconds);
    }

    private void ToggleFire()
    {
        foreach (var fireSource in fireSources)
        {
            if (active) fireSource.Play();
            else fireSource.Stop();
        }
        foreach (var fireTrigger in fireTriggers)
            fireTrigger.SetActive(active);
        active = !active;
        Invoke("ToggleFire", activeSeconds);
    }
}
