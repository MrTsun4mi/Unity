using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.Events;
using UnityEngine.UI;

namespace FinalCode
{
    public class NumberPad : MonoBehaviour
    {
        public string sequence;
        public KeycardSpawner cardSpawner;
        public TextMeshProUGUI inputDisplayText;

        private string m_CurrentEnteredCode = "";

        private void Awake()
        {
            inputDisplayText.text = "";
        }

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