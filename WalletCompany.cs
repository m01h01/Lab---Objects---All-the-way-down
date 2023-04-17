using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab___Objects___All_the_way_down
{
    internal class WalletCompany
    {
    //Containment - Company needs to have those list of the wallet that
    //have been made to check or access for the inventory or other information about those wallet
        List<WalletCreated> _created;

        public WalletCompany()
        {
        _created = new List<WalletCreated>();
        }
        internal List<WalletCreated> Created { get => _created; }
        
        public void AddInventory (WalletCreated walletCreated)
        {
            _created.Add (walletCreated);
        }
        public override string ToString()
        {
            return $"Amount of created wallet: {_created.Count}";

        }

    }
}
