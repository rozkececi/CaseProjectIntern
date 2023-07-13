using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownController : MonoBehaviour
{
   
    public float countdownDuration = 3f; // Geri sayým süresi 
    public Text countdownText; // Geri sayýmý gösteren metin 

    private float currentTime;

    private void Start()
    {
        currentTime = countdownDuration;
        StartCoroutine(StartCountdown());
    }

    private System.Collections.IEnumerator StartCountdown()
    {
        while (currentTime > 0)
        {
            UpdateCountdownText();
            yield return new WaitForSeconds(1f);
            currentTime--;
        }

        // Geri sayým tamamlandýðýnda yapýlacaklar
        countdownText.text = "GO!"; // Geri sayým bittiðinde metni güncelle
        yield return new WaitForSeconds(1f); // "Baþla!" metnini bir saniye göster

        countdownText.enabled = false; // Metni ekrandan kaldýr
        // Oyuna baþlamak için gerekli diðer iþlemleri buraya ekleyebilirsiniz
    }

    private void UpdateCountdownText()
    {
        countdownText.text = currentTime.ToString(); // Geri sayým metnini güncelle
    }
}
