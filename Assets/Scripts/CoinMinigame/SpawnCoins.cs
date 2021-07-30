using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnCoins : MonoBehaviour
{
    public int coinsCollected;
    public GameObject coinPrefab;
    private GameObject coinText;
    private UIController ui;
    private Vector3 mousePos;
    private Vector3 objectPos;
    // Start is called before the first frame update
    void Start()
    {
        coinsCollected = PlayerPrefs.GetInt("coins");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            spawnCoin();
        }
    }

    void spawnCoin(){ // Spawn a coin at the current mouse position
        mousePos = Input.mousePosition;
        mousePos.z = 2.0f;       // we want 2m away from the camera position
        objectPos = Camera.main.ScreenToWorldPoint(mousePos);
        if(coinsCollected > 0){
            Instantiate(coinPrefab, new Vector3(objectPos.x,objectPos.y,objectPos.z), Quaternion.identity);
            updateCoinCount();
        }
    }

    void updateCoinCount(){
        //coinsCollected --;
        //PlayerPrefs.SetInt("coins",coinsCollected);
    }
}
