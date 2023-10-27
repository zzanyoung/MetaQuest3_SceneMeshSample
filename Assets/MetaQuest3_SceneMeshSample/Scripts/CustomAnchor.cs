using UnityEngine;

[RequireComponent(typeof(OVRSpatialAnchor))]
public class CustomAnchor : MonoBehaviour
{
    private OVRSpatialAnchor _spatialAnchor;

    private void Awake()
    {
        _spatialAnchor = GetComponent<OVRSpatialAnchor>();
    }

    private void Start()
    {
        if (_spatialAnchor && !_spatialAnchor.Created)
        {
            // ������ ��Ŀ�� ���� ���� ���, ���ο� ��Ŀ�� �����մϴ�.
            CreateAnchor();
        }
    }

    private void Update()
    {
        // ��Ŀ�� �����ϰų� �����ϰ� ���� ������ ó���� �� �ֽ��ϴ�.
        if (Input.GetKeyDown(KeyCode.C))
        {
            CreateAnchor();
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            DestroyAnchor();
        }
    }

    private void CreateAnchor()
    {
        // ���ο� ��Ŀ�� �����մϴ�.
        if (_spatialAnchor)
        {
            _spatialAnchor.Save((anchor, success) =>
            {
                if (success)
                {
                    Debug.Log("��Ŀ ���� ����");
                }
                else
                {
                    Debug.Log("��Ŀ ���� ����");
                }
            });
        }
    }

    private void DestroyAnchor()
    {
        // ��Ŀ�� �����մϴ�.
        if (_spatialAnchor)
        {
            _spatialAnchor.Erase((anchor, success) =>
            {
                if (success)
                {
                    Debug.Log("��Ŀ ���� ����");
                }
                else
                {
                    Debug.Log("��Ŀ ���� ����");
                }
            });
        }
    }
}
