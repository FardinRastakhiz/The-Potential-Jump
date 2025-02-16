﻿using UnityEngine;

namespace ThePotentialJump.EditorUtilities
{
    public class UIWorldPosition : MonoBehaviour
    {
        [SerializeField] private RectTransform rectTransform;

        public void SetWorldPosition(Vector3 position)
        {
            rectTransform.position = position;
        }
    }
}