using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] Transform sphere;
    [SerializeField] LayerMask layerMask;

    void Update()
    {
        Vector3 mouPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Debug.DrawLine(Camera.main.transform.position, mouPosition);

        if (Input.GetMouseButtonDown(0)){
            Debug.Log(Input.mousePosition);
            Ray tiaBan = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(tiaBan, out RaycastHit hitInfo, 100, layerMask))
            {
                sphere.position = hitInfo.point;
            }

        }
    }
}
