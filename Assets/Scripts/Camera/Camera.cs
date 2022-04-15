using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace spat
{
    public class Camera : MonoBehaviour
    {
        private float horizontalInput;
        private float verticalInput;
        private float mouseScrollWheelInput;
        private Transform transformComponent;

        // Start is called before the first frame update
        void Start()
        {
            transformComponent = GetComponent<Transform>();
        }

        // Update is called once per frame
        void Update()
        {
            horizontalInput = Input.GetAxis("Horizontal");
            verticalInput = Input.GetAxis("Vertical");
            mouseScrollWheelInput = Input.GetAxis("Mouse ScrollWheel");
            transformComponent.position += new Vector3(horizontalInput, mouseScrollWheelInput * -10, verticalInput);
        }
    }
}
