using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.InputSystem;

public class SnapShotManager : MonoBehaviour
{
    public AudioMixerSnapshot ambience;
    public AudioMixerSnapshot rx7;

    bool isRX7 = false;

    private void OnMouseDown()
    {
        if (!isRX7)
        {
            rx7.TransitionTo(2f);
        }
        else
        {
            ambience.TransitionTo(2f);
        }
    }


}
