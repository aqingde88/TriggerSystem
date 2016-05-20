using UnityEngine;
using System.Collections;
namespace TriggerSystem
{
    public enum TriggerType
    {
        kTrig_None = 0,
        kTrig_Explosion = (1 << 0),
        kTrig_EnemyNear = (1 << 1),
        kTrig_Gunfire = (1 << 2),
    }
    public class Trigger
    {
        TriggerType m_triggeType;
        ulong m_triggerId;
        ulong m_idSource;
        Vector3 m_pos;
        float m_radius;
        ulong m_timeStamp;
        ulong m_expirationTime;
        bool m_bDynamicSourcePos;

        public Trigger(TriggerType triggeType,
        ulong triggerId,
        ulong idSource,
        Vector3 pos,
        float radius,
        ulong timeStamp,
        ulong expirationTime,
        bool bDynamicSourcePos)
        {
            m_triggeType = triggeType;
            m_triggerId = triggerId;
            m_idSource = idSource;
            m_pos = pos;
            m_radius = radius;
            m_timeStamp = timeStamp;
            m_expirationTime = expirationTime;
            m_bDynamicSourcePos = bDynamicSourcePos;
        }

        static ulong m_nextTirggerID;
    }
}

