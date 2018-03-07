using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Final_Pickup : MonoBehaviour
{
    public float LoadNewLevel = 0f;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }



    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Invoke("ReadyNextLevel", 2f);
        }
    }

    private void ReadyNextLevel()
    {
        SendMessage("LoadNextLevel");
    }
}

//Time.time + 5.0f
//&& Time.time > LoadNewLevel


/*
 *     IEnumerator LoadYourAsyncScene()
    {
        // The Application loads the Scene in the background at the same time as the current Scene.
        //This is particularly good for creating loading screens. You could also load the Scene by build //number.
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level 2");

        //Wait until the last operation fully loads to return anything
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
        var scene = SceneManager.GetSceneByName("Level 2");
        SceneManager.SetActiveScene(scene);
    }

      if (LoadNewLevel == 1f)
        {
            StartCoroutine(LoadYourAsyncScene());
        }
*/
