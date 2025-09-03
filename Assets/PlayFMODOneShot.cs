using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;
using FMOD.Studio;

public class PlayFMODOneShot : MonoBehaviour
{
    public EventReference eventReference;
    public void PlayOneShotAttached()
    {
        RuntimeManager.PlayOneShotAttached(eventReference, gameObject);
    }

    public void PlayOneShot()
    {
        RuntimeManager.PlayOneShot(eventReference);
    }
}
