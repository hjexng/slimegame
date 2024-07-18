using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    [SerializeField] private Monster[] slimes;
    [SerializeField] private float damage;
    private Monster curSlime;
    private float criticalDamage;
    private float criticalPercent;
    private float gold;

    public void SpawnSlime()
    {
        int spawnIndex = UnityEngine.Random.Range(0, slimes.Length);
        GameObject newSlime = Instantiate(slimes[spawnIndex].gameObject);
        curSlime = newSlime.GetComponent<Monster>();
    }

    private void Update()
    {
        if (curSlime == null)
        {
            SpawnSlime();
        }
    }

    public void HitSlime() 
    {
        if(curSlime != null)
        {
            curSlime.OnHit(damage);
        }
    }
}
