using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using TMPro;

public class BubbleShoot : MonoBehaviour
{
    XRGrabInteractable grabInteractable;
    [SerializeField] GameObject bubblePrefab;
    [SerializeField] Transform spawnPoint;
    int bubbleAmmo = 10;
    [SerializeField] TextMeshProUGUI ammoText;

    // Start is called before the first frame update
    void Awake()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.activated.AddListener(SpawnBubbles);
    }

    private void SpawnBubbles(ActivateEventArgs arg0)
    {
        if (bubbleAmmo > 0)
        {
            Instantiate(bubblePrefab, spawnPoint.position, Quaternion.identity);
            bubbleAmmo--;
            ammoText.text = bubbleAmmo.ToString();
        }
        
    }

}
