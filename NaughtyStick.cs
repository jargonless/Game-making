using UnityEngine;
using System.Collections;

public class NaughtyStick : MonoBehaviour {
    public GameObject prefabs;
    void Update() {
        transform.Rotate(new Vector3(0.0f, 360, 0.0f) * Time.deltaTime);
    }
}