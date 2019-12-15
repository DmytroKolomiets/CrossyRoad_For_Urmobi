using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TruckSpawner : MonoBehaviour
{
    public Transform spawnPoint;
    private float minSpawnTime = 1f;
    private float maxSpawnTime = 5f;
    private int poolCount = 7;
    public GameObject myTruck;
    private float Timer;
    private float spawnTime = 3;
    List<GameObject> poolOfTrucks;
   
    void Start()
    {      
        SpawnTime();
        poolOfTrucks = new List<GameObject>();
    //Instantiating pool of trucks
        for (int i = 0; i < poolCount; i++)
        {
            GameObject obj = (GameObject)Instantiate(myTruck);
            obj.transform.parent = transform;
            obj.SetActive(false);
            poolOfTrucks.Add(obj);
        }            
    }

    void Update()
    {
    //Spawn
       Timer += Time.deltaTime;
       if (Timer >= spawnTime)
        {
            Timer = 0;
            WakingUp();
            SpawnTime();
        }
    }
    //Wake up the truck
    private void WakingUp()
    {
        for (int i = 0; i < poolOfTrucks.Count; i++)
        {
            if (!poolOfTrucks[i].activeInHierarchy)
            {
                poolOfTrucks[i].transform.position = spawnPoint.transform.position;
                poolOfTrucks[i].transform.rotation = spawnPoint.transform.rotation;
                poolOfTrucks[i].transform.parent = gameObject.transform;               
                poolOfTrucks[i].SetActive(true);
                break;
            }
        }
    }
   
    // calculate random time for spawn the truck
    public void SpawnTime()
    {
       spawnTime = Random.Range(minSpawnTime, maxSpawnTime);
    }
}
