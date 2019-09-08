using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized * moveSpeed * Time.deltaTime);
        RaycastHit hit;
        Debug.DrawRay(transform.position, -transform.up*100, Color.red, 0.1f);
        if (Physics.Raycast(transform.position, -transform.up, out hit, 100f))
        {
           transform.rotation = Quaternion.FromToRotation(transform.up, hit.normal) * transform.rotation;
        }
    }
}
