using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFunCargoGame.Domain.Logon
{
    public enum LogonStatus
    {
        ValidLogon,
        ValidButPasswordExpiresSoon,
        InvalidWrongPassword,
        InvalidLockedOut,
        InvalidOtherReason
    }
}
