using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {

    Transform Player;
    public Transform ShooterHead;
    public GameObject Bullet;

    void TargetDetector() {
        Player = GameObject.FindWithTag("Player").transform;
    }

    void Update()
    {
        transform.LookAt(Player);
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player") {
            StartCoroutine("Shooting");
        }//End of if
    }
    
    void OnTriggerExit(Collider other) {
        if (other.gameObject.tag == "Player") {
            StopCoroutine("Shooting");
        }//End of if
    }

    IEnumerator Shooting() {
        while (true) {
            Instantiate(Bullet, ShooterHead.position, ShooterHead.rotation);
            yield return new WaitForSeconds(1);
        }
    }
}
