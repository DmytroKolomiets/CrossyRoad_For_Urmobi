using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movement : MonoBehaviour
{
    public DisplayScore displayScore;
    private Vector2 temp;
    public float amountToMove = 1;
    public bool IsDragActive;

    public void Move(Vector2 delta)
    {     
       if(Mathf.Abs(delta.y) < Mathf.Abs(delta.x))
        {
            temp = new Vector2(transform.position.x + amountToMove * Math.Sign(delta.x), transform.position.y);
            transform.position = temp;
        }
        else
        {              
            temp = new Vector2(transform.position.x, transform.position.y + amountToMove * Math.Sign(delta.y));
            transform.position = temp;
            displayScore.Score(transform.position.y);
        }
      
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            IsDragActive = false;
        }
        if (Input.GetMouseButtonUp(0)&&!IsDragActive)
        {
            temp = new Vector2(transform.position.x, transform.position.y + amountToMove);
            transform.position = temp;
            displayScore.Score(transform.position.y);
        }
    }

}
