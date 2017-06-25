using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour {

    bool IsEnemyInRad = false;
    Enemy enemy;
    [SerializeField]
    int Damage = 1;

    void Update()
    {
        AttackEnemy();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            IsEnemyInRad = true;
            Debug.Log(IsEnemyInRad);
            enemy = other.GetComponent<Enemy>();
            //enemy.lives -= 1;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            IsEnemyInRad = false;
            Debug.Log(IsEnemyInRad);
        }
    }

    void AttackEnemy()
    {
        if (IsEnemyInRad == true && Input.GetKeyDown(KeyCode.Mouse0))
        {
            enemy.lives -= Damage;
        }
    }


}
