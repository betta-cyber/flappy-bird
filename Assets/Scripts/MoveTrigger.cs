﻿using UnityEngine;
using System.Collections;

public class MoveTrigger : MonoBehaviour
{
    public Transform currentBg;
    public Pipe pipe1;
    public Pipe pipe2;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Player")
        { 
             //move the bg to the front of first transform 
             //1.get the first transform 
            Transform firstBg= GameManager._intance.firstBg;
            //2.move
            currentBg.position = new Vector3(firstBg.position.x + 10, currentBg.position.y, currentBg.position.z);

           
            GameManager._intance.firstBg = currentBg;
            //new posiotion for pipe

            pipe1.RandomGeneraterPosition();
            pipe2.RandomGeneraterPosition();
        }
    }
}
