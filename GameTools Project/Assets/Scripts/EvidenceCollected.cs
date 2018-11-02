using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class EvidenceCollected : MonoBehaviour {

    public Text evidenceText;
    public Text endText;
    public int evidenceCollected = 0;
    private bool addOne;
    private bool finnished;

    void Start ()
    {

    }
	
	void Update ()
    {
        if (finnished)
        {
            return;
        }
        if (addOne)
        {
            evidenceCollected++;
            addOne = false;
        }
        evidenceText.text = "Evidence: " + evidenceCollected;
        endText.text = "";
    }

    public void EvidenceCount()
    {
        addOne = true;
    }

    public void Finnish()
    {
        finnished = true;
        evidenceText.color = Color.yellow;
        endText.color = Color.yellow;

        if (evidenceCollected == 0)
        {
            endText.text = "No evidence found, they walk free.";
        }
        else if(evidenceCollected == 1 || evidenceCollected == 2)
        {
            endText.text = "Not enough evidenve to convict, they walk free.";
        }
        else if(evidenceCollected == 3 || evidenceCollected == 4)
        {
            endText.text = "Congradulations, you got'em. I only wish we had more to charge her with.";
        }
        else if(evidenceCollected == 5)
        {
            endText.text = "Wow, they'll be going away for life now. Good job!";
        }

    }
}
