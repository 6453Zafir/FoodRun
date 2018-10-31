using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    
    public GameObject player;
    GameObject currentRoad;
    int roadCount = 5;
    public static int currentRoadCount;
	// Use this for initialization
	void Start () {
        currentRoadCount = GameObject.FindGameObjectsWithTag("road").Length;
	}
	
	// Update is called once per frame
	void Update () {
        if (currentRoadCount < roadCount){
            currentRoadCount += 1;
            int nextRoadNum = Random.Range(0, 5);

            int nextFoodNum = Random.Range(0, 2);
            currentRoad = (GameObject) Instantiate(Resources.Load("Obstacle"+nextRoadNum),new Vector3(0,0,player.transform.position.z + 30f), transform.rotation);
            if(nextFoodNum==0){
                Instantiate(Resources.Load("red"), currentRoad.transform);

            }else{
                Instantiate(Resources.Load("green"), currentRoad.transform);
            }


        }
	}

}
