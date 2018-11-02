using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evidence : MonoBehaviour {


    public bool examined;

	public void BeExamined(Transform newParent)
    {
        examined = true;
        StartCoroutine(HandleEvidence(newParent));
    }

    IEnumerator HandleEvidence(Transform newParent)
    {
        yield return new WaitForSeconds(1.5f);
        transform.parent = newParent;
        transform.localPosition = Vector3.zero;

        yield return new WaitForSeconds(3.0f);
        Destroy(gameObject);

    }
}
