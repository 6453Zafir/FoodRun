using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour {
    float amplitude = 0.15f;
    float speed = 4;
    private float tempVal;

    private Vector3 tempPos;	// Use this for initialization
	void Start () {
        //transform.position = transform.parent.transform.position;
        if (transform.parent != null)
        { 
            int RandomPos = Random.Range(0, 3);
            if (RandomPos == 0)
            {
                tempPos.x = -1.6f;
            }
            else if (RandomPos == 1)
            {
                tempPos.x = 0;

            }
            else
            {
                tempPos.x = 1.6f;
            }
            tempVal = transform.position.y;
            tempPos.z = transform.parent.transform.position.z;
        }

	}
	
	// Update is called once per frame
	void Update () {
        if(transform.parent!=null){
          


            tempPos.y = tempVal + amplitude * Mathf.Sin(speed * Time.time);
            transform.position = tempPos;

        }else{

            Destroy(gameObject);
        }
      
	}
}
