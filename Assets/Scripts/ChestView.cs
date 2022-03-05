using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChestView : MonoBehaviour
{
    [SerializeField] private GameObject grid;
   // [SerializeField] private Button button;
    public ChestController chestController;

    public void spawnChest()
    {
        Debug.Log("spawning");
    }
}
