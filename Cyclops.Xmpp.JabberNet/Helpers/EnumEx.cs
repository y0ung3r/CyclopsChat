using Cyclops.Xmpp.Data;
using jabber.protocol.iq;

namespace Cyclops.Xmpp.JabberNet.Helpers;

internal static class EnumEx
{
    public static MucRole? Map(this RoomRole role) => role switch
    {
        RoomRole.moderator => MucRole.Moderator,
        RoomRole.participant => MucRole.Participant,
        RoomRole.visitor => MucRole.Visitor,
        RoomRole.none => MucRole.None,
        _ => null
    };

    public static MucAffiliation? Map(this RoomAffiliation affiliation) => affiliation switch
    {
        RoomAffiliation.admin => MucAffiliation.Admin,
        RoomAffiliation.member => MucAffiliation.Member,
        RoomAffiliation.none => MucAffiliation.None,
        RoomAffiliation.outcast => MucAffiliation.Outcast,
        RoomAffiliation.owner => MucAffiliation.Owner,
        _ => null
    };

    public static MucUserStatus? Map(this RoomStatus status) => (MucUserStatus)status;
}
