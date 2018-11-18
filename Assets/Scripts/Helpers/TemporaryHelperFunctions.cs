using UnityEngine;

public static class TemporaryHelperFunctions {

    public static Position ComponentWiseClamp(Position value, Position min,  Position max) {
        return new Position(Mathf.Clamp(value.Vector2.x, min.Vector2.x, max.Vector2.x), Mathf.Clamp(value.Vector2.y, min.Vector2.y, max.Vector2.y));
    }

}