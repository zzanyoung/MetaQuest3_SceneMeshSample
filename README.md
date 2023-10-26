# MetaQuest3_SceneMeshSample

This is a project based on OculusXR (OVR) for Mixed Reality. Includes 'Building Blocks' functionality and 'Scene Mesh'.

Loads a mesh based on the user's room settings (not guardian settings) and creates a realistic collider in the passthrough environment


<h2>Environment</h2> 

- Meta Quest3
- Unity 2022.3.11f1 <br>
- OculusIntegration_v57
- OculusXR (NOT OpenXR)
- Pre-scanned Space Data (NOT guardian settings, NOT furniture settings)

<h2>Getting Started Guide</h2> 

1) Clone or download the repository.
2) Load the project from Unity Hub
     - When you first load a project, the entire editor may be grayed out (presumably an issue with the Unity editor).
Solution: Force quit and restart
3) Change target platform to Android in build settings
4) Change Texture Compression to ASTC (recommended)
5) In ProjectSetting/Player/OtherSetting
    - Change Color Space to Linear
    - Change GraphicsAPI to OpenGLES3
    - Change Minimum API Level to 29 (Android10)
    - Change Scripting Backend to IL2CPP
    - Change Target Architectures to ARM64
6) Check only Oculus in ProjectSetting/XR Plug-in Management
7) Select Oculus/Tools/ProjectSetupTool from the editor menu, Fix and Apply unchecked items
8) Open Asset/MetaQuest3_SceneMeshSample/SceneMeshSample.Scene
9) Test or Edit


<h2>Reference</h2> 
https://developer.oculus.com/documentation/unity/unity-scene-mesh/


<h2>Licenses</h2> 
The Meta License applies to the SDK and supporting material. The MIT License applies to only certain, clearly marked documents. If an individual file does not indicate which license it is subject to, then the Meta License applies.
