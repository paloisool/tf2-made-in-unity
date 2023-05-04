using UnityEngine;
using UnityEngine.UI;

public class ShowHideButton : MonoBehaviour
{
    public GameObject objectToShowHide;

    private Button showHideButton;

    private void Start()
    {
        showHideButton = GetComponent<Button>();
        showHideButton.onClick.AddListener(ShowHideObject);
    }

    private void ShowHideObject()
    {
        objectToShowHide.SetActive(!objectToShowHide.activeSelf);
    }
}
