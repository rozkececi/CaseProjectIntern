using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    void Start()
    {
        Cursor.lockState = CursorLockMode.None; // Farenin imlecinin serbest býrakýlýr.
    }
    public void OyunuBaþlat()
    {
        SceneManager.LoadScene(1); // Ýkinci sahneyi yükler ve oyuna baþlar.
    }

    public void OyunuKapat()
    {
        Application.Quit(); // Oyunu kapatýr.
    }
}

