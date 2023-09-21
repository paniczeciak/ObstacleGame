using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightLeftObstacleMoves : MonoBehaviour
{
   
    [SerializeField] private float moveSpeed = 1f;
    private bool movingRight = true;
    

    // Start is called before the first frame update
    void Start()
    {
            transform.position = new Vector3(-5.0f,0.2f,-5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (movingRight)
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        }

        // Jeśli obiekt wychodzi poza pewny zakres, zmień kierunek poruszania
        if (transform.position.z > -3.3f)
        {
            movingRight = false;
        }
        else if (transform.position.z < -5.0f)
        {
            movingRight = true;
        }

    }
}
