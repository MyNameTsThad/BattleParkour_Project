using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathUIRef : MonoBehaviour
{
    public GameObject DeathUI;

    public void SetDeathUIActive(bool value)
    {
        DeathUI.SetActive(value);
    }
}
