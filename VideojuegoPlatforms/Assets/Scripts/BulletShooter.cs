using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShooter : MonoBehaviour
{
   public GameObject Bullet;
    public GameObject GunPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKeyDown(KeyCode.Space)){
        Instantiate(Bullet, GunPosition.transform.position, Quaternion.identity);
      }  
    }
}
