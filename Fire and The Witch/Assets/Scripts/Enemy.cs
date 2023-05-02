using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int[] enemyLevel;
    public int levelIndex;
    public int health;
    public GameObject fakeButton;
    public GameObject realButton;

    public void Start()
    {
        levelIndex = 0;
        ResetEnemyHealth();
    }

    public void Update()
    {
        if(GlobeFire.fireCount>=health)
        {
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }
        else
        {
            realButton.SetActive(false);
            fakeButton.SetActive(true);
        }
    }

    public void ResetEnemyHealth()
    {
        health = enemyLevel[levelIndex];
        if(levelIndex>= enemyLevel.Length)
        {
            levelIndex = 0;
        }
    }

    public void KillEnemy()
    {
        if (GlobeFire.fireCount >= health)
        {
            Debug.Log("Monster killed");
            GlobeFire.fireCount -=health;
            levelIndex += 1;
            GlobeBlood.bloodCount += health;
            ResetEnemyHealth();
           

        }
    }
}
