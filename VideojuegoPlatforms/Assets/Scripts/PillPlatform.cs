using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillPlatform : MonoBehaviour
{
    public GameObject Platform;

    // Start is called before the first frame update
    void Start()
    {
        Platform.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other){

        if(other.tag == "Player"){
            Destroy(gameObject);
            Platform.gameObject.SetActive(true);

        }
    }
}
