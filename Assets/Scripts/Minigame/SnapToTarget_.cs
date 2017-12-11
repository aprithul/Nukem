using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyUtils
{
    public class SnapToTarget_ : MonoBehaviour
    {

        public bool is_snapped;
        public string snap_object_name;
        private Transform snap_object;

        // Use this for initialization
        void Start()
        {
        }


        private void Update()
        {

        }

        // Update is called once per frame
        void LateUpdate()
        {
            if (snap_object)
            {
                snap_object.position = transform.position;
                is_snapped = true;
            }
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.name == snap_object_name)
            {
                snap_object = collision.transform;
            }
        }
    }
}
