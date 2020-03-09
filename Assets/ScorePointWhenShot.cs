using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePointWhenShot : MonoBehaviour
{
    public int score = 0;

   void OnCollisionEnter(Collision coll)
   {
       if (coll.gameObject.tag == "Respawn")
       {
            score++;

            Debug.Log("Your score is now " + score);
       }
   }
}
