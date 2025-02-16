﻿using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace ThePotentialJump.Gameplay
{

    public class PassOrFailUIContrller : MonoBehaviour
    {
        [SerializeField] private CanvasGroup PassUI;
        [SerializeField] private CanvasGroup FailUI;

        public UnityEvent ViewedPassUI;
        public UnityEvent ViewedFailUI;

        public void OnPassed()
        {
            ViewedPassUI?.Invoke();
            StartCoroutine(FadeInUI(PassUI));
        }

        public void OnFailed()
        {
            ViewedFailUI?.Invoke();
            StartCoroutine(FadeInUI(FailUI));
        }

        IEnumerator FadeInUI(CanvasGroup ui)
        {
            ui.interactable = true;
            ui.blocksRaycasts = true;
            while (ui.alpha < 1)
            {
                ui.alpha += Time.deltaTime;
                yield return null;
            }
        }

        public void FadeOutEndUI()
        {
            StartCoroutine(FadeOutUI(FailUI));
        }


        IEnumerator FadeOutUI(CanvasGroup ui)
        {
            ui.interactable = false;
            ui.blocksRaycasts = false;
            while (ui.alpha > 0)
            {
                ui.alpha -= Time.deltaTime;
                yield return null;
            }
        }

    }
}
