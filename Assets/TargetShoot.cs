using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetShoot : MonoBehaviour
{
    // Start is called before the first frame update
    [Range(1,10)] public int force;
    void Start()
    {
        string test = "0";
        string[] testt = test.Split('/');
        print(testt[0].ToString());
        print(123); 
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("hit G.O" + hit.collider.name);
                if (hit.rigidbody != null)
                {
                    hit.rigidbody.AddForceAtPosition(ray.direction * 1000*force, hit.point);
                }
            }
        }
    }
}
