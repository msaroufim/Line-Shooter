using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using Quaternion = UnityEngine.Quaternion;
using Vector2 = UnityEngine.Vector2;

public class Shoot : MonoBehaviour
{
    public GameObject whiteSquare;
    public GameObject whiteTriangle;
    public float positionIncrement;
    public float cooldownCounter = 1;
    private bool coolingdown = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // TODO: The cooldown only works for the very first bullet then stops working, need to debug this
        // Setup the animation properly
        // Add physics to the prefab where they can detect collisions
        Vector2 bulletPosition = new Vector2(transform.localPosition.x + positionIncrement, transform.localPosition.y);

        if(!coolingdown)
        {
            //Instantiate Game Object at current position + a bit in the x direction
            if (Input.GetMouseButtonDown(0))
                Instantiate(whiteSquare, bulletPosition, Quaternion.identity);

            if (Input.GetMouseButtonDown(1))
                Instantiate(whiteTriangle, bulletPosition, Quaternion.identity);

            coolingdown = true;
        }

        else
        {
            cooldownCounter -= Time.deltaTime;
            if(cooldownCounter <= 0)
            {
                coolingdown = false;
            }
        }

    }
}
