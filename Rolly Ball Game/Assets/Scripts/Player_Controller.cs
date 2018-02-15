using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player_Controller : MonoBehaviour
{

    public float speed;
    public Text countText;
    public Text winText;
    int movement;

    private Rigidbody rb;

    private int count;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.text = "";
        movement = 1;
    }

    void FixedUpdate()
    {
        if (movement == 1)
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVerticle = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVerticle);
            rb.AddForce(movement * speed);
        }
        if (movement == 2)
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVerticle = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(-moveHorizontal, 0.0f, -moveVerticle);
            rb.AddForce(movement * speed);
        }
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Burn Block"))
        {
            SceneManager.LoadScene(1);
        }

        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count++;
            SetCountText();
        }

    // CAMERA CONTROL HERE, MAIN
        if (other.gameObject.CompareTag("triggerMainCamera"))
        {
            movement = 1;
        }
    // CAMERA CONTROL SECOND
        if (other.gameObject.CompareTag("triggerSecondCamera"))
        {
            movement = 2;
        }
    }



    void SetCountText ()
    {
        countText.text = "Count: " + count.ToString() + "   / 10";
        if (count >= 10)
        {
            winText.text = "YOU WIN!!";
        }
    }

}
