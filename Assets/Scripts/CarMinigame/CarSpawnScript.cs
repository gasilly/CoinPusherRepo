using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawnScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject carPrefab;
    void Start()
    {
        StartCoroutine(SpawnCars());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnCars() //Move in the desired direction for the desired amount of time indefinetly 
    {
        while (true)
        {
            Instantiate(carPrefab, new Vector3(Random.Range(-2.0f,2.0f),this.gameObject.transform.position.y,0.0f),Quaternion.identity);
            yield return new WaitForSeconds(Random.Range(1.0f,1.5f));
        }
    }
}
