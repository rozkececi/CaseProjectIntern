using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{

    public int requiredBallCount = 10; // Gerekli top sayýsý

    private PlayerInventory playerInventory; 
   


    private void Awake()
    {
        playerInventory = FindObjectOfType<PlayerInventory>();
        playerInventory.OnBallCollected.AddListener(CheckBallCount); // OnBallCollected olayýna CheckBallCount metodunu dinleyici olarak ekler.
    }

    private void CheckBallCount(PlayerInventory inventory)
    {
        if (inventory.NumberOfBalls >= requiredBallCount) // Oyuncunun topladýðý top sayýsý gereken top sayýsýna eþit veya büyükse oyun yeniden baþlatýlýr.
        {
            RestartGame();
        }
    }

    private void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Oyun sahnesini yeniden yükler, oyuna baþtan baþlar.
    }
}
