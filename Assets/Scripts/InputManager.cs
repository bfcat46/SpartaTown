using System.Collections;
using System.Collections.Generic;
using Vector2 = UnityEngine.Vector2;
using UnityEngine;


public class InputManager : MonoBehaviour
{
    [SerializeField] private float speed;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        Vector2 direction = new Vector2(horizontal, vertical);
        direction = direction.normalized;

        GetComponent<Rigidbody>().velocity = direction * speed;

        
    }
}
