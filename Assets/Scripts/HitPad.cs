using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HitPad : MonoBehaviour
{
    private GameManger gameManger;
    private Button button;

    private void Awake()
    {
        gameManger = FindObjectOfType<GameManger>();
        button = GetComponent<Button>();
        button.onClick.AddListener(gameManger.HitSlime);
    }
}
