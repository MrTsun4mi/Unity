using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.Serialization;

namespace FinalCode
{
    public class TouchButon : XRBaseInteractable
    {
        [Header("Visuals")]
        public Material normalMaterial;
        public Material touchedMaterial;

        [Header("Button Data")]
        public int buttonNumber;
        public NumberPad linkedNumberpad;

        private int m_NumberOfInteractor = 0;
        private Renderer m_RendererToChange;

        // Start is called before the first frame update
        private void Start()
        {
            m_RendererToChange = GetComponent<MeshRenderer>();
        }

        public override bool IsHoverableBy(IXRHoverInteractor interactor)
        {
            return base.IsHoverableBy(interactor) && (interactor is XRDirectInteractor);
        }

        protected override void OnHoverEntered(HoverEnterEventArgs args)
        {
            base.OnHoverEntered(args);
            if (m_NumberOfInteractor == 0)
            {
                m_RendererToChange.material = touchedMaterial;
                linkedNumberpad.ButtonPressed(buttonNumber);
            }

            m_NumberOfInteractor += 1;
        }

        protected override void OnHoverExited(HoverExitEventArgs args)
        {
            base.OnHoverExited(args);
            m_NumberOfInteractor -= 1;

            if (m_NumberOfInteractor == 0)
                m_RendererToChange.material = normalMaterial;
        }
    }
}