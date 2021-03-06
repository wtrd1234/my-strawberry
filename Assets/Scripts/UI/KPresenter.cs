using UnityEngine;
using System.Collections;

/// <summary>
/// 界面组件的基类
/// </summary>
public class KComponent : MonoBehaviour {

    /// <summary>
    /// 需要的数据
    /// </summary>
    public virtual object DataContent { get; set; }
}