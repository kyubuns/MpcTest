using MessagePack;
using UnityEngine;

[MessagePackObject]
public class Hoge
{
    [Key(0)] public Vector2 Key1 { get; set; }
}