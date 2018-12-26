using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    Rigidbody rb;
    public float Bulletspeed;

    void start () {
        rb = GetComponent<Rigidbody>();
        rb.AddRelativeForce(0, 0, Bulletspeed, ForceMode.Impulse);
    }

}
