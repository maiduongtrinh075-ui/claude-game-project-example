using UnityEngine;

namespace Example.Gameplay.Combat
{
    public class CombatController : MonoBehaviour
    {
        [SerializeField] private CombatState state;

        public CombatState State => state;

        public void StartBattle()
        {
            if (state == null)
            {
                state = new CombatState();
            }

            state.IsBattleActive = true;
        }
    }
}
