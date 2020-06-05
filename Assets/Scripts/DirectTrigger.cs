using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectTrigger : MonoBehaviour
{
    [SerializeField] private MoveLines moveLines;
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Player pl))
        {
            pl.dataPlayer.lines = moveLines;
            pl.Target = null;
        }
    }
}
