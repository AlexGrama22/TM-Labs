using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    private static int SCREEN_WIDTH = 64;    //1024 pixels
    private static int SCREEN_HEIGHT = 50;   //768 pixels

    public float speed = 0.15f;
    private float timer=0;

    public bool simulationEnabled = false;
    public static GameMode gameMode;
    public GameMode gameModeInstance; // corrected variable name
    public bool Newtick = false;

    public int simNR=50;  //number of generations, this should be used to add nota 6 functionality
    public int ct=0;     //generations number used in counter

    public bool button2Down = false, button2Up = false;

    public int zoneX1 = 0, zoneY1 = 0;
    public int zoneX2 = 0, zoneY2 = 0;

    public int dangerZoneCount = 10;
    public int dangerZoneSize = 70;
    public float dangerZoneDamageRate = 1000000000000f;
    private float dangerZoneTimer = 0;

    Cell[,] grid = new Cell[SCREEN_WIDTH, SCREEN_HEIGHT];


    void Start(){
        PlaceCells();
        gameModeInstance = new GameMode();
<<<<<<< HEAD
<<<<<<< HEAD
        CreateDangerZones();
=======

>>>>>>> 984eb3ad62d8fe6f824d369539174d6c5f47f730
=======

>>>>>>> 984eb3ad62d8fe6f824d369539174d6c5f47f730
    }
    void Update(){
        userInput();

        if (button2Down && button2Up){
            int i,j,n,m,k,l;
            if (zoneX1 < zoneX2) {k = zoneX1; n = zoneX2;}
            else {k = zoneX2; n = zoneX1;}

            if (zoneY1 < zoneY2) {l = zoneY1; m = zoneY2;}
            else {l = zoneY2; m = zoneY1;}

            for (i = k; i <= n; i++){
                for (j = l; j <= m; j++)
                    grid[i,j].isInZone = true;
            }

            button2Down = false;
            button2Up = false;
        }

        if (simulationEnabled){
               if (timer>=speed){
                    timer = 0f;
                    CountNeighbors();
                    PopulationControl();
                    ct++;
                    if(ct==simNR){
                        simulationEnabled=false;
                        ct=0;
                    }
                }else{
                    timer += Time.deltaTime;
                }

                // Newtick = gameModeInstance.tick;
            }
            
        }

    void CreateDangerZones()
    {
        Color dangerZoneColor = new Color(1f, 0f, 0f, 0.5f); // red with 50% opacity
        SpriteRenderer cellRenderer;
        for (int i = 0; i < dangerZoneCount; i++)
        {
            int centerX = UnityEngine.Random.Range(dangerZoneSize, SCREEN_WIDTH - dangerZoneSize);
            int centerY = UnityEngine.Random.Range(dangerZoneSize, SCREEN_HEIGHT - dangerZoneSize);

            for (int x = centerX - dangerZoneSize; x <= centerX + dangerZoneSize; x++)
            {
                for (int y = centerY - dangerZoneSize; y <= centerY + dangerZoneSize; y++)
                {
                    grid[x, y].isInZone = true;
                    cellRenderer = grid[x, y].GetComponent<SpriteRenderer>();
                    cellRenderer.color = dangerZoneColor;
                }
            }
        }
    }

    void PlaceCells(){
        for(int y = 0; y<SCREEN_HEIGHT;y++){
            for(int x=0; x<SCREEN_WIDTH; x++){
                Cell cell=Instantiate(Resources.Load("Prefabs/Cell", typeof(Cell)), new Vector2(x,y), Quaternion.identity) as Cell;
                grid[x,y]=cell;
                grid[x,y].SetAlive(RandomAliveCell());
            }
        }
    }

    bool RandomAliveCell(){
        int rand = UnityEngine.Random.Range(0,100);
        
        if (rand> 75){
            return true;
        }
        return false;
    }

    void userInput(){
        if (Input.GetMouseButtonDown(0)){
            Vector2 mousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            int x = Mathf.RoundToInt(mousePoint.x);
            int y = Mathf.RoundToInt(mousePoint.y);
             
            if (x>= 0 && y>= 0 && x<SCREEN_WIDTH && y<SCREEN_HEIGHT){
                //in bounds
                grid[x,y].SetAlive(!grid[x,y].isAlive);
            }
        }

        if (Input.GetMouseButtonDown(1)){
            Vector2 mousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            zoneX1 = Mathf.RoundToInt(mousePoint.x);
            zoneY1 = Mathf.RoundToInt(mousePoint.y);
            button2Down = true;
        }
        
        if (Input.GetMouseButtonUp(1)){
            Vector2 mousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            zoneX2 = Mathf.RoundToInt(mousePoint.x);
            zoneY2 = Mathf.RoundToInt(mousePoint.y);
            button2Up = true;

            if (zoneX1 > SCREEN_WIDTH) {button2Down = false; button2Up = false;}
            if (zoneX1 < 0) {button2Down = false; button2Up = false;}
            if (zoneX2 > SCREEN_WIDTH) {button2Down = false; button2Up = false;}
            if (zoneX2< 0) {button2Down = false; button2Up = false;}
            if (zoneY1 > SCREEN_HEIGHT) {button2Down = false; button2Up = false;}
            if (zoneY1 < 0) {button2Down = false; button2Up = false;}
            if (zoneY2 > SCREEN_HEIGHT) {button2Down = false; button2Up = false;}
            if (zoneY2 < 0) {button2Down = false; button2Up = false;}
        }


        if(Input.GetKeyUp(KeyCode.P)){
            //start/pause simulation
            simulationEnabled=(!simulationEnabled);
            if(!simulationEnabled){
                ct=0;
            }
        }
        if(Input.GetKeyUp(KeyCode.Q)){
            //click Q to choose 5 gens
            simNR=5;
        }
        if(Input.GetKeyUp(KeyCode.W)){
            //click W to choose 10 gens
            simNR=10;
        }
        if(Input.GetKeyUp(KeyCode.E)){
            //click E to choose 100 gens
            simNR=100;
        }
        if(Input.GetKeyUp(KeyCode.R)){
            //click R to choose 1000 gens
            simNR=1000;
        }
        if(Input.GetKeyUp(KeyCode.T)){
            int i,j;
            //remove all zones
            for (i = 0; i < SCREEN_WIDTH; i++){
                for (j = 0; j < SCREEN_HEIGHT; j++)
                    grid[i,j].isInZone = false;
            }
        }
        if(Input.GetKeyUp(KeyCode.N)){
        //change of speed
        speed = 0.05f;
        }

        if(Input.GetKeyUp(KeyCode.M)){
        //change of speed x2
        speed = 0.01f;
        }

        if(Input.GetKeyUp(KeyCode.B)){
        //change of speed x2
        speed = 0.15f;
        }

        if(Input.GetKeyUp(KeyCode.X)){
        //Infinite life
        Newtick = false;
        }

        if(Input.GetKeyUp(KeyCode.C)){
        //Normal Life
        Newtick = true;
        }    
    }


    void CountNeighbors(){
        for (int  y =0; y<SCREEN_HEIGHT;y++){
            for (int x = 0; x<SCREEN_WIDTH; x++){
                int numNeighbors = 0;

                //North
                if (y+1<SCREEN_HEIGHT){
                    if(grid[x,y+1].isAlive){
                        numNeighbors++;
                    }

                }

                //East
                if (x+1<SCREEN_HEIGHT){
                    if(grid[x+1,y].isAlive){
                        numNeighbors++;
                    }
                }

                //South
                if (y-1>=0){
                    if(grid[x,y-1].isAlive){
                        numNeighbors++;
                    }
                }

                //West
                if(x-1>=0){
                    if(grid[x-1,y].isAlive){
                        numNeighbors++;
                    }
                }

                //NortEast

                if(x+1<SCREEN_WIDTH && y+1<SCREEN_HEIGHT ){
                    if (grid[x+1,y+1].isAlive){
                        numNeighbors++;
                    }
                }

                //NorthWest

                if(x-1>=0 && y+1<SCREEN_HEIGHT){
                    if(grid[x-1,y+1].isAlive){
                        numNeighbors++;
                    }
                }

                //SouthEast

                if(x+1<SCREEN_WIDTH && y-1>=0){
                    if (grid[x+1,y-1].isAlive){
                        numNeighbors++;
                    }
                }


                //SouthWest

                if(x-1>=0 && y-1>=0){
                    if(grid[x-1,y-1].isAlive){
                        numNeighbors++;
                    }
                }

                grid[x,y].numNeighbors=numNeighbors;
            }
        }
    }
    
    void PopulationControl(){
<<<<<<< HEAD
         if (dangerZoneTimer >= dangerZoneDamageRate){
            dangerZoneTimer = 0;

            for (int y=0; y<SCREEN_HEIGHT; y++){
                for(int x=0; x<SCREEN_WIDTH; x++){
                    if(grid[x, y].isInZone){
                        grid[x, y].ApplyDamage();
=======
        for (int y=0; y<SCREEN_HEIGHT; y++){
            for(int x=0; x<SCREEN_WIDTH; x++){

                if( Newtick == true)
                {


                    // Any cell alive with 2 or 3 neighbors survives
                    // Any dead cell with 3 alive neighbors rises from the dead
                    // All other live cells die in the next generation and all other cells stay dead

                    if(grid[x,y].isAlive){
                        if(grid[x,y].numNeighbors != 2 && grid[x,y].numNeighbors !=3){
                            grid[x,y].SetAlive(false);
                        }
                    }
                    else{
                        //dead cell
                        if (grid[x,y].numNeighbors==3){
                            grid[x,y].SetAlive(true);
                        }
>>>>>>> 984eb3ad62d8fe6f824d369539174d6c5f47f730
                    }

                }
<<<<<<< HEAD
<<<<<<< HEAD
            }
            } else {
                dangerZoneTimer += Time.deltaTime;
            }

            for (int y=0; y<SCREEN_HEIGHT; y++){
                for(int x=0; x<SCREEN_WIDTH; x++){

                    if( Newtick == true)
                    {


                        // Any cell alive with 2 or 3 neighbors survives
                        // Any dead cell with 3 alive neighbors rises from the dead
                        // All other live cells die in the next generation and all other cells stay dead

                        if(grid[x,y].isAlive){
                            if(grid[x,y].numNeighbors != 2 && grid[x,y].numNeighbors !=3){
                                grid[x,y].SetAlive(false);
                            }
=======
=======
>>>>>>> 984eb3ad62d8fe6f824d369539174d6c5f47f730

                if (Newtick == false)
                {
                    //long life rule zone
                    if (grid[x,y].isInZone){
                        if(grid[x,y].isAlive){
                            if(grid[x,y].numNeighbors != 5){
                                grid[x,y].SetAlive(false);
                            }
<<<<<<< HEAD
=======
                        }
                        else{
                            //dead cell
                            if (grid[x,y].numNeighbors==3 || grid[x,y].numNeighbors==4 || grid[x,y].numNeighbors==5){
                                grid[x,y].SetAlive(true);
                            }
>>>>>>> 984eb3ad62d8fe6f824d369539174d6c5f47f730
                        }
                        else{
                            //dead cell
                            if (grid[x,y].numNeighbors==3 || grid[x,y].numNeighbors==4 || grid[x,y].numNeighbors==5){
                                grid[x,y].SetAlive(true);
                            }
>>>>>>> 984eb3ad62d8fe6f824d369539174d6c5f47f730
                        }
                        else{
                            //dead cell
                            if (grid[x,y].numNeighbors==3){
                                grid[x,y].SetAlive(true);
                            }
                        }

                    }
<<<<<<< HEAD

                    if (Newtick == false)
                    {
                        //long life rule zone
                        if (grid[x,y].isInZone){
                            if(grid[x,y].isAlive){
                                if(grid[x,y].numNeighbors != 5){
                                    grid[x,y].SetAlive(false);
                                }
                            }
                            else{
                                //dead cell
                                if (grid[x,y].numNeighbors==3 || grid[x,y].numNeighbors==4 || grid[x,y].numNeighbors==5){
                                    grid[x,y].SetAlive(true);
                                }
                            }
                        }
                        else{
                            if(grid[x,y].isAlive){
                                if(grid[x,y].numNeighbors > 3){
                                    grid[x,y].SetAlive(false);
                                }
                            }
                            else{
                                    //dead cell
                                    if (grid[x,y].numNeighbors==3 || grid[x,y].numNeighbors==7){
                                        grid[x,y].SetAlive(true);
                                    }


                                }

                        }
=======
                    else{
                        if(grid[x,y].isAlive){
                            if(grid[x,y].numNeighbors > 3){
                                grid[x,y].SetAlive(false);
                            }
                        }
                        else{
                                //dead cell
                                if (grid[x,y].numNeighbors==3 || grid[x,y].numNeighbors==7){
                                    grid[x,y].SetAlive(true);
                                }


                            }
<<<<<<< HEAD
>>>>>>> 984eb3ad62d8fe6f824d369539174d6c5f47f730
=======
>>>>>>> 984eb3ad62d8fe6f824d369539174d6c5f47f730

                    }

                }
            }
        }


}