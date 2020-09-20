using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Phase {
    DRAW,
    USE_CARDS,
    USE_POTIONS,
    STATUS_EFFECTS
}

public class card {
    
}

public class Cauldron {
    private int health;
    public card[] ingredients;

}

public class GameState
{
    private bool turn;
    private Phase phase;
    private Cauldron[] cauldrons;
    public card[] p1_deck;
    public card[] p2_deck;
    public card[] p1_discard;
    public card[] p2_discard;

    void Start() {
        turn = false;
        phase = Phase.DRAW;
        for(int i = 0; i < 6; i++) {
            cauldrons[i] = new Cauldron();
        }

    }

    void shuffle(/*an array*/) {

    }

    void discard_cauldron(Cauldron cauldron,card[] discard_pile) {
        for(int i = 0;i < cauldron.ingredients.Length; i++) {
            
        }
    }


}
