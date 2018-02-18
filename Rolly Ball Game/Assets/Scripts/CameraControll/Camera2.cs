using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera2 : MonoBehaviour {

    public Camera SecondCamera;
    public Camera MainCamera;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            ShowSecondCamera();
    }

    public void ShowSecondCamera()
    {
        MainCamera.enabled = false;
        SecondCamera.enabled = true;
    }
}
