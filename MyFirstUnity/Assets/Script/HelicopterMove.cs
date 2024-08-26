using UnityEditor.Experimental.GraphView;
using UnityEngine;

namespace Helicopter
{


    public class HelicopterMove : MonoBehaviour
    {
        [SerializeField] float RotorSpeed;



        void Update()
        {

           if (Input.GetKey(KeyCode.Space))
           {
           
               transform.Rotate(Vector3.up, RotorSpeed * Time.deltaTime);
               RotorSpeed += 80 * Time.deltaTime;
           
           }
           else if (RotorSpeed > 2000.0f)
           {
               RotorSpeed = 2000.0f;
           }
           else if (RotorSpeed < 0.0f)
            {
                RotorSpeed = 0.0f;
            }
            else if (Input.GetKeyUp(KeyCode.Space) == false)
            {
                transform.Rotate(Vector3.up, RotorSpeed * Time.deltaTime);
                RotorSpeed += -50 * Time.deltaTime;
            }

        }
    }
}

