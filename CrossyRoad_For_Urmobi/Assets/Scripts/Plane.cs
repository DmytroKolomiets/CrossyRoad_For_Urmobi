using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{
    float amontToMove;
    bool wasVisible;
    public RoadSpawner roadSpawner;
    private int PlaneStepCounter;
    public float TruckSpeed =  4.1f;
    private void Start()
    {
        amontToMove = transform.localScale.y * 2;
    }
    private void OnBecameVisible()
    {
        wasVisible = true;
        roadSpawner.SpawnRoads();
    }
    //if object was visible and become invisible to the camera call "EndlessEffect"
    private void OnBecameInvisible()
    {
        if (wasVisible)
        {
            EndlessEffect();
            roadSpawner.DeactiveRoads();
            TruckSpeed += 1f;
            wasVisible = false;
        }
    }
    //teleports plane forward
   void EndlessEffect()
    {              
        Vector3 temp = new Vector3(0, amontToMove, 0);
        transform.position += temp;
    }
}
