using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBol : MonoBehaviour
{
    public float spid = 10f;
    public int damage = 1;

    private void Update()
    {
        transform.Translate(0,0,spid * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);

        PlayerCharacter player = other.GetComponent<PlayerCharacter>();
        if (player != null)
        {
            player.Hurt(damage);
        }
        Destroy(this.gameObject);
    }
}
