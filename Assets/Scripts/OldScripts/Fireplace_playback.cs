using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;
using FMOD.Studio;

public class Fireplace_playback : MonoBehaviour
{
    public FMODUnity.StudioEventEmitter fireplaceEmitter;
    FMOD.Studio.EventInstance FireplaceEmitter;
    //void start - przypisac event do instancji
    private void Start()
    {
        //FireplaceEmitter = FMODUnity.RuntimeManager.CreateInstance(fireplaceEmitter);
    }

    private void OnTriggerStay(Collider other)
    {
        //fireplaceEmitter.setParameterByNameWithLabel("Fire", "0");
    }

    private void OnTriggerExit(Collider other)
    {
        //fireplaceEmitter.setParameterByNameWithLabel("Fire", "1");
    }
}
