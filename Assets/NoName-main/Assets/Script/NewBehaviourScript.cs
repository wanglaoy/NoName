using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    float speed = 3;
    public float xget;
    public float yget;
    Vector2 _speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        turnAround();
    }

    void turnAround()
    {
        xget = Input.GetAxis("Horizontal");
        yget = Input.GetAxis("Vertical");
        _speed.x = xget * speed;
        _speed.y = yget * speed;
        transform.Rotate(0, _speed.x, _speed.y);
    }
}
