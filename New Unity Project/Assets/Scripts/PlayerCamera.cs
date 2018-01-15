using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour {

    public Camera SecondCamera;
    public Camera MainCamera;
    public GameObject player;

    private Vector3 offset;

	// Use this for initialization
	void Start () {
        offset = transform.position - player.transform.position;
        ShowMainCamera();
     
    }
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = player.transform.position + offset;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            ShowSecondCamera();
    }

    /*
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "TriggerSecondCamera")
        {
            ShowSecondCamera();
        }

        if (collision.gameObject.name == "TriggerMainCamera")
        {
            ShowMainCamera();
        }


    }
    */



    public void ShowSecondCamera()
    {
        MainCamera.enabled = false;
        SecondCamera.enabled = true;
    }

    public void ShowMainCamera()
    {
        SecondCamera.enabled = false;
        MainCamera.enabled = true;
    }





}


