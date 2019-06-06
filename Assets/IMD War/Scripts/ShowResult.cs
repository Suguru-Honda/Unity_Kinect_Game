using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowResult : MonoBehaviour
{
    public Text FinalScore;
    public Text FinalStatus;
    public int minCredit;
    public int minResearchPoint;
    public int minResearchPointForPhD;

    void Start()
    {
        transform.GetChild(0).gameObject.SetActive(false);
        transform.GetChild(1).gameObject.SetActive(false);
    }

    public void showResult()
    {
        transform.GetChild(0).gameObject.SetActive(true);
        transform.GetChild(1).gameObject.SetActive(true);

        string credit = GameObject.Find("Credit").GetComponent<Text>().text;
        string researchPoint = GameObject.Find("ResearchPoint").GetComponent<Text>().text;

        int creditNum = int.Parse(credit);
        int rPointNum = int.Parse(researchPoint);

        Debug.Log("credit:" + creditNum + ", researchP:" + rPointNum + ", minCresit: " + minCredit + ", minRPoint" + minResearchPoint);

        string status = "";
        if (creditNum >= minCredit && rPointNum >= minResearchPointForPhD)
        {
            status = "Next is PhD.!!!";
        }
        else if (creditNum >= minCredit && rPointNum >= minResearchPoint)
        {
            status = "Graduated!!";
        }
        else
        {
            status = "one more year...";
        }

        FinalScore.text = "Credit : " + credit + "      Research Point : " + researchPoint;
        FinalStatus.text = status;


    }
}
