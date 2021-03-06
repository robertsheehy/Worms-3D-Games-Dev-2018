﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileControl : MonoBehaviour {
    Vector3 velocity, acceleration;
    Quaternion grenaderotation;
    public float turningSpeed = 45;
    internal enum ProjectileType {Grenade, Missile, Bullet, Mortar };
    ProjectileType thisProjectile = ProjectileType.Missile;

    // Use this for initialization
    void Start () {
        //velocity = new Vector3(0, 0, 3);
        //acceleration = new Vector3(0, 0,0);
        //grenaderotation =  Quaternion.Euler(1,1,1);
		

	}

    internal void youAreA(ProjectileType projectileType, Vector3 position, Vector3 direction, float speed)
    {

        thisProjectile = projectileType;
        transform.position = position;
        velocity = speed * direction;

        switch (thisProjectile)
        {
            case ProjectileType.Grenade:
       
                acceleration = new Vector3(0, -9.8f, 0);
                turningSpeed = 180;
         
    
                break;

            case ProjectileType.Missile:

                acceleration = new Vector3(0, 0, 0);
                turningSpeed = 360;
      
 
                break;

            case ProjectileType.Bullet:
   
                acceleration = new Vector3(0, 0, 0);
                break;

            case ProjectileType.Mortar:

                acceleration = new Vector3(0, -9.8f, 0);
                break;
        }
    }

    // Update is called once per frame
    void Update() {

        velocity += acceleration * Time.deltaTime;
        transform.position += velocity * Time.deltaTime;

        switch (thisProjectile) {

            case ProjectileType.Missile:
        transform.Rotate(transform.forward, turningSpeed * Time.deltaTime); // rocket

                break;

            case ProjectileType.Grenade:

        transform.Rotate(transform.right, turningSpeed * Time.deltaTime); // Grenade
                break;


    }

    }


}


 
     
