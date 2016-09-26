using System.Collections.Generic;

namespace _09_Portfolio
{
    internal class Portfolio
    {
        List<IAsset> assetList;
        public Portfolio()
        {
            assetList = new List<IAsset>();
        }

        public Portfolio(List<IAsset> assetList)
        {
            this.assetList = assetList;
        }

        public double GetTotalValue()
        {
            double value = 0;

            foreach(IAsset asset in assetList)
            {
                value += asset.GetValue();
            }

            return value;
        }

        public void AddAsset(IAsset asset)
        {
            assetList.Add(asset);
        }
    }
}