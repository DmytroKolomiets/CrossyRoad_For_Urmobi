using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RoadSpawner : MonoBehaviour
{
    public GameObject Road;
    List<GameObject> Roads;
    int PlaneSize;
    Vector3 step;    
   
    void Start()
    {
        PlaneSize = (int)transform.localScale.y;
        step = transform.position;
        step.y -= PlaneSize / 2;
        step.z = 0.95f;
        // creating and placing roads  
        Roads = new List<GameObject>();
        for (int i = 0; i < PlaneSize; i++)
        {
            GameObject obj = (GameObject)Instantiate(Road);           
            obj.transform.parent = transform;            
            obj.transform.position = step;
            step.y++;
            int randomAngle = Random.Range(0, 2) *180;
            obj.transform.Rotate(0,0,randomAngle);
            obj.SetActive(false);
            Roads.Add(obj);
        }  
    }
    //wake up Roads
    public void SpawnRoads()
    {
        int numberOfRoads = Random.Range(2, PlaneSize / 2);
        int counter = 0;
        while (counter < numberOfRoads)
        {
            int Challanger = Random.Range(0,Roads.Count);           
            if (!Roads[Challanger].activeInHierarchy)
            {
                Roads[Challanger].SetActive(true);
                counter++; 
            }
        }
    }
    // deactivate roads
    public void DeactiveRoads()
    {
        for (int i = 0; i < Roads.Count; i++)
        {
            if (Roads[i].activeInHierarchy)
            {
                Roads[i].SetActive(false);
            }
        }
    }
}
