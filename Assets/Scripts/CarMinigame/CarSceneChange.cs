using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarSceneChange : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) == true)
        {
            SceneManager.LoadScene(sceneName:"Coin Pusher Scene");
        }
    }
}
