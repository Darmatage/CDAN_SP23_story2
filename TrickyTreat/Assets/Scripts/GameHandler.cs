using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class GameHandler : MonoBehaviour {

        public static int candy = 0;
		// public GameObject candyBag0;
		// public GameObject candyBag1;
		// public GameObject candyBag2;
		// public GameObject candyBag3;
		// public Text candyCount;
		
		public static bool isSuper = false;
		public static bool isGhost = false;
		public static bool isWolf = false;


		public static bool siblingGone = false;
		public static bool sawNPCHouse = false;
		public static bool sawGhostHouse = false;
		public static bool sawPartyHouse = false;
										

        public static bool GameisPaused = false;
        public GameObject pauseMenuUI;
        public AudioMixer mixer;
        public static float volumeLevel = 1.0f;
        private Slider sliderVolumeCtrl;

		


        void Awake(){
                SetLevel (volumeLevel);
                GameObject sliderTemp = GameObject.FindWithTag("PauseMenuSlider");
                if (sliderTemp != null){
                        sliderVolumeCtrl = sliderTemp.GetComponent<Slider>();
                        sliderVolumeCtrl.value = volumeLevel;
                }
        }

        void Start(){
                pauseMenuUI.SetActive(false);
                GameisPaused = false;
				
				// candyBag0.SetActive(true);
				// candyBag1.SetActive(false);
				// candyBag2.SetActive(false);
				// candyBag3.SetActive(false);
				// UpdateCandy ();
        }

        void Update(){
                if (Input.GetKeyDown(KeyCode.Escape)){
                        if (GameisPaused){
                                Resume();
                        }
                        else{
                                Pause();
                        }
                }
        }

		// void UpdateCandy () {
			// Text candyTemp = candyCount.GetComponent<Text>();
			// candyTemp.text = "" + (candy * 10); 
			
			// if (candy == 1){
				// candyBag0.SetActive(false);
				// candyBag1.SetActive(true);
			// } else if (candy == 2){
				// candyBag0.SetActive(false);
				// candyBag1.SetActive(false);
				// candyBag2.SetActive(true);
			// } else if (candy == 3){
				// candyBag0.SetActive(false);
				// candyBag1.SetActive(false);
				// candyBag2.SetActive(false);
				// candyBag3.SetActive(true);
			// }
		// }


        void Pause(){
                pauseMenuUI.SetActive(true);
                Time.timeScale = 0f;
                GameisPaused = true;
        }

        public void Resume(){
                pauseMenuUI.SetActive(false);
                Time.timeScale = 1f;
                GameisPaused = false;
        }

        public void SetLevel (float sliderValue){
                mixer.SetFloat("MusicVolume", Mathf.Log10 (sliderValue) * 20);
                volumeLevel = sliderValue;
        }

        public void StartGame(){
                SceneManager.LoadScene("Scene1");
        }

        public void OpenCredits(){
                SceneManager.LoadScene("Credits");
        }

        public void RestartGame(){
                Time.timeScale = 1f;
                SceneManager.LoadScene("MainMenu");
					
				candy = 0;
				isSuper = false;
				isGhost = false;
				isWolf = false;

				siblingGone = false;
				sawNPCHouse = false;
				sawGhostHouse = false;
				sawPartyHouse = false;
				
        }

        public void QuitGame(){
                #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
                #else
                Application.Quit();
                #endif
        }
}