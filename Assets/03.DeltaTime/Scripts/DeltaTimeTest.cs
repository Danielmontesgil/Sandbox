using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sandbox
{
    public class DeltaTimeTest : MonoBehaviour
    {
        [SerializeField] private float speed;

        [SerializeField] private Transform squareDeltaTime;
        [SerializeField] private Transform squareNoDeltaTime;
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            // Debug.Log($"{Time.deltaTime} seg {1.0 / Time.deltaTime} fps");
            
        }

        private void FixedUpdate()
        {
            Debug.Log($"{Time.deltaTime} seg {1.0 / Time.deltaTime} fps");
            squareDeltaTime.Translate(Vector3.right * (speed * Time.deltaTime));
            squareNoDeltaTime.Translate(Vector3.right * speed);
        }
    }
}
