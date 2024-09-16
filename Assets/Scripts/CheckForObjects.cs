using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForObjects : MonoBehaviour
{
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        if (Physics.Raycast(ray,out hit,  100))
        {
            print("hit " + hit.collider.gameObject.name);
        }

        //RaycastHit hit;

        //if (Physics.Raycast(transform.position, -Vector3.up, out hit, 100f))
        //{
        //    print("We hit something at " + hit.transform.position);
        //}
        //else
        //{
        //    print("Nothing underneath us ");
        //}
    }
}
