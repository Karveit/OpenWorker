﻿using Core.Systems.NetSystem.Attributes;
using Core.Systems.NetSystem.Opcodes;
using Core.Systems.NetSystem.Permissions;
using Core.Systems.NetSystem.Requests.Movement;

namespace DistrictService.Systems.NetSystem.Handlers
{
    internal static class MovementHandler
    {
        [Handler(HandlerOpcode.MovementJump, HandlerPermission.Authorized)]
        public static void Jump(Session session, JumpRequest request)
        {
            session.Character.Place.Position = request.Position;
            session.Character.Place.Rotation = request.Rotation;

            session.Channel.BroadcastMovementJump(session, request);
        }

        [Handler(HandlerOpcode.MovementLoopMotionEnd, HandlerPermission.Authorized)]
        public static void LoopMotionEndBroadcast(Session session) =>
            session.Channel.BroadcastLoopMotionEnd(session);

        [Handler(HandlerOpcode.MovementMove, HandlerPermission.Authorized)]
        public static void Move(Session session, MoveRequest request)
        {
            session.Character.Place.Position = request.Position;
            session.Character.Place.Rotation = request.Rotation;

            session.Channel.BroadcastMovementMove(session, request);
        }

        [Handler(HandlerOpcode.MovementStopBt, HandlerPermission.Authorized)]
        public static void Stop(Session session, StopRequest request)
        {
            session.Character.Place.Position = request.Position;
            session.Character.Place.Rotation = request.Rotation;

            session.Channel.BroadcastMovementStop(session, request);
        }
    }
}