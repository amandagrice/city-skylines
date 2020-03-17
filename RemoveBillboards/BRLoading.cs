using ColossalFramework.UI;
using ICities;

namespace BillboardRemover
{
    public class BRLoading : ILoadingExtension
    {
        public void OnCreated(ILoading loading){}

        public void OnLevelLoaded(LoadMode mode) {
            for (uint index = 0; index < PrefabCollection<BuildingInfo>.LoadedCount(); index++) {

                BuildingInfo prefab = PrefabCollection<BuildingInfo>.GetLoaded(index);
                if (prefab == null || prefab.m_props == null) continue;
                for (int propIndex = 0; propIndex < prefab.m_props.Length; propIndex++) {
                    BuildingInfo.Prop propItem = prefab.m_props[propIndex];
                    if (propItem.m_prop == null) continue;

                    string propName = propItem.m_prop.name;
                    if (propName == "Billboard_big_variation"
                        || propName == "Billboard_big_variation_01"
                        || propName == "Billboard_big_variation_02"
                        || propName == "Billboard_big_variation_04"
                        || propName == "neon-yakisoba-noodles"
                        || propName == "neon-burned-bean-coffee"
                        || propName == "neon-morellos") {
                        propItem.m_probability = 0;
                    }
                }
            }
        }

        public void OnLevelUnloading() {}

        public void OnReleased(){}
    }
}