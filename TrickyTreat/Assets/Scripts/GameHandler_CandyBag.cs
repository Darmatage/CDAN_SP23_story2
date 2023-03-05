using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameHandler_CandyBag : MonoBehaviour {

		public GameObject candyBag0;
		public GameObject candyBag1;
		public GameObject candyBag2;
		public GameObject candyBag3;
		public Text candyCount;
	
        void Start(){
				candyBag0.SetActive(true);
				candyBag1.SetActive(false);
				candyBag2.SetActive(false);
				candyBag3.SetActive(false);
				UpdateCandy();
        }


		public void UpdateCandy () {
			Text candyTemp = candyCount.GetComponent<Text>();
			candyTemp.text = "" + (GameHandler.candy * 10); 
			
			if (GameHandler.candy == 1){
				candyBag0.SetActive(false);
				candyBag1.SetActive(true);
			} else if (GameHandler.candy == 2){
				candyBag0.SetActive(false);
				candyBag1.SetActive(false);
				candyBag2.SetActive(true);
			} else if (GameHandler.candy == 3){
				candyBag0.SetActive(false);
				candyBag1.SetActive(false);
				candyBag2.SetActive(false);
				candyBag3.SetActive(true);
			}
		}

}