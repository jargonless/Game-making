using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {
    public GameObject prefabs; 
    void Update() {
        transform.Rotate(new Vector3(Random.Range(0,360), Random.Range(0, 360), Random.Range(0, 360)) * Time.deltaTime);
    }
}