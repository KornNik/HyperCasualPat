using UnityEngine;
using UnityEngine.UI;
using HyperCasual.Controller;

namespace HyperCasual.UI
{
    internal class MenuUI : BaseUI
    {
        [SerializeField] private Button _startGameButton;
        [SerializeField] private Button _endGameButton;

        private void OnEnable()
        {
            _startGameButton.onClick.AddListener(StartGameBtnClick);
            _endGameButton.onClick.AddListener(EndGameBtnClick);
        }

        private void OnDisable()
        {
            _startGameButton.onClick.RemoveListener(StartGameBtnClick);
            _endGameButton.onClick.RemoveListener(EndGameBtnClick);
        }

        public override void Show()
        {
            gameObject.SetActive(true);
            ShowUI.Invoke();
        }

        public override void Hide()
        {
            gameObject.SetActive(false);
            HideUI.Invoke();
        }

        private void StartGameBtnClick()
        {
            LevelController.Instance.LoadScene();
            ScreenInterface.GetInstance().Execute(Helpers.ScreenTypes.GameUI);
        }
        private void EndGameBtnClick()
        {

        }
    }
}
