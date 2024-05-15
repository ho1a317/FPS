using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactiveTarget : MonoBehaviour
{
    private EnemiAI enemiAI;

    private void Start()
    {
        enemiAI = GetComponent<EnemiAI>();
    }

    public void ReactToHit()
    {
        if(enemiAI != null)
        {
            enemiAI.SetAlive(false);
        }

        StartCoroutine(DieCoroutine(3));
    }

    private IEnumerator DieCoroutine(float waitSekont)
    {
        this.transform.Rotate(45,0,0);

        yield return new WaitForSeconds(waitSekont);

        Destroy(this.transform.gameObject);
    }
}
