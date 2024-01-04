using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonFinish : MonoBehaviour
{
    public Gamestats gs;
    public TextMeshProUGUI text;
    public GameObject ButtonManager;

    public void Resart()
    {
        SceneManager.LoadScene(0);

    }

    public void Start()
    {
        ButtonManager.SetActive(true);
        gs.MoneyTextSet();
    }

    private void Update()
    {
        text.text = gs.Money.ToString() + "$";
    }

    public void Myling()
    {

        ButtonManager?.SetActive(false);
        if (gs.ghosttype == 3)
        {
            gs.Money = gs.Money + 10;
            gs.MoneySave();
            gs.MoneyTextSet();

        }
        else
        {
            gs.Money = gs.Money - 5;
            gs.MoneySave();
            gs.MoneyTextSet();

        }
    }
    public void Oni()
    {
        ButtonManager?.SetActive(false);
        if (gs.ghosttype == 0)
        {

            gs.Money = gs.Money + 10;
            gs.MoneySave();
            gs.MoneyTextSet();


        }
        else
        {
            gs.Money = gs.Money - 5;
            gs.MoneySave();
            gs.MoneyTextSet();

        }
    }
    public void Shade()
    {
        ButtonManager?.SetActive(false);
        if (gs.ghosttype == 1)
        {
            gs.Money = gs.Money + 10;
            gs.MoneySave();
            gs.MoneyTextSet();

        }
        else
        {
            gs.Money = gs.Money - 5;
            gs.MoneySave();
            gs.MoneyTextSet();

        }
    }

    public void Obake()
    {
        ButtonManager?.SetActive(false);
        if (gs.ghosttype == 2)
        {
            gs.Money = gs.Money + 10;
            gs.MoneySave();
            gs.MoneyTextSet();

        }
        else
        {
            gs.Money = gs.Money - 5;
            gs.MoneySave();
            gs.MoneyTextSet();

        }
    }
}
