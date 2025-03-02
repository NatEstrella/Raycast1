using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]

public class NewBehaviourScript : MonoBehaviour
{
    private LineRenderer line;
    // Start is called before the first frame update
    void Start()
    {
        line = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        Vector3 origin = transform.position + transform.forward;
        Vector3 direction = transform.forward;

        Vector3 point1 = transform.position + transform.forward;
        Vector3 point2 = transform.position + (transform.forward * 3);

        Vector3[] positions = new Vector3[2];

        positions[0] = point1;
        positions[1] = point2;

        
        //pipipi no se usar github ;;
        

        if(Physics.Raycast(origin, direction, out hit, 20f)){
            
            positions[1] = hit.point;
            
            Debug.DrawRay(origin, direction * hit.distance, Color.blue);

            line.startColor = Color.blue;
            line.endColor = Color.green;
        } else{

            positions[1] = origin + direction * 10f;

            Debug.DrawRay(origin, direction * 10f, Color.magenta);

            line.startColor = Color.magenta;
            line.endColor = Color.red;
        }

        line.SetPositions(positions);
    }
}
