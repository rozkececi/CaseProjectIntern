using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] public GameObject PauseMenuPanel;

    public void Pause()
    {
        PauseMenuPanel.SetActive(true); // Duraklatma menüsü paneli aktif hale getirilir.
        Time.timeScale = 0f; // Oyun zamaný sýfýr olarak ayarlanýr ve oyun durur.
    }

    public void Resume()
    {
        PauseMenuPanel.SetActive(false); // Duraklatma menüsü paneli devre dýþý býrakýlýr.
        Time.timeScale = 1f; // Oyun zamaný bir olarak ayarlanýr ve oyun devam eder.
    }


    public void Restart()
    {
        Time.timeScale = 1f; 
        SceneManager.LoadScene("SampleScene"); // "SampleScene" sahnesini yeniden yükler, oyuna baþtan baþlar.
    }
}

   

