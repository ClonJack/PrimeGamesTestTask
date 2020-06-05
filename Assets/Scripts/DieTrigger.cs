using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out Player pl))
        {
            PlayerPrefs.SetInt("Money", pl.dataPlayer.Money);
            Time.timeScale = 0;
            pl.dataPlayer.UIOver.SetActive(true);
       
        }
    }
}
