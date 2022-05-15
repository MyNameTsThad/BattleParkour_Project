using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;
    public GameObject[] hurtScriptHolder;
    public GameObject PointAndShootScriptHolder;
    public HotBarSwitcher hotBarHolder;
   
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (hotBarHolder.SelectedIndex == 2)
            {
                PointAndShootScriptHolder.GetComponent<PointAndShoot>().enabled = false;
                Attack();
            }
        }
    }
    void Attack()
    {
       Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);
        foreach (Collider2D enemy in hitEnemies)
        {
            hurtScriptHolder[0].GetComponent<Hurt>().takeDamage(40);
            hurtScriptHolder[1].GetComponent<Hurt>().takeDamage(40);
            hurtScriptHolder[2].GetComponent<Hurt>().takeDamage(40);
            hurtScriptHolder[3].GetComponent<Hurt>().takeDamage(40);
        }
    }
    void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
        {
            return;
        }
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
