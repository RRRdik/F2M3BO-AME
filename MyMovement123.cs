using System.Collections;
using System.Collections.Generic;
using UnityEngine;

        [RequireComponent(typeof(Rigidbody))]
        public class MyMovement123 : MonoBehaviour {
     
         public Vector3 jump;
         public float jumpForce = 2.0f;
     
         public bool isGrounded;
         Rigidbody rb;
         void Start(){
             rb = GetComponent<Rigidbody>();
             jump = new Vector3(0.0f, 2.0f, 0.0f);
         }
     
         void OnCollisionStay()
         {
             isGrounded = true;
         }
     
         void Update(){
             if (Input.GetKey(KeyCode.A))
            {
                transform.position += new Vector3(-10 * Time.deltaTime, 0, 0);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.position += new Vector3(10 * Time.deltaTime, 0, 0);
            }
            if (Input.GetKey(KeyCode.W))
            {
                transform.position += new Vector3(0, 0, 10 * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.position += new Vector3(0, 0, -10 * Time.deltaTime);
            }
             if(Input.GetKeyDown(KeyCode.Space) && isGrounded){
     
                 rb.AddForce(jump * jumpForce, ForceMode.Impulse);
                 isGrounded = false;
             }
         }
     }