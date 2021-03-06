﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour {
    GameObject player;
    bool haveOn = false;
    bool isDelete = false;
	// Use this for initialization
	void Start () {
        player = GameObject.FindWithTag("Player").gameObject;
	}
	
	// Update is called once per frame
	void Update () {
        /*
        if(gameObject!=null){
            if (Vector3.Distance(transform.position, player.transform.position) < 10f)
            {
                haveOn = true;
            }
            if (haveOn && Vector3.Distance(transform.position, player.transform.position) > 5f)
            {
                if(!isDelete){
                    GameController.currentRoadCount--;
                    isDelete = true;
                }
                StartCoroutine(DestoryWithDelay(1));
            }
        }
       */
	}

    IEnumerator DestoryWithDelay(float waittime){

        yield return new WaitForSeconds(waittime);
        Destroy(gameObject);
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player"){
            haveOn = true;
           // GameController.currentRoadName = gameObject.name;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            if (!isDelete)
            {
                GameController.currentRoadCount--;
                isDelete = true;
            }
            StartCoroutine(DestoryWithDelay(1));
        }
    }
}
