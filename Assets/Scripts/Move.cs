using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;
        transform.position = new Vector2(position.x + 0.01f, position.y);
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //decrease enemy hp
        //
        GameObject.Destroy(this);
    }
}
