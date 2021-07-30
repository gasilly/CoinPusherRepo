using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinToCarSceneChange : MonoBehaviour
{
    private GameObject coinText;
    private UIController ui;
    void Start()
    {
        coinText = GameObject.FindWithTag("UI");
        ui = coinText.GetComponent<UIController>();
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftControl) == true)
        {
            //PlayerPrefs.SetInt("coins",ui.coinsRemaining);
            SceneManager.LoadScene(sceneName:"Car Racer Scene");
        }
    }
}
