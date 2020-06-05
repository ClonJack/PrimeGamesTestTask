using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateTrigger : MonoBehaviour
{
    [SerializeField] private GameObject prefabInst;
    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out Player pl))
        {
            var spawnPanel = Instantiate(Resources.Load<GameObject>("Platform Variant"), pl.CurrentPanel.position + new Vector3(30f, 0, 0), Quaternion.identity);
        
            pl.CurrentPanel = spawnPanel.transform;
        }
    }
}
