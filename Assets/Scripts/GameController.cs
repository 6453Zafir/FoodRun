using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    
    public GameObject player;
    GameObject currentRoad;

    int roadNum = 4;
    int TotalRoad = 5;
    public static int currentRoadCount;
    public static string currentRoadName;

	// Use this for initialization
	void Start () {
        currentRoadCount = GameObject.FindGameObjectsWithTag("road").Length;
	}
	
	// Update is called once per frame
	void Update () {
        if (currentRoadCount < TotalRoad){
            currentRoadCount += 1;
            roadNum++;
            int nextRoadNum = Random.Range(0, 5);

            int nextFoodNum = Random.Range(0, 2);
            currentRoad = (GameObject) Instantiate(Resources.Load("Obstacle"+nextRoadNum),new Vector3(0,0, 10*roadNum), transform.rotation);
            if(nextFoodNum==0){
                Instantiate(Resources.Load("red"), currentRoad.transform);

            }else{
                Instantiate(Resources.Load("green"), currentRoad.transform);
            }


        }
	}

}
