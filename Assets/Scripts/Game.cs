using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Game : MonoBehaviour
{
    [SerializeField] private Player player;
    [SerializeField] private GameObject strartText;
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            player.enabled = true;
     
            player.dataPlayer.Money = PlayerPrefs.GetInt("Money", 0);
            player.dataPlayer.MoneyText.text = PlayerPrefs.GetInt("Money", 0).ToString();
            strartText.SetActive(false);
        }
      
    }
    public void Reload() => SceneManager.LoadSceneAsync(0);
}
