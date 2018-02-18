using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levels : MonoBehaviour {

    public int Level;
	// Use this for initialization
	void Start () {
       

    }
	
	// Update is called once per frame
	void Update () {
		
	}


public void Restart()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "Level 1")
        {
            Level = 0;
        }
        else if (scene.name == "Level 2")
        {
            Level = 1;
        }

        SceneManager.LoadScene(Level);   // Loads the current lvl, as specified above.
    }

}


// Player = GetComponent<Player_Controller>();