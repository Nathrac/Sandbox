using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverWall : MonoBehaviour
{
    HingeJoint leverHinge;
    [SerializeField] GameObject wall;
    [SerializeField] GameObject car;

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
            wall.SetActive(false);
            car.SetActive(true);

        }
    }
}
