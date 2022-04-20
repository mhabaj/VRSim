BEFORE YOU START:
- you need Unity 2019.3+
- you need HD SRP pipline 7.18 or higer, if you use higher please import 7.2 support pack.
- there is wind prefab which will manage wind at your scene
Be patient HD RP tech is so fluid... we coudn't fallow every beta version

Step 1 - Import our HD RP 7.18 Unity 2019.3 Mountain Tree Pack compatibility pack or 7.2 if you use higher.
Step 2 - Setup Shadows and other render setups.

Find File "HDRenderPipelineAsset" and find Material section, drag and drop our SSS settings diffusion profiles for foliage into Diffusion profile list:
NM_SSSSettings_Skin_Foliage
NM_SSSSettings_Skin_NM Foliage
NM_SSSSettings_Skin_NM Foliage Trees
Without this foliage materials will not become affected by scattering.
