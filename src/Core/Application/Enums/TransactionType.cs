using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Enums
{
    public enum TransactionType
    {
        SMALL_AMOUNT,
        LARGE_VERIFIED,
        LARGE_UNVERIFIED,
        CARD_TO_WALLET,
        DONATION
    }
}
