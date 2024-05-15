using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiAI : MonoBehaviour
{
    public float spid = 5.0f;
    public float obstacRande = 5.0f;
    public bool alive = true;

    [SerializeField]
    private GameObject[] fireballsPrefab;
    private GameObject firiball;

    private void Start()
    {
        alive = true;
    }

    private void Update()
    {
        if (alive)
        {
            transform.Translate(0, 0, spid * Time.deltaTime);

            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                GameObject hitObject = hit.transform.gameObject;

                if (hitObject.GetComponent<CharacterController>())
                {
                    if (firiball == null)
                    {
                        int randomFriball = Random.Range(1, fireballsPrefab.Length);
                        firiball = Instantiate(fireballsPrefab[randomFriball]) as GameObject;
                        firiball.transform.position = transform.TransformPoint(Vector3.forward * 1.5f);
                        firiball.transform.rotation = transform.rotation;
                    }


                }
                else
                {
                    if (hit.distance < obstacRande)
                    {
                        float angleRotation = Random.Range(-100, 100);
                        transform.Rotate(0, angleRotation, 0);
                    }
                }
            }
        }
    }

    public void SetAlive(bool isAlive)
    {
        alive = isAlive;
    }

}
