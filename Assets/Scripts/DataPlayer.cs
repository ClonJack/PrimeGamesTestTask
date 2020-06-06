using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public enum MoveLines
{
    RightLines,
    LeftLines,
    CenterLines
};

[Serializable]
public class DataPlayer
{
    public int Money;
    public TextMeshProUGUI MoneyText;
    public Animator Animator;
    public Transform RightLines, LeftLines, CenterLines;
    public MoveLines lines;
    public TextMeshProUGUI UnitText;
    public AnimationClip AnimationEffect;
    public GameObject UIOver;

    public IEnumerator IPlayEffectText()
    {
        WaitForSeconds waitFor = new WaitForSeconds(AnimationEffect.length);
        yield return waitFor;

        Animator.SetBool("IsPlayEffect", false);
    }
    public Transform Target(float dirX)
    {
        Transform tr = null;

        if (dirX > 0)
            tr = RightLines;

        else if (dirX < 0)
            tr = LeftLines;

        return tr;

    }
}
