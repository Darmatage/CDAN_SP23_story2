using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene4bDialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
		 public Text Char3name;
        public Text Char3speech;
       //public Text Char3name;
       //public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1a;
       public GameObject ArtChar1b;
       public GameObject ArtChar1c;
	    public GameObject ArtChar1d;
		public GameObject ArtChar1e;
		public GameObject ArtChar2a;
		public GameObject ArtChar2b;
		public GameObject ArtChar2c;
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
		public GameObject Choice2a;
       public GameObject Choice2b;
		public GameObject Choice3a;
		public GameObject Choice3b;
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
		ArtChar1c.SetActive(false);
		ArtChar1d.SetActive(false);
		ArtChar1e.SetActive(false);
		
		ArtChar2a.SetActive(false);
		ArtChar2b.SetActive(false);
		ArtChar2c.SetActive(false);
		
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
		Choice2a.SetActive(false);
        Choice2b.SetActive(false);
		Choice3a.SetActive(false);
        Choice3b.SetActive(false);
		
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
				ArtChar1a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "PARTY GUY";
                Char2speech.text = "Hey guys we got another party animal up in here!";
								Char3name.text = "";
                Char3speech.text = "";
		}
       else if (primeInt == 3){
                Char1name.text = "YOU";
                Char1speech.text = "Hey everyone.";
                Char2name.text = "";
                Char2speech.text = "";
								Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 4){
				ArtChar1d.SetActive(true);
				ArtChar1a.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "PARTY GUY";
                Char2speech.text = "YEAH LETS PARTY!";
								Char3name.text = "";
                Char3speech.text = "";
		}
		else if (primeInt == 5){
                Char1name.text = "YOU";
                Char1speech.text = "Hey, I also wanted to ask. Have you seen my sibling here?";
                Char2name.text = "";
                Char2speech.text = "";
								Char3name.text = "";
                Char3speech.text = "";
		}
				else if (primeInt == 6){
                Char1name.text = "YOU";
                Char1speech.text = "They said they would go to a party, but I don't know which?";
                Char2name.text = "";
                Char2speech.text = "";
								Char3name.text = "";
                Char3speech.text = "";
		}
				else if (primeInt == 7){
				ArtChar1d.SetActive(false);
				ArtChar1a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "PARTY GUY";
                Char2speech.text = " I don't know party kid, what do they look like?";
								Char3name.text = "";
                Char3speech.text = "";
		}
		
		else if (primeInt == 8){
				ArtChar1a.SetActive(true);
				ArtChar1d.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
								Char3name.text = "";
                Char3speech.text = "";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }
		
		
		
		
	
		
		
		
		//response to choice 1a
		else if (primeInt==20){
				ArtChar1a.SetActive(false);
				ArtChar1e.SetActive(true);
			 Char1name.text = "";
             Char1speech.text = "";
             Char2name.text = "PARTY GUY";
             Char2speech.text = "Sorry little dude, haven't seen anyone like that around";
			 				Char3name.text = "";
                Char3speech.text = "";
			primeInt = 39;
		}
		
		//response to choice 1b
		else if (primeInt==30){
				ArtChar1a.SetActive(false);
				ArtChar1e.SetActive(true);
			 Char1name.text = "";
             Char1speech.text = "";
             Char2name.text = "PARTY GUY";
             Char2speech.text = "Wow, very descriptive, thanks.";
			 				Char3name.text = "";
                Char3speech.text = "";
			primeInt = 39;
		}
		
		//Response to choice 2a
			else if (primeInt==300){
			 Char1name.text = "";
             Char1speech.text = "";
             Char2name.text = "PARTY GUY";
             Char2speech.text = "You know it's just a dance off right, there's no dueling.";
			Char3name.text = "";
            Char3speech.text = "";
		}
		else if (primeInt==301){
			 Char1name.text = "YOU";
             Char1speech.text = "He still said to the death!";
             Char2name.text = "";
             Char2speech.text = "";
			Char3name.text = "";
            Char3speech.text = "";
		}
				else if (primeInt==302){
			 Char1name.text = "YOU";
             Char1speech.text = "That's it, I'm out of here!";
             Char2name.text = "";
             Char2speech.text = "";
			Char3name.text = "";
            Char3speech.text = "";
		}
				else if (primeInt==303){
				ArtChar1e.SetActive(false);
				ArtChar1b.SetActive(true);
			 Char1name.text = "";
             Char1speech.text = "";
             Char2name.text = "PARTY GUY";
             Char2speech.text = "Look what you did, Dance Machine! You got rid of our party animal!!";
			Char3name.text = "";
            Char3speech.text = "";
		}
				else if (primeInt==304){
			ArtChar2a.SetActive(false);
				ArtChar2b.SetActive(true);
			 Char1name.text = "";
             Char1speech.text = "";
             Char2name.text = "";
             Char2speech.text = "";
			Char3name.text = "DANCE MACHINE";
            Char3speech.text = "THAT'S WHAT I WANTED MUHA HA HA!!!";
		}
		else if (primeInt==305){
		          Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
				Char2speech.text = "";
				ArtChar1b.SetActive(false);
				ArtChar1a.SetActive(false);
				ArtChar1c.SetActive(false);
				ArtChar1d.SetActive(false);
				ArtChar1e.SetActive(false);		
				ArtChar2b.SetActive(false);				
                DialogueDisplay.SetActive(false);
                nextButton.SetActive(false);
                allowSpace = false;
				NextScene2Button.SetActive(true);
				NextScene3Button.SetActive(true);
				}
			
			//Response to choice 2b
			else if (primeInt==400){
				ArtChar1e.SetActive(false);
				ArtChar1d.SetActive(true);
			 Char1name.text = "";
             Char1speech.text = "";
             Char2name.text = "PARTY GUY";
             Char2speech.text = "I like your confidence kid!";
			 Char3name.text = "";
             Char3speech.text = "";
		}
			else if (primeInt==401){
				ArtChar2a.SetActive(false);
				ArtChar2b.SetActive(true);
			 Char1name.text = "";
             Char1speech.text = "";
             Char2name.text = "";
             Char2speech.text = "";
			 Char3name.text = "DANCE MACHINE";
             Char3speech.text = "LET’S DO-DO-DO-DO-DO THIS!!!";
		}
			else if (primeInt == 402){
	             Char1name.text = "YOU";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice3a.SetActive(true); // function Choice2aFunct()
                Choice3b.SetActive(true); // function Choice2bFunct()
        }
		
		
	// after choice 1 is complete	
       else if (primeInt == 40){
		   		ArtChar2a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "DANCE MACHINE";
                Char3speech.text = "HEY HEY HEY DANCE MACHINE HAS ENTERED LA PARTY!";
	   }
	          else if (primeInt == 41){
				ArtChar1a.SetActive(true);
				ArtChar1e.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "PARTY GUY";
                Char2speech.text = "Oh yeah kid, you'll love this guy! Hey Dance machine, meet our new party animal!";
				Char3name.text = "";
                Char3speech.text = "";
	   }
	   	      else if (primeInt == 42){
				ArtChar2c.SetActive(true);
				ArtChar2a.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "DANCE MACHINE";
                Char3speech.text = "WHOA WHOA WHOA I THOUGHT I WAS THE ONLY PARTY ANIMAL!";
	   }
	   	   	      else if (primeInt == 43){
				ArtChar1e.SetActive(true);
				ArtChar1a.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "PARTY GUY";
                Char2speech.text = "Hey now, we can have more than one party animal.";
				Char3name.text = "";
                Char3speech.text = "";
	   }
	   	   	   	  else if (primeInt == 44){
				ArtChar1e.SetActive(false);
				ArtChar1a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "PARTY GUY";
                Char2speech.text = "Besides, it's more fun that way.";
				Char3name.text = "";
                Char3speech.text = "";
	   }
	   	   	   	      else if (primeInt == 45){
				ArtChar2a.SetActive(true);
				ArtChar2c.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "DANCE MACHINE";
                Char3speech.text = "NO WAY! WE MUST DUEL TO THE DEATH! I DECLARE A DANCE OFFFF!!!!!!";
	   }
	   	   	   	   	      else if (primeInt == 46){
				ArtChar1e.SetActive(true);
				ArtChar1a.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "PARTY GUY";
                Char2speech.text = "Whoa, a dance off! That's pretty intence kid. Are you sure you want to do it?";
				Char3name.text = "";
                Char3speech.text = "";
	   }
			    else if (primeInt == 47){
	             Char1name.text = "YOU";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice2a.SetActive(true); // function Choice2aFunct()
                Choice2b.SetActive(true); // function Choice2bFunct()
        }
		
	//after choice 2 is complete	
// button to go back to street	
						
						
			// if (GameHandler.isSuper == true){
			// Char2speech.text = "Ok, Superface. Try not get to get kidnapped.";
			// }
			// if (GameHandler.isGhost == true){
			// Char2speech.text = "Alright, sheets-a-lot. See you when I see you.";
			// }
			// if (GameHandler.isWolf == true){
			// Char2speech.text = "Alright, fuzzy. Don't forget-- I get half your candy.";
			// }
		// }
		 
       // else if (primeInt ==51){
		   // ArtChar1b.SetActive(false);
                // Char1name.text = "YOU";
                // Char1speech.text = "Huh. Which house should I try first?";
                // Char2name.text = "";
                // Char2speech.text = "";
		 
				// Turn off "Next" button, turn on "Choice" buttons
                // nextButton.SetActive(false);
                // allowSpace = false;
                // NextScene1Button.SetActive(true);
				// NextScene2Button.SetActive(true);
				// NextScene3Button.SetActive(true);
        // }

// ENCOUNTER AFTER CHOICE #2




		// choice 3a response
       else if (primeInt == 1100){
		   		ArtChar1d.SetActive(false);
				ArtChar1e.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "PARTY GUY";
				Char2speech.text = "Well that's weird, why are you moving like that?";
				Char3name.text = "";
                Char3speech.text = "";
	   }
	     else if (primeInt == 1101){
		   		ArtChar2b.SetActive(false);
				ArtChar2a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
				Char2speech.text = "";
				Char3name.text = "DANCE MACHINE";
                Char3speech.text = "HEY! ONLY A HUMAN CAN HAVE THOSE SWAGGER MOVES!!";
	   }
	   	     else if (primeInt == 1102){
		   		ArtChar2b.SetActive(true);
				ArtChar2a.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
				Char2speech.text = "";
				Char3name.text = "DANCE MACHINE";
                Char3speech.text = "GET THEM!!";
	   }
	     else if (primeInt == 1103){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
				Char2speech.text = "";
				ArtChar1b.SetActive(false);
				ArtChar1a.SetActive(false);
				ArtChar1c.SetActive(false);
				ArtChar1d.SetActive(false);
				ArtChar1e.SetActive(false);
				ArtChar2b.SetActive(false);	
                DialogueDisplay.SetActive(false);
                nextButton.SetActive(false);
                allowSpace = false;
				NextScene1Button.SetActive(true);
	   }


// after 3b
		       else if (primeInt == 1200){
				ArtChar1e.SetActive(false);
				ArtChar1d.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "PARTY GUY";
				Char2speech.text = "You're moving like a true party animal!!";
				Char3name.text = "";
                Char3speech.text = "";
	   }
	   		       else if (primeInt == 1201){
				ArtChar2b.SetActive(false);
				ArtChar2c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
				Char2speech.text = "";
				Char3name.text = "DANCE MACHINE";
                Char3speech.text = "NOOO! MY TITLE OF PARTY ANIMAL HAS BEEN STOLEN!! I'M RUINED!!!";
	   }
	     else if (primeInt == 1202){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
				Char2speech.text = "";
				ArtChar1b.SetActive(false);
				ArtChar1a.SetActive(false);
				ArtChar1c.SetActive(false);
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
                Char1speech.text = "They’ve got spiking hair, and piercings.";
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
                Char1speech.text = "They’re annoying and dumb, and a big stupid face.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 29;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		
		public void Choice2aFunct(){
				Char1name.text = "YOU";
                Char1speech.text = "No way I’m gonna duel to the death!";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 299;
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
				// Choice2c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice2bFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Yeah! It will be a piece of cake!";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 399;
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
				// Choice2c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		public void Choice3aFunct(){
				Char1name.text = "YOU";
                Char1speech.text = "(starts freestyle breakdancing)";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 1099;
                Choice3a.SetActive(false);
                Choice3b.SetActive(false);
				// Choice2c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice3bFunct(){
				ArtChar1e.SetActive(true);
				ArtChar1d.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "PARTY GUY";
                Char2speech.text = "Whoa where did you learn those moves!?";
                primeInt = 1199;
                Choice3a.SetActive(false);
                Choice3b.SetActive(false);
				// Choice2c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        // public void Choice2cFunct(){
			// FrameWolf.SetActive(true);
			// Frame2Wolf.SetActive(true);
				// GameHandler.isWolf = true;
                // Char1name.text = "YOU";
                // Char1speech.text = "What does a wolf say? Woof?";
                // Char2name.text = "";
                // Char2speech.text = "";
                // primeInt = 499;
                // Choice2a.SetActive(false);
                // Choice2b.SetActive(false);
				// Choice2c.SetActive(false);
                // nextButton.SetActive(true);
                // allowSpace = true;
        // }
		
		

        public void SceneChange1(){
               SceneManager.LoadScene("DEATH");
        }
       public void SceneChange2(){
                SceneManager.LoadScene("Scene2");
        }
		public void SceneChange3(){
                SceneManager.LoadScene("SCOLD");
        }
		public void SceneChange4(){
                SceneManager.LoadScene("PARTYANIMAL");
        }
}

