using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinToCarSceneChange : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftControl) == true)
        {
            SceneManager.LoadScene(sceneName:"Car Racer Scene");
        }
    }
}
