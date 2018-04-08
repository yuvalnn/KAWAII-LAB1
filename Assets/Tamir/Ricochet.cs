﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ricochet : MonoBehaviour
{
    public LayerMask collisionMask;
    public float speed;
    public float ProjectileSpeed;

    private void BounceProjectile()
    {
        Ray ray = new Ray(transform.position, transform.forward); //You might have to change this to transform.up instead of transform.forward for a 2D game
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, Time.deltaTime * ProjectileSpeed + 0.1f, collisionMask))
        {
            //Vector2 reflectDir2D = Vector2.Reflect(ray.direction, hit.normal);
            Vector3 reflectDir = Vector3.Reflect(ray.direction, hit.normal);
            float rot = 90 - Mathf.Atan2(reflectDir.z, reflectDir.x) * Mathf.Rad2Deg; //I think this should be Mathf.Atan2(reflectDir2D.y, reflectDir.x) * Mathf.Rad2Deg; for 2D
            transform.eulerAngles = new Vector3(0, rot, 0); //For 2D I think this should be maybe Vector3(0,0,rot)
        }
    }

}
