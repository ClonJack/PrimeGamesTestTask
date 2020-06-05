using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] private List<Transform> obj = new List<Transform>();
    public List<Transform> Money = new List<Transform>();
    public List<Transform> Obstacles = new List<Transform>();
    [SerializeField] private bool isSpawn;
    [SerializeField] private SettingSpawn setting;
    private void SetObstacle()
    {
        for (int i = 1; i < transform.childCount; i++)
        {
            obj.Add(transform.GetChild(i));
            if (transform.GetChild(i).tag == "obstacle") Obstacles.Add(transform.GetChild(i).transform);
            else if (transform.GetChild(i).tag == "Money") Money.Add(transform.GetChild(i).transform);
        }
    }

    private void Awake() => setting = GameObject.Find("Manager").GetComponent<SettingSpawn>();        
    

    private void Start()
    {

        SetObstacle();
        setting.FixSpawn(this);
        if (isSpawn)
            Generator.GenerateOffset(obj);
    }
}
