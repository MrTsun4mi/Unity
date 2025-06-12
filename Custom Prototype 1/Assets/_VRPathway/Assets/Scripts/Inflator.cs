using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;  // add this line

public class Inflator : XRGrabInteractable
{
    // Set GameObject's Inspector Data.
    [Header("Balloon Data")]
    public Transform attachPoint;
    public Balloon balloonPrefab;

    // Set private variables.
    private Balloon m_BalloonInstance;
    private XRBaseController m_Controller; // Use this to trigger the activation value.

    // ProcessInteractible is called every frame to process all registered interactibles.
    public override void ProcessInteractable(XRInteractionUpdateOrder.UpdatePhase updatePhase)
    {
        base.ProcessInteractable(updatePhase);

        if (isSelected && m_Controller != null)
        {
            m_BalloonInstance.transform.localScale = Vector3.one * Mathf.Lerp(1.0f, 4.0f, m_Controller.activateInteractionState.value);
        }

    }

    // OnSelectEntered will initiate code based on a selection/grab interaction with the object.
    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        base.OnSelectEntered(args);
        m_BalloonInstance = Instantiate(balloonPrefab, attachPoint);
        var controllerInteractor = args.interactorObject as XRBaseControllerInteractor; // Declares new local variable that holds an IXRSelectInteractor as an XRControllerInteractor
        m_Controller = controllerInteractor.xrController;

        m_Controller.SendHapticImpulse(1, 0.5f); // For Testing Purposes
    }

    // OnSelectExited will initiate code when the user cancels interaction (stops grabbing) with the object.
    protected override void OnSelectExited(SelectExitEventArgs args)
    {
        base.OnSelectExited(args);
        Destroy(m_BalloonInstance.gameObject);
    }

    // Start is called before the first frame update.
    void Start()
    {
        
    }

    // Update is called once per frame.
    void Update()
    {
        
    }
}
