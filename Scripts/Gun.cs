﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    /// <summary>
    /// resets to zero after every shot 
    /// </summary>
    public float TimeFromLastShot; 
    public float ReloadTime = 3;
    /// <summary>
    /// "Bullet fired by this gun"
    /// </summary>
    public GameObject FiredThing;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TimeFromLastShot += Time.deltaTime;
        if(Input.GetMouseButton(0) == true && TimeFromLastShot >= ReloadTime)
        {
            Shoot();       
        }
    }
    void Shoot()
    {
        Instantiate(FiredThing, transform, false);
        TimeFromLastShot = 0;
    }
}
