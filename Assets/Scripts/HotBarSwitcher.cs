using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HotBarSwitcher : MonoBehaviour
{
    public GameObject HotBar1;
    public GameObject HotBar2;
    public GameObject HotBar3;
    public GameObject HotBar4;
    public GameObject HotBar5;
    public int SelectedIndex;
    

    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Alpha1))
       {
            changeHotbar(1);
            SelectedIndex = 1;
       }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            changeHotbar(2);
            SelectedIndex = 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            changeHotbar(3);
            SelectedIndex = 3;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            changeHotbar(4);
            SelectedIndex = 4;
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            changeHotbar(5);
            SelectedIndex = 5;
        }
        
    }
    public void changeHotbar(int hotbarSlot)
    {
        if (hotbarSlot <= 5)
        {
            if (hotbarSlot >= 1)
            {
                if (hotbarSlot == 1)
                {
                    HotBar1.SetActive(true);
                    HotBar2.SetActive(false);
                    HotBar3.SetActive(false);
                    HotBar4.SetActive(false);
                    HotBar5.SetActive(false);
                }
                if (hotbarSlot == 2)
                {
                    HotBar1.SetActive(false);
                    HotBar2.SetActive(true);
                    HotBar3.SetActive(false);
                    HotBar4.SetActive(false);
                    HotBar5.SetActive(false);
                }
                if (hotbarSlot == 3)
                {
                    HotBar1.SetActive(false);
                    HotBar2.SetActive(false);
                    HotBar3.SetActive(true);
                    HotBar4.SetActive(false);
                    HotBar5.SetActive(false);
                }
                if (hotbarSlot == 4)
                {
                    HotBar1.SetActive(false);
                    HotBar2.SetActive(false);
                    HotBar3.SetActive(false);
                    HotBar4.SetActive(true);
                    HotBar5.SetActive(false);
                }
                if (hotbarSlot == 5)
                {
                    HotBar1.SetActive(false);
                    HotBar2.SetActive(false);
                    HotBar3.SetActive(false);
                    HotBar4.SetActive(false);
                    HotBar5.SetActive(true);

                }
            }
        }
    }
}

