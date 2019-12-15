using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DisplayScore : MonoBehaviour
{
    public Text textScore;
    float highestPosition = 0;
    public Reload_Lvl Dead;
  
    //Display highest score
    public void  Score(float y_position)
    {
        if (!Dead.IsDead)// make sure that player can't increase score after death
        if (y_position > highestPosition)
        {            
            highestPosition = y_position;
            int temp = (int)highestPosition;
            textScore.text = temp.ToString();
        }
    }
    
}
