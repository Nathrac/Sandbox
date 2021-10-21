using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class KeyFob : MonoBehaviour
{
    XRGrabInteractable grabInteractable;
    [SerializeField] AudioSource startEngine;
    [SerializeField] AudioSource idleEngine;

    private void Awake()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.activated.AddListener(playAudio);
    }

    private void playAudio(ActivateEventArgs arg0)
    {
        StartCoroutine(CarSounds());
    }

    private IEnumerator CarSounds()
    {
        startEngine.Play();

        yield return new WaitForSeconds(1f);

        idleEngine.Play();
    }
}
