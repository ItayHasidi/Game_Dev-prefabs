using UnityEngine;

/**
 * This component spawns the given laser-prefab whenever the player clicks a given key.
 * It also updates the "scoreText" field of the new laser.
 */
public class LaserShooter: KeyboardSpawner {
    [SerializeField] NumberField scoreField;
    [SerializeField] string typeOfWeapon;
    public bool BombFlag = true;

    protected override GameObject spawnObject() {
        // Modify the text field of the new object.
        if(typeOfWeapon == "Bomb" && !BombFlag){
            return null;
        }
        if(typeOfWeapon == "Bomb" && BombFlag){
            Debug.Log("Bomb Shot : " + BombFlag);
            BombFlag = false;
        }
        
        return spawner();
    }
    private GameObject spawner(){
         GameObject newObject = base.spawnObject();  // base = super
            ScoreAdder newObjectScoreAdder = newObject.GetComponent<ScoreAdder>();
            if (newObjectScoreAdder)
                newObjectScoreAdder.SetScoreField(scoreField);        
        return newObject;
    }
}
