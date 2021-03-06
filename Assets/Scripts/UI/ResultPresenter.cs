﻿using UnityEngine;
using System.Collections;

public class ResultPresenter : KPresenter
{

    [SerializeField]
    private GameObject _next;

    [SerializeField]
    private GameObject _replay;

    [SerializeField]
    private GameObject _back;

    [SerializeField]
    private UISprite _resultSprite;

    [SerializeField]
    private GameObject[] _stars;

    public override object DataContent
    {
        set
        {
            PlayResult result = (PlayResult)value;

            bool isSuccess = result != PlayResult.FAIL;

            _resultSprite.spriteName = isSuccess ? "result_success" : "result_fail";
            _next.SetActive(isSuccess);

            int stars = (int)result;
            _stars[0].SetActive(stars >= 1);
            _stars[1].SetActive(stars >= 2);
            _stars[2].SetActive(stars >= 3);
        }
    }

    void Start()
    {
        UIEventListener.Get(_next).onClick = (go) =>
        {
            SceneManager.LoadScene(SceneManager.SceneIndex + 1);
        };

        UIEventListener.Get(_replay).onClick = (go) =>
        {
            SceneManager.LoadScene(SceneManager.SceneIndex);
        };

        UIEventListener.Get(_back).onClick = (go) =>
        {
            Application.LoadLevel(Constant.LEVEL_START_NAME);
        };
    }
}
