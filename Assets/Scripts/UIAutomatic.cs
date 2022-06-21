using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIAutomatic : MonoBehaviour
{
    [SerializeField] private GameObject infoPanel;
    [SerializeField] private GameObject infoButton;
    [SerializeField] private TextMeshProUGUI infoLabel = null;
    string chosenText;

    const string PORTAL1 = "Am meisten leiden Robben, Delfine, Wale, Meeresschildkr�ten und Seevogel unter Plastik in ihrem Lebensraum. " +
        "Einige verschlucken Plastikteile, weil sie diese f�r Nahrung halten oder ihre Nahrung damit versetzt ist. " +
        "Dadurch k�nnen Gifte in den K�rper gelangen und die Verdauung beeintr�chtigen, sowie innere Verletzungen entstehen. " +
        "Andere verheddern sich in Plastikgebilden, z.B. in T�ten oder Netzen, wodurch ihre Bewegung eingeschr�nkt wird " +
        "und sie angreifbar sind f�r Fressfeinde.";

    const string PORTAL2 = "Eigentlich bietet das Korallenriff vielen Fischen einen farbenfrohen Lebensraum. " +
        "Doch vielen Korallen geht es nicht gut, sie bleichen aus. " +
        "Neben der Erw�rmung des Wassers hat der Plastikm�ll in den Meeren einen gro�en Anteil daran. " +
        "Dieser bietet vielen Krankheitserregern einen Lebensraum, sie bilden einen Biofilm auf der Oberfl�che. " +
        "Plastik kann das Gewebe der Korallen besch�digen und die Erreger k�nnen sich so leichter ansiedeln.";

    const string PORTAL3 = "Obwohl Plastik billig und in gro�en Mengen herzustellen ist, ist es robust und langlebig. So langlebig, " +
        "dass es in der Umwelt mehrere hundert Jahre �berdauert. Demzufolge ist jedes jemals in der Natur gelandete " +
        "St�ck Plastik dort immer noch zu finden. Selbst die Antarktis hat es erreicht, " +
        "mit mehr als 12000 Plastikpartikel (Mikroplastik) pro Liter Meereis. Selbst in 2000 Metern Tiefe hat man " +
        "Plastik gefunden und in Tieren nachgewiesen. Nur 6% des Plastiks in den Ozeanen treibt an die Oberfl�che, " +
        "der gro�e Rest sinkt auf den Meeresgrund und verursacht Schaden an den dort lebendenden Organismen.";

    const string PORTAL4 = "Das Plastik in den Meeren hat auch Auswirkungen auf uns Menschen. Durch Reibung zerf�llt Plastik in " +
        "kleine Teilchen unter 5 Millimeter, das sogenannte Mikroplastik. Durch Nahrung, die wir essen, z.B.Fische, " +
        "die Mikroplastik gefressen haben, kommt der Kunststoff auch in unseren K�rper.Durch die enthaltenen Chemikalien, " +
        "z.B.Weichmacher, k�nnen diverse Gesundheitssch�den entstehen, von Allergien bis hin zur Unfruchtbarkeit. " +
        "Bisphenol A (BPA) beispielsweise gilt als besonders besorgniserregend, weil es sich auf das Hormonsystem auswirkt. " +
        "Noch heute ist es in Kunststoffen enthalten. Viele andere, inzwischen verbotene Zusatzstoffe, treiben totzdem immer " +
        "noch in altem Plastik in den Meeren und finden so ihren Weg in die K�rper der Menschen.";

    // Start is called before the first frame update
    public void ToggleInfoPanel()
    {
        infoPanel.transform.GetChild(0).GetComponent<TextMeshProUGUI>().SetText(chosenText);
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

    public void chooseText(int portal)
    {
        switch (portal)
        {
            case 1:
                chosenText = PORTAL1;
                break;
            case 2:
                chosenText = PORTAL2;
                break;
            case 3:
                chosenText = PORTAL3;
                break;
            case 4:
                chosenText = PORTAL4;
                break;
        }
    }
}
