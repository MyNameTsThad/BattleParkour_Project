using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healer : MonoBehaviour
{
    public PlayerHealth player;
    public float healIncrement;
    public float timeBtwHeal;
    void Start()
    {
        StartCoroutine(Heal(player, healIncrement, timeBtwHeal));
    }
    public IEnumerator Heal(PlayerHealth player, float healIncrement, float timeBtwHeal)
    {
        player.health += healIncrement;

        yield return new WaitForSeconds(timeBtwHeal);
        StartCoroutine(Heal(player, healIncrement, timeBtwHeal));

    }
}
