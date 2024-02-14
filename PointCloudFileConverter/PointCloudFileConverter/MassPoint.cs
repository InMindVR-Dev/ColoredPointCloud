using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointCloudFileConverter
{
    public struct MassPoint
    {
        public float X, Y, Z, M;
        public string ToCsv(char sep = '\t') => X.ToString(CultureInfo.InvariantCulture) + sep + Y.ToString(CultureInfo.InvariantCulture) + sep + Z.ToString(CultureInfo.InvariantCulture) + sep + M.ToString(CultureInfo.InvariantCulture);

        public MoleculeType GetMolecule() => MassRanges.GetMoleculeTypeFromMass(M);

    }

    

}
