
using UnityEngine;
using UnityEngine.Events;
using VRTK;


public class MenuToggle : MonoBehaviour
{
    public VRTK_ControllerEvents controllerEvents;
    public GameObject menu;
    public UnityEvent eventOnSelect;
    bool menuState = false;


    private void OnEnable()
    {
        controllerEvents.ButtonTwoReleased += ControllerEvents_ButtonTwoReleased;
        controllerEvents.ButtonOneReleased += ControllerEvents_ButtonOneReleased;
    }

    private void ControllerEvents_ButtonOneReleased(object sender, ControllerInteractionEventArgs e)
    {
        if (eventOnSelect != null)
        {
            eventOnSelect.Invoke();
        }
    }

    private void OnDisable()
    {
        controllerEvents.ButtonTwoReleased -= ControllerEvents_ButtonTwoReleased;
        controllerEvents.ButtonOneReleased -= ControllerEvents_ButtonOneReleased;
    }

    private void ControllerEvents_ButtonTwoReleased(object sender, ControllerInteractionEventArgs e)
    {
        menuState = !menuState;
        menu.SetActive(menuState);
    }
}
