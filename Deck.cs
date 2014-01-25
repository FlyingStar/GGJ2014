using UnityEngine;
using System.Collections;

public class Deck : MonoBehaviour {
	const int HandSize = 5;
	const int HandSelection = 3;
	const int DeckSize = 21;

	//Gui definitions
	public Texture btnTexture = null;
	public Texture cardBackTexture = null;
	public Texture deckTexture = null;
	public Texture[] cardsTexture = new Texture[(int)Card.Id.Max];
	public bool isLeftPlayer = true;
	public int leftOffset = 20;
	public int topOffset = 0;
	public int offsetBetweenCards = 20;
	int leftFirstCard = 0;
	int topFirstCard = 0;

	// Use this for initialization
	void Start () {
		initializeGui();
	}

	// Update is called once per frame
	void Update () {
	
	}


	void initializeGui()
	{
		if(isLeftPlayer)
		{
			leftFirstCard = leftOffset;
		}
		else
		{
			leftFirstCard = Screen.width - Card.width - leftOffset;
		}

		topFirstCard = Screen.height/2 - ((HandSize + 1) * Card.height + HandSize * topOffset)/2;
	}

	void OnGUI() {
		if (!btnTexture) {
			Debug.LogError("Please assign a texture on the inspector");
			return;
		}


		int topPosition = topFirstCard;

		for(int i = 0; i < HandSize; ++i)
		{
			if (GUI.Button(new Rect(leftFirstCard, topPosition, Card.width, Card.height), btnTexture, new GUIStyle()))
				Debug.Log("Clicked the button with an image");
			topPosition += Card.height + offsetBetweenCards;
		}

		if (GUI.Button(new Rect(leftFirstCard, topPosition, Card.width, Card.height), deckTexture, new GUIStyle()))
			Debug.Log("Clicked the button with an image");
	}
}
