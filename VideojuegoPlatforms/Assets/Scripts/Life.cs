using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{

void OnTriggerEnter2D(Collider2D col){

    GameControl.Health+=1;
}
}
