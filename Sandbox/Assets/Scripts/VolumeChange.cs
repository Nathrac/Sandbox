using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeChange : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    Slider volumeSlider;
    // Start is called before the first frame update
    void Start()
    {
        volumeSlider = GetComponent<Slider>();
    }
    
    public void VolumeManager()
    {
        audioSource.volume = volumeSlider.value;
    }
}
