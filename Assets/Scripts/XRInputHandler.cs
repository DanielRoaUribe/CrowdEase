using UnityEngine;
using UnityEngine.XR;

public class XRInputHandler : MonoBehaviour
{
    public DensityAndAudioManager crowdManager;

    InputDevice rightHand;

    void Start()
    {
        rightHand = InputDevices.GetDeviceAtXRNode(XRNode.RightHand);
    }

    void Update()
    {
        if (!rightHand.isValid)
            rightHand = InputDevices.GetDeviceAtXRNode(XRNode.RightHand);

        bool bPressed = false;
        bool aPressed = false;

        rightHand.TryGetFeatureValue(CommonUsages.secondaryButton, out bPressed);
        rightHand.TryGetFeatureValue(CommonUsages.primaryButton, out aPressed);

        if (bPressed)
            crowdManager.StartScenario();

        if (aPressed)
            crowdManager.ResetScenario();
    }
}
