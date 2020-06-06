using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public static Generator Gen;
    private void Awake() => Gen = this;

    private IEnumerator IMove(Transform objMove, Vector3 targetPos)
    {
        WaitForEndOfFrame waitForEnd = new WaitForEndOfFrame();

        while (Vector3.Distance(objMove.position, targetPos) > 0.1f)
        {
            objMove.localPosition = Vector3.MoveTowards(objMove.localPosition, targetPos, 2f * Time.deltaTime);
            yield return waitForEnd;
        }
    }

    public void GenerateOffset(List<Transform> obj)
    {
        foreach (var ob in obj)
        {
            var offset = ob.localPosition;

            if (ob.localPosition.z < 0)
                offset += new Vector3(0, 0, Random.Range(-0.5f,2.5f));
            else if (ob.localPosition.z > 0) offset += new Vector3(0, 0, Random.Range(0.5f, -2.5f));

            StartCoroutine(IMove(ob, offset));
        }


    }


}
