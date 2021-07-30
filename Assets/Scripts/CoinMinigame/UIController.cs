using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    // Start is called before the first frame update
    public Text Score_UIText;

    void Start(){
        if(!PlayerPrefs.HasKey("coins")) PlayerPrefs.SetInt("coins",20); 
    }
    // Update is called once per frame
    void Update()
    {
        Score_UIText.text = "Coins remaining - " + PlayerPrefs.GetInt("coins").ToString();
    }
}
