using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIAutomatic : MonoBehaviour
{
    [SerializeField] private GameObject infoPanel;
    [SerializeField] private GameObject infoButton;
    [SerializeField] private TextMeshProUGUI infoLabel = null;
    // Start is called before the first frame update
    public void ToggleInfoPanel()
    {
        bool isActive = infoPanel.activeSelf;
        infoPanel.SetActive(!isActive);
    }
    public void HideInfoButton()
    {
        infoButton.SetActive(false);
    }
    public void ShowInfoButton()
    {
        infoButton.SetActive(true);
    }
    public void displayInfo(string info)
    {
        infoLabel.SetText(info);
    }
}
