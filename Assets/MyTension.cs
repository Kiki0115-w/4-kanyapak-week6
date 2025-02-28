using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyTension : MonoBehaviour
{
    public float tension, mass, acc;

    void Start()
    {
        mass = GetComponent<Rigidbody>().mass;
        acc = 5f;
        tension = mass * (-Physics.gravity.y + acc);

    }// Start


    void Update()
    {
        GetComponent<Rigidbody>().AddForce(0, tension, 0);
    } // Update


}//MyTension
