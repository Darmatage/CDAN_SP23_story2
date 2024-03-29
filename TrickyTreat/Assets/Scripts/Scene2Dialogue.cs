using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene2Dialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
       //public Text Char3name;
       //public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1a;
       public GameObject ArtChar1b;
       //public GameObject ArtChar2;
        public GameObject ArtBG1;
		//public GameObject ArtBG2;
		public GameObject FrameSuper;
		public GameObject FrameGhost;
		public GameObject FrameWolf;
		public GameObject Frame2Super;
		public GameObject Frame2Ghost;
		public GameObject Frame2Wolf;
		
        public GameObject Choice1a;
        public GameObject Choice1b;
		//public GameObject Choice2a;
       // public GameObject Choice2b;
		//public GameObject Choice2c;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
		public GameObject NextScene3Button;
		public GameObject NextScene4Button;
        public GameObject nextButton;
       //public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;

// initial visibility settings. Any new images or buttons need to also be SetActive(false);
void Start(){  
        DialogueDisplay.SetActive(false);
        ArtChar1a.SetActive(false);
		ArtChar1b.SetActive(false);
		
        ArtBG1.SetActive(true);
		//ArtBG2.SetActive(false);
		FrameSuper.SetActive(false);
		FrameGhost.SetActive(false);
		FrameWolf.SetActive(false);
		Frame2Super.SetActive(false);
		Frame2Ghost.SetActive(false);
		Frame2Wolf.SetActive(false);
		
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
		//Choice2a.SetActive(false);
        //Choice2b.SetActive(false);
		//Choice2c.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
		NextScene3Button.SetActive(false);
		NextScene4Button.SetActive(false);
        nextButton.SetActive(true);

    if (GameHandler.isSuper == true){
		FrameSuper.SetActive(true);
		Frame2Super.SetActive(true);
	}
	if (GameHandler.isGhost == true){
		FrameGhost.SetActive(true);
		Frame2Ghost.SetActive(true);
	}
	if (GameHandler.isWolf == true){
		FrameWolf.SetActive(true);
		Frame2Wolf.SetActive(true);
	}
	
	if (GameHandler.siblingGone){
			primeInt = 49;
	}
	
   }

void Update(){         // use spacebar as Next button
		
		if (allowSpace == true){
                if (Input.GetKeyDown("space")){
                       next();
                }		
        }
   }

//Story Units! This is the main story function. Players hit [NEXT] to progress to the next primeInt:
public void next(){
        primeInt = primeInt + 1;
        if (primeInt == 1){
                // AudioSource.Play();
        }
        else if (primeInt == 2){
                DialogueDisplay.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "Where are we? I thought you said we were going trick or treating?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==3){
		    ArtChar1a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "SIBLING";
                Char2speech.text = "Change of plans pip squeak.";
        }
       else if (primeInt == 4){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "SIBLING";
                Char2speech.text = "You’re old enough to trick or treat on your own.";
        }
       else if (primeInt == 5){
		   ArtChar1a.SetActive(false);
		   ArtChar1b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "SIBLING";
                Char2speech.text = "I'm heading to a party. Don’t get into any trouble, and don't tell mom.";
        }
		
		else if (primeInt == 6){
                Char1name.text = "YOU";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }
		
		//response to choice 1a
		else if (primeInt==20){
			 Char1name.text = "";
             Char1speech.text = "";
             Char2name.text = "SIBLING";
             Char2speech.text = "That's the spirit. I'll pick you up after the party.";
			primeInt = 39;
		}
		
		//response to choice 1b
		else if (primeInt==30){
			ArtChar1a.SetActive(true);
		   ArtChar1b.SetActive(false);
			 Char1name.text = "";
             Char1speech.text = "";
             Char2name.text = "SIBLING";
             Char2speech.text = "If you tell mom I’ll pummel you so hard you’ll never see another halloween again!";
		}
		else if (primeInt==31){
			ArtChar1a.SetActive(true);
		   ArtChar1b.SetActive(false);
			 Char1name.text = "";
             Char1speech.text = "";
             Char2name.text = "SIBLING";
             Char2speech.text = "Man the parties gonna start soon, I'm going to be late.";
			primeInt = 39;
		}
		
		
	// after choice 1 is complete

	else if (primeInt==40){
		ArtChar1a.SetActive(true);
		ArtChar1b.SetActive(false);
			 Char1name.text = "";
             Char1speech.text = "";
             Char2name.text = "SIBLING";
             Char2speech.text = "See ya squirt";
			 
		GameHandler.siblingGone = true;
	}
	
       else if (primeInt == 41){
				ArtChar1a.SetActive(false);
				ArtChar1b.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				// Turn off "Next" button, turn on "Choice" buttons
                DialogueDisplay.SetActive(false);
                nextButton.SetActive(false);
                allowSpace = false;
				
				if (GameHandler.sawNPCHouse == false){NextScene1Button.SetActive(true);}
				if (GameHandler.sawGhostHouse == false){NextScene2Button.SetActive(true);}
				if (GameHandler.sawPartyHouse == false){NextScene3Button.SetActive(true);}
				
				if ((GameHandler.sawNPCHouse)&&(GameHandler.sawGhostHouse)&&(GameHandler.sawPartyHouse)){
					Char1name.text = "YOU";
					Char1speech.text = "Oh, I've been to all three houses...";					

					DialogueDisplay.SetActive(true);
					nextButton.SetActive(true);
					allowSpace = true;
					primeInt=59;
				}
				
        }
		
		
		else if (primeInt==50){
			DialogueDisplay.SetActive(true);
			//ArtChar1a.SetActive(false);
			 Char1name.text = "YOU";
             Char1speech.text = "OK. Back on the street.";
             Char2name.text = "";
             Char2speech.text = "";
		}
		else if (primeInt==51){
			 Char1name.text = "YOU";
             Char1speech.text = "Where next?";
             Char2name.text = "";
             Char2speech.text = "";
			 primeInt = 40;
		}		
		
		
		else if (primeInt==60){
			ArtChar1a.SetActive(false);
			 Char1name.text = "YOU";
             Char1speech.text = "Huh. Was that path always there?";
             Char2name.text = "";
             Char2speech.text = "";
		}
		else if (primeInt==61){
			 Char1name.text = "YOU";
             Char1speech.text = "Is that... another house?";
             Char2name.text = "";
             Char2speech.text = "";
		}	
		else if (primeInt==62){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				// Turn off "Next" button, turn on "Choice" buttons
                DialogueDisplay.SetActive(false);
                nextButton.SetActive(false);
                allowSpace = false;
				NextScene4Button.SetActive(true);
		}
		
	
	// never delete the bracket below here. it en ds the next() function!:
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch-scenes)
        public void Choice1aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Yeah I am old enough!";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 19;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "No fair! I'm telling mom!";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 29;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		

        public void SceneChange1(){
               SceneManager.LoadScene("Scene3a");
        }
       public void SceneChange2(){
                SceneManager.LoadScene("Scene3b");
        }
		public void SceneChange3(){
                SceneManager.LoadScene("Scene3c");
        }
		public void SceneChange4(){
                SceneManager.LoadScene("Scene6");
        }
}