using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
[CustomEditor(typeof(Character))]
public class AbilityEditor : Editor {

    bool ability1Dropdown = true;
    bool ability2Dropdown = true;
    bool ability3Dropdown = true;
    bool ability4Dropdown = true;

    public override void OnInspectorGUI()
    {
        Character myCharacter = (Character)target;

        myCharacter.totalHealth = EditorGUILayout.IntField("Total Health", myCharacter.totalHealth);
        myCharacter.totalMana= EditorGUILayout.IntField("Total Mana", myCharacter.totalMana);

        //Ability 1 Dropdown menu
        ability1Dropdown = EditorGUILayout.Foldout(ability1Dropdown,"Ability 1", true);
        if (ability1Dropdown)
        {
            myCharacter.ability1Name = EditorGUILayout.TextField("Name", myCharacter.ability1Name);
            myCharacter.ability1Damage = EditorGUILayout.IntField("Damage", myCharacter.ability1Damage);
            myCharacter.ability1DamageType = EditorGUILayout.TextField("Damage Type", myCharacter.ability1DamageType);
            myCharacter.ability1HitAllEnemies = EditorGUILayout.Toggle("Hit All Enemies?", myCharacter.ability1HitAllEnemies);
            myCharacter.ability1ManaCost = EditorGUILayout.IntField("Mana Cost", myCharacter.ability1ManaCost);
        }
        //Ability 2 Dropdown menu
        ability2Dropdown = EditorGUILayout.Foldout(ability2Dropdown, myCharacter.ability2Name, true);
        if (ability2Dropdown)
        {
            myCharacter.ability2Name = EditorGUILayout.TextField("Name", myCharacter.ability2Name);
            myCharacter.ability2Damage = EditorGUILayout.IntField("Damage", myCharacter.ability2Damage);
            myCharacter.ability2DamageType = EditorGUILayout.TextField("Damage Type", myCharacter.ability2DamageType);
            myCharacter.ability2HitAllEnemies = EditorGUILayout.Toggle("Hit All Enemies?", myCharacter.ability2HitAllEnemies);
            myCharacter.ability2ManaCost = EditorGUILayout.IntField("Mana Cost", myCharacter.ability2ManaCost);
        }
        //Ability 3 Dropdown menu
        ability3Dropdown = EditorGUILayout.Foldout(ability3Dropdown, myCharacter.ability3Name, true);
        if (ability3Dropdown)
        {
            myCharacter.ability3Name = EditorGUILayout.TextField("Name", myCharacter.ability3Name);
            myCharacter.ability3Damage = EditorGUILayout.IntField("Damage", myCharacter.ability3Damage);
            myCharacter.ability3DamageType = EditorGUILayout.TextField("Damage Type", myCharacter.ability3DamageType);
            myCharacter.ability3HitAllEnemies = EditorGUILayout.Toggle("Hit All Enemies?", myCharacter.ability3HitAllEnemies);
            myCharacter.ability3ManaCost = EditorGUILayout.IntField("Mana Cost", myCharacter.ability3ManaCost);
        }
        //Ability 4 Dropdown menu
        ability4Dropdown = EditorGUILayout.Foldout(ability4Dropdown, myCharacter.ability4Name, true);
        if (ability4Dropdown)
        {
            myCharacter.ability4Name = EditorGUILayout.TextField("Name", myCharacter.ability4Name);
            myCharacter.ability4Damage = EditorGUILayout.IntField("Damage", myCharacter.ability4Damage);
            myCharacter.ability4DamageType = EditorGUILayout.TextField("Damage Type", myCharacter.ability4DamageType);
            myCharacter.ability4HitAllEnemies = EditorGUILayout.Toggle("Hit All Enemies?", myCharacter.ability4HitAllEnemies);
            myCharacter.ability4ManaCost = EditorGUILayout.IntField("Mana Cost", myCharacter.ability4ManaCost);
        }
    }
}
