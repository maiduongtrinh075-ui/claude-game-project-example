using Example.Gameplay.Combat;
using UnityEngine;
using UnityEngine.UI;

namespace Example.UI.Battle
{
    public class BattlePanelController : MonoBehaviour
    {
        [SerializeField] private CombatController combatController;
        [SerializeField] private Button attackButton;

        private void Awake()
        {
            if (attackButton != null)
            {
                attackButton.onClick.AddListener(OnAttackClicked);
            }
        }

        private void OnAttackClicked()
        {
            if (combatController != null && !combatController.State.IsBattleActive)
            {
                combatController.StartBattle();
            }
        }
    }
}
