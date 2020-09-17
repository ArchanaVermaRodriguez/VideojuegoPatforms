﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SneezeDrops : MonoBehaviour
{
    public float Speed;
    float lifeTime = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        Awake();
    }

    // Update is called once per frame
    void Update()
    {
         gameObject.transform.Translate(new Vector2(-1*Speed, 0));
    }

    

    void Awake () { Destroy (gameObject, lifeTime); }
}