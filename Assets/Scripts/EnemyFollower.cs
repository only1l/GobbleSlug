using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyFollower : MonoBehaviour
{
    public Transform player;
    public Stats enemyStats;
    void OnEnable(){
        player = PlayerInfo.player.transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = (player.position - transform.position).normalized;
            // Двигаем врага в сторону игрока
            transform.position += direction * enemyStats.speed * Time.deltaTime;
    }
}
