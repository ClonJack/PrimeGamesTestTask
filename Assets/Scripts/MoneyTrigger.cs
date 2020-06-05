using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out Player pl))
        {
           
            pl.SetMoney();
            PlayerPrefs.SetInt("Money", pl.dataPlayer.Money);
            gameObject.SetActive(false);

        }
    }
}
