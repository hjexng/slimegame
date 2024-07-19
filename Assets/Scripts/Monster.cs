using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    [SerializeField] private HpBar hpbar;
    [SerializeField] private float maxHp;
    [SerializeField] private SlimeName slimeNameText;
    [SerializeField] private string slimeName;
    [SerializeField] private MonsterGold monsterGoldText;
    [SerializeField] private string monsterGold;
    private float curHp;
    
    private bool isDead = false;
    private Animator animator;

    private void Awake()
    {
        curHp = maxHp;
        animator = GetComponent<Animator>();
        slimeNameText.ChangeSlimeName(slimeName);
    }

    //1. �Է��� ������ Ȯ�����(50% Ȯ���� ũ��Ƽ�� ����)
    //2. Ȯ������Ŀ� ũ��Ƽ���� �ߵ���(+20��ŭ�� �߰�������)

    public void OnHit(float damage)
    {
        int percent = Random.Range(1, 101);
        if (percent > 50)
        {
            damage += 20;
        }

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
            monsterGoldText.ChangeMonsterGold(monsterGold);
            Debug.Log(monsterGold);
        }
    }
}
