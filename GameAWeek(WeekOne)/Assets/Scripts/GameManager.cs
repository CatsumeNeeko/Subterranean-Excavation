using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Drawing;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour

{
    //Gold Variables
    public int Gold;
    public GameObject GoldText;
    public Text GoldUI;
    //Deck Variables
    public List<Sprite> DrawDeck = new List<Sprite>() { };
    public List<Sprite> ActiveDeck = new List<Sprite>() { };
    public List<Sprite> SearchDeck = new List<Sprite>() { };
    [SerializeField] public List<Sprite> ImageList = new List<Sprite>() { };
    [SerializeField] public GameObject CardPerfab;
    public GameObject ActiveCard;


    //Deck Search Variables
    public GameObject SearchCardOne;
    public GameObject SearchCardTwo;
    public GameObject SearchCardThree;
    public GameObject SearchCardFour;
    public GameObject SearchCardFive;
    public GameObject SearchCardSix;
    public GameObject SearchCardSeven;
    public GameObject SearchCardEight;
    public GameObject SearchCardNine;




    //Timer Variables
    public float TimeLeft = 30.0f;
    public Text TimeUI;
    public Text TimeShopUI;
    public Text ShopGoldUI;

    //Death Variables
    public int Mask;
    public int deathcount = 0;
    public Text DeathCountUI;

    //Shop Variables
    public Text MaskUI;
    public Text SearchUI;
    public string Searching;
    //Ui Variables
    public GameObject MainCanvas;
    public GameObject GameOverCanvas;
    public GameObject ShopCanvas;
    public GameObject VictorScreenCanvas;

    public void DrawCard()
    {
         Debug.Log("Draw clicked");
         print("OwO");
        if (ActiveCard.activeInHierarchy)
        {
            Destroy(ActiveCard.gameObject);
        }
        //Destroy(ActiveCard.gameObject);
         ActiveCard = Instantiate(CardPerfab, new Vector3(0, 1, 0), Quaternion.identity);
         SpriteRenderer spriteRenderer = ActiveCard.GetComponent<SpriteRenderer>();
         spriteRenderer.sprite = ActiveDeck[0];
         int id = ImageList.FindIndex((Sprite s) => s == ActiveDeck[0]);
         if (id != -1)
         {
             if (id == 0)
             {
                 print("Nothing Found");
             }
             if (id == 1)
             {
                 Gold = Gold + 1;
             }
             if (id == 2)
             {
                 Gold = Gold + 2;
             }
             if (id == 3)
             {
                 Gold = Gold + 3;
             }
             if (id == 4)
             {
                 Gold = Gold + 4;
             }
             if (id == 5)
             {
                if (Mask == 0)
                {
                    print("Game Over!");
                    MainCanvas.SetActive(false);
                    Destroy(ActiveCard.gameObject);
                    GameOverCanvas.SetActive(true);
                }
                if (Mask > 0)
                {
                    print("Saved");
                    Mask--;
                }
             }
        }

         ActiveDeck.RemoveAt(0);
        if (ActiveDeck.Count == 0)
        {
            print("You Win!");
            MainCanvas.SetActive(false);
            VictorScreenCanvas.SetActive(true);
            Destroy(ActiveCard.gameObject);

        }


    }
    public void CardSearchOne()
    {
        SearchDeck.Clear();
        SearchCardOne.SetActive(false);
        deathcount = 0;
        for (int i = 0; i < 1; i++)
        {
            SearchDeck.Add(ActiveDeck[i]);
            if (SearchDeck.Contains(ImageList[05]))
            {
                deathcount++;
                print(deathcount);
                SearchDeck.Remove(SearchDeck[i]);
            }
        }



    }
    public void CardSearchTwo()
    {
        SearchDeck.Clear();
        SearchCardTwo.SetActive(false);
        deathcount = 0;
        for (int i = 0; i < 2; i++)
        {
            SearchDeck.Add(ActiveDeck[i]);
            if (SearchDeck.Contains(ImageList[05]))
            {
                deathcount++;
                print(deathcount);
                SearchDeck.Remove(SearchDeck[i]);
            }
        }
    }
    public void CardSearchThree()
    {
        SearchDeck.Clear();
        SearchCardThree.SetActive(false);
        deathcount = 0;
        for (int i = 0; i < 3; i++)
        {
            
            SearchDeck.Add(ActiveDeck[i]);
            if (SearchDeck.Contains(ImageList[05]))
            {
                deathcount++;
                print(deathcount);
                SearchDeck.Remove(SearchDeck[i]);
            }
        }
    }
    public void CardSearchFour()
    {
        SearchDeck.Clear();
        SearchCardFour.SetActive(false);
        deathcount = 0;
        for (int i = 0; i < 4; i++)
        {
            SearchDeck.Add(ActiveDeck[i]);
            if (SearchDeck.Contains(ImageList[05]))
            {
                deathcount++;
                print(deathcount);
                SearchDeck.Remove(SearchDeck[i]);
            }
        }
    }
    public void CardSearchFive()
    {
        SearchDeck.Clear();
        SearchCardFive.SetActive(false);
        deathcount = 0;
        for (int i = 0; i < 5; i++)
        {
            SearchDeck.Add(ActiveDeck[i]);
            if (SearchDeck.Contains(ImageList[05]))
            {
                deathcount++;
                print(deathcount);
                SearchDeck.Remove(SearchDeck[i]);
            }
        }
    }
    public void CardSearchSix()
    {
        SearchDeck.Clear();
        SearchCardSix.SetActive(false);
        deathcount = 0;
        for (int i = 0; i < 6; i++)
        {
            SearchCardSix.SetActive(false);
            SearchDeck.Add(ActiveDeck[i]);
            if (SearchDeck.Contains(ImageList[05]))
            {
                deathcount++;
                print(deathcount);
                SearchDeck.Remove(SearchDeck[i]);
            }
        }
    }
    public void CardSearchSeven()
    {
        SearchDeck.Clear();
        SearchCardSeven.SetActive(false);
        deathcount = 0;
        for (int i = 0; i < 7; i++)
        {
            SearchCardSeven.SetActive(false);
            SearchDeck.Add(ActiveDeck[i]);
            if (SearchDeck.Contains(ImageList[05]))
            {
                deathcount++;
                print(deathcount);
                SearchDeck.Remove(SearchDeck[i]);
            }
        }
    }
    public void CardSearchEight()
    {
        SearchDeck.Clear();
        SearchCardEight.SetActive(false);
        deathcount = 0;
        for (int i = 0; i < 8; i++)
        {
            SearchCardEight.SetActive(false);
            SearchDeck.Add(ActiveDeck[i]);
            if (SearchDeck.Contains(ImageList[05]))
            {
                deathcount++;
                print(deathcount);
                SearchDeck.Remove(SearchDeck[i]);
            }
        }
    }
    public void CardSearchNine()
    {
        SearchDeck.Clear();
        SearchCardNine.SetActive(false);
        deathcount = 0;
        for (int i = 0; i < 9; i++)
        {
            SearchCardNine.SetActive(false);
            SearchDeck.Add(ActiveDeck[i]);
            if (SearchDeck.Contains(ImageList[05]))
            {
                deathcount++;
                print(deathcount);
                SearchDeck.Remove(SearchDeck[i]);
            }
        }
    }
    public void EnterShop()
    {
        MainCanvas.SetActive(false);
        ShopCanvas.SetActive(true);
        ActiveCard.SetActive(false);
    }
    public void ExitShop()
    {
        MainCanvas.SetActive(true);
        ShopCanvas.SetActive(false);
        ActiveCard.SetActive(true);
    }


    void Start()
    {
        for (int i = 0; i < 7; i++)
        {
            DrawDeck.Add(ImageList[0]);
        }
        for (int i = 0; i < 5; i++)
        {
            DrawDeck.Add(ImageList[1]);
        }
        for (int i = 0; i < 5; i++)
        {
            DrawDeck.Add(ImageList[2]);
        }
        for (int i = 0; i < 4; i++)
        {
            DrawDeck.Add(ImageList[3]);
        }
        for (int i = 0; i < 2; i++)
        {
            DrawDeck.Add(ImageList[4]);
        }
        for (int i = 0; i < 5; i++)
        {
            DrawDeck.Add(ImageList[5]);
        }
        while (DrawDeck.Count>0)
        {
            int pointer = Random.Range(0, DrawDeck.Count);
            ActiveDeck.Add(DrawDeck[pointer]);
            DrawDeck.Remove(DrawDeck[pointer]);
        }
    }
    void Update()
    {
        GoldUI.text = "Gold: " + Gold;
        TimeUI.text = "Time left: " + TimeLeft;
        TimeShopUI.text = "Time left: " + TimeLeft;
        MaskUI.text = "" + Mask;
        ShopGoldUI.text = "Gold: " + Gold;
        DeathCountUI.text = "Poison Room Chance:" + deathcount;
        SearchUI.text = "" + Searching;
        

        TimeLeft -= Time.deltaTime;

        if (TimeLeft <= 0.0f)
        {
            TimerEnded();
        }
    }
    public void BuyMask()
    {
        if (Gold >= 5)
        {
            Mask++;
            Gold = Gold - 5;
        }
    }
    public void BuyBurn()
    {
        if (Gold >= 7)
        {
            Gold = Gold - 7;
            ActiveDeck.Remove(ActiveDeck[0]);
            if (ActiveDeck.Count == 0)
            {
                print("You Win!");
                ShopCanvas.SetActive(false);
                VictorScreenCanvas.SetActive(true);
                Destroy(ActiveCard.gameObject);
            }
        }
    }
    public void BuySearch()
    {
        SearchDeck.Clear();
        
        if (Gold >= 3)
        {
            Gold = Gold - 3;
            int id = ImageList.FindIndex((Sprite s) => s == ActiveDeck[0]);
            if (id != -1)
            {
                if (id == 0)
                {
                    print("Nothing Found");
                    Searching = "The room appears Empty";
                    
                }
                if (id == 1)
                {
                    print("1");
                    Searching = "One gold lies ahead";
                }
                if (id == 2)
                {
                    print("2");
                    Searching = "Two gold lies ahead";
                }
                if (id == 3)
                {
                    print("3");
                    Searching = "Three gold lies ahead";
                }
                if (id == 4)
                {
                    print("4");
                    Searching = "A jackpot of good is ahead";
                }
                if (id == 5)
                {
                    print("Death Card");
                    Searching = "Death is soon";
                }
            }
        }
    }

    void TimerEnded()
    {
        //do your stuff here.
        print("Times Up!");
        MainCanvas.SetActive(false);
        Destroy(ActiveCard.gameObject);
        GameOverCanvas.SetActive(true);
    }

    public void EndTurn()
    {
        TimeLeft = 30f;
        SearchCardOne.SetActive(true);
        SearchCardTwo.SetActive(true);
        SearchCardThree.SetActive(true);
        SearchCardFour.SetActive(true);
        SearchCardFive.SetActive(true);
        SearchCardSix.SetActive(true);
        SearchCardSeven.SetActive(true);
        SearchCardEight.SetActive(true);
        SearchCardNine.SetActive(true);
        
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        print("Restart!");
    }
}