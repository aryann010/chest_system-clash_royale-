using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestModel 
{

    public ChestModel(ChestScriptableObject chestSO)
    {
        this.ChestName = chestSO.ChestName;
        this.ChestSprite = chestSO.ChestSprite;
        this.UnlockDuration = chestSO.UnlockDuration;
        this.RewardCoins = Random.Range(chestSO.MinCoins, chestSO.MaxCoins + 1);
        this.RewardGems = Random.Range(chestSO.MinGems, chestSO.MaxGems + 1);
        this.UnlockGemCost = chestSO.UnlockGemCost;
    }

    [SerializeField] private ChestScriptableObject chestScriptableObject;
    public string ChestName { get; }
    public Sprite ChestSprite { get; }
    public float UnlockDuration { get; }
    public int RewardCoins { get; }
    public int RewardGems { get; }
    public int UnlockGemCost { get; }
}
