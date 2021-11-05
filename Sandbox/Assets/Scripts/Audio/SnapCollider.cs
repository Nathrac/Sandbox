using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SnapCollider : MonoBehaviour
{
    public AudioMixerSnapshot ambience;
    public AudioMixerSnapshot rx7;

    bool isRx7 = false;
 

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (!isRx7)
            {
                rx7.TransitionTo(2f);
                isRx7 = true;
            }
            else if (isRx7)
            {
                ambience.TransitionTo(2f);
                isRx7 = false;
            }
        }
    }
}
