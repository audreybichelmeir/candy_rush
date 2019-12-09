                using System.Collections;
                using System.Collections.Generic;
                using UnityEngine;
                using UnityEngine.SceneManagement;
                using UnityEngine.UI;

                public class GameManager : MonoBehaviour
                {

                    private float timeLeft = 10;
                    public int playerScore = 0;
                    public GameObject timeLeftUI;
                    public GameObject playerScoreUI;


                    void Update()
                    {
                        timeLeft -= Time.deltaTime;
                        timeLeftUI.gameObject.GetComponent<Text>().text = ("Time Left: " + (int)timeLeft);
                        playerScoreUI.gameObject.GetComponent<Text>().text = ("Score: " + playerScore);
                        if (timeLeft < 0.1f)
                        {
                            SceneManager.LoadScene("Candy Rush");
                        }
                    }

                     void OnTriggerEnter2D(Collider2D trig)
                        {
                        if (trig.gameObject.name == "candyBlue")
                            {
                                playerScore += 1;
                                Destroy(trig.gameObject);
                                //CountScore();
                            }
                        if (trig.gameObject.name == "candyGreen")
                        {
                            playerScore += 15;
                            Destroy(trig.gameObject);
                            //CountScore();
                         }
                        if (trig.gameObject.name == "candyRed")
                        { 
                            playerScore += 30;
                            Destroy(trig.gameObject);
                            //CountScore();
                         }
                        if (trig.gameObject.name == "candyYellow")
                        { 
                            playerScore += 10;
                            Destroy(trig.gameObject);
                            //CountScore();
                         }
                        CountScore();
                }

                    void CountScore()
                        {
                        playerScore =+ playerScore;
                        //playerScore + (int)(timeLeft * 10);
                            Debug.Log(playerScore);
                        }


    
                }
