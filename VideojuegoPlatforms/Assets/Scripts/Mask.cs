using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mask : MonoBehaviour
{
    public int maskValue = 1;
    
    private void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("Player")){
            ScoreMasks.instance.ChangeScore(maskValue);

        }
    }

}
