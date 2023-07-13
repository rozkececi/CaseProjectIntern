using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour

{
    private TextMeshProUGUI ballText;
    void Start()
    {
        ballText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateBallText(PlayerInventory playerInventory)
    {
        ballText.text = playerInventory.NumberOfBalls.ToString(); // playerInventory üzerindeki NumberOfBalls deðerini alarak top sayýsýný günceller.
    }
}


