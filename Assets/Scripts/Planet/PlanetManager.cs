using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetManager : MonoBehaviour
{
    public Transform star; // ������ ������ (��������, ������)
    public float orbitRadius = 10f; // ������ ������
    public float orbitSpeed = 1f; // �������� �������� �� ������

    private Vector2 center; // ����� ������ (������� ������)
    private float angle; // ���� �������� ������� ������������ ������

    void Start()
    {
        center = star.position; // ������������� ����� ������ ��� ������� ������
        angle = 0f; // ��������� ����
    }

    void Update()
    {
        center = star.position; // ������������� ����� ������ ��� ������� ������
        angle = 0f; // ��������� ����

        angle += Time.deltaTime * orbitSpeed; // ��������� ���� ������ ����

        // ���������� ����� ������� ������� � ������ ���� � ������� ������
        var offset = new Vector2(Mathf.Sin(angle), Mathf.Cos(angle)) * orbitRadius;
        transform.position = center + offset;

        // ������������ ������� � ������
        transform.LookAt(star);
    }
}
