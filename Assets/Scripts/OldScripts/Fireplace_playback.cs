using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;
using FMOD.Studio;

public class Fireplace_playback : MonoBehaviour
{
    public StudioEventEmitter fireplaceEmitter;
    private EventInstance fireplaceInstance;

    private void Start()
    {
        fireplaceInstance = fireplaceEmitter.EventInstance;
    }

    private void OnTriggerStay(Collider other)
    {
        fireplaceInstance.setParameterByNameWithLabel("Fire", "0");
    }

    private void OnTriggerExit(Collider other)
    {
        fireplaceInstance.setParameterByNameWithLabel("Fire", "1");
    }
}