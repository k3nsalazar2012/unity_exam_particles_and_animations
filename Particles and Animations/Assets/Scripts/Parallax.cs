using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ParticlesAndAnimations
{
    public class Parallax : MonoBehaviour
    {
        [SerializeField]
        private float speed;

        [SerializeField]
        private Transform[] childImages;

        private void Update()
        {
            foreach(Transform t in childImages)
            {
                if (t.localPosition.y > 3.34f)
                    t.localPosition = Vector3.up * -3.34f;

                t.Translate(Vector3.up * speed * Time.deltaTime);               
            }
        }
    }
}