using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlimeName : MonoBehaviour
{
    [SerializeField] private Text slimeName;

    public void ChangeSlimeName(string name)
    {
        slimeName.text = name;
    }
}
