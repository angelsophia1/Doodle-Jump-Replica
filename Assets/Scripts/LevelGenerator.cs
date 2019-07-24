using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour {
    public GameObject platformPrefab;

    public int numberOfPlatforms;
    public float levelWidth = 6f;
    public float minY = .2f;
    public float maxY = 1.5f;

	// Use this for initialization
	void Start () {
        Vector3 spawnPosition = new Vector3(0f,-2.3f,0f);
        for (int i = 0; i < numberOfPlatforms;i++ )
        {
            spawnPosition.y += Random.Range(minY,maxY);
            spawnPosition.x = Random.Range(-levelWidth,levelWidth);
            Instantiate(platformPrefab,spawnPosition,Quaternion.identity);
        }
	}
	
}
