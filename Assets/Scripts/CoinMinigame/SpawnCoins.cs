using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnCoins : MonoBehaviour
{
    public GameObject coinPrefab;
    private GameObject coinText;
    private UIController ui;
    private Vector3 mousePos;
    private Vector3 objectPos;
    private int coinsCollected;
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
        AddCoinsDebugger();
        CoinAmountDebugger();
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
        coinsCollected = PlayerPrefs.GetInt("coins");
        coinsCollected -= 1;
        PlayerPrefs.SetInt("coins",coinsCollected);
    }

    void AddCoinsDebugger(){
        if(Input.GetKey(KeyCode.Alpha1)){
            coinsCollected ++;
            PlayerPrefs.SetInt("coins",coinsCollected);
        }
    }

    void CoinAmountDebugger(){
        if(Input.GetKeyDown(KeyCode.Alpha2)){
           Debug.Log("Real coin count is: " + PlayerPrefs.GetInt("coins"));
        }
    }
}
