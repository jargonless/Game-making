using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed;
    public Text countText;
    public Text winText;
    public Text HowToWin;
    public GameObject Glass;

    private Rigidbody rb;
    private int count;
    void Start() {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.text = "";
    }

    void FixedUpdate() {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
 
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Pick Up")) {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
        if (other.gameObject.CompareTag("Trap")) {
            GetComponent<Rigidbody>().velocity = Vector3.up * speed * 5;
            winText.text = "Wasted!";
        }
        if (other.gameObject.CompareTag("Spring")) {
            GetComponent< Rigidbody > ().velocity = Vector3.up * speed;
        }
        if (other.gameObject.CompareTag("Glass")) {
            MeshRenderer rend = Glass.GetComponent<MeshRenderer>();
            rend.enabled = true;
        }
    }//End of OnTriggerEnter

    void SetCountText() {
        countText.text = "Count: " + count.ToString();
        HowToWin.text = "Collect 6 cubes to win";
        if (count >= 6) {
            winText.text = "You Win!";
        }
    }
    void Update () {
        if (Input.GetKeyDown(KeyCode.R))
            Application.LoadLevel(0);
    }
}