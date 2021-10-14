using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    HingeJoint leverHinge;
    [SerializeField] GameObject bubbleGun;

    // Start is called before the first frame update
    void Start()
    {
        leverHinge = GetComponent<HingeJoint>();
    }

    // Update is called once per frame
    void Update()
    {
        if (leverHinge.angle == leverHinge.limits.min)
        {
            bubbleGun.SetActive(true);

        }
    }
}
