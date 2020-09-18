using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainMonster : MonoBehaviour
{
    public GameObject Cannon1;

    public GameObject Cannon2;

    public GameObject RainDrop;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Shoot", 0,1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Shoot(){
        Instantiate(RainDrop, Cannon1.transform.position,Quaternion.identity);
        Instantiate(RainDrop, Cannon2.transform.position,Quaternion.identity);
    }


}
