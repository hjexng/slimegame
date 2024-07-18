using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    [SerializeField] private HpBar hpbar;
    [SerializeField] private float maxHp;
    [SerializeField] private SlimeName slimeNameText;
    [SerializeField] private string slimeName;
    [SerializeField] private MonsterGold monstergoldtext;
    [SerializeField] private string monstergold;
    private float curHp;
    
    private bool isDead = false;
    private Animator animator;

    private void Awake()
    {
        curHp = maxHp;
        animator = GetComponent<Animator>();
        slimeNameText.ChangeSlimeName(slimeName);
    }

    public void OnHit(float damage)
    {
        curHp -= damage;
        if (curHp <= 0)
        {
            curHp = 0;
            isDead = true;
        }
        animator.SetTrigger("Hit");
        Debug.Log("Slime Hit!, Current Hp : " + curHp);
        hpbar.ChangeHpBarAmount(curHp/maxHp);

        if(isDead)
        {
            Debug.Log("Slime if Dead");
            animator.SetTrigger("Death");
            Destroy(gameObject, 1.5f);
            monstergoldtext.ChangeMonsterGold(monstergold);
            Debug.Log(monstergold);
        }
    }
}
