using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ParticlesAndAnimations
{
    public class Tap : MonoBehaviour
    {
        [SerializeField]
        private GameObject particle;

        [SerializeField]
        private new Camera camera;

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                var mousePos = Input.mousePosition;
                mousePos.z = 10;

                var position = camera.ScreenToWorldPoint(mousePos);
                position.z = 0f;
                GameObject tapEffect = Instantiate(particle);
               
                tapEffect.transform.position = position;
            }
        }
    }
}