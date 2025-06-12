using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FinalCode
{
    public class DoorHandle : MonoBehaviour
    {
        [Header("Door Handle Data")]
        public Transform draggeddTransform;
        public Vector3 localDragDirection;
        public float dragDistance;
        public int doorWeight = 20;

        [Header("Visual References")]
        public LineRenderer handleToHandLine;
        public LineRenderer dragVectorLine;

        private Vector3 m_StartPosition;
        private Vector3 m_EndPosition;
        private Vector3 m_WorldDragDirection;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
