using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Gamestats : MonoBehaviour
{
    public ghosthandler gh;
    public int Money = 0;
    public TextMeshProUGUI MoneyDisplay;

    public int ghosttype;

    private void Start()
    {
        ghosttype = PlayerPrefs.GetInt("GhostType");
        Money = PlayerPrefs.GetInt("Money");
    }

 
    public void MoneyTextSet()
    {
        Money = PlayerPrefs.GetInt("Money");
        MoneyDisplay.text = Money.ToString() + "$";
    }
    public void MoneySave()
    {
        PlayerPrefs.SetInt("Money", Money);
    }

    public void Update()
    {


        if (Input.GetKey("p"))
        {
            PlayerPrefs.SetInt("Money", 0);
            Money = PlayerPrefs.GetInt("Money");
        }

        if (Input.GetKey("m"))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            PlayerPrefs.SetInt("GhostType", gh.activeghost);
            SceneManager.LoadScene(1);
            
        }
    }
}
