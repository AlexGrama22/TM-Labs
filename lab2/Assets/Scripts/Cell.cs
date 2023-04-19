using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{
    public bool isAlive=false;
    public int numNeighbors=0;
    public bool isInZone = false;
    public float health = 1f;
    public float damage = 0.1f;

    public void SetAlive(bool alive){ 
        isAlive=alive;
        if (isAlive){
            GetComponent<SpriteRenderer>().enabled = true;
        }
        else{
            GetComponent<SpriteRenderer>().enabled = false;

        }
    }

    public void ApplyDamage(){
        health -= damage;
        if (health <= 0){
            SetAlive(false);
            health = 1f;
        }
    }
}
