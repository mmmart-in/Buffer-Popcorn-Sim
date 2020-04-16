﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopcornSpawner : MonoBehaviour
{
    public GameObject stekpanna;
    public GameObject popcorn;
    public GameObject[] popcornArray;

    public float xPos;
    public float yPos;

    private float popcornSpawnNumber;
    private int randomAngle;
    private float panRadius = 0.4f;
    private int randomPopcorn;

    private void FixedUpdate()
    {
        randomPopcorn = Random.Range(0, popcornArray.Length);
        xPos = Random.Range(stekpanna.transform.position.x - panRadius, stekpanna.transform.position.x + panRadius);
        yPos = transform.position.y;
        randomAngle = Random.Range(-45, 45);
        
        popcornSpawnNumber = Random.Range(1, 10) / Stekpanna.stekpannaInstance.distanceToFire;
        if (popcornSpawnNumber > 9)
            Instantiate(popcornArray [randomPopcorn], new Vector3(xPos, yPos, 15f), Quaternion.AngleAxis(randomAngle, Vector3.one));
    }


}
