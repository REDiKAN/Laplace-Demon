using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetManager : MonoBehaviour
{
    public Transform star; // Префаб звезды (например, Солнце)
    public float orbitRadius = 10f; // Радиус орбиты
    public float orbitSpeed = 1f; // Скорость вращения по орбите

    private Vector2 center; // Центр орбиты (позиция звезды)
    private float angle; // Угол поворота планеты относительно центра

    void Start()
    {
        center = star.position; // Устанавливаем центр орбиты как позицию звезды
        angle = 0f; // Начальный угол
    }

    void Update()
    {
        center = star.position; // Устанавливаем центр орбиты как позицию звезды
        angle = 0f; // Начальный угол

        angle += Time.deltaTime * orbitSpeed; // Обновляем угол каждый кадр

        // Вычисление новой позиции планеты с учетом угла и радиуса орбиты
        var offset = new Vector2(Mathf.Sin(angle), Mathf.Cos(angle)) * orbitRadius;
        transform.position = center + offset;

        // Поворачиваем планету к звезде
        transform.LookAt(star);
    }
}
