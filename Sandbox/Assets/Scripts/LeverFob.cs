using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverFob : MonoBehaviour
{
    HingeJoint leverHinge;
    [SerializeField] GameObject fob;

    // Start is called before the first frame update
    void Start()
    {
        leverHinge = GetComponent<HingeJoint>();
    }

    // Update is called once per frame
    void Update()
    {
        if (leverHinge.angle == leverHinge.limits.max)
        {
            fob.SetActive(true);

        }
    }
}
