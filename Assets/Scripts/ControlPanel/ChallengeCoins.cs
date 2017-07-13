using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.ControlPanel
{
    public class ChallengeCoins : MonoBehaviour
    {
        public Text CurrentAmountText;

        private int _coinsAmount;

        private PanelController _panelController;

        private void Start ()
        {
            SetChallengeCoins(0);
            _panelController = FindObjectOfType<PanelController>();
        }

        public void AddCoin()
        {
            _panelController.SendChallengeCoinsValue(_coinsAmount + 1);
        }

        public void Withdraw()
        {
            _panelController.SendChallengeCoinsValue(0);
        }

        public void SetChallengeCoins(int challengeCoins)
        {
            _coinsAmount = challengeCoins;
            CurrentAmountText.text = _coinsAmount.ToString();
        }
    }
}
