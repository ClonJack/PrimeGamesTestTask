using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public DataPlayer dataPlayer;
    [SerializeField] public Transform Target;
    [SerializeField] private Transform moveObj;
    [SerializeField] private float speed;
    [SerializeField] public Transform CurrentPanel;
    [SerializeField] private Vector3 startPos;

    private void Start() => startPos = transform.position;

    public void SetMoney()
    {
        dataPlayer.Money++;
        dataPlayer.MoneyText.text = dataPlayer.Money.ToString();
        dataPlayer.Animator.SetBool("IsPlayEffect", true);

        StartCoroutine(dataPlayer.IPlayEffectText());
    }


    private void MoveInput()
    {
        if (Target != null)
            transform.position = Vector3.MoveTowards(transform.position, Target.position, 10 * Time.deltaTime);
    }
    private void MoveForward() => moveObj.Translate(new Vector3(1, 0, 0) * Time.deltaTime * speed);

    private void Update()
    {
        if(Input.GetAxisRaw("Horizontal")!=0)
        Target = dataPlayer.Target(Input.GetAxisRaw("Horizontal"));

        MoveForward();
        MoveInput();

        dataPlayer.UnitText.text = (Vector3.Distance(transform.position, startPos)).ToString("#.#");

    }
}
