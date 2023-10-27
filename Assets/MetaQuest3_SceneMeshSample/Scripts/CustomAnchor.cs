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
            // 생성된 앵커가 아직 없는 경우, 새로운 앵커를 생성합니다.
            CreateAnchor();
        }
    }

    private void Update()
    {
        // 앵커를 선택하거나 제거하고 싶은 조건을 처리할 수 있습니다.
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
        // 새로운 앵커를 생성합니다.
        if (_spatialAnchor)
        {
            _spatialAnchor.Save((anchor, success) =>
            {
                if (success)
                {
                    Debug.Log("앵커 생성 성공");
                }
                else
                {
                    Debug.Log("앵커 생성 실패");
                }
            });
        }
    }

    private void DestroyAnchor()
    {
        // 앵커를 제거합니다.
        if (_spatialAnchor)
        {
            _spatialAnchor.Erase((anchor, success) =>
            {
                if (success)
                {
                    Debug.Log("앵커 제거 성공");
                }
                else
                {
                    Debug.Log("앵커 제거 실패");
                }
            });
        }
    }
}
