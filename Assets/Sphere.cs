﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{


    void OnTriggerEnter2D(Collider2D col)
    {

        {

            ScoreTextScript.coinamount += 1;
            Destroy(gameObject);




        }
    }

}