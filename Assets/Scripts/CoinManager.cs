using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class CoinManager : MonoBehaviour
{
    public TextMeshProUGUI TotalCoins;

    public TextMeshProUGUI CoinsCollected;

    public TextMeshProUGUI levelCleared;

    public GameObject transition;

    private int totalCoinsInLevel;

    private void Start()
    {
        totalCoinsInLevel = transform.childCount;

    }


    private void Update()
    {
        AllCoinsCollected();
        TotalCoins.text = totalCoinsInLevel.ToString();
        CoinsCollected.text = (totalCoinsInLevel - transform.childCount).ToString();
    }
    public void AllCoinsCollected()
    {
        if (transform.childCount == 0)
        {
            Debug.Log("No quedan Monedas, Victoria");
            levelCleared.gameObject.SetActive(true);
            transition.SetActive(true);
            Invoke("ChangeScene", 3);
        }
    }

    void ChangeScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

}
