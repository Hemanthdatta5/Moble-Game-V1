using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textPrompt : MonoBehaviour
{
	public GameObject TextGO;
	string[] jeffery = {"Hemanth gazes deep into your eyes, you feel the romance coming on.", 
	"You: Hemanth, can I fuck your giant milk-infused cock?",
	"Hemanth: Only if you'll be my Milky Caramel™."};
	int dialogProgress;
	TMPro.TextMeshProUGUI stringObject;
    // Start is called before the first frame update
    void Start()
    {
		dialogProgress = 1;
		stringObject = TextGO.GetComponent<TMPro.TextMeshProUGUI>();
		stringObject.text = jeffery[0];
    }
	
    // Update is called once per frame
		void Update()
		{
			if (Input.GetMouseButtonDown(0))
			{
				Debug.Log("Pressed primary button.");
				stringObject.text = jeffery[dialogProgress];
				if (dialogProgress + 1 < jeffery.Length)
					dialogProgress++;
			}
		}

}
