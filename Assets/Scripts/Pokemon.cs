using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokemon : MonoBehaviour
{
    // // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Peens");
    }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }

    // Constructor
    private Pokemon(){
        _name = "Default";
        _level = 1;
        _maxhealth = 1;
        _currenthealth = 1;
        _exp = 0;

        _attack = 1;
        _specialAttack = 1;
        _defense = 1;
        _specialDefense = 1;
        _hp = 1;
        _speed = 1;

        _height = 1.0F;
        _weight = 1.0F;
        _gender = "Male";
        _type = "Grass";
        _ability = "None";
        _id = 1;
    }


    private string _name;
    private int _level;
    private int _maxhealth;
    private int _currenthealth;
    private int _exp;

    // Pokemon stats
    private int _attack;
    private int _specialAttack;
    private int _defense;
    private int _specialDefense;
    private int _hp;
    private int _speed;

    // Extra stats
    private float _height;
    private float _weight;
    private string _gender;
    private string _type;
    private string _ability; // Passive ability
    private int _id;

    // Moves and stuff
    private string[] currentMoves = new string[4]; 



    // GETTERS

    public string getName(){
        return _name;
    }

    public int getLevel(){
        return _level;
    }

    public int getMaxhealth(){
        return _maxhealth;
    }

    public int getCurrenthealth(){
        return _currenthealth;
    }

    public int getExp(){
        return _exp;
    }

    public int getAttack(){
        return _attack;
    }

    public int getSpecialAttack(){
        return _specialAttack;
    }

    public int getHP(){
        return _hp;
    }

    public int getSpeed(){
        return _speed;
    }

    public float getHeight(){
        return _height;
    }

    public float getWeight(){
        return _weight;
    }

    public string getGender(){
        return _gender;
    }

    public string getType(){
        return _type;
    }

    public string getAbility(){
        return _ability;
    }

    public int getId(){
        return _id;
    }

    // SETTERS

    public void setName(string name){
        _name = name;
    }

    public void setLevel(int level){
        _level = level;
    }

    public void setMaxhealth(int maxhealth){
        _maxhealth = maxhealth;
    }

    public void setCurrenthealth(int currenthealth){
        _currenthealth = currenthealth;
    }

    public void setExp(int exp){
        _exp = exp;
    }

    public void setAttack(int attack){
        _attack = attack;
    }

    public void setSpecialAttack(int specialAttack){
        _specialAttack = specialAttack;
    }

    public void setHP(int hp){
        _hp = hp;
    }

    public void setSpeed(int speed){
        _speed = speed;
    }

    public void setHeight(float height){
        _height = height;
    }

    public void setWeight(float weight){
        _weight = weight;
    }

    public void setGender(string gender){
        _gender = gender;
    }

    public void setType(string type){
        _type = type;
    }

    public void setAbility(string ability){
        _ability = ability;
    }

    public void setId(int id){
        _id = id;
    }

}
