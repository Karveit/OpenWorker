﻿using GateService.Game;
using Microsoft.EntityFrameworkCore;
using ow.Framework.Database.Accounts;
using ow.Framework.IO.Lan;
using ow.Framework.IO.Network.Attributes;
using ow.Framework.IO.Network.Opcodes;
using ow.Framework.IO.Network.Permissions;
using ow.Framework.IO.Network.Requests.Gate;
using System.Linq;

namespace GateService.Network.Handlers
{
    internal static class ServiceHandler
    {
        [Handler(ServerOpcode.GateEnter, HandlerPermission.UnAuthorized)]
        public static void Enter(Session session, EnterRequest request, Gate gate, LanContext lan)
        {
            if (gate.Id != request.GateId)
            {
#if !DEBUG
                session.Disconnect();
#endif
                return;
            }

            uint accountId = lan.GetAccountIdBySessionKey(request.SessionKey);
            if (request.AccountId != accountId)
            {
#if !DEBUG
                session.Disconnect();
#endif
                return;
            }

            using AccountContext context = new();

            AccountModel model = context.Accounts.AsNoTracking().FirstOrDefault(c => c.Id == request.AccountId);
            if (model is null)
            {
#if !DEBUG
                session.Disconnect();
#endif
                return;
            }

            session.Account = new(model);
            session.Characters = new(request.AccountId, request.GateId);

            session.SendGateEnterResult().SendCurrentDate();
        }
    }
}