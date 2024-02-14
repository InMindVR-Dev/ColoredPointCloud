using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointCloudFileConverter
{
    public static class MassRanges
    {

        public static List<MassRange> MASSRANGES = new List<MassRange>()
        {
            new MassRange() {MoleType = MoleculeType.Si, Min = 13.942f, Max = 14.090f},
            new MassRange() {MoleType = MoleculeType.Si, Min = 14.460f, Max = 14.540f},
            new MassRange() {MoleType = MoleculeType.Si, Min = 14.950f, Max = 15.029f},

            new MassRange() {MoleType = MoleculeType.Cr, Min = 25.923f, Max = 26.053f},
            new MassRange() {MoleType = MoleculeType.Cr, Min = 24.944f, Max = 25.030f},
            new MassRange() {MoleType = MoleculeType.Cr, Min = 26.431f, Max = 26.504f},

            new MassRange() {MoleType = MoleculeType.Fe, Min = 26.892f, Max = 27.181f},
            new MassRange() {MoleType = MoleculeType.Fe, Min = 27.72f, Max = 28.350f},
            new MassRange() {MoleType = MoleculeType.Fe, Min = 28.4f, Max = 28.64f},
            new MassRange() {MoleType = MoleculeType.Fe, Min = 55.886f, Max = 56.073f},

            new MassRange() {MoleType = MoleculeType.Mn, Min = 27.377f, Max = 27.677f},

            new MassRange() {MoleType = MoleculeType.Ni, Min = 28.892f, Max = 29.113f},
            new MassRange() {MoleType = MoleculeType.Ni, Min = 29.903f, Max = 30.082f},
            new MassRange() {MoleType = MoleculeType.Ni, Min = 30.409f, Max = 30.521f},
            new MassRange() {MoleType = MoleculeType.Ni, Min = 30.910f, Max = 31.051f},
            new MassRange() {MoleType = MoleculeType.Ni, Min = 31.910f, Max = 32.027f},

            new MassRange() {MoleType = MoleculeType.Mo, Min = 48.883f, Max = 49.040f},
            new MassRange() {MoleType = MoleculeType.Mo, Min = 30.582f, Max = 30.669f},
            new MassRange() {MoleType = MoleculeType.Mo, Min = 31.253f, Max = 31.337f},
            new MassRange() {MoleType = MoleculeType.Mo, Min = 31.599f, Max = 31.677f},
            new MassRange() {MoleType = MoleculeType.Mo, Min = 32.259f, Max = 32.331f},
            new MassRange() {MoleType = MoleculeType.Mo, Min = 32.599f, Max = 32.665f},
            new MassRange() {MoleType = MoleculeType.Mo, Min = 33.269f, Max = 33.345f},
            new MassRange() {MoleType = MoleculeType.Mo, Min = 45.893f, Max = 46.030f},
            new MassRange() {MoleType = MoleculeType.Mo, Min = 46.89f, Max = 47.011f},
            new MassRange() {MoleType = MoleculeType.Mo, Min = 47.38f, Max = 47.55f},
            new MassRange() {MoleType = MoleculeType.Mo, Min = 47.88f, Max = 48.04f},
            new MassRange() {MoleType = MoleculeType.Mo, Min = 48.38f, Max = 48.53f},
            new MassRange() {MoleType = MoleculeType.Mo, Min = 49.89f, Max = 50.04f},

            new MassRange() {MoleType = MoleculeType.C, Min = 5.975f, Max = 6.037f},
            new MassRange() {MoleType = MoleculeType.C, Min = 11.973f, Max = 12.08f},
            new MassRange() {MoleType = MoleculeType.C, Min = 23.953f, Max = 24.07f},
            new MassRange() {MoleType = MoleculeType.C, Min = 12.974f, Max = 13.032f},

            new MassRange() {MoleType = MoleculeType.P, Min = 10.299f, Max = 10.358f},
            new MassRange() {MoleType = MoleculeType.P, Min = 15.457f, Max = 15.533f},

            new MassRange() {MoleType = MoleculeType.O, Min = 15.964f, Max = 16.042f},

            new MassRange() {MoleType = MoleculeType.Co, Min = 29.43f, Max = 29.518f},

            new MassRange() {MoleType = MoleculeType.Cu, Min = 31.418f, Max = 31.53f},
            new MassRange() {MoleType = MoleculeType.Cu, Min = 32.417f, Max = 32.540f},
            new MassRange() {MoleType = MoleculeType.Cu, Min = 62.830f, Max = 63.060f},
            new MassRange() {MoleType = MoleculeType.Cu, Min = 64.850f, Max = 65.000f},

            new MassRange() {MoleType = MoleculeType.Ga, Min =34.413f, Max = 34.540f},
            new MassRange() {MoleType = MoleculeType.Ga, Min =35.416f, Max = 35.540f},
            new MassRange() {MoleType = MoleculeType.Ga, Min =68.850f, Max = 69.035f},
            new MassRange() {MoleType = MoleculeType.Ga, Min =70.810f, Max = 71.010f},

            new MassRange() {MoleType = MoleculeType.x375, Min =37.4f, Max = 37.54f},

            new MassRange() {MoleType = MoleculeType.H2O, Min =17.97f, Max = 18.065f},

            new MassRange() {MoleType = MoleculeType.MoN, Min =52.890f, Max = 53.013f},
            new MassRange() {MoleType = MoleculeType.MoN, Min =53.901f, Max = 54.027f},
            new MassRange() {MoleType = MoleculeType.MoN, Min =54.905f, Max = 55.016f},
            new MassRange() {MoleType = MoleculeType.MoN, Min =54.401f, Max = 54.497f},
            new MassRange() {MoleType = MoleculeType.MoN, Min =55.388f, Max = 55.521f},

            new MassRange() {MoleType = MoleculeType.V, Min =25.43f, Max =25.510f},

            new MassRange() {MoleType = MoleculeType._57, Min =56.89f, Max =57.03f},


        };


        public static MoleculeType GetMoleculeTypeFromMass(float mass, MoleculeType notFound = MoleculeType.Unknown)
        {
            for (int i = 0; i < MASSRANGES.Count; i++)
            {
                if (MASSRANGES[i].IsInRange(mass)) return MASSRANGES[i].MoleType;
            }

            return notFound;
        }

    }


    public struct MassRange
    {
        public float Min { get; set; }
        public float Max { get; set; }
        public MoleculeType MoleType { get; set; }

        public bool IsInRange(float v) => v <= Max && v >= Min;
    }
}
