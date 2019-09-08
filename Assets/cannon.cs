using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannon : MonoBehaviour
{
    public GameObject Spawner;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.DrawRay(transform.position, transform.forward * 100, Color.red);
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, 60))
            {
                if (hit.transform.tag == "indestructible")
                {
                    Debug.Log("Indestructible");
                }
                else
                {
                    Debug.Log(hit.transform.name);
                    Destroy(hit.transform.gameObject);
                }
            }
        }
        if (GameObject.FindGameObjectsWithTag("enemy").Length == 0)
        {
            Debug.Log("all dead");
            Spawner.SetActive(true);
        }

    }
}
