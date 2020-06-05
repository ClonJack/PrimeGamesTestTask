using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingSpawn : MonoBehaviour
{
    [Range(1, 5)]
    [SerializeField] private int moneyCountSpawn;
    [Range(1, 9)]
    [SerializeField] private int obstacleCountSpawn;


    public void FixSpawn(Platform platform)
    {
        
        var needDeleteMoney = platform.Money.Count - moneyCountSpawn;
        var needDeleteObstacle = platform.Obstacles.Count - obstacleCountSpawn;


        for(int i = 0; i < needDeleteObstacle; i++)
        {
            var del = platform.Obstacles[Random.Range(0, platform.Obstacles.Count)];
            Destroy(del.gameObject);
            platform.Obstacles.Remove(del);

        }

        for (int i = 0; i < needDeleteMoney; i++)
        {
            var del = platform.Money[Random.Range(0, platform.Money.Count)];
            Destroy(del.gameObject);
            platform.Money.Remove(del);

        }
   
    }

}
