using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levels : MonoBehaviour {

    public int Level;
	// Use this for initialization
	void Start () {
        // Determines what scene we are on
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "Level 1")
        {
            Level = 0;
        }
        else if (scene.name == "Level 2")
        {
            Level = 1;
        }
        else if (scene.name == "Level 3")
        {
            Level = 2;
        }
        else if (scene.name == "Level 4")
        {
            Level = 3;
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void LoadNextLevel()
    {
        ++Level;
        SceneManager.LoadScene(Level);
    }

    public void Restart()
    {
        
        SceneManager.LoadScene(Level);   // Loads the current lvl, as specified above.
    }

}


// Player = GetComponent<Player_Controller>();