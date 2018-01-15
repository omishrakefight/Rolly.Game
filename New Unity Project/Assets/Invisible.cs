using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invisible : MonoBehaviour {


    public Renderer rend;

    // Turn objects invisible.
    // Use this for initialization
    void Start () {
        rend = GetComponent<Renderer>();
        rend.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
