using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] GameObject circle;
    [SerializeField] LayerMask layerMask;
    bool isPlayed = true;
    Vector2 worldPosition;
    void Start()
    {
      


      
    }

    // Update is called once per frame
    void Update()
    {
        worldPosition = Camera.main.ScreenToWorldPoint(transform.position);
        if (Physics2D.OverlapPoint(circle.transform.position, layerMask))
        {
            Debug.Log("created");
        }
        else
        {
            Debug.Log("No");
        }
    }
    private void creator()
    {
        Instantiate(circle, new Vector3(-2, 0, 0), Quaternion.identity);
        Instantiate(circle, new Vector3(2, 0, 0), Quaternion.identity);

    }

}
