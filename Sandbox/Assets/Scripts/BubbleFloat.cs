using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleFloat : MonoBehaviour
{
    Rigidbody rb;
    float speed = 0.5f;
    float life = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.forward * (speed / 2), ForceMode.VelocityChange);
        rb.AddForce(Vector3.up * speed, ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {
        if (life >= 0)
        {
            life -= Time.deltaTime;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
