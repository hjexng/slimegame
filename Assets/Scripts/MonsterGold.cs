using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonsterGold : MonoBehaviour
{
    [SerializeField] private Text MonsterGiveGold;

    public void ChangeMonsterGold(string monsterGold)
    {
        MonsterGiveGold.text = monsterGold;
    }
}
